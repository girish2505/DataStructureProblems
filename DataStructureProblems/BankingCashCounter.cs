using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblems
{
    class BankingCashCounter
    {
        public int balance= 1000;
        public void Queue()
        {
            Console.WriteLine("Enter the number of persons in Queue");
            int persons = Convert.ToInt32(Console.ReadLine());
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            for (int i = 1; i <= persons; i++)
            {
                list.Enqueue(i);
                Amount();
                list.Dequeue();
            }
        }
        public void Amount()
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Deposit Cash");
                Console.WriteLine("2.Withdrawal cash");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposit");
                        int amountDeposit = Convert.ToInt32(Console.ReadLine());
                        balance = balance + amountDeposit;
                        Console.WriteLine("Balance : {0}",balance);
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdrawal");
                        int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                        balance = balance - withdrawalAmount;
                        Console.WriteLine("Balance : {0}", balance);

                        break;
                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag = Console.ReadLine();
            }

        }
    }
}
