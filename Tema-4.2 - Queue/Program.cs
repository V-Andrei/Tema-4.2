using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine("The elemets in queue are:");
            queue.ElementsQueuePrint();

            queue.Dequeue();
            queue.Enqueue(2);
            Console.WriteLine("The new element in queue is:");
            queue.ElementsQueuePrint();
            Console.ReadLine();
        }
    }


}
