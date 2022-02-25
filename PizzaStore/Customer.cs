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
        }
    }
}
