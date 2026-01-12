using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    public class CustomerDetails
    {
        public string Name;
        public long Phoneno;
        public byte Age;
        public double balance;

        public CustomerDetails(string name,long phoneno,byte age,double balance)
        {
            Name=name;
            Phoneno=phoneno;    
            Age=age;
            this.balance = balance;
        }

        //public void AddDetails(CustomerDetails c)
        //{
        //    customers.Add(c);
        //}

        //public void Display()
        //{
        //    foreach (var c in customers)
        //    {
        //        Console.WriteLine($"Name: {c.Name}, Phone: {c.Phoneno}, Age: {c.Age}");
        //    }
        //}
    }
}
