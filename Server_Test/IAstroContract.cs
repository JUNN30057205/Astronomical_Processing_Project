using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server_Test
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        //string ReverseString(string value);
        double StarVelocity(double ObservedWavelength, double RestWavelength);

        [OperationContract]
        double StarDistance(double ArcsecondAngle);

        [OperationContract]
        double TemparatureCoveter(double Celsius);

        [OperationContract]
        double EventHorizon(double BlackholeMass);

    }
}
