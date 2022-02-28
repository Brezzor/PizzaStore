using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Order
    {
        private string _firstName;
        private int _orderNum;
        private List<OrderItem> _orderItems = new List<OrderItem>();
        private List<Order> _order = new List<Order>();
        public Order(Customer customer, OrderItem orderItem)
        {
            _firstName = customer.FirstName;
            _orderItems.Add(orderItem);
            _order.Add(this);
        }

        public int OrderNum { get { return _orderNum = _order.Count; } }
    }
}
