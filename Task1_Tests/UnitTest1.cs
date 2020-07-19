using System;
using epam_task_2._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VectorNegativeIntoPositive1()
        {
            float t_x = 1;
            float t_y = 1;
            float t_z = 1;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = -1;
            float ex_y = -1;
            float ex_z = -1;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = -vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorNegativeIntoPositive2()
        {
            float t_x = 1;
            float t_y = 5;
            float t_z = 0;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = -1;
            float ex_y = -5;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = -vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorNegativeIntoPositive3()
        {
            float t_x = 0;
            float t_y = 0;
            float t_z = -5;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = 0;
            float ex_y = 0;
            float ex_z = 5;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = -vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorIncrement1()
        {
            float t_x = 1;
            float t_y = 1;
            float t_z = 1;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = 2;
            float ex_y = 2;
            float ex_z = 2;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = ++vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorIncrement2()
        {
            float t_x = 0;
            float t_y = 0;
            float t_z = 0;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = 1;
            float ex_y = 1;
            float ex_z = 1;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = ++vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorIncrement3()
        {
            float t_x = -1;
            float t_y = 1;
            float t_z = -1;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = 0;
            float ex_y = 2;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = ++vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorDecrement1()
        {
            float t_x = 1;
            float t_y = 1;
            float t_z = 1;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = 0;
            float ex_y = 0;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = --vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorDecrement2()
        {
            float t_x = 0;
            float t_y = 0;
            float t_z = 0;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = -1;
            float ex_y = -1;
            float ex_z = -1;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = --vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorDecrement3()
        {
            float t_x = -1;
            float t_y = 1;
            float t_z = -1;

            Vector3 vector3ToTest = new Vector3(t_x, t_y, t_z);

            float ex_x = -2;
            float ex_y = 0;
            float ex_z = -2;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3ToTest = --vector3ToTest;

            Assert.IsTrue(vector3Expected.Equals(vector3ToTest));
        }

        [TestMethod]
        public void VectorAddition1()
        {
            float t_x1 = 1;
            float t_y1 = 1;
            float t_z1 = 1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 1;
            float t_y2 = 1;
            float t_z2 = 1;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);



            float ex_x = 2;
            float ex_y = 2;
            float ex_z = 2;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);


            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA + vector3ToTestB));
        }

        [TestMethod]
        public void VectorAddition2()
        {
            float t_x1 = 1;
            float t_y1 = 1;
            float t_z1 = 1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = -1;
            float t_y2 = 1;
            float t_z2 = -1;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);



            float ex_x = 0;
            float ex_y = 2;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);


            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA + vector3ToTestB));
        }

        [TestMethod]
        public void VectorAddition3()
        {
            float t_x1 = -1;
            float t_y1 = 1;
            float t_z1 = -1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = -1;
            float t_y2 = 1;
            float t_z2 = -1;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = -2;
            float ex_y = 2;
            float ex_z = -2;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);


            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA + vector3ToTestB));
        }

        [TestMethod]
        public void VectorSubstraction1()
        {
            float t_x1 = 1;
            float t_y1 = 1;
            float t_z1 = 1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 1;
            float t_y2 = 1;
            float t_z2 = 1;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = 0;
            float ex_y = 0;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);


            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA - vector3ToTestB));
        }

        [TestMethod]
        public void VectorSubstraction2()
        {
            float t_x1 = 1;
            float t_y1 = 1;
            float t_z1 = 1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = -1;
            float t_y2 = 1;
            float t_z2 = -1;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = 2;
            float ex_y = 0;
            float ex_z = 2;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);


            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA - vector3ToTestB));
        }

        [TestMethod]
        public void VectorSubstraction3()
        {
            float t_x1 = 1;
            float t_y1 = -1;
            float t_z1 = 0;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 5;
            float t_y2 = 6;
            float t_z2 = -100;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = -4;
            float ex_y = -7;
            float ex_z = 100;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA - vector3ToTestB));
        }

        [TestMethod]
        public void VectorMultiplication1()
        {
            float t_x1 = 1;
            float t_y1 = -1;
            float t_z1 = 0;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 5;
            float t_y2 = 6;
            float t_z2 = -100;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = 5;
            float ex_y = -6;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA * vector3ToTestB));
        }

        [TestMethod]
        public void VectorMultiplication2()
        {
            float t_x1 = 0;
            float t_y1 = 0;
            float t_z1 = 0;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 5;
            float t_y2 = 6;
            float t_z2 = -100;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = 0;
            float ex_y = 0;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA * vector3ToTestB));
        }

        [TestMethod]
        public void VectorMultiplication3()
        {
            float t_x1 = 10;
            float t_y1 = 10;
            float t_z1 = 0;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 2.5f;
            float t_y2 = 10;
            float t_z2 = -100;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = 25;
            float ex_y = 100;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA * vector3ToTestB));
        }

        [TestMethod]
        public void VectorDivision1()
        {
            float t_x1 = 10;
            float t_y1 = 2;
            float t_z1 = 6;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 2;
            float t_y2 = 2;
            float t_z2 = 2;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = 5;
            float ex_y = 1;
            float ex_z = 3;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA / vector3ToTestB));
        }

        [TestMethod]
        public void VectorDivision2()
        {
            float t_x1 = 100;
            float t_y1 = 20;
            float t_z1 = 60;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 2;
            float t_y2 = 2;
            float t_z2 = 2;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = 50;
            float ex_y = 10;
            float ex_z = 30;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA / vector3ToTestB));
        }

        [TestMethod]
        public void VectorDivision3()
        {
            float t_x1 = -50;
            float t_y1 = 0;
            float t_z1 = 60;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 2;
            float t_y2 = 2;
            float t_z2 = 2;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = -25;
            float ex_y = 0;
            float ex_z = 30;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA / vector3ToTestB));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void VectorDivisionExeption()
        {
            float t_x1 = -50;
            float t_y1 = 0;
            float t_z1 = 60;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float t_x2 = 0;
            float t_y2 = 2;
            float t_z2 = 2;

            Vector3 vector3ToTestB = new Vector3(t_x2, t_y2, t_z2);

            float ex_x = -25;
            float ex_y = 0;
            float ex_z = 30;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3Expected.Equals(vector3ToTestA / vector3ToTestB);
        }

        [TestMethod]
        public void VectorMultiplicationByFloat1()
        {
            float t_x1 = 1;
            float t_y1 = -1;
            float t_z1 = 0;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 0;

            float ex_x = 0;
            float ex_y = 0;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA * b));
        }

        [TestMethod]
        public void VectorMultiplicationByFloat2()
        {
            float t_x1 = 1;
            float t_y1 = -1;
            float t_z1 =1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 10;

            float ex_x = 10;
            float ex_y = -10;
            float ex_z = 10;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA * b));
        }

        [TestMethod]
        public void VectorMultiplicationByFloat3()
        {
            float t_x1 = 1;
            float t_y1 = -1;
            float t_z1 = 1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 5;

            float ex_x = 5;
            float ex_y = -5;
            float ex_z = 5;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA * b));
        }

        [TestMethod]
        public void VectorMultiplicationByFloatButFloatIsFirst()
        {
            float t_x1 = 1;
            float t_y1 = -1;
            float t_z1 = 0;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 0;

            float ex_x = 0;
            float ex_y = 0;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(b * vector3ToTestA));
        }

        [TestMethod]
        public void VectorDivisionByFloat1()
        {
            float t_x1 = 10;
            float t_y1 = -10;
            float t_z1 = 0;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 2;

            float ex_x = 5;
            float ex_y = -5;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA / b));
        }

        [TestMethod]
        public void VectorDivisionByFloat2()
        {
            float t_x1 = 52;
            float t_y1 = 44;
            float t_z1 = 1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 2;

            float ex_x = 26;
            float ex_y = 22;
            float ex_z = 0.5f;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA / b));
        }

        [TestMethod]
        public void VectorDivisionByFloat3()
        {
            float t_x1 = 0;
            float t_y1 = 0;
            float t_z1 = 0;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 5;

            float ex_x = 0;
            float ex_y = 0;
            float ex_z = 0;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(vector3ToTestA / b));
        }

        [TestMethod]
        public void VectorDivisionByFloatButFloatIsFirst()
        {
            float t_x1 = 1;
            float t_y1 = 1;
            float t_z1 = 1;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 2;

            float ex_x = 0.5f;
            float ex_y = 0.5f;
            float ex_z = 0.5f;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            Assert.IsTrue(vector3Expected.Equals(b / vector3ToTestA));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void VectorDivisionByFloatExeption()
        {
            float t_x1 = -50;
            float t_y1 = 0;
            float t_z1 = 60;

            Vector3 vector3ToTestA = new Vector3(t_x1, t_y1, t_z1);

            float b = 0;

            float ex_x = -25;
            float ex_y = 0;
            float ex_z = 30;

            Vector3 vector3Expected = new Vector3(ex_x, ex_y, ex_z);

            vector3Expected.Equals(vector3ToTestA / b);
        }
    }
}
