/* 
 * Program.cs
 * Desc: Program to take user input and test conditions.
 * 
 * Version information: v0.0.1
 * Author: Marinus Toman
 * Date:   29-09-2023
 *  
 * Copyright notice 
 */

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user input
            Console.WriteLine("Please enter a number greater than 1:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Loop through each value i to n
            for(int i = 1; i <= n; i++)
            {
                // Check user input
                if ((i % 3 == 0) && (i %5 != 0)) 
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 3 != 0) && ((i % 5 == 0)))
                {
                    Console.WriteLine("Buzz");
                }
                else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else 
                { 
                    Console.WriteLine(i); 
                }
            }
        }
    }
}