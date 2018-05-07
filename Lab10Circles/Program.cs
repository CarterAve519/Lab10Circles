
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Circle
{
    class Program
    {
        static int CirCount = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Circle Tester");

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Enter radius:");

                //() means Method
                string answer = Console.ReadLine();

                double radius;

                while (!double.TryParse(answer, out radius))
                {
                    Console.WriteLine("This is not a valid input. Please try again.");
                    answer = Console.ReadLine();
                }

                //Constructor is a method to instantiate an object (no return type, no void)
                Circle FullCircle = new Circle(radius);

                //raduis needs no () bc it's a property
                //double xx = FullCircle.Radius;



                //Console.WriteLine($"This is the Circumference: {FullCircle.CalculateCircumference()}");

                //Console.WriteLine($"This is the Area: {FullCircle.CalculateArea()}");

                Console.WriteLine($"This is the Formatted Circumference: {FullCircle.CalculateFormattedCircumference()}");

                Console.WriteLine($"This is the Formatter Area: {FullCircle.CalculateFormattedArea()}");

                //This is counting the number of circles made
                CirCount++;

                Console.WriteLine("Would you like to continue (y/n)");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    continue;
                }

                while (true)
                {
                    Console.WriteLine($"Goodbye. You created {CirCount} circle object(s)");

                   
                    if (input == "n")
                    {

                        //this is making it false to stop the loop
                        repeat = false;
                        break;
                    }
                    
                }



            }


        }
    }
}