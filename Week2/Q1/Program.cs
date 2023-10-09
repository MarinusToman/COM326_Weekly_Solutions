namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            string msg = "";

            do
            {
                PrintMenu();
                option = InputOption();
                msg = GetMessage(option);
                Console.WriteLine(msg);
            } while (option != 0);
        }

        static void PrintMenu()
        {
            Console.WriteLine("Please enter a valid option from below:");
            Console.WriteLine("1. Hello in French?");
            Console.WriteLine("2. Hello in Spanish?");
            Console.WriteLine("3. Hello in German?");
            Console.WriteLine("4. Hello in Irish?");
            Console.WriteLine("0. Exit application");
        }

        static int InputOption()
        {
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }

        static string GetMessage(int n)
        {
            string msg = "";
            switch (n)
            {
                case 0: msg = "Goodbye";
                    break;
                case 1: msg = "Bonjour";
                    break;
                case 2: msg = "Ola";
                    break;
                case 3: msg = "Hallo";
                    break;
                case 4: msg = "Dia dhuit";
                    break;
                default: msg = "Please enter a valid option";
                    break;
            }
            return msg;
        }
    }
}