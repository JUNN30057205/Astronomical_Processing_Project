using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class CalculateAstroMath
    {
        //Star Velocity
        public double StarVelocity(double ObservedWavelength, double RestWavelength)
        {
            //change in Wavelength = ObservedWavelength - RestWavelength
            //Speep of Light (C) = 299792458 meter per sec m/s
            //V = velocity in metres per second
            double c = 299792458;
            double v = c * ((ObservedWavelength - RestWavelength) / RestWavelength);

            return Math.Round(v, 3);
        }

        //Star Distance
        public double StarDistance(double ArcsecondAngle)
        {
            //Parallax Angle(P) in arcseconds (1 arcs = 1/3600)
            //Distance (D) in parsecs (1 parsec = 3.0857 * 10 ^ 16m)
            //D = 1 / P
            
            double distanceParsecs = 1.0 / ArcsecondAngle;
            return Math.Round(distanceParsecs, 2);
        }
        
        //Temparature in Kelvin
        public double TemparatureCoveter(double Celsius)
        {
            //Celsius must be greater than 273, Kelvin greater than 0 (TemC > -273, TemK > 0)
            if (Celsius < -273)
            {
                throw new ArgumentOutOfRangeException("Out of Range");
            }
            double Kelvin = Celsius + 273;

            return Math.Round(Kelvin, 2);
        }

        //Event Horizon
        public double EventHorizon(double BlackholeMass)
        {
            //Gravity Constant(G) = 6.674 * 10 ^-11 m3kg-1s-2
            //Speep of Light (C) = 299792458 meter per sec m/s
            //Mass of the Blackhole(M) = measured in kilograms (the sun is 2 * 10^30 Kg)
            //R = 2GM / C^2 (Math.Pow (base, exponent))
            double G = 6.674e-11; 
            double C = 299792458;
            double R = 2.0 * G * BlackholeMass / Math.Pow(C, 2);

            return Math.Round(R, 2);
        }
    }
    //太陽を調べる光の目
    //https://jspc.sakura.ne.jp/sun_tour/sun_tour2017/list/20180322_ichimoto.pdf
    //https://www.fenet.jp/dotnet/column/language/3839/

}
    

