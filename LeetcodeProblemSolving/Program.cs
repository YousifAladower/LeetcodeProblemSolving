﻿namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to check if it's a palindrome:");
            int number;

            // Ensure the input is a valid integer
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }

            // Check if the number is a palindrome
            bool isPalindrome = IsPalindrome(number);
            if (isPalindrome)
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static bool IsPalindrome(int x)
        {
            // Negative numbers and numbers ending in 0 (but not 0 itself) cannot be palindromes
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int reversed = 0;
            int original = x;

            // Reverse half of the number
            while (x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            // Check if the original number is equal to the reversed half
            return x == reversed || x == reversed / 10;
        }
    }
}