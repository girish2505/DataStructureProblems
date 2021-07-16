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
                default:
                    break;
            }
        }
    }
}
