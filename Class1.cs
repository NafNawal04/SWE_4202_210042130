using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_210042130
{
    public static class Class1

    {
        internal static List<Class2> users = new List<Class2>();

        public static void load_users()
        {
            string path = "TextFile1.txt";
            StreamReader srr = new StreamReader(path);

            var strr = srr.ReadLine();

            while (strr != null)
            {

                string[] k = null;
                k = strr.Split(',');
                string user_name = k[0];
                string pass = k[1];
                string name = k[2];

                Class2 u = new Class2(user_name, pass, name);
                users.Add(u);
                strr = srr.ReadLine();
                srr.Close();
            }
            srr.Close();
        }
    }
}
