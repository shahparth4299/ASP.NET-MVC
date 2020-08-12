using System;
using System.Threading;
using System.Threading.Tasks;
namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo1();
            Demo2();
            Console.WriteLine("End of Main");
            Console.Read();
        }
        static void Demo1()
        {
            Console.WriteLine("Inside the Demo1");
        }
        static void Demo2()
        {
            Console.WriteLine("Inside the Demo2");
        }
    }
}
