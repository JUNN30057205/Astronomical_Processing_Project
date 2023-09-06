using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/";
            NetNamedPipeBinding binding =
            new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            Console.WriteLine("1. Calculate Star Velocity.");
            double v = channel.StarVelocity(500.1, 500.0);
            Console.WriteLine(v + " m/s");
            Console.WriteLine();
        }
    }
}
