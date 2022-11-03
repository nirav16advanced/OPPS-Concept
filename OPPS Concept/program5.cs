using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS_Concept
{
    interface addition
    {
        int add(int a, int b);
    }
    interface subtraction
    {
        int sub(int x, int y);
    }

    class Calculation : addition, subtraction
    {
        public int sum;
        public int add(int a, int b)
        {
            return sum = a + b;
        }
        public int difference;
        public int sub(int x, int y)
        {
            return difference = x - y;
        }
    }
}
