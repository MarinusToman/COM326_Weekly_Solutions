namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user input
            Console.WriteLine("Please enter age:");
            int age = Convert.ToInt32(Console.ReadLine());

            // Check age with if-else ladder
            if (age < 13)
            {
                Console.WriteLine("You're a child");
            }
            else if (age < 20)
            {
                Console.WriteLine("You're a teen");
            }
            else
            {
                Console.WriteLine("You're an adult");
            }

            // Check age with switch
            switch(age)
            {
                case < 13:
                    Console.WriteLine("You're a child");
                    break;
                case < 19:
                    Console.WriteLine("You're a teen");
                    break;
                default:
                    Console.WriteLine("You're an adult");
                    break;

            }
        }
    }
}