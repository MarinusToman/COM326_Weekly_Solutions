namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            // Get user input
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            // initialise word counter
            int numberOfWords = 1;

            for(int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (Char.IsUpper(c))
                {
                    numberOfWords++;
                }
            }
            
            // Print number of words
            Console.WriteLine($"Number of words = {numberOfWords}");

            /* Task 2
             * Caesar Cipher
             */
            string S = "If-Else";
            int K = 2;
            string encrypted = Encrypt(S, K);
            Console.WriteLine($"Original string: {S}, Encrypted: {encrypted}");
            string decrypted = Decrypt(encrypted, K);
            Console.WriteLine($"Encrypted String: {encrypted}, Decrypted: {decrypted}");
        }

        static string Encrypt(string S, int K)
        {
            string encodedText = "";
            foreach (char c in S) // for each char in the string S
            {
                if (!char.IsLetter(c)) // check if char is a letter
                {
                    encodedText += c; // not a letter, so don't encrypt
                }
                else // must be a letter, so encrypt
                {
                    int encodedChar = c + K;
                    if (char.IsLower(c))
                    {
                        if (encodedChar > 'z') // remember that the computer treats chars as numbers
                        {
                            encodedChar -= 26; // loop back to 'a'
                        }
                    }
                    else if (char.IsUpper(c))
                    {
                        if (encodedChar > 'Z')
                        {
                            encodedChar -= 26; // loop back to 'A'
                        }
                    }

                    encodedText += (char)encodedChar; // concatenate char to string
                }
            }

            return encodedText;
        }

        static string Decrypt(string S, int K)
        {
            string decodedText = "";
            foreach (char c in S) // for each char in the string S
            {
                if (!char.IsLetter(c)) // check if char is a letter
                {
                    decodedText += c; // not a letter, so don't decrypt
                }
                else // must be a letter, so decrypt
                {
                    int decodedChar = c - K;

                    if (char.IsUpper(c)) // for uppercase letters
                    {
                        if (decodedChar < 'A') // remember that the computer treats chars as numbers
                        {
                            decodedChar += 26; // loop back to 'Z'
                        }
                    }
                    else // for lowercase letters
                    {
                        if (decodedChar < 'a') // remember that the computer treats chars as numbers
                        {
                            decodedChar += 26; // loop back to 'z'
                        }
                    }

                    decodedText += (char)decodedChar; // concatenate char to string
                }
            }

            return decodedText;
        }
    }
}