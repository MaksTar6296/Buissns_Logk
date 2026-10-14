using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inventory
    {
        private List<Item> items = new List<Item>();
        private const int capacity = 10;

        public bool AddItem(Item item)
        {
            if (item == null || items.Count >= capacity)
                return false;

            items.Add(item);
            return true;
        }

        public bool RemoveItem(int id)
        {
            Item item = items.FirstOrDefault(i => i.GetId() == id);

            if (item == null)
                return false;

            items.Remove(item);
            return true;
        }

        public List<Item> GetItems()
        {
            return new List<Item>(items);
        }

        public bool UseItem(int id, Player player)
        {
            Item item = items.FirstOrDefault(i => i.GetId() == id);

            if (item == null || player == null)
                return false;

            bool success = item.Use(player);

            if (success && item.IsConsumable)
                items.Remove(item);

            return success;
        }
    }

}
