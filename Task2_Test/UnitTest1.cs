using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2;

namespace Task2_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PolyPositiveIntoNegative1()
        {
            float t_x0 = 1;
            float t_x1 = 1;
            float t_x2 = 1;
            float t_x3 = 1;
        
            Polymonial polyToTest = new Polymonial(t_x0, t_x1, t_x2, t_x3);

            float ex_x0 = -1;
            float ex_x1 = -1;
            float ex_x2 = -1;
            float ex_x3 = -1;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            polyToTest = -polyToTest;

            Assert.IsTrue(polyToExpected.Equals(polyToTest));
            
        }

        [TestMethod]
        public void PolyPositiveIntoNegative2()
        {
            float t_x0 = -1;
            float t_x1 = -1;
            float t_x2 = -1;
            float t_x3 = -1;

            Polymonial polyToTest = new Polymonial(t_x0, t_x1, t_x2, t_x3);

            float ex_x0 = 1;
            float ex_x1 = 1;
            float ex_x2 = 1;
            float ex_x3 = 1;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            polyToTest = -polyToTest;

            Assert.IsTrue(polyToExpected.Equals(polyToTest));

        }

        [TestMethod]
        public void PolyPositiveIntoNegative3()
        {
            float t_x0 = 1;
            float t_x1 = 0;
            float t_x2 = 0;
            float t_x3 = -1;

            Polymonial polyToTest = new Polymonial(t_x0, t_x1, t_x2, t_x3);

            float ex_x0 = -1;
            float ex_x1 = 0;
            float ex_x2 = 0;
            float ex_x3 = 1;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            polyToTest = -polyToTest;

            Assert.IsTrue(polyToExpected.Equals(polyToTest));

        }

        [TestMethod]
        public void PolyAdditions1()
        {
            float t1_x0 = 1;
            float t1_x1 = 1;
            float t1_x2 = 1;
            float t1_x3 = 1;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float t2_x0 = 1;
            float t2_x1 = 1;
            float t2_x2 = 1;
            float t2_x3 = 1;

            Polymonial polyToTest2 = new Polymonial(t2_x0, t2_x1, t2_x2, t2_x3);

            float ex_x0 = 2;
            float ex_x1 = 2;
            float ex_x2 = 2;
            float ex_x3 = 2;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 + polyToTest2));
        }

        [TestMethod]
        public void PolyAdditions2()
        {
            float t1_x0 = 100;
            float t1_x1 = 0;
            float t1_x2 = 0;
            float t1_x3 = -100;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float t2_x0 = 50;
            float t2_x1 = -40;
            float t2_x2 = 1;
            float t2_x3 = 321;

            Polymonial polyToTest2 = new Polymonial(t2_x0, t2_x1, t2_x2, t2_x3);

            float ex_x0 = 150;
            float ex_x1 = -40;
            float ex_x2 = 1;
            float ex_x3 = 221;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 + polyToTest2));
        }

        [TestMethod]
        public void PolyAdditions3()
        {
            float t1_x0 = 1;
            float t1_x1 = 1;
            float t1_x2 = 1;
            float t1_x3 = 1;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float t2_x0 = 1;
            float t2_x1 = 1;
            float t2_x2 = 1;
            float t2_x3 = 1;

            Polymonial polyToTest2 = new Polymonial(t2_x0, t2_x1, t2_x2, t2_x3);

            float ex_x0 = 2;
            float ex_x1 = 2;
            float ex_x2 = 2;
            float ex_x3 = 2;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 + polyToTest2));
        }

        [TestMethod]
        public void PolySubstraction1()
        {
            float t1_x0 = 1;
            float t1_x1 = 1;
            float t1_x2 = 1;
            float t1_x3 = 1;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float t2_x0 = 1;
            float t2_x1 = 1;
            float t2_x2 = 1;
            float t2_x3 = 1;

            Polymonial polyToTest2 = new Polymonial(t2_x0, t2_x1, t2_x2, t2_x3);

            float ex_x0 = 0f;
            float ex_x1 = 0f;
            float ex_x2 = 0f;
            float ex_x3 = 0f;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 - polyToTest2));
        }

        [TestMethod]
        public void PolySubstraction2()
        {
            float t1_x0 = 100;
            float t1_x1 = 0;
            float t1_x2 = 0;
            float t1_x3 = -100;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float t2_x0 = 50;
            float t2_x1 = -40;
            float t2_x2 = 1;
            float t2_x3 = 321;

            Polymonial polyToTest2 = new Polymonial(t2_x0, t2_x1, t2_x2, t2_x3);

            float ex_x0 = 50;
            float ex_x1 = 40;
            float ex_x2 = -1;
            float ex_x3 = -421;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 - polyToTest2));
        }

        [TestMethod]
        public void PolySubstraction3()
        {
            float t1_x0 = 10;
            float t1_x1 = -1;
            float t1_x2 = 0;
            float t1_x3 = 131;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float t2_x0 = 134.5f;
            float t2_x1 = -1;
            float t2_x2 = 1;
            float t2_x3 = 0;

            Polymonial polyToTest2 = new Polymonial(t2_x0, t2_x1, t2_x2, t2_x3);

            float ex_x0 = -124.5f;
            float ex_x1 = 0;
            float ex_x2 = -1;
            float ex_x3 = 131;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 - polyToTest2));
        }

        [TestMethod]
        public void PolyMultiplicationWithDifferentDegrees()
        {
            float t1_x0 = 10;
            float t1_x1 = -1;
            float t1_x2 = 0;
            float t1_x3 = 4;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float t2_x0 = 2;
            float t2_x1 = -1;
            float t2_x2 = 1;
            float t2_x3 = 3;
            float t2_x4 = 1;

            Polymonial polyToTest2 = new Polymonial(t2_x0, t2_x1, t2_x2, t2_x3, t2_x4);

            float ex_x0 = 20;
            float ex_x1 = -12;
            float ex_x2 = 11;
            float ex_x3 = 37;
            float ex_x4 = 3;
            float ex_x5 = 3;
            float ex_x6 = 12;
            float ex_x7 = 4;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3,ex_x4, ex_x5, ex_x6, ex_x7);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * polyToTest2));
        }

        [TestMethod]
        public void PolyMultiplicationWithSameDegrees()
        {
            float t1_x0 = 3;
            float t1_x1 = 12;
            float t1_x2 = 134;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float t2_x0 = 2;
            float t2_x1 = 3;
            float t2_x2 = -5;

            Polymonial polyToTest2 = new Polymonial(t2_x0, t2_x1, t2_x2);

            float ex_x0 = 6;
            float ex_x1 = 33;
            float ex_x2 = 289;
            float ex_x3 = 342;
            float ex_x4 = -670;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3, ex_x4);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * polyToTest2));
        }

        [TestMethod]
        public void PolyAdditionWithFloat1()
        {
            float t1_x0 = 3;
            float t1_x1 = 33;
            float t1_x2 = 289;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float b = -3;

            float ex_x0 = 0;
            float ex_x1 = 33;
            float ex_x2 = 289;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 + b));
        }

        [TestMethod]
        public void PolyAdditionWithFloat2()
        {
            float t1_x0 = 5124;
            float t1_x1 = 33;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = -512;

            float ex_x0 = 4612;
            float ex_x1 = 33;
            float ex_x2 = 289;
            float ex_x3 = 41219;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 + b));
        }

        [TestMethod]
        public void PolyAdditionWithFloat3()
        {
            float t1_x0 = 0;
            float t1_x1 = 0;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 412.5f;

            float ex_x0 = 412.5f;
            float ex_x1 = 0;
            float ex_x2 = 289;
            float ex_x3 = 41219;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 + b));
        }

        [TestMethod]
        public void PolyAdditionWithFloatButFloatFirst1()
        {
            float t1_x0 = 3;
            float t1_x1 = 33;
            float t1_x2 = 289;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float b = -3;

            float ex_x0 = 0;
            float ex_x1 = 33;
            float ex_x2 = 289;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2);

            Assert.IsTrue(polyToExpected.Equals(b + polyToTest1));
        }

        [TestMethod]
        public void PolyAdditionWithFloatButFloatFirst2()
        {
            float t1_x0 = 5124;
            float t1_x1 = 33;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = -512;

            float ex_x0 = 4612;
            float ex_x1 = 33;
            float ex_x2 = 289;
            float ex_x3 = 41219;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(b + polyToTest1));
        }

        [TestMethod]
        public void PolyAdditionWithFloatButFloatFirst3()
        {
            float t1_x0 = 0;
            float t1_x1 = 0;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 412.5f;

            float ex_x0 = 412.5f;
            float ex_x1 = 0;
            float ex_x2 = 289;
            float ex_x3 = 41219;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(b + polyToTest1));
        }

        [TestMethod]
        public void PolySubstractionWithFloat1()
        {
            float t1_x0 = 3;
            float t1_x1 = 33;
            float t1_x2 = 289;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float b = -3;

            float ex_x0 = 6;
            float ex_x1 = 33;
            float ex_x2 = 289;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 - b));
        }

        [TestMethod]
        public void PolySubstractionWithFloat2()
        {
            float t1_x0 = 5124;
            float t1_x1 = 33;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = -512;

            float ex_x0 = 5636;
            float ex_x1 = 33;
            float ex_x2 = 289;
            float ex_x3 = 41219;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 - b));
        }

        [TestMethod]
        public void PolySubstractionWithFloat3()
        {
            float t1_x0 = 0;
            float t1_x1 = 0;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 412.5f;

            float ex_x0 = -412.5f;
            float ex_x1 = 0;
            float ex_x2 = 289;
            float ex_x3 = 41219;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 - b));
        }

        [TestMethod]
        public void PolySubstractionWithFloatButFloatFirst1()
        {
            float t1_x0 = 3;
            float t1_x1 = 33;
            float t1_x2 = 289;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float b = -3;

            float ex_x0 = 6;
            float ex_x1 = 33;
            float ex_x2 = 289;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2);

            Assert.IsTrue(polyToExpected.Equals(b - polyToTest1));
        }

        [TestMethod]
        public void PolySubstractionWithFloatButFloatFirst2()
        {
            float t1_x0 = 5124;
            float t1_x1 = 33;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = -512;

            float ex_x0 = 5636;
            float ex_x1 = 33;
            float ex_x2 = 289;
            float ex_x3 = 41219;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(b - polyToTest1));
        }

        [TestMethod]
        public void PolySubstractionWithFloatButFloatFirst3()
        {
            float t1_x0 = 0;
            float t1_x1 = 0;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 412.5f;

            float ex_x0 = -412.5f;
            float ex_x1 = 0;
            float ex_x2 = 289;
            float ex_x3 = 41219;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(b - polyToTest1));
        }

        [TestMethod]
        public void PolyMultiplicationWithFloat1()
        {
            float t1_x0 = 3;
            float t1_x1 = 33;
            float t1_x2 = 289;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float b = 2;

            float ex_x0 = 6;
            float ex_x1 = 66;
            float ex_x2 = 578;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * b));
        }

        [TestMethod]
        public void PolyMultiplicationWithFloat2()
        {
            float t1_x0 = 5124;
            float t1_x1 = 33;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 512;

            float ex_x0 = 2623488;
            float ex_x1 = 16896;
            float ex_x2 = 147968;
            float ex_x3 = 21104128;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * b));
        }

        [TestMethod]
        public void PolyMultiplicationWithFloat3()
        {
            float t1_x0 = 0;
            float t1_x1 = 0;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 412.5f;

            float ex_x0 = 0;
            float ex_x1 = 0;
            float ex_x2 = 119212.5f;
            float ex_x3 = 17002837.5f;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * b));
        }

        [TestMethod]
        public void PolyMultiplicationWithFloatButFloatFirst1()
        {
            float t1_x0 = 3;
            float t1_x1 = 33;
            float t1_x2 = 289;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float b = 2;

            float ex_x0 = 6;
            float ex_x1 = 66;
            float ex_x2 = 578;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2);

            Assert.IsTrue(polyToExpected.Equals(b * polyToTest1));
        }

        [TestMethod]
        public void PolyMultiplicationWithFloatButFloatFirst2()
        {
            float t1_x0 = 5124;
            float t1_x1 = 33;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 512;

            float ex_x0 = 2623488;
            float ex_x1 = 16896;
            float ex_x2 = 147968;
            float ex_x3 = 21104128;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(b * polyToTest1));
        }

        [TestMethod]
        public void PolyMultiplicationWithFloatButFloatFirst3()
        {
            float t1_x0 = 0;
            float t1_x1 = 0;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 412.5f;

            float ex_x0 = 0;
            float ex_x1 = 0;
            float ex_x2 = 119212.5f;
            float ex_x3 = 17002837.5f;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(b * polyToTest1));
        }

        [TestMethod]
        public void PolyDivisionWithFloat1()
        {
            float t1_x0 = 3;
            float t1_x1 = 33;
            float t1_x2 = 249;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float b = 3;

            float ex_x0 = 1;
            float ex_x1 = 11;
            float ex_x2 = 83;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 / b));
        }

        [TestMethod]
        public void PolyDivisionWithFloat2()
        {
            float t1_x0 = 5124;
            float t1_x1 = 33;
            float t1_x2 = 289;
            float t1_x3 = 41219;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2, t1_x3);

            float b = 512;

            float ex_x0 = 10.0078125f;
            float ex_x1 = 0.064453125f;
            float ex_x2 = 0.564453125f;
            float ex_x3 = 80.505859375f;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2, ex_x3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 / b));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void PolyDivisionWithFloat3()
        {
            float t1_x0 = 3;
            float t1_x1 = 33;
            float t1_x2 = 249;

            Polymonial polyToTest1 = new Polymonial(t1_x0, t1_x1, t1_x2);

            float b = 0;

            float ex_x0 = 1;
            float ex_x1 = 11;
            float ex_x2 = 83;

            Polymonial polyToExpected = new Polymonial(ex_x0, ex_x1, ex_x2);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 / b));
        }
    }
}
