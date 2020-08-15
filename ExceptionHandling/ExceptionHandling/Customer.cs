using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExceptionHandling
{
    public class Customer
    {
        string name, address;
        short age;
        int mobile,amount;
        public Customer(string name,string address,short age,int mobile,int amount)
        {
            try
            {
                ValidateData(name, address, age, mobile, amount);
            }
            catch(Exception e)
            {
                throw;
            }

        }
        public void ValidateData(string name, string address, short age, int mobile, int amount)
        {
            if (name.Length == 0)
            {
                throw new Exception("Name is Null");
            }
            if (address.Length == 0)
            {
                throw new Exception("Addres is null");
            }
            if (age < 1 || age > 110)
            {
                throw new ParthException("INVALID AGE ");
            }
        }
    }
}
