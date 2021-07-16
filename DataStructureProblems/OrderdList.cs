using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructureProblems
{
    class OrderdList
    {
        public static void List()
        {
            string text = File.ReadAllText(@"C:\Users\giris\source\repos\DataStructureProblems\DataStructureProblems\number.txt");
            string[] textArray = text.Split(" ");
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            int[] arr = new int[textArray.Length];
            for (int i = 0; i < textArray.Length; i++)
            {
                int a = Convert.ToInt32(textArray[i]);
                arr[i] = a;
            }
            for (int i = 0; i < textArray.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
                //Console.WriteLine("\n");
            }
            for (int i = 0; i < textArray.Length; i++)
            {
                list.Sort(arr[i]);
            }
            list.Display();
            Console.WriteLine("\nEnter a number to search");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            if (list.Search(searchNum))
            {
                list.DeleteElement(searchNum);

            }
            else
            {
                list.Sort(searchNum);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"C:\Users\giris\source\repos\DataStructureProblems\DataStructureProblems\number.txt", textFile);
            list.Display();

        }
    }
}
