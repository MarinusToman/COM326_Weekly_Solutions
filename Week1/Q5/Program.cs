namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            do
            {
                // Display menu
                Console.WriteLine("Please enter an option from below:");
                Console.WriteLine("1. Hello in French?");
                Console.WriteLine("2. Hello in Spanish?");
                Console.WriteLine("3. Hello in German?");
                Console.WriteLine("4. Hello in Irish?");
                Console.WriteLine("0. Exit application");
                // Take user's option
                option = Convert.ToInt32(Console.ReadLine());
                // Determine which option was entered and display msg to user
                switch (option)
                {
                    case 0: Console.WriteLine("Goodbye");
                        break; 
                    case 1: Console.WriteLine("Bonjour");
                        break;
                    case 2: Console.WriteLine("Hola");
                        break;
                    case 3: Console.WriteLine("Hallo");
                        break;
                    case 4: Console.WriteLine("Dia dhuit");
                        break;
                    default: Console.WriteLine("Please enter a valid option");
                        break;
                }
                Console.WriteLine();
            } while (option != 0);
        }
    }
}