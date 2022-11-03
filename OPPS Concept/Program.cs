
using OPPS_Concept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OPPS_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1 from Assignment
            Rectangle r = new Rectangle(10, 5);
            int areaOfRectangle = r.Area();
            Square sq = new Square(10, 10);
            int areaOfSquare = sq.Area();
            Console.WriteLine("Area of Rectangle is " + areaOfRectangle + ".");
            Console.WriteLine("Area of Square is " + areaOfSquare + ".");

            Console.WriteLine("------------------------------------------------------------------");

            // Question 2 from Assignment
            PrintDetails p = new PrintDetails();
            p.printData("Nirav", "Harshadbhai", "Narsinhpura");
            p.printData("9375166308", "nirav0567@gmail.com");

            Console.WriteLine("------------------------------------------------------------------");

            // Question 3 from Assignment
            mobilio mob = new mobilio();
            amaze ama = new amaze();
            mob.Brand();
            Console.WriteLine("Model:" + mob.modelName);
            mob.Price();
            Console.WriteLine();
            ama.Brand();
            Console.WriteLine("Model:" + ama.modelName);
            ama.Price();

            Console.WriteLine("------------------------------------------------------------------");

            // Question 4 from Assignment
            Apple myApple = new Apple(); //Create an Apple object
            myApple.FruitName();
            myApple.FruitColor();

            Mango myMango = new Mango(); //Create an Apple object
            myMango.FruitName();
            myMango.FruitColor();

            Papaya myPapaya = new Papaya(); //Create an Apple object
            myPapaya.FruitName();
            myPapaya.FruitColor();

            Console.WriteLine("------------------------------------------------------------------");

            // Question 5 from Assignment
            Calculation c = new Calculation();
            c.add(8, 2);
            c.sub(20, 10);
            Console.WriteLine("Multiple Inheritance concept Using two Interfaces :\n ");
            Console.WriteLine("Addition: " + c.sum);
            Console.WriteLine("Subtraction: " + c.difference);
            Console.ReadKey();

            Console.WriteLine("------------------------------------------------------------------");

            // Question 6 from Assignment
            Teachers teachers = new Teachers();
            //Public data member can be access directly
            teachers.firstName = "Nirav";
            teachers.lastName = "Patel";

            //To use private data member we have to implement get and set methods
            teachers.Email = "nirav0567@gmail.com";

            //This gives error because methods are private or protected
            //teachers.PrintDetails();
            //teachers.ShowDetails();

            teachers.DisplayDetails();

            Console.WriteLine("--------------------------------------------------------------------------");

            // Question 7 From Assignment 
            Son s = new Son();
            s.DisplaySonC();
            s.DisplayParentsAB();

            Console.WriteLine("--------------------------------------------------------------------------");

            // Question 8 From Assignment
            Child cd = new Child();
            cd.DisplayChildZ();
            cd.DisplayParentsCD();
            cd.DisplayGrandParentsAB();

            Console.WriteLine("--------------------------------------------------------------------------");

            // Question 9 From Assignment
            ChildC cc = new ChildC();
            ChildD cdd = new ChildD();

            cc.DisplayChildC();
            cc.DisplayParentsAB();  // accessing parent class

            cdd.DisplayChildD();
            cdd.DisplayParentsAB();   // accessing parent class

            Console.WriteLine("--------------------------------------------------------------------------");

            // Question 10 Part1 From Assignment
            addition1 obj = new addition1(); //an object is created , constructor is called
            Console.WriteLine(obj.digit1);
            Console.WriteLine(obj.digit2);
            Console.Read();

            Console.WriteLine("--------------------------------------------------------------------------");

            // Question 10 Part2 From Assignment
            paraconstrctor v = new paraconstrctor(100, 175);   // Creating object of Parameterized Constructor and int values
            Console.WriteLine("value of a=" + v.a);
            Console.WriteLine("value of b=" + v.b);
            Console.Read();


        }
    }
}
