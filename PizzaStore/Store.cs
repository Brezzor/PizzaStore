using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Store
    {
        public static void Start()
        {
            int command = 0;
            int menuNum = 0;
            bool correctCommand = false;
            bool _exit = false;

            while (!_exit)
            {
                Console.Clear();
                Console.WriteLine("---- Pizza Store ----");
                Console.WriteLine("[1]: Order pizza " +
                                  "\n[2]: Show orders" +
                                  "\n[0]: Exit'");
                Console.WriteLine("Type the number of what you would like to do");
                Console.Write("Command: ");

                while (!correctCommand)
                {                    
                    while (!int.TryParse(Console.ReadLine(), out command))
                    {
                        Console.WriteLine("Invalid command!");
                        Console.WriteLine("Command has to be a number");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        Console.Write("\nCommand: ");
                    }

                    correctCommand = true;
                }
                correctCommand = false;

                switch (command)
                {
                    case 1:
                        Menu.PrintMenu();
                        Console.WriteLine("\nWhat's number of pizza, would you like?");
                        Console.Write("Pizza number: ");
                        
                        while (!correctCommand)
                        {                          
                            while (!int.TryParse(Console.ReadLine(), out menuNum))
                            {
                                Console.WriteLine("Invalid number!");
                                Console.WriteLine("Has to be a number");
                                Console.Write("Press any key to continue");
                                Console.ReadKey();
                                Console.Write("\nPizza number: ");
                            }

                            correctCommand = true;
                        }
                        correctCommand = false;

                        Menu.GetPizza(menuNum);

                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:

                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 0:
                        _exit = true;
                        break;
                    default:
                        Console.WriteLine("Inavlid command!");
                        Console.WriteLine("Command is not possible");
                        Console.Write("Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
