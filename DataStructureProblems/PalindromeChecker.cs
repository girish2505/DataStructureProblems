using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class PalindromeChecker
    {
        public string input;
        public void CheckPalindrome()
        {
            CustomLinkedList<char> linkedList = new CustomLinkedList<char>();
            Console.WriteLine("Enter the string : ");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                linkedList.Enqueue(input[i]);
            }
            linkedList.Display();

            string reverse = linkedList.Palindrome();
            if (input == reverse)
            {
                Console.WriteLine("\n{0} is a Palindrome", input);
            }
            else
            {
                Console.WriteLine("\n{0} is not a Palindrome", input);

            }
        }

    }
}
