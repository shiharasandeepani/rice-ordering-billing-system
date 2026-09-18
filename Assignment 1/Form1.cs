using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Price = 0;
            if (listBox1.SelectedItem.ToString() == "Vegetable Rice")
            {
                Price = 600 * Convert.ToInt16(txtpacks.Text);
            }
            if (listBox1.SelectedItem.ToString() == "Egg Rice")
            {
                Price = 650 * Convert.ToInt16(txtpacks.Text);
            }
            if (listBox1.SelectedItem.ToString() == "Chicken Rice")
            {
                Price = 700 * Convert.ToInt16(txtpacks.Text);
            }
            if (listBox1.SelectedItem.ToString() == "Pork Rice")
            {
                Price = 800 * Convert.ToInt16(txtpacks.Text);
            }
            if (listBox1.SelectedItem.ToString() == "Beef Rice")
            {
                Price = 850 * Convert.ToInt16(txtpacks.Text);
            }
            if (listBox1.SelectedItem.ToString() == "Seafood Rice")
            {
                Price = 900 * Convert.ToInt16(txtpacks.Text);
            }
            if (listBox1.SelectedItem.ToString() == "Mixed Rice")
            {
                Price = 1000 * Convert.ToInt16(txtpacks.Text);
            }

            if (checkedListBox1.GetItemChecked(0))
            { Price = Price + 3; }
            if (checkedListBox1.GetItemChecked(1))
            { Price = Price + 5; }
            if (checkedListBox1.GetItemChecked(2))
            { Price = Price + 7; }
            if (checkedListBox1.GetItemChecked(3))
            { Price = Price + 4; }
            if (checkedListBox1.GetItemChecked(4))
            { Price = Price + 5; }

            if (radioButton1.Checked)
            { Price = Price + 80; }
            if (radioButton2.Checked)
            { Price = Price + 120; }
            if (radioButton3.Checked)
            { Price = Price + 110; }
            if (radioButton4.Checked)
            { Price = Price + 100; }


            if (checkedListBox2.GetItemChecked(0))
            { Price = Price + 160; }
            if (checkedListBox2.GetItemChecked(1))
            { Price = Price + 150; }
            if (checkedListBox2.GetItemChecked(2))
            { Price = Price + 70; }
            if (checkedListBox2.GetItemChecked(3))
            { Price = Price + 140; }
            if (checkedListBox2.GetItemChecked(4))
            { Price = Price + 140; }

            txtvalue.Text = Convert.ToString(Price);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
