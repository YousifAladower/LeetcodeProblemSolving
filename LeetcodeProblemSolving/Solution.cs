namespace LeetcodeProblemSolving
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        /*public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0); // Dummy head to simplify handling the result list
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = carry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                // Calculate new digit and carry
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
            }

            return dummyHead.next; // Return the next node to skip the dummy head
        }*/

        /*        public static int RomanToInt(string s)
                {
                    // Dictionary to store the Roman numeral values
                    Dictionary<char, int> romanValues = new Dictionary<char, int>()
                        {
                            {'I', 1},
                            {'V', 5},
                            {'X', 10},
                            {'L', 50},
                            {'C', 100},
                            {'D', 500},
                            {'M', 1000}
                        };

                    int total = 0;
                    int previousValue = 0;

                    // Iterate over the string from left to right
                    foreach (char c in s)
                    {
                        int currentValue = romanValues[c];

                        // If the previous value is smaller, we need to subtract it twice
                        if (previousValue < currentValue)
                        {
                            total += currentValue - 2 * previousValue;
                        }
                        else
                        {
                            total += currentValue;
                        }

                        // Update the previous value
                        previousValue = currentValue;
                    }

                    return total;
                }
        */
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            // Start with the first string as the initial prefix
            string prefix = strs[0];

            // Compare the prefix with each subsequent string
            for (int i = 1; i < strs.Length; i++)
            {
                // Adjust the prefix to match the current string

                while (strs[i].IndexOf(prefix) != 0)
                {
                    int ss = strs[i].IndexOf(prefix);
                    // Shorten the prefix by removing the last character
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // If the prefix becomes empty, there's no common prefix
                    if (string.IsNullOrEmpty(prefix))
                        return "";
                }
            }
            return prefix;
        }

        public bool IsValid(string s)
        {
            // Dictionary to map closing brackets to their corresponding opening brackets
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            // Stack to hold opening brackets
            Stack<char> stack = new Stack<char>();

            // Loop through each character in the string
            foreach (char ch in s)
            {
                // If the character is a closing bracket
                if (bracketPairs.ContainsKey(ch))
                {
                    // Check the top of the stack or use a dummy value if the stack is empty
                    char topElement = stack.Count > 0 ? stack.Pop() : '#';

                    // If the popped element doesn't match the corresponding opening bracket
                    if (topElement != bracketPairs[ch])
                    {
                        return false;
                    }
                }
                else
                {
                    // Push open brackets onto the stack
                    stack.Push(ch);
                }
            }

            // Check if the stack is empty at the end
            return stack.Count == 0;
        }
    }
}
