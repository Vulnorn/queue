using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> shoppingQueue = new Queue<int>();
            Random random = new Random();
            bool hasQueue = true;
            int firstValueForTest = 0;
            int secondValueForTest = 10;
            int numberBuyers = random.Next(firstValueForTest,secondValueForTest);
            int purchaseAmount;
            int accountTotal =0;

            while (numberBuyers !=0)
            {
                purchaseAmount = random.Next(firstValueForTest, secondValueForTest);
                shoppingQueue.Enqueue(purchaseAmount);
                numberBuyers--;
            }

            while (hasQueue)
            {
                Console.WriteLine($"Счет текущего клиента: {shoppingQueue.First()}. \nСчет Магазина: {accountTotal}");
                accountTotal += shoppingQueue.Dequeue();
                Console.WriteLine($"Клиент совершил покупку. Счет магазина: {accountTotal}");
                Console.ReadKey();

                if (shoppingQueue.Count!=0)
                {
                    Console.Clear();
                }
                else
                {
                    hasQueue = false;
                    Console.WriteLine($"Очередь закончилась, вы обслужили всех клиентов");
                    Console.ReadKey();
                }
            }
        }
    }
}