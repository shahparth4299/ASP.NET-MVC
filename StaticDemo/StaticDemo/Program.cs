using System;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Class and Non-Static Class");
            
            Console.WriteLine("Static Variable Count: " + StaticDemo.count);
            Console.WriteLine("Static Method Call Count: "+StaticDemo.ShowCount());
            Console.WriteLine("Static Method Call Count: " + StaticDemo.ShowCount());
            Console.WriteLine("Static Variable Count: " + StaticDemo.count);

            NoneStaticDemo obj = new NoneStaticDemo();
            Console.WriteLine("Non-Static Variable Count: " + obj.count1);
            Console.WriteLine("Non-Static Method Call Count: " + obj.DisplayCount());
            Console.WriteLine("Non-Static Variable Count: " + obj.count1);

            Console.WriteLine("Static Variable Count: " + NoneStaticDemo.count2);
            Console.WriteLine("Static Method Call Count: " + NoneStaticDemo.DisplayCount2());
            Console.WriteLine("Static Variable Count: " + NoneStaticDemo.count2);

        }
    }
    static class StaticDemo
    {
        public static int count;
        public static int ShowCount()
        {
            return ++count;
        }
    }
    class NoneStaticDemo
    {
        public int count1;
        public static int count2;
        public int DisplayCount()
        {
            return ++count1;
        }
        public static int DisplayCount2()
        {
            return ++count2;
        }

    }
}
