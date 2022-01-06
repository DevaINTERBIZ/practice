using System;
using System.Threading;
namespace MultithreadingTest
{
    class Program
    {
        public void counter() {
            lock (this)
            {
                for (int i = 1; i <= 25; i++)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(200);
                }
            }
        }


        public void counter3()
        {
            lock (this)
            {
                for (int i = 51; i <= 75; i++)
                {
                    Console.Write(i + " ");

                    Thread.Sleep(200);
                }
            }
        }

        public void counter1()
        {
            lock (this)
            {
                for (int i = 26; i <= 50; i++)
                {
                    Console.Write(i + " ");

                    Thread.Sleep(200);
                }
            }
        }

        static void Main(string[] args)
        {
            Program pr = new Program();
            Thread t1 = new Thread(pr.counter);
            Thread t2 = new Thread(pr.counter1);
            Thread t3 = new Thread(pr.counter3);

            t1.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            t3.Start();
            
            
        }
    }
}
