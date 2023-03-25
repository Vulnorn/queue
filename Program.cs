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
            Random rand = new Random();
            bool queue = true;
            int firstValueForTest = 0;
            int secondValueForTest = 10;
            int numberBuyers = rand.Next(firstValueForTest,secondValueForTest);
            int purchaseAmount;
            int accountTotal =0;

            while (numberBuyers !=0)
            {
                purchaseAmount = rand.Next(firstValueForTest, secondValueForTest);
                shoppingQueue.Enqueue(purchaseAmount);
                numberBuyers--;
            }

            while (queue)
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
                    queue = false;
                    Console.WriteLine($"Очередь закончилась, вы обслужили всех клиентов");
                    Console.ReadKey();
                }
            }
        }
    }
}