using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HW
{
    internal interface IFacebookGroup
    {
        void Send(string message, IMember member);
        void AddToGroup(IMember member);
        void RemoveFromGroup(IMember member);
    }
}
