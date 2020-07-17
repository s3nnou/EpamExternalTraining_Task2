using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Food : Product
    {
        public Food(string name, string type, float price) : base(name, type, price)
        {

        }

         public static Food operator +(Food a, Food b)
        {
            return new Food(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        }

        public static explicit operator Chemical(Food a)
        {
            return new Chemical(a.Name, a.Type, a.Price);
        }

        public static explicit operator Furniture(Food a)
        {
            return new Furniture(a.Name, a.Type, a.Price);
        }

        public static explicit operator Technic(Food a)
        {
            return new Technic(a.Name, a.Type, a.Price);
        }

        public static explicit operator int(Food a)
        {
            return (int) (a.Price * 100);
        }

        public static explicit operator float(Food a)
        {
            return a.Price;
        }
    }
}
