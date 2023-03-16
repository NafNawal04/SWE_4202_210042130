using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_210042130
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 lf = new Form1();
            lf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string user_name = textBox2.Text;
            string password = textBox3.Text;
            int count = password.Length;
            string retype_pass = textBox4.Text;

            if (Class1.users.Count > 0)
            {
                foreach (Class2 u in Class1.users)
                {
                    if (u.username == user_name)
                    {

                        if (count >= 6)
                        {
                            if (password == retype_pass)
                            {
                                string path = "TextFile1.txt";
                                StreamWriter sw = File.AppendText(path);
                                Class2 aww = new Class2(user_name, name, password);
                                Class1.users.Add(aww);
                                string ss = $"{user_name},{password},{name}";
                                sw.WriteLine(ss);
                                sw.Close();

                                Form1 lf = new Form1();
                                lf.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Password must be 6 or more characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username already exists. Try another one");
                    }
                }
            }

            else
            {

                string path = "TextFile1.txt";
                StreamWriter sw = File.AppendText(path);
                Class2 aww = new Class2(user_name, name, password);
                Class1.users.Add(aww);
                string ss = $"{user_name},{password},{name}";
                sw.WriteLine(ss);
                sw.Close();

                Form1 lf = new Form1();
                lf.Show();
                this.Hide();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
