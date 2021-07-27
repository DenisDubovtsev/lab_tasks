using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class Customer
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }

        public IPrint PrintInfo { get; set; }

        public Customer(string name, string phone, decimal revenue, IPrint print)
        {
            Name = name;
            ContactPhone = phone;
            Revenue = revenue;

            PrintInfo = print;
        }

        public string ShowInfo()
        {
            return PrintInfo.Print(Name, ContactPhone, Revenue);
        }
    }
}
