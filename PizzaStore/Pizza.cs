using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Pizza
    {
        private List<Menu> _pizza = new List<Menu>();
        public Pizza(Menu menu)
        {
            _pizza.Add(menu);
        }        

        public List<Menu> GetPizza
        {
            get 
            {
                List<Menu> pizza = new List<Menu>();

                for (int i = 0; i < _pizza.Count; i++)
                {
                    pizza.Add(_pizza[i]);
                }

                return pizza;
            }
        }
    }
}