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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {


            if (textUserName.Text == "raiyan123" && textpassword.Text == "raiyan123")
            {
                new Form4().Show();
                this.Hide();
            }
            else if (textUserName.Text == "" && textpassword.Text == "")
            {
                MessageBox.Show("The username or password texbox is empty");
            }
            else if (textUserName.Text.Length > 6 && textpassword.Text.Length > 6)
            {
                MessageBox.Show("More than 6 ");
            }
            else
            {

                MessageBox.Show("The username or password is wrong ,try again");
                textUserName.Clear();
                textpassword.Clear();
                textUserName.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

