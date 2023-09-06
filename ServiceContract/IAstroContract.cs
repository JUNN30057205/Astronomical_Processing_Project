using AstroMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        //string ReverseString(string value);
        double StarVelocity(double ObservedWavelength, double RestWavelength);



    }
}
