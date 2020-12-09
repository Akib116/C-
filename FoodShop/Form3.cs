using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodShop
{
    public partial class Form3 : Form
    {
        public object Newtextpassword { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

     
        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



            {

                if (TextUserName.Text == "" && TextPassword.Text == "")  
                {
                    MessageBox.Show("Textbox are empty");

                }
                else if (TextUserName.Text.Length < 6) 
                {
                    MessageBox.Show("More than 6 charater in username ");
                }
                else if ( TextPassword.Text.Length < 6)
                {
                    MessageBox.Show("More than 6 charater in password ");
                }
                else if (TextMail.Text == "" && TextPhoneNumber.Text == "")

                {
                    MessageBox.Show("Textbox are empty");

                }

                else
                {
                    MessageBox.Show("Registration Complete");
                    new Form1().Show();
                    this.Hide();
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr)&& chr !=8)


            {
                e.Handled = true;
                MessageBox.Show("Enter only number");
        
            
                }

        }



        private void Form3_BackgroundImageChanged(object sender, EventArgs e)
        {



        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
