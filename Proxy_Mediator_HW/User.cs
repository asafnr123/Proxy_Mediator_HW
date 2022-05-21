using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HW
{
    internal class User
    {
        public int ID { private get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Adress { private get; set; }
        public string Password { private get; set; }

        public User(int iD, string name, int birthYear, string adress, string password)
        {
            ID = iD;
            Name = name;
            BirthYear = birthYear;
            Adress = adress;
            Password = password;
        }


        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Name: {Name}\n" +
                $"Birth Year: {BirthYear}\n" +
                $"Address: {Adress} \n" +
                $"Password: {Password}\n";
        }
    }
}
