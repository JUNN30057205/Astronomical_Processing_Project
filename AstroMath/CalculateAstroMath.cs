using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//ID: 30057205
//NAME: JUN SUMIDA
namespace AstroMath
{
    /// <summary>
    /// A DLL file with the following four mathematical formulas and save the file as AstroMath.DLL. 
    /// </summary>
    public class CalculateAstroMath
    {
        //Star Velocity
        /// <summary>
        /// Star Velocity: 
        /// To calculate the Star velocity using the Doppler shift, it has two input parameters of type double (Observed Wavelength and Rest Wavelength).
        /// Fomula: v = c* (Δλ / λo)
        /// </summary>
        /// <param name="ObservedWavelength">Input double represening the observed wavelength of the body in nano metres</param>
        /// <param name="RestWavelength">Input double value representing the rest wavelength of the body in nano metres</param>
        /// <returns>Return a double which represents the velocity</returns>
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
        /// <summary>
        /// Star Distance:
        /// To calculate the star distance using the parallax angle, it has a single input parameter of type double (Arcseconds angle).
        /// Fomula: Dstar = 1 / P
        /// Dstar = 1 / P Where Dstar is the Star Distance(parsecs) P is the parallax angle(arc-seconds)
        /// To calculate the star distance, divide 1 by the parallax angle.
        /// </summary>
        /// <param name="ArcsecondAngle">Input double value representing the observed angle of the star in arcseconds</param>
        /// <returns>Return a double which represents distance of the star</returns>
        public double StarDistance(double ArcsecondAngle)
        {
            //Parallax Angle(P) in arcseconds (1 arcs = 1/3600)
            //Distance (D) in parsecs (1 parsec = 3.0857 * 10 ^ 16m)
            //D = 1 / P
            
            double distanceParsecs = 1.0 / ArcsecondAngle;
            return Math.Round(distanceParsecs, 2);
        }

        //Temparature in Kelvin
        /// <summary>
        /// To convert Celsius to Kelvin, simply take the Celsius temperature and add 273. 
        /// The method has a single input parameter of type double (temperature in Celsius).
        /// Fomula: K = C + 273
        /// </summary>
        /// <param name="Celsius">Input double value representing the temperature of celsius</param>
        /// <returns>Returns a double which is the temperature in the target unit</returns>
        /// <exception cref="ArgumentOutOfRangeException">Error handling for "Out of Range"</exception>
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
        /// <summary>
        /// To calculate The Schwarzschild radius you obtain the gravitational acceleration on the surface of a black hole, also called the event horizon.
        /// The method has a single input parameter of type double (Blackhole Mass)
        /// Fomula:  R = 2*G* M/C^2.
        /// </summary>
        /// <param name="BlackholeMass">Input double value representing the mass of the black hole in kilograms</param>
        /// <returns>Return a double which is the event horizon in metres</returns>
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
    

