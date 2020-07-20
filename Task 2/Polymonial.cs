using System;
using System.Linq;

namespace Task_2
{
    /// <summary>
    /// Polymonial and basic actions with them
    /// </summary>
    public class Polymonial
    {
        private float[] members;
        private int degree;

        public float this[int index]
        {
            get => members[index];
        }

        public Polymonial(params float[] args)
        {
            if (args.Length > 0)
            {
                degree = args.Length;
                members = args;
            }
            else
            {
                throw new Exception("Such poly cannot exists");
            }
        }

        /// <summary>
        /// Getter for array items
        /// </summary>
        public float[] Items { get => members; set => members = value; }

        /// <summary>
        ///  This is unary operator. Used for making all members of the poly negative
        /// </summary>
        /// <param name="a"></param>
        /// <returns>-members</returns>
        public static Polymonial operator -(Polymonial a)
        {
            float[] newPoly = new float[a.degree];

            for (int i = 0; i < a.degree; i++)
            {
                newPoly[i] = -a[i];

            }

            return new Polymonial(newPoly);
        }

        /// <summary>
        /// This is binary operator. Used for addition.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Poly (a + b)</returns>
        public static Polymonial operator +(Polymonial a, Polymonial b)
        {
            float[] newPoly;

            if(a.degree > b.degree)
            {
                newPoly = new float[a.degree];

                for (int i = 0; i < a.degree; i++)
                {
                    if(i < b.degree)
                    {
                        newPoly[i] = a[i] + b[i];
                    }
                    else
                    {
                        newPoly[i] = a[i];
                    }
                }

                return new Polymonial(newPoly);
            }
            else if(a.degree < b.degree){
                newPoly = new float[b.degree];

                for (int i = 0; i < b.degree; i++)
                {
                    if (i < a.degree)
                    {
                        newPoly[i] = a[i] + b[i];
                    }
                    else
                    {
                        newPoly[i] = b[i];
                    }
                }

                return new Polymonial(newPoly);
            }
            else
            {
                newPoly = new float[b.degree];

                for (int i = 0; i < b.degree; i++)
                {
                    newPoly[i] = a[i] + b[i];
                }

                return new Polymonial(newPoly);
            }
        }

        /// <summary>
        /// This is binary operator. Used for subtraction any poly with poly
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Poly( a - b)</returns>
        public static Polymonial operator -(Polymonial a, Polymonial b)
        {
            float[] newPoly;

            if (a.degree > b.degree)
            {
                newPoly = new float[a.degree];

                for (int i = 0; i < a.degree; i++)
                {
                    if (i < b.degree)
                    {
                        newPoly[i] = a[i] - b[i];
                    }
                    else
                    {
                        newPoly[i] = a[i];
                    }
                }

                return new Polymonial(newPoly);
            }
            else if (a.degree < b.degree)
            {
                newPoly = new float[b.degree];

                for (int i = 0; i < b.degree; i++)
                {
                    if (i < a.degree)
                    {
                        newPoly[i] = a[i] - b[i];
                    }
                    else
                    {
                        newPoly[i] = b[i];
                    }
                }

                return new Polymonial(newPoly);
            }
            else
            {
                newPoly = new float[b.degree];

                for (int i = 0; i < b.degree; i++)
                {
                    newPoly[i] = a[i] - b[i];
                }

                return new Polymonial(newPoly);
            }
        }

        /// <summary>
        /// This is binary operator. Used for multiplication poly with poly
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Poly( a  * b)</returns>
        public static Polymonial operator *(Polymonial a, Polymonial b)
        {
            float[] newPoly = new float[a.degree + b.degree - 1];

            for (int i = 0; i < a.degree; i++)
            {
                for(int j = 0; j < b.degree; j++)
                {
                    newPoly[i + j] += a[i] * b[j];

                }
            }

            return new Polymonial(newPoly);
        }


        /// <summary>
        /// Same as an addition any poly with a float.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>Vector(a) + b</returns>
        public static Polymonial operator +(Polymonial a, float b)
        {
            float[] newPoly = a.members;

            newPoly[0] += b;

            return new Polymonial(newPoly);
        }

        /// <summary>
        /// Same as addition for a poly and a float
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>poly(a) + b</returns>
        public static Polymonial operator +(float b, Polymonial a)
        {
            return a + b;
        }

        /// <summary>
        /// Binary operation. Used for a binary substraction for a poly and a float
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns> Poly(a) - b</returns>
        public static Polymonial operator -(Polymonial a, float b)
        {
            float[] newPoly = a.members;

            newPoly[0] -= b;

            return new Polymonial(newPoly);
        }

        /// <summary>
        /// Same as an substarction for any poly with a float.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>Vector(a) + b</returns>
        public static Polymonial operator -(float b, Polymonial a)
        {
            return a - b;
        }

        /// <summary>
        /// Binary operation. Used for a multiplication for a poly and a float
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Poly(a) * b</returns>
        public static Polymonial operator *(Polymonial a, float b)
        {
            float[] newPoly = a.members;

            for (int i = 0; i < a.degree; i++)
            {
                newPoly[i] = a[i] * b;

            }

            return new Polymonial(newPoly);
        }

        /// <summary>
        /// Same as a multiplication for any poly with a float.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Polymonial operator *(float b, Polymonial a)
        {
            return a * b;
        }

        /// <summary>
        /// Binary operation. Used for division for a poly with a float.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Poly(a) / b </returns>
        public static Polymonial operator /(Polymonial a, float b)
        {
            float[] newPoly = a.members;

            if(b != 0)
            {
                for (int i = 0; i < a.degree; i++)
                {
                    newPoly[i] = a[i] / b;

                }
            }
            else
            {
                throw new DivideByZeroException();
            }

            return new Polymonial(newPoly);
        }

        /// <summary>
        /// Used for comparing two objects
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If two items are equal - true, else - false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Polymonial)
            {
                Polymonial polymonial = obj as Polymonial;

                if (Enumerable.SequenceEqual(this.members, polymonial.members))
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
            return (members.GetHashCode() ^ degree.GetHashCode());
        }
    }
}
