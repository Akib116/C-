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
    public partial class Form5 : Form
    {
        public Form5(string Str_Value, string Str_Value1, string Str_Value2, string Str_Value3, string Str_Value4)
        {
            InitializeComponent();
            labelsubtotal.Text = Str_Value;
            labeldiscount.Text = Str_Value1;
            labelnet.Text = Str_Value2;
            labelpaid.Text = Str_Value3;
            labelbalance.Text = Str_Value4;

            label4.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }
        




            private void listView2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}