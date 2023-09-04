using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(AstroServer),
                new Uri[]{
                    new Uri("net.pipe://localhost")
                }))
            {
                host.AddServiceEndpoint(typeof(IAstroContract),
                    new NetNamedPipeBinding(), "PipeReverse");
                host.Open();
                Console.WriteLine("Service is available. " + "Press <ENTER> to exit.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
