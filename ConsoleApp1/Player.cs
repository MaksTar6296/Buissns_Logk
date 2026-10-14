using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        private string name;
        private Stat health;
        private Stat mana;
        private Stat energy;
        private Inventory inventory;

        public Player(string name, int maxHealth, int maxMana, int maxEnergy)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Ім'я не може бути порожнім");

            this.name = name;

            health = new Stat(maxHealth);
            mana = new Stat(maxMana);
            energy = new Stat(maxEnergy);
            inventory = new Inventory();
        }
        public string GetName()
        {
            return name;
        }
        public Stat GetHealth()
        {
            return health;
        }
        public Stat GetMana()
        {
            return mana;
        }
        public Stat GetEnergy()
        {
            return energy;
        }
        public Inventory GetInventory()
        {
            return inventory;
        }
    }

}
