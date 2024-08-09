using System.Runtime.ConstrainedExecution;
namespace CodeAlong;

//Det er ikke lov å kjøpe alkohol etter kl 20, dersom kunden ser eldre ut enn 25 kan de kjøpe uansett.Dersom de ser yngre ut enn 25 må de fremvise gyldig legitimasjon (over 18 år)

class Program
{
    static void Main(string[] args)
    {
        var shop = new Shop();
        MainMenu(shop);
    }

    static void MainMenu(Shop shop)
    {
        bool atMenu = true;

        while (atMenu)
        {
            Console.Clear();

            Console.WriteLine("1. Who are you?");
            Console.WriteLine("2. Go shopping");
            Console.WriteLine("3. Add person");
            Console.WriteLine("4. Exit");

            var choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    Console.Clear();
                    shop.ChoosePerson();
                    BackToMenu();
                    break;
                case '2':
                    Console.Clear();
                    shop.BuyBeer();
                    BackToMenu();
                    break;
                case '3':
                    Console.Clear();
                    shop.Add();
                    BackToMenu();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Bye");
                    atMenu = false;
                    break;
                default:
                    break;
            }
        }
    }

    static void BackToMenu()
    {
        Console.WriteLine("\nPress any key to go back to the main menu");
        Console.ReadKey();
    }
}

