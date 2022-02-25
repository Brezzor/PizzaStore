using System;
using System.Threading;

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

                        Console.Write("First name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Last name: ");
                        string lastName = Console.ReadLine();

                        Console.Write("Mail: ");
                        string mail = Console.ReadLine();

                        bool correctNum = false;
                        int phoneNum;
                        while (!correctNum)
                        {
                            Console.Write("Phone number: ");

                            while (!int.TryParse(Console.ReadLine(), out phoneNum))
                            {
                                Console.WriteLine("Invalid phone number!");
                                Console.WriteLine("Phone number should only contain numbers");                                
                                Console.Write("Phone number: ");
                            }

                            correctNum = true;
                        }
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
