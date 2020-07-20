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

        /// <summary>
        /// Used for a addition between same types of items.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>new same class item object</returns>
        public static Technic operator +(Technic a, Technic b)
        {
            return new Technic(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        }

        /// <summary>
        /// Converts this class object into a Chemical class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Chemical(Technic a)
        {
            return new Chemical(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Converts this class object into a Furniture class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Furniture(Technic a)
        {
            return new Furniture(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Converts this class object into a Food class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Food(Technic a)
        {
            return new Food(a.Name, a.Type, a.Price);
        }

        /// <summary>
        /// Returns item price in the coins
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator int(Technic a)
        {
            return (int)(a.Price * 100);
        }

        /// <summary>
        /// Returns item price in the money and coins
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator float(Technic a)
        {
            return a.Price;
        }

        /// <summary>
        /// Used for comparing two objects
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If two items are equal - true, else - false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Technic)
            {
                Technic technic = obj as Technic;

                if (this.Name == technic.Name && this.Price == technic.Price && this.Type == technic.Type)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns HashCode of the object
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            return (Type.GetHashCode() ^ Price.GetHashCode() ^ Name.GetHashCode());
        }
    }
}
