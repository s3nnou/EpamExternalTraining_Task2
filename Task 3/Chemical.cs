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

        /// <summary>
        /// Used for a addition between same types of items.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>new same class item object</returns>
        public static Chemical operator +(Chemical a, Chemical b)
        {
            return new Chemical(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        }


        /// <summary>
        /// Converts this class object into a Food class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Food(Chemical a)
        {
            return new Food(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Converts this class object into a Furniture class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Furniture(Chemical a)
        {
            return new Furniture(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Converts this class object into a Technic class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Technic(Chemical a)
        {
            return new Technic(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Returns item price in the coins type
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator int(Chemical a)
        {
            return (int) (a.Price * 100);
        }

        /// <summary>
        /// Returns item price in the money and coins type
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator float(Chemical a)
        {
            return  a.Price;
        }
    }
}
