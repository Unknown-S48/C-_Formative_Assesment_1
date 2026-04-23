//Wian Sandenbergh
//Question 1
/*
Prompt the user to enter a student name				-- Line 20
Prompt the user to enter three subject marks		-- Line 23
Validate that marks entered are numeric values		-- Line 34
Calculate the total marks							-- Line 53
Calculate the average marks							-- Line 55
Display whether the student PASS or FAIL			-- Line 75
Rule: Average >= 50 = PASS							-- Line 57
Dispaly results in the format shown above			-- Line 67
*/

using System;
using System.Globalization;
class Question_1
{
	static void Main()
	{
		//Promting for student name and getting an input
		Console.Write("Enter student name: ");
		string name = Console.ReadLine() ?? string.Empty;
		//Promting for three marks and getting an input
		//creating an list var called marks and then looping from 0 to 3 getting the input for each time it loops
		int[] marks = new int[3];
		for (int i = 0; i < 3; i++)
		{
			bool accepted = false;
			do
			{
				//Adding each input to an list called marks
				Console.Write($"Enter mark for Subject {i + 1}: ");
				string? input = Console.ReadLine();
				//Adding a try catch to validate the input for the marks to be numeric and in range
				try 
				{
					//Checking if the input is null
					if (input is null) throw new Exception("No input");
					int mark = int.Parse(input);
					//Checking if the input is in between 0 and 100 but not including 0 or 100
					if (mark < 0 || mark > 100) throw new Exception("Input out of range");
					marks[i] = mark;
					//Ending the loop
					accepted = true;
				}
				//Adding the catch output
				catch
				{
					Console.WriteLine($"Wrong input try again.");
				}
			} while (!accepted);
		}
		//Calculating the Total marks
		int total = marks[0] + marks[1] + marks[2];
		//Calculating Average makrs
		double average = total / 3.0;
		//Adding the result rule
		string result;
		if (average >= 50.0)
		{
			result = "PASS";
		}
		else
		{
			result = "FAIL";
		}
		//Dislaying the GUI and data collected above
		Console.WriteLine();
		Console.WriteLine("===== STUDENT RESULTS =====");
		Console.WriteLine($"Student Name: {name}");
		Console.WriteLine($"Total Marks: {total}");
		//Formatting for the comma as decimal separator 
		string avgFormatted = average.ToString("0.##", CultureInfo.CurrentCulture);
		Console.WriteLine($"Average Marks: {avgFormatted}");
		//Displaying if the student Passed or Failed
		Console.WriteLine($"Result: {result}");
		Console.WriteLine($"Result Issued At: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
		Console.WriteLine($"");
		Console.WriteLine($"Press any key to exit...");
		Console.WriteLine(true);
	}
}