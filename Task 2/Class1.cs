using System;

namespace Task_2
{
    public class Polymonial
    {
        private float[] members;
        private int rank;


        public float this[int index]
        {
            get => members[index];
        }

        Polymonial(params float[] args)
        {
            if (args.Length > 0)
            {
                rank = args.Length;
                members = args;
            }
            else
            {
                throw new Exception("Test");
            }
        }

        public float[] Items { get => members; set => members = value; }

        public static Polymonial operator +(Polymonial a) => a;
        public static Polymonial operator -(Polymonial a)
        {
            float[] newPoly = new float[a.rank];

            for (int i = 0; i < a.rank; i++)
            {
                newPoly[i] = -a[i];

            }

            return new Polymonial(newPoly);
        }


        public static Polymonial operator +(Polymonial a, Polymonial b)
        {
            float[] newPoly;

            if(a.rank > b.rank)
            {
                newPoly = new float[a.rank];

                for (int i = 0; i < a.rank; i++)
                {
                    if(i < b.rank)
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
            else if(a.rank < b.rank){
                newPoly = new float[b.rank];

                for (int i = 0; i < b.rank; i++)
                {
                    if (i < a.rank)
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
                newPoly = new float[b.rank];

                for (int i = 0; i < b.rank; i++)
                {
                    newPoly[i] = a[i] + b[i];
                }

                return new Polymonial(newPoly);
            }
        }

        public static Polymonial operator -(Polymonial a, Polymonial b)
        {
            float[] newPoly;

            if (a.rank > b.rank)
            {
                newPoly = new float[a.rank];

                for (int i = 0; i < a.rank; i++)
                {
                    if (i < b.rank)
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
            else if (a.rank < b.rank)
            {
                newPoly = new float[b.rank];

                for (int i = 0; i < b.rank; i++)
                {
                    if (i < a.rank)
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
                newPoly = new float[b.rank];

                for (int i = 0; i < b.rank; i++)
                {
                    newPoly[i] = a[i] + b[i];
                }

                return new Polymonial(newPoly);
            }
        }

        public static Polymonial operator *(Polymonial a, Polymonial b)
        {
            float[] newPoly = new float[a.rank + b.rank - 1];

            for (int i = 0; i < a.rank; i++)
            {
                for(int j = 0; j < b.rank; j++)
                {
                    if (newPoly[i + j] != 0)
                    {
                        newPoly[i + j] = a[i] * b[j];
                    }
                    else
                    {
                        newPoly[i + j] += a[i] * b[j];
                    }
                }
            }

            return new Polymonial(newPoly);
        }

      
        public static Polymonial operator +(Polymonial a, float b)
        {
            float[] newPoly = new float[a.rank];

            newPoly[0] += b;

            return new Polymonial(newPoly);
        }


        public static Polymonial operator +(float b, Polymonial a)
        {
            return a + b;
        }

        public static Polymonial operator -(Polymonial a, float b)
        {
            float[] newPoly = new float[a.rank];

            newPoly[0] -= b;

            return new Polymonial(newPoly);
        }

        public static Polymonial operator -(float b, Polymonial a)
        {
            return a - b;
        }

        public static Polymonial operator *(Polymonial a, float b)
        {
            float[] newPoly = new float[a.rank];

            for (int i = 0; i < a.rank; i++)
            {
                newPoly[i] = a[i] * b;

            }

            return new Polymonial(newPoly);
        }

        public static Polymonial operator *(float b, Polymonial a)
        {
            return a * b;
        }

        public static Polymonial operator /(Polymonial a, float b)
        {
            float[] newPoly = new float[a.rank];

            for (int i = 0; i < a.rank; i++)
            {
                newPoly[i] = a[i] / b;

            }

            return new Polymonial(newPoly);
        }

        public static Polymonial operator /(float b, Polymonial a)
        {
            return a / b;
        }
    }
}
