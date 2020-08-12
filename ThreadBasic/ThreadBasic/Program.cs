using System;
using System.Threading;

namespace ThreadBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Demo));
            Thread t2 = new Thread(new ThreadStart(Demo2));
            t1.Start();
            t2.Start();
            Console.WriteLine("Completed");
            Console.Read();
        }
        static void Demo()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Inside 1st Function");
        }
        static void Demo2()
        {
            Console.WriteLine("Inside 2nd Function");
        }
    }
}
