using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stat
    {
        private int currentValue;
        private int maxValue;

        public Stat(int maxValue)
        {
            if (maxValue < 0)
                throw new ArgumentException("Значення не може бути від'ємним");

            this.maxValue = maxValue;
            currentValue = maxValue;
        }

        public void ChangeCurrentValue(int value)
        {
            currentValue += value;

            if (currentValue < 0)
            {
                currentValue = 0;
            }

            if (currentValue > maxValue)
            {
                currentValue = maxValue;
            }
        }
    }
}
