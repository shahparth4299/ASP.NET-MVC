using System;

namespace Interface
{
    public interface BankPayment
    {
        float DoBankPayment(float amount);
    }
    interface UPIPayment
    {
        float DoUpiPayment(float amount);
    }
    public class Payment : BankPayment, UPIPayment
    {
        public float DoBankPayment(float amount)
        {
            return amount - (amount * (float)0.15);
        }
        public float DoUpiPayment(float amount)
        {
            return amount - (amount * (float)0.25);
        }
    }
    public class NetBanking : BankPayment
    {
        public float DoBankPayment(float amt)
        {
            Console.WriteLine("Validation Using Username and Password");
            return amt - amt * (float)0.2;
        }
    }
    public class CardPayment : BankPayment
    {
        public float DoBankPayment(float amt)
        {
            Console.WriteLine("Validation Using CardNumber and CVV");
            return amt - amt * (float)0.25;
        }
    }
    public static class Factory 
    {
        public static BankPayment create(int flag)
        {
            if(flag == 1)
            {
                return new NetBanking();
            }
            else
            {
                return new CardPayment();
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Demo Code: ");
            BankPayment obj1 = new Payment();
            Console.WriteLine("After Discount: "+obj1.DoBankPayment(25000));

            UPIPayment obj2 = new Payment();
            Console.WriteLine("After Discount: " +obj2.DoUpiPayment(50000));

            Console.WriteLine("Interface Demo Code Using Factory Method: ");
            BankPayment obj3 = Factory.create(1);
            Console.WriteLine(obj3.DoBankPayment(35000));
            BankPayment obj4 = Factory.create(2);
            Console.WriteLine(obj4.DoBankPayment(78000));
        }
    }
}
