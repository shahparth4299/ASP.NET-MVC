using System;

namespace DelegateDemo1
{
    class Program
    {
        delegate void pointer();
        static pointer point;
        static void Main(string[] args)
        {
            point += Demo1;
            point += Demo2;
            point.Invoke();
            Console.Read();
        }
        static void Demo1()
        {
            Console.WriteLine("Function 1");
        }
        static void Demo2()
        {
            Console.WriteLine("Function 2");
        }
    }
}
