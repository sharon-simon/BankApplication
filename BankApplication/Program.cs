using System;
using System.Collections.Generic;
using BankApplication;

class Program
{
    public static void Main()
    {
        // Dictionary to store multiple banks by name
        Dictionary<string, Account> banks = new Dictionary<string, Account>();
        Actions actions = new Actions();

        while (true)
        {
            Console.WriteLine("Multi-Bank System");
            Console.WriteLine("1. Add Bank");
            Console.WriteLine("2. Create Account");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Display All Accounts in a Bank");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice: ");
            byte choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Add a new bank
                    Console.Write("Enter Bank Name: ");
                    string newBankName = Console.ReadLine();
                    if (!banks.ContainsKey(newBankName))
                    {
                        banks.Add(newBankName, new Account());
                        Console.WriteLine($"Bank '{newBankName}' added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Bank already exists!");
                    }
                    break;

                case 2: // Create account in a bank
                    Console.Write("Enter Bank Name: ");
                    string bankForAcc = Console.ReadLine();
                    if (banks.ContainsKey(bankForAcc))
                    {
                        Account acc = banks[bankForAcc];
                        CustomerDetails c = new CustomerDetails(acc.GetName(),acc.GetPhone(),acc.GetAge(),acc.GetBal(),acc.GetIF(),acc.GetAccNo());
                        acc.AddDetails(c);
                        Console.WriteLine("Account created successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Bank not found!");
                    }
                    break;

                case 3: // Deposit
                    Console.Write("Enter Bank Name: ");
                    string depBank = Console.ReadLine();
                    if (banks.ContainsKey(depBank))
                    {
                        Account acc = banks[depBank];
                        actions.Check(acc, acc.GetAccNo());
                    }
                    else
                    {
                        Console.WriteLine("Bank not found!");
                    }
                    break;

                case 4: // Withdraw
                    Console.Write("Enter Bank Name: ");
                    string withBank = Console.ReadLine();
                    if (banks.ContainsKey(withBank))
                    {
                        Account acc = banks[withBank];
                        actions.withdrawal(acc, acc.GetAccNo());
                    }
                    else
                    {
                        Console.WriteLine("Bank not found!");
                    }
                    break;

                case 5: // Display accounts in a bank
                    Console.Write("Enter Bank Name: ");
                    string displayBank = Console.ReadLine();

                    if (banks.ContainsKey(displayBank))
                    {
                        Account acc = banks[displayBank];
                        acc.Display(acc);
                    }
                    else
                    {
                        Console.WriteLine("Bank not found!");
                    }
                    break;

                case 6:
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
