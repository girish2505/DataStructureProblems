using System;

namespace DataStructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Problems");
            Console.WriteLine("1.Unordered List");
            Console.WriteLine("2.Ordered List");
            Console.WriteLine("3.Balanced Parentheses");
            Console.WriteLine("enter your option :");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UnorderdList.List();
                    break;
                case 2:
                    OrderdList.List();
                    break;
                case 3:
                    char[] expression = "[(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)]".ToCharArray();
                    BalancedParentheses parentheses = new BalancedParentheses();
                    bool result = parentheses.Isbalanced(expression);
                    if (result)
                    {
                        Console.WriteLine("Parentheses is Balanced");
                    }
                    else
                    {
                        Console.WriteLine("Parentheses is UnBalanced");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
