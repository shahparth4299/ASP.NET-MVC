using System;
using System.Diagnostics;
namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            CheckPerformance();
            s1.Stop();
            Console.WriteLine(s1.ElapsedMilliseconds);
            s1.Restart();
            s1.Start();
            CheckPerformance();
            s1.Stop();
            Console.WriteLine(s1.ElapsedMilliseconds);
            s1.Restart();
            s1.Start();
            CheckPerformance();
            s1.Stop();
            Console.WriteLine(s1.ElapsedMilliseconds);

            Console.Read(); 
            Console.WriteLine("This is main");
        }
        static void CheckPerformance()
        {
            for (int i = 0; i < 10000000; i++)
            {
                int a = 200;
                object b = a;
            }
        }
    }
}
