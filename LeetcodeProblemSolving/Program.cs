using LeetcodeProblemSolving;

namespace PalindromeChecker
{
    class Program
    {
        /*        static void Main(string[] args)
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
        */




        static void Main(string[] args)
        {
            /*  // Create first number: 342 (in reverse order: 2 -> 4 -> 3)
              ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));

              // Create second number: 465 (in reverse order: 5 -> 6 -> 4)
              ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

              // Instantiate the Solution class and call the AddTwoNumbers method
              Solution solution = new Solution();
              ListNode result = solution.AddTwoNumbers(l1, l2);

              // Print the result
              Console.Write("Result: ");
              while (result != null)
              {
                  Console.Write(result.val + " ");
                  result = result.next;
              }

              Console.ReadLine(); // Keep console open*/

            /* Console.Write("Enter a Roman numeral: ");
             string romanNumeral = Console.ReadLine();
             int result = RomanToInt(romanNumeral);
             Console.WriteLine($"The integer value of {romanNumeral} is: {result}");*/

            /*  string[] words = { "flower", "flow", "flight" };
              string result = Solution.LongestCommonPrefix(words);
              Console.WriteLine($"Longest common prefix: \"{result}\"");
              Console.ReadLine(); // Keep console open*/


            Console.WriteLine("Enter a string of parentheses to check if it is valid:");
            string input = Console.ReadLine();

            Solution solution = new Solution();
            bool isValid = solution.IsValid(input);

            if (isValid)
            {
                Console.WriteLine("The string is valid.");
            }
            else
            {
                Console.WriteLine("The string is not valid.");
            }
        }
    }
}
