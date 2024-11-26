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
            int firstValueForTest = 0;
            int secondValueForTest = 10;
            int numberBuyers = random.Next(firstValueForTest,secondValueForTest);
            int purchaseAmount;
            int accountTotal =0;

            for (int i = numberBuyers; i > 0; i--)
            {
                purchaseAmount = random.Next(firstValueForTest, secondValueForTest);
                shoppingQueue.Enqueue(purchaseAmount);
            }

            while (shoppingQueue.Count != 0)
            {
                Console.WriteLine($"Счет текущего клиента: {shoppingQueue.First()}. \nСчет Магазина: {accountTotal}");
                accountTotal += shoppingQueue.Dequeue();
                Console.WriteLine($"Клиент совершил покупку. Счет магазина: {accountTotal}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Очередь закончилась, вы обслужили всех клиентов");
            Console.ReadKey();
        }
    }
}