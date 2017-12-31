// Author: Muhammad Faheem Khan

using System;

namespace text_obfuscator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining Vars
            Random rand = new Random();
            string user_input;
            // Chars to choose from
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789~!@#$%^&*()_-=+/{}:;,.";
            // Length of Chars
            int chars_len = chars.Length;
            // printing program name
            Console.WriteLine("Author: Muhammad Faheem Khan");
            Console.WriteLine(" Simple Text Obfuscator");
            // setting user_input to users input
            user_input = Console.ReadLine().Trim();
            // Getting user input length
            int user_input_len = user_input.Length;
            string obfs_input = "";
            // Using for loop generate a Obfuscator string
            for (int i = 0; i < user_input_len; i++){
                // Generating new random number every pass
                int x = rand.Next(0, chars_len);
                // get the char based on the string
                obfs_input += chars[x];
            }
            // Exiting the program
            Console.WriteLine(obfs_input);
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
