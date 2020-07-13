using System;

namespace epam_task_2._0
{
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

        //unary
        public static Vector3 operator +(Vector3 a) => new Vector3(a.X, a.Y, a.Z);
        public static Vector3 operator -(Vector3 a) => new Vector3(-a.X, -a.Y, -a.Z);
        public static Vector3 operator ++(Vector3 a) => new Vector3(++a.X, ++a.Y, ++a.Z);
        public static Vector3 operator --(Vector3 a) => new Vector3(--a.X, --a.Y, --a.Z);

        //binary with vectors
        public static Vector3 operator +(Vector3 a, Vector3 b) => new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector3 operator *(Vector3 a, Vector3 b) => new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

        public static Vector3 operator /(Vector3 a, Vector3 b)
        {
            float x;
            float y;
            float z;
            try
            {
                x = a.X / b.X;
                y = a.Y / b.Y;
                z = a.Z / b.Z;
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }

            return new Vector3(x, y, z);
        }

        //binary with float and vector
        public static Vector3 operator %(Vector3 a, float b) => new Vector3(a.X % b, a.Y % b, a.Z % b);
        public static Vector3 operator +(Vector3 a, float b) => new Vector3(a.X + b, a.Y + b, a.Z + b);
        public static Vector3 operator *(Vector3 a, float b) => new Vector3(a.X * b, a.Y * b, a.Z * b);

        public static Vector3 operator /(Vector3 a, float b)
        {
            float x;
            float y;
            float z;

            try
            {
                x = a.X / b;
                y = a.Y / b;
                z = a.Z / b;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }

            return new Vector3(x, y, z);
        }

        public static Vector3 operator %(float b, Vector3 a) => a % b;
        public static Vector3 operator +(float b, Vector3 a) => a + b;
        public static Vector3 operator *(float b, Vector3 a) => a * b;

        public static Vector3 operator /(float b, Vector3 a) => a / b;
    }
}
