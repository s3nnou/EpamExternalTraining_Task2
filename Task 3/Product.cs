using System;

namespace Task_3
{
    public class Product
    {
        private string name;
        private float price;
        private string type;

        public Product(string name, string type, float price)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
    }
}
