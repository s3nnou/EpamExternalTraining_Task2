using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Technic:Product
    {
        public Technic(string name, string type, float price) : base(name, type, price)
        {

        }
        public static Technic operator +(Technic a, Technic b)
        {
            return new Technic(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        }

        public static explicit operator Chemical(Technic a)
        {
            return new Chemical(a.Name, a.Type, a.Price);
        }

        public static explicit operator Furniture(Technic a)
        {
            return new Furniture(a.Name, a.Type, a.Price);
        }

        public static explicit operator Food(Technic a)
        {
            return new Food(a.Name, a.Type, a.Price);
        }

        public static explicit operator int(Technic a)
        {
            return (int)(a.Price * 100);
        }

        public static explicit operator float(Technic a)
        {
            return a.Price;
        }

    }
}
