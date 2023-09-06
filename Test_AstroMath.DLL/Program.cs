using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;

namespace Test_AstroMath.DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instance of class
            CalculateAstroMath calculateAstroMath = new CalculateAstroMath();
            Console.WriteLine("DLL test program");

            //Star Velocity
            Console.WriteLine("1. Calculate Star Velocity.");
            double v = calculateAstroMath.StarVelocity(500.1, 500.0);
            Console.WriteLine( v + " m/s");      
            Console.WriteLine();

            //Star Distance
            Console.WriteLine("2. Calculate Star Distance.");
            double distanceParsec = calculateAstroMath.StarDistance(0.547);
            Console.WriteLine(distanceParsec + " parsec");
            Console.WriteLine();

            //Temparature in Kelvin
            Console.WriteLine("3. Calculate Temparature in kelvin");
            double kelvin = calculateAstroMath.TemparatureCoveter(27.0);
            Console.WriteLine(kelvin + " degrees");
            Console.WriteLine();

            //Event Horizon
            Console.WriteLine("4. Calculate Event Horizon.");
            double r = calculateAstroMath.EventHorizon(8.2e36);
            Console.WriteLine(r + " metres");
            Console.WriteLine();

        }
    }
}
