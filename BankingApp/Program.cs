/*
 * Class Name: Banking App
 * Version 1
 * Author: Lewis Parke
*/

void BuildBankingApp()
{

    int choice;
    double depositAmount;
    double AccountBalance = 1000.00;

    Console.WriteLine("Please choose an option.");
    Console.WriteLine("========================");
    Console.WriteLine("1 - Deposit Or Withdraw Funds");
    Console.WriteLine("2 - View Account Details");
    Console.WriteLine("Select An Option (1-2).");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 || choice == 2)
    {
        if (choice == 1)
        {
            Console.WriteLine("You have chosen to deposit or withdraw funds.");
            Console.WriteLine("Input how much you would like to deposit.");

            depositAmount = Convert.ToDouble(Console.ReadLine());

            AccountBalance += depositAmount;
            Console.WriteLine($"Updated Account Balance is: £{AccountBalance}");
        } else
        {
            Console.WriteLine("You have chosen to view account details.");
            Console.WriteLine($"Current Account Balance: £{AccountBalance}");
        }
    } else
    {
        Console.WriteLine("Invalid choice.");
    }
}

BuildBankingApp();