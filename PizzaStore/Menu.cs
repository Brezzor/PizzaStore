using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Menu
    {
        private static List<Pizza> menu = new List<Pizza>()
        {
            new Pizza("Pepperoni pizza", new List<string>(){"Pepperoni"}),
            new Pizza("Hawaian pizza", new List<string>(){"Ham", "Pineapple"})
        };        
        public static List<Pizza> GetMenu()
        {            
            return menu;
        }
        public static void PrintMenu()
        {
            List<Pizza> pizzas = GetMenu();

            for (int i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine($"\nPizza[{i}]: {pizzas[i].Name}");                
                pizzas[i].GetToppings();
                Console.WriteLine("-----------------------------");
            }
        }           
        public static Pizza GetPizza(int num)
        {
            return GetMenu()[num];
        }        
        public static int LastIndexNum()
        {
            return Menu.GetMenu().Count - 1;
        }
    }
}
