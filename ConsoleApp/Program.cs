using System;
using CollectionEnvironment;

namespace ConsoleApp
{
    static class Program
    {
        static void Main()
        {
            RingQueue<int> ringQueue = new RingQueue<int>(new DoublingStrategy());

            ringQueue.Enqueue(0);
            ringQueue.Enqueue(1);
            ringQueue.Enqueue(2);
            ringQueue.Enqueue(3);
            ringQueue.Enqueue(4);
            ringQueue.Enqueue(5);
            ringQueue.Enqueue(6);
            ringQueue.Enqueue(7);
            ringQueue.Enqueue(8);
            ringQueue.Enqueue(9);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(ringQueue.Dequeue());
            }

            ringQueue.Enqueue(0);
            ringQueue.Enqueue(1);
            ringQueue.Enqueue(2);
            ringQueue.Enqueue(3);
            ringQueue.Enqueue(4);
            ringQueue.Enqueue(5);
            ringQueue.Enqueue(6);
            ringQueue.Enqueue(7);
            ringQueue.Enqueue(8);
            ringQueue.Enqueue(9);
            ringQueue.Enqueue(0);
            ringQueue.Enqueue(1);
            ringQueue.Enqueue(2);
            ringQueue.Enqueue(3);
            ringQueue.Enqueue(4);
            ringQueue.Enqueue(5);
            ringQueue.Enqueue(6);
            ringQueue.Enqueue(7);
            ringQueue.Enqueue(8);
            ringQueue.Enqueue(9);

            for (int i = ringQueue.Size; i > 0; i--)
            {
                Console.WriteLine(ringQueue.Dequeue());
            }

            ringQueue.Enqueue(1);

            for (int i = ringQueue.Size; i > 0; i--)
            {
                Console.WriteLine(ringQueue.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
