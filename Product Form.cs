using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AGOT_WEEK05_WORK04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_origin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_barcode.Clear();
            txtbox_name.Clear();
            txtbox_description.Clear();

            cmb_category.SelectedIndex = -1;

            radio_local.Checked = false;
            radio_abroad.Checked = false;

            check_active.Checked = false;

            txtBox_cost.Clear();
            txtBox_price.Clear();
            txtBox_markup.Clear();

            txtBox_barcode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal cost, price;

            if (!decimal.TryParse(txtBox_cost.Text, out cost) ||
                !decimal.TryParse(txtBox_price.Text, out price))
            {
                MessageBox.Show("Please enter valid numbers for Cost and Price!");
                return;
            }

            if (cost <= 0 || price < 0)
            {
                MessageBox.Show("Cost must be greater than zero and Price cannot be negative!");
                return;
            }

            decimal markup = ((price - cost) / cost) * 100;

            txtBox_markup.Text = markup.ToString("0.00") + "%";


            string origin = "";

            if (radio_local.Checked)
            {
                origin = "Local";
            }
            else if (radio_abroad.Checked)
            {
                origin = "Abroad";
            }
            else
            {
                MessageBox.Show("Please select product origin!");
                return;
            }

            string status = check_active.Checked ? "Active" : "Inactive";

            MessageBox.Show(
                "Product Saved Successfully!\n\n" +
                "Barcode: " + txtBox_barcode.Text +
                "\nName: " + txtbox_name.Text +
                "\nDescription: " + txtbox_description.Text +
                "\nCategory: " + cmb_category.Text +
                "\nOrigin: " + origin +
                "\nStatus: " + status +
                "\nCost: " + cost +
                "\nPrice: " + price +
                "\nMarkup: " + txtBox_markup.Text,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void txtbox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            decimal cost, price;

            if (!decimal.TryParse(txtBox_cost.Text, out cost) ||
                !decimal.TryParse(txtBox_price.Text, out price))
            {
                MessageBox.Show("Please enter valid numbers for Cost and Price!");
                return;
            }

            if (cost <= 0 || price < 0)
            {
                MessageBox.Show("Cost must be greater than zero and Price cannot be negative!");
                return;
            }

            decimal markup = ((price - cost) / cost) * 100;

            txtBox_markup.Text = markup.ToString("0.00") + "%";


            string origin = "";

            if (radio_local.Checked)
            {
                origin = "Local";
            }
            else if (radio_abroad.Checked)
            {
                origin = "Abroad";
            }
            else
            {
                MessageBox.Show("Please select product origin!");
                return;
            }

            string status = check_active.Checked ? "Active" : "Inactive";

            MessageBox.Show(
                "Product Saved Successfully!\n\n" +
                "Barcode: " + txtBox_barcode.Text +
                "\nName: " + txtbox_name.Text +
                "\nDescription: " + txtbox_description.Text +
                "\nCategory: " + cmb_category.Text +
                "\nOrigin: " + origin +
                "\nStatus: " + status +
                "\nCost: " + cost +
                "\nPrice: " + price +
                "\nMarkup: " + txtBox_markup.Text,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
