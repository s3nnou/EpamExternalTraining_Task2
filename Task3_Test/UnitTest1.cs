using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_3;

namespace Task3_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChemicalCreation()
        {
            string t_name = "Mr.Proper";
            float t_price = 2.5f;
            string t_type = "cleaner";
            Chemical chemicalToTest = new Chemical(t_name, t_type, t_price);

            string ex_name = "Mr.Proper";
            float ex_price = 2.5f;
            string ex_type = "cleaner";
            Chemical chemicalExpected = new Chemical(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, chemicalToTest);
        }

        [TestMethod]
        public void ChemicalMoneyInCoins()
        {
            string t_name = "Mr.Proper";
            float t_price = 2.5f;
            string t_type = "cleaner";
            Chemical chemicalToTest = new Chemical(t_name, t_type, t_price);

            int coins = 250;

            Assert.AreEqual(coins, (int)chemicalToTest);
        }

        [TestMethod]
        public void ChemicalMoney()
        {
            string t_name = "Mr.Proper";
            float t_price = 2.5f;
            string t_type = "cleaner";
            Chemical chemicalToTest = new Chemical(t_name, t_type, t_price);

            float coins = 2.5f;

            Assert.AreEqual(coins, (float)chemicalToTest);
        }

        [TestMethod]
        public void ChemicalAddition()
        {
            string t1_name = "Mr.Proper";
            float t1_price = 2.5f;
            string t1_type = "cleaner";
            Chemical chemicalToTest1 = new Chemical(t1_name, t1_type, t1_price);

            string t2_name = "Mr.Clean";
            float t2_price = 3.5f;
            string t2_type = "cleaner";
            Chemical chemicalToTest2 = new Chemical(t2_name, t2_type, t2_price);


            string ex_name = "Mr.Proper - Mr.Clean";
            float ex_price = 3f;
            string ex_type = "cleaner";
            Chemical chemicalExpected = new Chemical(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, chemicalToTest1 + chemicalToTest2);
        }

        [TestMethod]
        public void ChemicalCastToFood()
        {
            string t_name = "Mr.Proper";
            float t_price = 2.5f;
            string t_type = "cleaner";
            Chemical chemicalToTest = new Chemical(t_name, t_type, t_price);

            string ex_name = "Mr.Proper";
            float ex_price = 2.5f;
            string ex_type = "cleaner";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, (Food) chemicalToTest);
        }

        [TestMethod]
        public void ChemicalCastToFurniture()
        {
            string t_name = "Mr.Proper";
            float t_price = 2.5f;
            string t_type = "cleaner";
            Chemical chemicalToTest = new Chemical(t_name, t_type, t_price);

            string ex_name = "Mr.Proper";
            float ex_price = 2.5f;
            string ex_type = "cleaner";
            Furniture furnitureExpected = new Furniture(ex_name, ex_type, ex_price);

            Assert.AreEqual(furnitureExpected, (Furniture)chemicalToTest);
        }

        [TestMethod]
        public void ChemicalCastToTechnic()
        {
            string t_name = "Mr.Proper";
            float t_price = 2.5f;
            string t_type = "cleaner";
            Chemical chemicalToTest = new Chemical(t_name, t_type, t_price);

            string ex_name = "Mr.Proper";
            float ex_price = 2.5f;
            string ex_type = "cleaner";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, (Technic)chemicalToTest);
        }

        [TestMethod]
        public void FoodCreation()
        {
            string t_name = "Burger";
            float t_price = 2.5f;
            string t_type = "snack";
            Food foodToTest = new Food(t_name, t_type, t_price);

            string ex_name = "Burger";
            float ex_price = 2.5f;
            string ex_type = "snack";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, foodToTest);
        }

        [TestMethod]
        public void FoodMoneyInCoins()
        {
            string t_name = "Burger";
            float t_price = 2.5f;
            string t_type = "snack";
            Food foodToTest = new Food(t_name, t_type, t_price);

            int coins = 250;

            Assert.AreEqual(coins, (int)foodToTest);
        }

        [TestMethod]
        public void FoodMoney()
        {
            string t_name = "Burger";
            float t_price = 2.5f;
            string t_type = "snack";
            Food foodToTest = new Food(t_name, t_type, t_price);

            float coins = 2.5f;

            Assert.AreEqual(coins, (float)foodToTest);
        }

        [TestMethod]
        public void FoodAddition()
        {
            string t1_name = "Burger";
            float t1_price = 2.5f;
            string t1_type = "snack";
            Food foodToTest1 = new Food(t1_name, t1_type, t1_price);

            string t2_name = "Whopper";
            float t2_price = 3.5f;
            string t2_type = "snack";
            Food foodToTest2 = new Food(t2_name, t2_type, t2_price);


            string ex_name = "Burger - Whopper";
            float ex_price = 3f;
            string ex_type = "snack";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, foodToTest1 + foodToTest2);
        }

        [TestMethod]
        public void FoodCastToFood()
        {
            string t_name = "Burger";
            float t_price = 2.5f;
            string t_type = "snack";
            Food foodToTest = new Food(t_name, t_type, t_price);

            string ex_name = "Burger";
            float ex_price = 2.5f;
            string ex_type = "snack";
            Chemical chemicalExpected = new Chemical(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, (Chemical)foodToTest);
        }

        [TestMethod]
        public void FoodCastToFurniture()
        {
            string t_name = "Burger";
            float t_price = 2.5f;
            string t_type = "snack";
            Food foodToTest = new Food(t_name, t_type, t_price);

            string ex_name = "Burger";
            float ex_price = 2.5f;
            string ex_type = "snack";
            Furniture furnitureExpected = new Furniture(ex_name, ex_type, ex_price);

            Assert.AreEqual(furnitureExpected, (Furniture)foodToTest);
        }

        [TestMethod]
        public void FoodCastToTechnic()
        {
            string t_name = "Burger";
            float t_price = 2.5f;
            string t_type = "snack";
            Food foodToTest = new Food(t_name, t_type, t_price);

            string ex_name = "Burger";
            float ex_price = 2.5f;
            string ex_type = "snack";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, (Technic)foodToTest);
        }

        [TestMethod]
        public void FurnitureCreation()
        {
            string t_name = "Glass table";
            float t_price = 232f;
            string t_type = "table";
            Furniture furnitureToTest = new Furniture(t_name, t_type, t_price);

            string ex_name = "Glass table";
            float ex_price = 232f;
            string ex_type = "table";
            Furniture furnitureExpected = new Furniture(ex_name, ex_type, ex_price);

            Assert.AreEqual(furnitureExpected, furnitureToTest);
        }

        [TestMethod]
        public void FurnitureMoneyInCoins()
        {
            string t_name = "Glass table";
            float t_price = 232f;
            string t_type = "table";
            Furniture furnitureToTest = new Furniture(t_name, t_type, t_price);

            int coins = 23200;

            Assert.AreEqual(coins, (int)furnitureToTest);
        }

        [TestMethod]
        public void FurnitureMoney()
        {
            string t_name = "Glass table";
            float t_price = 232f;
            string t_type = "table";
            Furniture furnitureToTest = new Furniture(t_name, t_type, t_price);

            float coins = 232f;

            Assert.AreEqual(coins, (float)furnitureToTest);
        }

        [TestMethod]
        public void FurnitureAddition()
        {
            string t1_name = "Glass table";
            float t1_price = 235f;
            string t1_type = "table";
            Furniture furnitureToTest1 = new Furniture(t1_name, t1_type, t1_price);

            string t2_name = "Wood table";
            float t2_price = 305f;
            string t2_type = "table";
            Furniture furnitureToTest2 = new Furniture(t2_name, t2_type, t2_price);


            string ex_name = "Glass table - Wood table";
            float ex_price = 270f;
            string ex_type = "table";
            Furniture furnitureExpected = new Furniture(ex_name, ex_type, ex_price);

            Assert.AreEqual(furnitureExpected, furnitureToTest1 + furnitureToTest2);
        }

        [TestMethod]
        public void FurnitureCastToFurniture()
        {
            string t_name = "Glass table";
            float t_price = 232f;
            string t_type = "table";
            Furniture furnitureToTest = new Furniture(t_name, t_type, t_price);

            string ex_name = "Glass table";
            float ex_price = 232f;
            string ex_type = "table";
            Chemical chemicalExpected = new Chemical(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, (Chemical)furnitureToTest);
        }

        [TestMethod]
        public void FurnitureCastToFood()
        {
            string t_name = "Glass table";
            float t_price = 232f;
            string t_type = "table";
            Furniture furnitureToTest = new Furniture(t_name, t_type, t_price);

            string ex_name = "Glass table";
            float ex_price = 232f;
            string ex_type = "table";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, (Food)furnitureToTest);
        }

        [TestMethod]
        public void FurnitureCastToTechnic()
        {
            string t_name = "Glass table";
            float t_price = 232f;
            string t_type = "table";
            Furniture furnitureToTest = new Furniture(t_name, t_type, t_price);

            string ex_name = "Glass table";
            float ex_price = 232f;
            string ex_type = "table";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, (Technic)furnitureToTest);
        }

        [TestMethod]
        public void TechnicCreation()
        {
            string t_name = "Iphone X";
            float t_price = 1232f;
            string t_type = "phone";
            Technic technicToTest = new Technic(t_name, t_type, t_price);

            string ex_name = "Iphone X";
            float ex_price = 1232f;
            string ex_type = "phone";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, technicToTest);
        }

        [TestMethod]
        public void TechnicMoneyInCoins()
        {
            string t_name = "Iphone X";
            float t_price = 1232f;
            string t_type = "phone";
            Technic technicToTest = new Technic(t_name, t_type, t_price);

            int coins =123200;

            Assert.AreEqual(coins, (int)technicToTest);
        }

        [TestMethod]
        public void TechnicMoney()
        {
            string t_name = "Iphone X";
            float t_price = 1232f;
            string t_type = "phone";
            Technic technicToTest = new Technic(t_name, t_type, t_price);

            float coins = 1232f;

            Assert.AreEqual(coins, (float)technicToTest);
        }

        [TestMethod]
        public void TechnicAddition()
        {
            string t1_name = "Ihone X";
            float t1_price = 1235f;
            string t1_type = "phone";
            Technic technicToTest1 = new Technic(t1_name, t1_type, t1_price);

            string t2_name = "Xiaomi Redmi 3s";
            float t2_price = 305f;
            string t2_type = "phone";
            Technic technicToTest2 = new Technic(t2_name, t2_type, t2_price);


            string ex_name = "Ihone X - Xiaomi Redmi 3s";
            float ex_price = 752.5f;
            string ex_type = "phone";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, technicToTest1 + technicToTest2);
        }

        [TestMethod]
        public void TechnicCastToTechnic()
        {
            string t_name = "Iphone X";
            float t_price = 1232f;
            string t_type = "phone";
            Technic technicToTest = new Technic(t_name, t_type, t_price);

            string ex_name = "Iphone X";
            float ex_price = 1232f;
            string ex_type = "phone";
            Chemical chemicalExpected = new Chemical(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, (Chemical)technicToTest);
        }

        [TestMethod]
        public void TechnicCastToFood()
        {
            string t_name = "Iphone X";
            float t_price = 1232f;
            string t_type = "phone";
            Technic technicToTest = new Technic(t_name, t_type, t_price);

            string ex_name = "Iphone X";
            float ex_price = 1232f;
            string ex_type = "phone";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, (Food)technicToTest);
        }

        [TestMethod]
        public void TechnicCastToFurniture()
        {
            string t_name = "Iphone X";
            float t_price = 1232f;
            string t_type = "phone";
            Technic technicToTest = new Technic(t_name, t_type, t_price);

            string ex_name = "Iphone X";
            float ex_price = 1232f;
            string ex_type = "phone";
            Furniture technicExpected = new Furniture(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, (Furniture)technicToTest);
        }
    }
}
