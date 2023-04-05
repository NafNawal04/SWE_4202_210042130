using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_210042130
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string user_name = textBox1.Text;
                string password = textBox2.Text;

                foreach (Class2 u in Class1.users)
                {
                    if (u.username != user_name && u.password != password)
                    {
                        MessageBox.Show("Wrong username or Password");
                    }
                    else
                    {
                        Form3 df = new Form3();
                        df.Show();
                        this.Hide();
                    }
                }
            
        }
    }
}
