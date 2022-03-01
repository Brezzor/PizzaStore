using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Menu
    {
        public static List<Pizza> GetMenu()
        {
            List<Pizza> pizzas = new List<Pizza>();

            pizzas.Add(new Pizza("Pepperoni pizza", new List<string>() {"Pepperoni"}));
            pizzas.Add(new Pizza("Hawaian pizza", new List<string>() { "Ham", "Pineapple" }));
            pizzas.Add(new Pizza("Italian pizza", new List<string>() { "Meatballs", "Chili" }));
            pizzas.Add(new Pizza("Vegetarian pizza", new List<string>() { "Vegetables" }));

            return pizzas;
        }

        public static void PrintMenu()
        {
            List<Pizza> pizzas = GetMenu();

            for (int i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine($"\nPizza[{i}]: {pizzas[i].Name}");                
                pizzas[i].Toppings();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
