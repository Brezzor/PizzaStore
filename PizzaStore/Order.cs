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
        private int _orderNum = orders.Count + 1;
        public Order(Customer customer, Pizza pizza)
        {
            _customer = customer;
            _pizza = pizza;
            orders.Add(this);            
        }
        private Customer Customer { get { return _customer; } }
        private Pizza Pizza { get { return _pizza; } }
        private int OrderNum { get { return _orderNum; } }
        private string Toppings()
        {
            List<string> toppings = Pizza.GetToppings();
            return string.Join(", ", toppings);
        }
        public static void PrintOrder(Order order)
        {
            Console.WriteLine($"\n---- Pizza order {order.OrderNum}----");
            Console.WriteLine($"First name: {order.Customer.FirstName}");
            Console.WriteLine($"Last name: {order.Customer.LastName}");
            Console.WriteLine($"Pizza name: {order.Pizza.Name}");
            Console.WriteLine($"Toppings: {order.Toppings()}");
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
            }
        }
    }
}
