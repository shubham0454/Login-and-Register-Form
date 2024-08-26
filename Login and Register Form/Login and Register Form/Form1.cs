using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Login_and_Register_Form
{
    public partial class Login : Form
    {
        string reg = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$";
        public static string RegUserName = "";
        public static string RegPassword ="";
  
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LoginUserName = textBox1.Text;
            string LoginPassword = textBox2.Text;
            
            if (RegUserName.Equals(LoginUserName))
            {
                if (RegPassword.Equals(LoginPassword))
                {
                    Form3 form = new Form3();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("password is incorrect ");
                }
            }
            else {
                MessageBox.Show("No registered users. Please register first");
            }


            // check the text box not be empty
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "please enter user name");
            }
            else if (Regex.IsMatch(textBox2.Text, reg) == false)
            {
                textBox1.Focus();
                errorProvider2.SetError(this.textBox2, "Invalid password");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "please enter user name");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
            if (Regex.IsMatch(textBox2.Text, reg) == false) {
                textBox1.Focus();
                errorProvider2.SetError(this.textBox2, "Invalid password");
            }
            else
            {
                errorProvider2.Clear();
            }

        }
    }
}
