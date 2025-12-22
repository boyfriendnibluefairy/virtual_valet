using System;
using System.Text;

namespace PalindromeDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("Palindrome Detector Console Program");
            Console.WriteLine("If you enter a valid palindrome, the program will");
            Console.WriteLine("return True and the length of Palindrome.");
            Console.WriteLine("Otherwise, it will return False and length=0.");
            Console.WriteLine("Type 'exit' to escape the program.");
            Console.WriteLine("=================================\n");

            string userInput = "";

            do
            {
                Console.Write("---------> ");
                userInput = Console.ReadLine();
                (bool, int) result = IsPalindrome(user_input: userInput);
                Console.WriteLine($"Palindrome: {result.Item1} , Length = {result.Item2}\n");

            } while (userInput != "exit");

            //Console.ReadKey();
        }

        static (bool, int) IsPalindrome(string user_input)
        {
            // remove punctuation marks and whitespaces in user input
            StringBuilder sb = new StringBuilder();
            foreach(char c in user_input)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(char.ToLower(c));
                }
            }

            // get reversed version of the string
            char[] charArray = sb.ToString().ToCharArray();
            Array.Reverse(charArray);
            string reversedUserInput = new string(charArray);

            // compare stripped userInput with reversedUserInput
            Console.WriteLine($"sb = {sb.ToString()}");
            Console.WriteLine($"reversed = {reversedUserInput}");
            bool isPalindrome = sb.ToString().Equals(reversedUserInput);
            int palindromeLength = isPalindrome ? sb.ToString().Length : 0;

            return (isPalindrome, palindromeLength);
        }

    }
}
