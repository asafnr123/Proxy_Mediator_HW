using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HW
{
    internal class Member : IMember
    {
        IFacebookGroup chat;
        public string name;

        public Member(IFacebookGroup chat, string name)
        {
            this.chat = chat;
            this.name = name;
        }

        public void RecieveMessage(string message)
        {
            Console.WriteLine($"{name} Got: {message}");
        }

        public void SendMessage(string message)
        {
            chat.Send($"{DateTime.Now.Hour}:{DateTime.Now.Minute} {name}: " + message, this);
        }

        
    }
}
