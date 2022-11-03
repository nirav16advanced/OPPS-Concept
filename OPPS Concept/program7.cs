using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS_Concept
{
    public class Parent
    {
        public void DisplayParentsAB()
        {
            Console.WriteLine("harshadbhai and Bhavanaben are my parents");
        }
    }

    public class Son : Parent
    {
        public void DisplaySonC()
        {
            Console.WriteLine("I am the son Nirav");
        }
    }
}
