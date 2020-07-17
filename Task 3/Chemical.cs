using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Chemical:Product
    {
        public Chemical(string name, string type, float price): base(name, type, price)
        {
           
        }

        public static Chemical operator +(Chemical a, Chemical b)
        {
            return new Chemical(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        }

        public static explicit operator Food(Chemical a)
        {
            return new Food(a.Name, a.Type, a.Price);
        }

        public static explicit operator Furniture(Chemical a)
        {
            return new Furniture(a.Name, a.Type, a.Price);
        }

        public static explicit operator Technic(Chemical a)
        {
            return new Technic(a.Name, a.Type, a.Price);
        }

        public static explicit operator int(Chemical a)
        {
            return (int) (a.Price * 100);
        }

        public static explicit operator float(Chemical a)
        {
            return  a.Price;
        }
    }
}
