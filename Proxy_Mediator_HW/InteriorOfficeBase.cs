using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HW
{
    internal abstract class InteriorOfficeBase
    {
        public static List<User> users = new List<User>();

        public bool CheckIfUserExist(User user)
        {
            return users.Contains(user);
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
       
        public void ChnageUserPassword(User user)
        {
            Console.WriteLine("Choose a new passoword");
            string newPassword = Console.ReadLine();
            Console.WriteLine("Re-Enter password");
            string newPassword2 = Console.ReadLine();

            while (newPassword != newPassword2)
            {
                Console.WriteLine("Password don't mwatch");
                newPassword2 = Console.ReadLine();
            }

            user.Password = newPassword;

        }


        public void UpdatePassport()
        {
            Console.WriteLine("You'r passport has been updated");
        }

        public void ChangeUserAddress(User user)
        {
            Console.WriteLine("Choose a new address");
            string newAddress = Console.ReadLine();
            Console.WriteLine("Re-Enter address");
            string newAddress2 = Console.ReadLine();

            while (newAddress != newAddress2)
            {
                Console.WriteLine("Addresses don't mwatch");
                newAddress2 = Console.ReadLine();
            }

            user.Adress = newAddress;
        }
        
        public void ShowUserInfo(User user)
        {
            Console.WriteLine(user);
        }
    }
}
