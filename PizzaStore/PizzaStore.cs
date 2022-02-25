using System;

namespace PizzaStore
{
    class PizzaStore
    {        
        static void Main(string[] args)
        {
            bool _exit = false;

            while (!_exit)
            {
                Console.Clear();
                Console.WriteLine("---- Pizza Store ----");
                Console.WriteLine("'Order pizza' 'Exit'");
                Console.Write("What would you like to do? ");
                switch (Console.ReadLine())
                {
                    case "Order pizza":
                        string firstName = Console.ReadLine();
                        string lastName = Console.ReadLine();
                        string mail = Console.ReadLine();
                        
                        break;
                    case "Exit":
                        _exit = true;
                        break;
                    default:                        
                        break;
                }
            }

            Console.WriteLine("Press any key to terminate program!");
            Console.ReadKey();
        }
    }
}
