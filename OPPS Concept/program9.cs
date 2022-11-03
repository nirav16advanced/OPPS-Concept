using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS_Concept
{
    public class Parentss
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("A and B are my parents");
        }
    }

    public class ChildC : Parent
    {
        public void DisplayChildC()
        {
            Console.WriteLine("I am the child C");
        }
    }

    public class ChildD : Parent
    {
        public void DisplayChildD()
        {
            Console.WriteLine("I am the child D");
        }
    }
}
