using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _mail;
        private int _phoneNum;        

        public Customer(string firstName, string lastName, string mail, int phoneNum)
        {
            _firstName = firstName;
            _lastName = lastName;
            _mail = mail;
            _phoneNum = phoneNum;
            //Order order = new Order(firstName);
        }

        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        public string Mail { get { return _mail; } }
        public int PhoneNum { get { return _phoneNum; } }
    }
}
