using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;
using System.ServiceModel;

namespace ServiceContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        CalculateAstroMath calculateAstroMath = new CalculateAstroMath();

        public double StarVelocity(double ObservedWavelength, double RestWavelength)
        {
            return calculateAstroMath.StarVelocity(ObservedWavelength, RestWavelength);
        }
    }
}
