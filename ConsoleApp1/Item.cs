using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Item
    {
        private int id;
        private string name;
        private int price;

        private static int nextId = 1;

        public Item(string name, int price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Назва не може бути порожньою");

            if (price < 0)
                throw new ArgumentException("Ціна не може бути від'ємною");

            id = nextId++;
            this.name = name;
            this.price = price;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPrice()
        {
            return price;
        }
    }

}
