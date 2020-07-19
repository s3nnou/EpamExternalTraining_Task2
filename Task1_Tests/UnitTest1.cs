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

    }
}
