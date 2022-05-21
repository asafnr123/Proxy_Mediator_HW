using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HW
{
    internal interface IMember
    {
        void SendMessage(string message);
        void RecieveMessage(string message);
    }
}
