using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer c1 = new Customer("Parth Shah", "dffdsg", 200, 54352345, 5000);
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
            Console.WriteLine("\nSuccess");
        }
    }
}
