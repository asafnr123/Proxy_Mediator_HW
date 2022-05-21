using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HW
{
    internal class ServiceMachine : InteriorOffice, IServiceMachine
    {
        private User user;

        public ServiceMachine(User user)
        {
            this.user = user;
        }

        public void ChooseFromMenu()
        {
            string userChoice;
            Console.WriteLine("1) Update Passport\n" +
                "2) Change Password\n" +
                "3) Change Address\n" +
                "4) Show Info\n" +
                "5) Exit");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1": UpdatePassport(); break;
                case "2": ChnageUserPassword(user); break;
                case "3": ChangeUserAddress(user); break;
                case "4": ShowUserInfo(user); break;
                case "5": break;
                default: ChooseFromMenu(); break;

            }
            
        }
    }
}
