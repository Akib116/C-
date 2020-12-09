using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoodShop
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Green;
            radioButton2.ForeColor = Color.Red;
            radioButton3.ForeColor = Color.Red;
            radioButton4.ForeColor = Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Fried Rice");
            cmb_items.Items.Add("Kacchi Biryani");
            cmb_items.Items.Add("Morog Polao");
            cmb_items.Items.Add("Beef Tehari");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Red;
            radioButton2.ForeColor = Color.Green;
            radioButton3.ForeColor = Color.Red;
            radioButton4.ForeColor = Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Burger");
            cmb_items.Items.Add("Pizza");
            cmb_items.Items.Add("Chicken Fry");
            cmb_items.Items.Add("Sandwich");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Red;
            radioButton2.ForeColor = Color.Red;
            radioButton3.ForeColor = Color.Green;
            radioButton4.ForeColor = Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Coca-Cola");
            cmb_items.Items.Add("Sprite");
            cmb_items.Items.Add("Fanta");
            cmb_items.Items.Add("Mountain Dew");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Red;
            radioButton2.ForeColor = Color.Red;
            radioButton3.ForeColor = Color.Red;
            radioButton4.ForeColor = Color.Green;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Brownies");
            cmb_items.Items.Add("Snickers Cake");
            cmb_items.Items.Add("Pudding");
            cmb_items.Items.Add("Ice cream");
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == "Fried Rice")
            {
                txt_price.Text = "150";
            }
            else if (cmb_items.SelectedItem.ToString() == "Kacchi Biryani")
            {
                txt_price.Text = "220";
            }
            else if (cmb_items.SelectedItem.ToString() == "Morog Polao")
            {
                txt_price.Text = "180";
            }
            else if (cmb_items.SelectedItem.ToString() == "Beef Tehari")
            {
                txt_price.Text = "120";
            }
            else if (cmb_items.SelectedItem.ToString() == "Burger")
            {
                txt_price.Text = "100";
            }
            else if (cmb_items.SelectedItem.ToString() == "Pizza")
            {
                txt_price.Text = "80";
            }
            else if (cmb_items.SelectedItem.ToString() == "Chicken Fry")
            {
                txt_price.Text = "70";
            }
            else if (cmb_items.SelectedItem.ToString() == "Sandwich")
            {
                txt_price.Text = "60";
            }
            else if (cmb_items.SelectedItem.ToString() == "Coca-Cola")
            {
                txt_price.Text = "20";
            }
            else if (cmb_items.SelectedItem.ToString() == "Sprite")
            {
                txt_price.Text = "20";
            }
            else if (cmb_items.SelectedItem.ToString() == "Fanta")
            {
                txt_price.Text = "20";
            }
            else if (cmb_items.SelectedItem.ToString() == "Mountain Dew")
            {
                txt_price.Text = "20";
            }
            else if (cmb_items.SelectedItem.ToString() == "Brownies")
            {
                txt_price.Text = "70";
            }
            else if (cmb_items.SelectedItem.ToString() == "Snickers Cake")
            {
                txt_price.Text = "80";
            }
            else if (cmb_items.SelectedItem.ToString() == "Pudding")
            {
                txt_price.Text = "50";
            }
            else if (cmb_items.SelectedItem.ToString() == "Ice cream")
            {
                txt_price.Text = "60";
            }
            else
            {
                txt_price.Text = "0";
            }
            txt_total.Text = "";
            txt_qty.Text = "";
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {

                txt_total.Text = (Convert.ToInt16(txt_qty.Text) * Convert.ToInt16(txt_price.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);


            txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_discount.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();


                    }
                }
            }
        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(txt_sub.Text, txt_discount.Text, txt_net.Text, txt_paid.Text, txt_balance.Text);
            form5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
