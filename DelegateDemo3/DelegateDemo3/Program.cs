using System;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser p1 = new Parser();
            p1.p += demo1;
            p1.p += demo2;
            Task t1 = new Task(p1.parse);
            t1.Start();
            Console.WriteLine("Inside Main");
            Console.Read();
        }
        static void demo1(int i)
        {
            Console.WriteLine("Fun 1: "+i);
            
        }
        static void demo2(int i)
        {
            
            Console.WriteLine("Fun 2: "+i);
        }
    }
    public class Parser
    {
        public delegate void pointer(int i);
        public pointer p;
        public void parse()
        {
            for(int i=0;i<10;i++)
            {
                Thread.Sleep(2000);
                p.Invoke(i);
            }
        }
    }
}
