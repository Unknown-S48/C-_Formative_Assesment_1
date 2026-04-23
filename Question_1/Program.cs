//Wian Sandenbergh
//Question 1
/*
Prompt the user to enter a student name				
Prompt the user to enter three subject marks	
Validate that marks entered are numeric values		
Calculate the total marks							
Calculate the average marks							
Display whether the student PASS or FAIL			
Rule: Average >= 50 = PASS							
Display results in the format shown above			
*/
using System;
using System.Globalization;
class Question_1
{
    static void Main()
        {
            // Prompting for student name and getting an input
            Console.Write("Enter student name: ");
            string name = Console.ReadLine() ?? string.Empty;
            // Prompting for three marks and getting an input
            int[] marks = new int[3];
            for (int i = 0; i < 3; i++)
            {
                bool accepted = false;
                do
                {
                // Adding each input to the marks array
                Console.Write($"Enter mark for Subject {i + 1}: ");
                string? input = Console.ReadLine();
                // Validate numeric input  
                if (!int.TryParse(input, out int mark))
                {
                    Console.WriteLine("Invalid input — please enter a numeric value.");
                    continue;
                }
                // Validate range 0–100  
                if (mark < 0 || mark > 100)
                {
                    Console.WriteLine("Please enter a value between 0 and 100.");
                    continue;
                }
                marks[i] = mark;
                accepted = true;
                } while (!accepted);
            }
            // Calculating the total marks 
            int total = marks[0] + marks[1] + marks[2];
            // Calculating average marks 
            double average = total / 3.0;
            // Determine PASS/FAIL (Average >= 50 = PASS)  
            string result;
            if (average >= 50.0)
            {
                result = "PASS";
            }
            else
            {
            result = "FAIL";
            }
            // Displaying the results in the requested format  
            Console.WriteLine();
            Console.WriteLine("===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            // Round to one decimal place and format using current culture  
            string avgFormatted = Math.Round(average, 1).ToString("0.0", CultureInfo.CurrentCulture);
            Console.WriteLine($"Average Marks: {avgFormatted}");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result Issued At: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
    }
}