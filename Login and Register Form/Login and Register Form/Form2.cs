using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_and_Register_Form
{

    public partial class Form2 : Form
    {
/*        string reg = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$";*/
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RegUserName = this.textBox1.Text;
            string RegPassword = this.textBox2.Text;
            String RegPassword2 = this.textBox3.Text;

            if (RegUserName != null)
            {
                if (RegPassword.Equals(RegPassword2))
                {
                    Login.RegUserName = RegUserName;
                    Login.RegPassword = RegPassword;
                    Form3 form = new Form3();
                    form.Show();
                }
                else
                {
                  /*  MessageBox.Show("Passwords do not match. Please enter the same password.");*/
                }

            }
            else{
                MessageBox.Show("Enter the user name");
            }

    /*        if (RegPassword != RegPassword2)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox2, "please enter the same Password");
            }
*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string RegPassword = this.textBox2.Text;
            String RegPassword2 = this.textBox3.Text;
            if (RegPassword.Equals(RegPassword2))
            {
                errorProvider2.Clear();
            }
            else
            {
                textBox1.Focus();
                errorProvider2.SetError(this.textBox2, "please enter the same Password");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
/*            if (Regex.IsMatch(textBox2.Text, reg) == false)
            {
                textBox1.Focus();
                errorProvider2.SetError(this.textBox2, "Invalid password");
            }*/
        }
    }
}
