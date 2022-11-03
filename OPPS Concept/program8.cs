using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS_Concept
{
    public class Grandparent
    {
        public Grandparent()
        {
            Console.WriteLine("Constructor called at run-time");
        }
        public void DisplayGrandParentsAB()
        {
            Console.WriteLine("A and B are my grandparents");
        }
    }

    public class Parents : Grandparent
    {
        public void DisplayParentsCD()
        {
            Console.WriteLine("C and D are my parents");
        }
    }

    public class Child : Parents
    {
        public void DisplayChildZ()
        {
            Console.WriteLine("I am the child Z");
        }
    }
}
