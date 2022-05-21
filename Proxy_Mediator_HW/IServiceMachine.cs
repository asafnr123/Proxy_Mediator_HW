using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HW
{
    internal interface IServiceMachine 
    {
        void ChooseFromMenu();
        void UpdatePassport();
        void ChnageUserPassword(User user);
        void ShowUserInfo(User user);
        void ChangeUserAddress(User user);


    }
}
