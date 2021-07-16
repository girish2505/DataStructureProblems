using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructureProblems
{
    public class UnorderdList
    {
        public static void List()
        {
            string text = File.ReadAllText(@"C:\Users\giris\source\repos\DataStructureProblems\DataStructureProblems\DS.txt");
            string[] textArray = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                list.InsertFront(textArray[i]);
            }
            list.Display();
            Console.WriteLine("\nEnter a string which you want to search");
            string searchStr = Console.ReadLine();
            if (list.Search(searchStr))
            {
                list.DeleteElement(searchStr);
            }
            else
            {
                list.InsertFront(searchStr);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"C:\Users\giris\source\repos\DataStructureProblems\DataStructureProblems\DS.txt", textFile);
            list.Display();
        }
    }
}
