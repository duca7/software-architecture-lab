using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace PhoneServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpChannel(6969), false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PhoneBUS), "sellphone", WellKnownObjectMode.SingleCall);
            RemotingConfiguration.CustomErrorsMode = CustomErrorsModes.Off;
            Console.WriteLine("SERVER is started...");
            Console.Read();
        }
    }
}
