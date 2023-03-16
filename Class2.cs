using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_210042130
{
    internal class Class2
    {
        public string username { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public Class2(string username, string name, string password)
        {
            this.username = username;
            this.name = name;
            this.password = password;
        }
    }
}