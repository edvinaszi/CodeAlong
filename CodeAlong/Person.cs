using System;
namespace CodeAlong
{
	public class Person
	{
		public string Name { get; private set; }
		public int Age { get; private set; }
		public bool LooksYoung;
		public bool CameAfter20;

		public Person(string name, int age, bool looksYoung, bool cameAfter20)
		{
			Name = name;
			Age = age;
			LooksYoung = looksYoung;
			CameAfter20 = cameAfter20;
		}

		public void DisplayPerson(int index)
		{
			string looks;

			if (LooksYoung == true)
			{
				looks = "younger than 25";
			}
			else
			{
				looks = "older than 25";
			}

			Console.WriteLine($"{index}. {Name} is {Age}, but looks {looks}");
		}
	}
}

