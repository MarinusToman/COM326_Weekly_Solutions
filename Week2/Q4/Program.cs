namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("Try to divide by zero...");
            int x = Divide(10, 0);
            Console.WriteLine("The program didn't crash because this line still printed\n");
            Console.WriteLine("Try to divide by zero again...");
            double y = Divide(10.0, 0.0);
            Console.WriteLine("We handled (or caught) the error and again, the program didn't crash");

            // Task 2
            try
            {
                Console.Write("Please enter a string: ");
                string input = Console.ReadLine();
                Console.WriteLine($"You input the string: {input}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
            }
        }

        static int Divide(int a, int b)
        {
            int x = 0;

            try
            {
                x = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured, message: {ex.Message}");
            }
            return x;
        }

        static double Divide(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Can't divide by zero");
                return 0;
            }

            double x = 0;

            try
            {
                x = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured, message: {ex.Message}");
            }
            return x;
        }
    }
}