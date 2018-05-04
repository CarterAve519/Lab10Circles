using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Circle
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            //get is saying give me the ^radius
            //set is saying take the valus and making it the raduis (left to right)
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            //
            this.Radius = radius;
        }

        public double CalculateCircumference()
        {
            //
            double Circum = (2 * Math.PI * Radius);
            return Circum;
        }
        public string CalculateFormattedCircumference()
        {
            //
            double Circum = (2 * Math.PI * Radius);
            //formating strings N2 saying give me 2 decimal places
            return ($"{Circum,0:N2}");

        }
        public double CalculateArea()
        {
            //
            double CalcArea = (Math.PI * Radius * Radius);
            return CalcArea;
        }
        public string CalculateFormattedArea()
        {
            //
            double CalcArea = (Math.PI * Radius * Radius);
            return ($"{CalcArea,0:N2}");
        }
            //private string FormatNumber(double x);
    }
}
