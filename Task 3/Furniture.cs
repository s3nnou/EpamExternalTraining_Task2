using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Furniture : Product
    {
        public Furniture(string name, string type, float price) : base(name, type, price)
        {

        }

        public static Furniture operator +(Furniture a, Furniture b)
        {
            return new Furniture(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        }

        public static explicit operator Chemical(Furniture a)
        {
            return new Chemical(a.Name, a.Type, a.Price);
        }

        public static explicit operator Food(Furniture a)
        {
            return new Food(a.Name, a.Type, a.Price);
        }

        public static explicit operator Technic(Furniture a)
        {
            return new Technic(a.Name, a.Type, a.Price);
        }

        public static explicit operator int(Furniture a)
        {
            return (int)(a.Price * 100);
        }

        public static explicit operator float(Furniture a)
        {
            return a.Price;
        }
    }
}
