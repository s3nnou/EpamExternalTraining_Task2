using System;

namespace epam_task_2._0
{
    /// <summary>
    /// This is a basic 3d vector
    /// </summary>
    public class Vector3
    {
        private float x;
        private float y;
        private float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }

        /// <summary>
        /// This is unary operator -. Used for making vector coords nagative nubmers
        /// </summary>
        /// <param name="a"></param>
        /// <returns>-Vector</returns>
        public static Vector3 operator -(Vector3 a) => new Vector3(-a.X, -a.Y, -a.Z);

        /// <summary>
        /// This is unary operator ++. Used for increment
        /// </summary>
        /// <param name="a"></param>
        /// <returns>++Vector</returns>
        public static Vector3 operator ++(Vector3 a) => new Vector3(++a.X, ++a.Y, ++a.Z);

        /// <summary>
        /// This is unary operator --. Used for decrement
        /// </summary>
        /// <param name="a"></param>
        /// <returns>--Vector</returns>
        public static Vector3 operator --(Vector3 a) => new Vector3(--a.X, --a.Y, --a.Z);

        /// <summary>
        /// This is binary operator. Used for addition.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Vector(a + b)</returns>
        public static Vector3 operator +(Vector3 a, Vector3 b) => new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        /// <summary>
        /// This is binary operator. Used for multiplication.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Vector(a * b)</returns>
        public static Vector3 operator *(Vector3 a, Vector3 b) => new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

        /// <summary>
        /// This is binary operator. Used for substraction.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Vector(a - b)</returns>
        public static Vector3 operator -(Vector3 a, Vector3 b) => new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        /// <summary>
        /// This is binary operator. Used for division.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Vector(a / b)</returns>
        public static Vector3 operator /(Vector3 a, Vector3 b)
        {
            float x;
            float y;
            float z;
            if(b.x != 0 && b.y != 0 && b.z != 0)
            {
                x = a.X / b.X;
                y = a.Y / b.Y;
                z = a.Z / b.Z;
            }
            else
            {
                throw new Exception();
            }
      
            return new Vector3(x, y, z);
        }

     

        /// <summary>
        /// This is binary operator. Used for multiplication any vector with a float.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Vector(a) * b</returns>
        public static Vector3 operator *(Vector3 a, float b) => new Vector3(a.X * b, a.Y * b, a.Z * b);

        /// <summary>
        /// This is binary operator. Used for division any vector with a float.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Vector(a) / b</returns>
        public static Vector3 operator /(Vector3 a, float b)
        {
            float x;
            float y;
            float z;

            if (b != 0)
            {
                x = a.X / b;
                y = a.Y / b;
                z = a.Z / b;
            }
            else
            {
                throw new Exception();
            }

            return new Vector3(x, y, z);
        }

        /// <summary>
        /// Same as a multiplication any vector with a float.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>Vector(a) * b</returns>
        public static Vector3 operator *(float b, Vector3 a) => a * b;

        /// <summary>
        /// Same a division any vector with a float.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns>Vector(a) / b</returns>
        public static Vector3 operator /(float b, Vector3 a) => a / b;

        public override bool Equals(object obj)
        {
            if(obj is Vector3)
            {
                Vector3 vector3 = obj as Vector3;

                if ((x == vector3.x) && (y == vector3.y) && (z == vector3.z))
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
    }
}
