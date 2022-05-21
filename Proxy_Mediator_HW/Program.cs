using System;


namespace Proxy_Mediator_HW
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Proxy Pattern 
            //InteriorOfficeBase office = new InteriorOffice();
            //User u1 = new User(111, "Dana", 1997, "Yoseftal 10", "111");
            //User u2 = new User(112, "Asaf", 1998, "ben avi 60", "123");
            //User u3 = new User(113, "Orel", 1998, "ha shiva 7", "555");

            //office.AddUser(u1);
            //office.AddUser(u2);
            //office.AddUser(u3);

            //IServiceMachine machine = new ServiceMachine(u1);
            //machine.ChooseFromMenu();

            //InteriorOfficeBase.users.ForEach(u => Console.WriteLine(u));

            #endregion

            #region Mediator
            IFacebookGroup groupChat = new FacebookGroup();
            IMember m1 = new Member(groupChat, "Asaf");
            IMember m2 = new Member(groupChat, "Dana");
            IMember m3 = new Member(groupChat, "Orel");
            
            groupChat.AddToGroup(m1);
            groupChat.AddToGroup(m2);
            groupChat.AddToGroup(m3);

            m1.SendMessage("Hello All");
            m2.SendMessage("Hi");









            #endregion



        }




    }
}
