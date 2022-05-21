using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HW
{
    internal class FacebookGroup : IFacebookGroup
    {
        private List<IMember> members = new List<IMember>();


        public void AddToGroup(IMember member)
        {
            members.Add(member);
        }

        public void RemoveFromGroup(IMember member)
        {
            members.Remove(member);
        }

        public void Send(string message, IMember member)
        {
            foreach (IMember m in members)
            {
                if (m != member)
                {
                    m.RecieveMessage(message);
                }
            }

        }
    }
}
