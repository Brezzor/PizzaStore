using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Order
    {
        private static Customer _customer;
        private static Pizza _pizza;
        private static List<Order> orders = new List<Order>();
        private int _orderNum = orders.Count;
        public Order(Customer customer, Pizza pizza)
        {
            _customer = customer;
            _pizza = pizza;
            orders.Add(this);            
        }
        private Customer Customer { get { return _customer; } }
        private Pizza Pizza { get { return _pizza; } }
        private int OrderNum { get { return _orderNum + 1; } }
        private string Toppings()
        {
            List<string> toppings = Pizza.GetToppings();
            return string.Join(", ", toppings);
        }
        private double CalculateTotalPrice()
        {
            return Pizza.Price;
        }
        public void PrintOrder()
        {
            Console.WriteLine($"\n---- Pizza order {OrderNum}----");
            Console.WriteLine($"First name: {Customer.FirstName}");
            Console.WriteLine($"Last name: {Customer.LastName}");
            Console.WriteLine($"Pizza name: {Pizza.Name}");
            Console.WriteLine($"Toppings: {Toppings()}");
            Console.WriteLine($"Total price: {CalculateTotalPrice()}");
        }
        public static void PrintOrders()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"\n---- Pizza order {orders[i].OrderNum}----");                
                Console.WriteLine($"First name: {orders[i].Customer.FirstName}");
                Console.WriteLine($"Last name: {orders[i].Customer.LastName}");
                Console.WriteLine($"Pizza name: {orders[i].Pizza.Name}");
                Console.WriteLine($"Toppings: {orders[i].Toppings()}");
                Console.WriteLine($"Total price: {orders[i].CalculateTotalPrice()}");
            }
        }
    }
}
