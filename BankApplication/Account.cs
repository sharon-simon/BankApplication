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
            customerlist=new List<CustomerDetails>();
            }
        public void AddDetails(CustomerDetails customer)
        {
            //customers = new List<CustomerDetails>();
            customerlist.Add(customer);
        }
        public string GetName()
        {
            Console.WriteLine("Enter your name");
            //String name= Console.ReadLine();
           
            return Console.ReadLine();

        }
        public long GetPhone()
        {
            Console.WriteLine("Enter your phone number");
            long pno=long.Parse(Console.ReadLine());
            return pno;
        }
        public byte GetAge()
        {
            Console.WriteLine("Enter your age");
            byte age=byte.Parse(Console.ReadLine());
            return age;
        }
        public double GetBal()
        {
            Console.WriteLine("Enter your amount");
            double bal = double.Parse(Console.ReadLine());
            return bal;
        }
        public void Display(Account acc,String name)
        {
            CustomerDetails customer = acc.customerlist.FirstOrDefault(c => c.Name == name);

            if (customer != null)
            {
                foreach (var c in customerlist)
                {
                    Console.WriteLine($"Name: {c.Name}, Phone: {c.Phoneno}, Age: {c.Age},Balace:{c.balance}");
                }
            }
            
        }
    }
}
