using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Xml.Linq;

namespace BankApplication
{
    internal class Actions 
    {
        public double amt;

        public void Check( Account acc,string name)
        {
            CustomerDetails customer = acc.customerlist.FirstOrDefault(c =>c.Name == name );

            if (customer != null)
            {
                Balance(acc, name);
                deposit(acc, name);
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }
        public void deposit(Account acc, string name)
        {
            Console.WriteLine("Enter deposit amount");
            amt = double.Parse(Console.ReadLine());

            CustomerDetails customer = acc.customerlist.FirstOrDefault(c =>c.Name == name );

            if (customer != null)
            {
                customer.balance += amt;
                Balance(acc, name);
            }
        }

        public void withdrawal(Account acc,string name)
        {

            Console.WriteLine("Enter withdrawal amount");
            amt = double.Parse(Console.ReadLine());

            CustomerDetails customer = acc.customerlist.FirstOrDefault(c => c.Name == name);

            if (customer != null)
            {
                customer.balance -= amt;
                Balance(acc, name);
            }
        }

        public void Balance(Account acc, string name)
        {
            CustomerDetails customer =acc.customerlist.FirstOrDefault(c => c.Name == name);

            if (customer != null)
            {
                Console.WriteLine("Remaining balance: " + customer.balance);
            }
        }

    }
}
