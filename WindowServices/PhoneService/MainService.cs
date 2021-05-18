using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace PhoneService
{
    public partial class MainService : ServiceBase
    {
        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ChannelServices.RegisterChannel(new TcpChannel(6969), false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PhoneBUS), "sellphone", WellKnownObjectMode.SingleCall);
            RemotingConfiguration.CustomErrorsMode = CustomErrorsModes.Off;
        }

        protected override void OnStop()
        {
        }
    }
}
