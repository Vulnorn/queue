using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//У вас есть множество целых чисел. Каждое целое число - это сумма покупки.
//Вам нужно обслуживать клиентов до тех пор, пока очередь не станет пуста.
//После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
//После обслуживания каждого клиента программа ожидает нажатия любой клавиши, после чего затирает консоль и по новой выводит всю информацию, только уже со следующим клиентом

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> shoppingQueue = new Queue<int>();
            Random rand = new Random();
            bool queue = true;

            int numberBuyers = rand.Next();
            int purchaseAmount;

            while (numberBuyers !=0)
            {
                purchaseAmount = rand.Next();
                shoppingQueue.Enqueue(purchaseAmount);
                numberBuyers--;
            }

            while (queue)
            {
                Console.WriteLine($"Счет текущего клиента: {shoppingQueue} "); ;
            }
        }
    }
}
