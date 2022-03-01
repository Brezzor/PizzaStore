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
                #region Display Pizza Store
                Console.Clear();
                Console.WriteLine("---- Pizza Store ----");
                Console.WriteLine("[1]: Menu" +
                                  "\n[2]: Make order" +
                                  "\n[3]: Show orders" +
                                  "\n[0]: Exit'");
                Console.WriteLine("Type the number of what you would like to do");
                Console.Write("Command: ");
                #endregion

                #region Check if command is correct
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
                #endregion

                switch (command)
                {
                    case 1:
                        Menu.PrintMenu();
                        Console.Write("\nPress any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        #region Choosing and creating a pizza
                        Menu.PrintMenu();
                        Console.WriteLine("\nWhat's number of pizza, would you like?");                        

                        #region Check if command is correct
                        while (!correctCommand)
                        {
                            Console.Write("\nPizza number: ");
                            while (!int.TryParse(Console.ReadLine(), out menuNum))
                            {
                                Console.WriteLine("Invalid number!");
                                Console.WriteLine("Has to be a number");
                                Console.Write("Press any key to continue");
                                Console.ReadKey();
                                Console.Write("Pizza number: ");
                            }
                            if (menuNum <= Menu.LastIndexNum())
                            {
                                correctCommand = true;                                
                            }
                            else
                            {                                
                                Console.WriteLine("Invalid number!");
                                Console.WriteLine("Has to be a number");
                                Console.Write("Press any key to continue");
                                Console.ReadKey();
                            }
                        }
                        correctCommand = false;
                        #endregion

                        Pizza pizza = Menu.GetPizza(menuNum);
                        #endregion

                        #region Create customer
                        Console.WriteLine("-- Customer info --");
                        Console.Write("First name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string lastName = Console.ReadLine();

                        Customer customer = new Customer(firstName, lastName);
                        #endregion

                        #region Create and print order
                        Order order = new Order(customer, pizza);

                        Order.PrintOrder(order);
                        #endregion

                        Console.Write("\nPress any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Order.PrintOrders();

                        Console.Write("\nPress any key to continue");
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
