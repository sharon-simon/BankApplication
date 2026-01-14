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
        public int IFSC;
        public int AccountNumber;


        public CustomerDetails(string name, long phoneno, byte age, double balance,int ifsc,int accno)
        {
            Name = name;
            Phoneno = phoneno;
            Age = age;
            this.balance = balance;
            IFSC = ifsc;
            AccountNumber = accno;
        }
    }
}
