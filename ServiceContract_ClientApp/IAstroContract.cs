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
        string ReverseString(string value);
    }
}
