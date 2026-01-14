using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Xml.Linq;

namespace BankApplication
{
     class Actions:Account
    {
        public double amt;

        public void Check(Account acc, int accno)
        {
            CustomerDetails customer = acc.customerlist.FirstOrDefault(c => c.AccountNumber == accno);

            if (customer != null)
            {
                Balance(acc, accno);
                deposit(acc, accno);
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }
        public void deposit(Account acc, int ifsc)
        {
            Console.WriteLine("Enter deposit amount");
            amt = double.Parse(Console.ReadLine());

            CustomerDetails customer = acc.customerlist.FirstOrDefault(c => c.IFSC == ifsc);

            if (customer != null)
            {
                customer.balance += amt;
                Balance(acc, ifsc);
            }
        }

        public void withdrawal(Account acc, int accno)
        {

            Console.WriteLine("Enter withdrawal amount");
            amt = double.Parse(Console.ReadLine());

            CustomerDetails customer = acc.customerlist.FirstOrDefault(c => c.AccountNumber == accno);

            if (customer != null)
            {
                if (customer.balance >= amt)
                {
                    customer.balance -= amt;
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }  
            }
            Balance(acc, accno);
        }

        public void Balance(Account acc,int accno)
        {
            CustomerDetails customer = acc.customerlist.FirstOrDefault(c => c.AccountNumber == accno);

            if (customer != null)
            {
                Console.WriteLine("Remaining balance: " + customer.balance);
            }
        }

    }
}
