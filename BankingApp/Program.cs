/*
 * *Class name: Banking App
 * Version 1
 * Author: Matthew Lowry
 */
using System.Xml.Serialization;

void BuildBankingApp()
{
    //initilise variable
    int choice;
    double depositAmount;
    double accountBalance = 1000.00;

    //display the main menu screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    /*Read user menu choice
     * convert the string to an interger 
     * using explicit typecasting
     */
    choice = Convert.ToInt32(Console.ReadLine());

    /*the || in the loop represents OR
     * which means that a menu choice of 1 OR 2 
     * is accepted for this logical operation
     */
    if (choice == 1 || choice == 2)
    {
        if (choice == 1)
        {
            //deposit or withdraw funds
            Console.WriteLine("You have chosen to Deposit or withdraw funds");
            Console.WriteLine("How much funds do you want to deposit?");
            Console.WriteLine("Enter amount including pence using a decimal point");

            //double type needed to store currency
            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");

            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
        }
        if (choice == 2)
        {
            //View current account info
            Console.WriteLine("You have chosen to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        else
        {
            //View current account information
            Console.WriteLine("You have chosen to view current account information");
        }
    }
    else
    {
        //invalid choice menu
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}

BuildBankingApp();