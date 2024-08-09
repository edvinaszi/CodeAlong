using System;
namespace CodeAlong
{
	public class Shop
	{
		private List<Person> persons = new List<Person>()
		{
			new Person("James", 27, true, false),
			new Person("Ryan", 22, false, true),
			new Person("Jesicca", 17, false, false)
		};

		private Person chosenPerson = null;



		public void BuyBeer()
		{
			bool canBuy = false;
			bool oldEnough = false;

			if(chosenPerson.LooksYoung)
			{
				Console.Clear();
				Console.WriteLine("Please show me your ID");
				Thread.Sleep(2000);
				oldEnough = ShowId();
			}
			else if(chosenPerson.CameAfter20)
			{
				Console.Clear();
				Console.WriteLine("Its past 20:00..Sorry");
			}
			else
			{
				canBuy = true;
			}

            if (chosenPerson.LooksYoung && oldEnough || !chosenPerson.LooksYoung && !chosenPerson.CameAfter20)
            {
                canBuy = true;
            }

            if (canBuy)
			{
				Console.WriteLine("Here is your beer, come again.");
			}
			
		}

		

		public void ChoosePerson()
		{
			ShowPeople();
			int indexChoice;

			while (true)
			{
                var choice = int.TryParse(Console.ReadLine(), out indexChoice);

				if (!choice)
				{
					Console.WriteLine("Please enter valid number");
				} else if(indexChoice < 1 || indexChoice > persons.Count)
				{
					Console.WriteLine("Person does not exist");
				}
				else
				{
					break;
				}

            }

			chosenPerson = persons[indexChoice - 1];

			Console.Clear();
			Console.WriteLine($"You chose to be {chosenPerson.Name}");

        }

		public void ShowPeople()
		{
			int index = 1;
			foreach(var person in persons)
			{
				person.DisplayPerson(index++);
			}
		}

		public bool ShowId()
		{
			if (chosenPerson.Age >= 18)
			{
				Console.Clear();
				Console.WriteLine("You are old enough yes.");
				return true;
			}
			else
			{
				Console.Clear();
				Console.WriteLine("You are not old enough..");
				return false;
			}
		}

		public void Add()
		{
			string name;
			int age;
			int time;
			bool comingLate = false;
			bool looksYoung = false;



			Random random = new Random();

			if (random.Next(0, 2) == 0)
			{
				looksYoung = true;
			}

            Console.WriteLine("What is your name?");

			while (true)
			{
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
				{
					Console.WriteLine("Name cannot be empty");
				}
				else
				{
					break;
				}
			}

			Console.Clear();

			Console.WriteLine("How old are you?");

            while (true)
            {
                string inputAge = Console.ReadLine();

				var tryParsing = int.TryParse(inputAge, out age);

                if (!tryParsing)
                {
                    Console.WriteLine("Enter valid age");
                }
                else
                {
                    break;
                }
            }

			Console.Clear();
            Console.WriteLine("When are you going to the shop? (Enter time in 24-hour format)");

            while (true)
            {
                string inputTime = Console.ReadLine();

                var tryParsing = int.TryParse(inputTime, out time);
                if (!tryParsing)
                {
                    Console.WriteLine("Enter a valid time");
                }
                else if (time < 0 || time > 24)
                {
                    Console.WriteLine("Enter a valid time between 0 and 24");
                }
                else
                {
                    comingLate = time >= 20;
                    break;
                }
            }


            persons.Add(new Person(name, age, looksYoung, comingLate));

			Console.Clear();

			Console.WriteLine($"You added {name}");


        }
	}
}

