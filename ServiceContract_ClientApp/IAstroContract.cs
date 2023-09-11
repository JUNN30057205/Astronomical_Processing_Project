using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceContract_ClientApp
{
    [ServiceContract]
    internal interface IAstroContract
    {        

        [OperationContract]        
        double StarVelocity(double ObservedWavelength, double RestWavelength);

        [OperationContract]
        double StarDistance(double ArcsecondAngle);

        [OperationContract]
        double TemparatureCoveter(double Celsius);

        [OperationContract]
        double EventHorizon(double BlackholeMass);
    }
}
