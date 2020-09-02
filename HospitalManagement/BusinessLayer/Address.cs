using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    //Storing the address of Hospital Staff and Patients
    public class Address
    {
        private short _flat;
        public short flat
        {
            get
            {
                return _flat;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Invalid Flat Number");
                else
                    _flat = value; 
            } 
        }
        public string building { get; set; } 
        public string street{ get; set; }
        public string city { get; set; }
        public int pin { get; set; }
        public Address() { }
        public Address(short f, string b,string street,int pin,string city)
        {
            flat = f;
            building = b;
            this.street = street;
            this.pin = pin;
            this.city = city;
        }
    }
}
