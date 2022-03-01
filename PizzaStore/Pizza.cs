using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Pizza
    {
        private string _name;
        private List<string> _toppings = new List<string>();
        public Pizza(string name, List<string> toppings)
        {
            _name = name;
            foreach (string topping in toppings)
            {
                _toppings.Add(topping);
            }
        }

        public string Name { get { return _name; } }
        public void Toppings()
        {
            for (int i = 0; i < _toppings.Count; i++)
            {
                Console.WriteLine($"{_toppings[i]}");
            }
        }
    }
}