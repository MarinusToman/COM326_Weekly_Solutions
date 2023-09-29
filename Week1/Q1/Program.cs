/* 
 * Program.cs
 * Desc: Program to take user input.
 * 
 * Version information: v0.0.1
 * Author: Marinus Toman
 * Date:   29-09-2023
 *  
 * Copyright notice 
 */

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}, you will be {(age + 5)} in 5 years");
        }
    }
}