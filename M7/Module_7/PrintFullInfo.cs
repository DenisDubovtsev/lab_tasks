using System;
using System.Collections.Generic;
using System.Text;

namespace Module_7
{
    class PrintFullInfo : IPrint
    {
        public string Print(string name = "", string phone = "", decimal revenue = 0)
        {
            string result = $"Customer full info: {name}, {phone}, {revenue}";
            return result;
        }
    }

    class PrintContactNumber : IPrint
    {
        public string Print(string name = "", string phone = "", decimal revenue = 0)
        {
            string result = $"Customer contact: {phone}";
            return result;
        }
    }

    class PrintNameAndRevenue : IPrint
    {
        public string Print(string name = "", string phone = "", decimal revenue = 0)
        {
            string result = $"Customer name and revenue: {name}, {revenue}";
            return result;
        }
    }

    class PrintName : IPrint
    {
        public string Print(string name = "", string phone = "", decimal revenue = 0)
        {
            string result = $"Customer name: {name}";
            return result;
        }
    }

    class PrintAdditional : IPrint
    {
        public string Print(string name = "", string phone = "", decimal revenue = 0)
        {
            string result = $"Please, welcome, Mr/Mrs/Ms: {name}";
            return result;
        }
    }
}
