using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace BankApplication
{
    class Account
    {
        public List<CustomerDetails> customerlist;
        public Account()
        {
            customerlist = new List<CustomerDetails>();
        }
        public void AddDetails(CustomerDetails customer)
        {
            customerlist.Add(customer);
        }
        public string GetName()
        {
            Console.WriteLine("Enter your name");           
            return Console.ReadLine();
        }
        public long GetPhone()
        {
            Console.WriteLine("Enter your phone number");
            long pno = long.Parse(Console.ReadLine());
            return pno;
        }
        public byte GetAge()
        {
            Console.WriteLine("Enter your age");
            byte age = byte.Parse(Console.ReadLine());
            return age;
        }
        public double GetBal()
        {
            Console.WriteLine("Enter your amount");
            double bal = double.Parse(Console.ReadLine());
            return bal;

        }
        public int GetIF()
        {
            Console.WriteLine("Enter your IFSC code");
            int ifsc = int.Parse(Console.ReadLine());
            return ifsc;
        }
        public int GetAccNo()
        {
            Console.WriteLine("Enter your account number");
            int accno = int.Parse(Console.ReadLine());
            return accno;
        }
        public void Display(Account acc)
        {
            foreach (var c in customerlist)
            {
                Console.WriteLine($"Name: {c.Name}, Phone: {c.Phoneno}, Age: {c.Age},Balace:{c.balance}");
            }
        }
    }
}
