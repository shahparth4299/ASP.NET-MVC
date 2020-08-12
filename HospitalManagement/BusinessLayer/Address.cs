using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Address
    {
        internal short flat;
        internal string building, street;
        internal int pin;
        public Address(short f, string b,string street,int pin)
        {
            flat = f;
            building = b;
            this.street = street;
            this.pin = pin;
        }
    }
}
