using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class User
    {
        string login = "";
        string password = "";
        string name = "";
        string sername = "";
        int age = 0;
        private readonly DateTime Time;

        public User(string login, string password, string name, string sername, int age = 45)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.sername = sername;
            this.age = age;
            Time = DateTime.Now;
        }

        public void Output()
        {
            string output = string.Format(@"
                             Your Login: {0}
                             Your password: {1}
                             Your Name: {2}
                             Your SerName: {3}
                             Your Age: {4}
                             Date: {5}", login, password, name, sername, age, Time);
            Console.WriteLine(output);
        }
    }
}
