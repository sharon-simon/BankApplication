using System;
using BankApplication;

class Program
{
   public  static void Main()
    {
        

        Account acc = new Account();
        Actions d = new Actions();

        while (true) // Loop forever until user chooses to exit
        {
            Console.WriteLine("Welcome to abc company");
            Console.WriteLine("Choose the required service:");
            Console.WriteLine("1.Account Creation");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Withdrawal");
            Console.WriteLine("4.Exit"); // Add an option to quit

            byte choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CustomerDetails c = new CustomerDetails(
                        acc.GetName(),
                        acc.GetPhone(),
                        acc.GetAge(),
                        acc.GetBal()
                    );
                    acc.AddDetails(c);
                    //acc.Display();
                    break;

                case 2:
                    d.Check(acc, acc.GetName());
                    break;

                case 3:
                    d.withdrawal(acc, acc.GetName());
                    break;

                case 4:
                    acc.Display(acc,acc.GetName());
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    return; // Exit Main method (end program)
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine(); // Blank line for readability
        }
    }
}
