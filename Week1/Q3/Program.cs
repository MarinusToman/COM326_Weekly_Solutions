namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Option 1: using implicit casting in the For loop statement
            for (int i = 'A'; i <= 'z'; i++)
            {
                // If the value is between 91-96, we don't want to print
                if(!(i > 90 && i <= 96))
                {
                    Console.WriteLine($"{i}\t{(char) i}"); // we use explicit casting here
                }
                    
            }

            // Option 2: 
            for(int i = 65;  i <= 90;  i++)
            {
                Console.WriteLine($"{i}\t{(char) i}\t{(i+32)}\t{(char) (i+32)}"); // print all on one line
            }
        }
    }
}