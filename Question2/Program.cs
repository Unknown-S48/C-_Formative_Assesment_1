//Wian Sandenbergh
//Question 2
/*
Develop a Simple ATM Console Application using C# that simulates a basic banking withdrawal transaction. 
The system must interact with the user, accept inputs, perform calculations, and display transaction results including the updated balance and transaction time.
*/
using System;
using System.Globalization;
class Question_2
{
	static void Main()
	{
		//Printing the program title
		Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");
		Console.WriteLine("");
		//Asking for users name and printing it in upper case
		Console.WriteLine("HI , WHAT IS YOUR NAME?");
		string name = Console.ReadLine() ?? string.Empty;
		Console.WriteLine("");
		Console.WriteLine($"WELCOME {name.ToUpper()}!");
		//Getting and validating balance
		Console.Write($"Enter account balance: ");
		decimal balance = GetValidDecimalInput();
		//Loop for withdrawal attempts
		bool transactionComplete = false;
		while (!transactionComplete)
		{
			//Getting and validating the withdrawal amount
			Console.Write("Enter withdrawal amount: ");
			decimal withdrawal = GetValidDecimalInput();
			//Adding a break for spacing
			Console.WriteLine("");
			//Validating the withdrawal process
			//Output for an invalid input
			if (withdrawal <= 0)
			{
				Console.WriteLine("Withdrawal Failed!");
				Console.WriteLine("Error: withdrawal amount must be greater than 0!");
				Console.WriteLine("Please try again.\n");
			}
			//Output for insufficient funds
			else if (withdrawal > balance)
			{
				Console.WriteLine("Withdrawal Failed!");
				Console.WriteLine($"Error: Insufficient funds. your current balance is {balance:C}");
				Console.WriteLine("Please try again.\n");
			}
			//Output for a successful withdrawal
			else
			{
				decimal newBalance = balance - withdrawal;
				Console.WriteLine("Withdrawal Successful!");
				Console.WriteLine($"Updated Balance: {newBalance:F2}");
				Console.WriteLine($"Transaction Time: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
				transactionComplete = true;
			}
		}
	}
	// Helper method
	static decimal GetValidDecimalInput()
	{
		while (true)
		{
			if (decimal.TryParse(Console.ReadLine(), out decimal results) && results >= 0)
			{
				return results;
			}
			else
			{
				Console.WriteLine("Invalid input! Please enter a valid number.");
			}
		}
	}
}