using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS_Concept
{
    //Abstract Class
    abstract class Vehicle
    {
        //Abstract class without body
        public abstract void Price();

        //Regular Method
        public void Brand()
        {
            Console.WriteLine("Brand: Honda");
        }
    }

    //Derived Class (inherited from Vehicle)
    class mobilio : Vehicle
    {
        public string modelName = "Mobilio";
        public override void Price()
        {
            Console.WriteLine("Price: 15 Lakhs");
        }
    }
    class amaze : Vehicle
    {
        public string modelName = "Amaze";
        public override void Price()
        {
            Console.WriteLine("Price: 7 Lakhs");
        }
    }
}
