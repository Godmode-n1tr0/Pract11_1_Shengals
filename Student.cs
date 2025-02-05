using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt11_1_Shengals
{
    class Student
    {
        public string name;
        public int size;
        public double weight;
        public void SetEat(int feat)
        {
            if (feat < 1) return;

            int caloriesAfterEating = feat * 1000;
            if (feat == 5 && feat < 10)
            {
                size -= 1;
                weight += (int)(0.7 * (caloriesAfterEating - 1600) / 1000);
            }
            else if (feat >= 10)
            {
                size -= 2;
                weight += (int)(0.5 * (caloriesAfterEating - 1800) / 1000);
            }
        }
        public double GetEat()
        {
            return weight;
        }
        public double GetSize()
        {
            return size;
        }
    }
}
