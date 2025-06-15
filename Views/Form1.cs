using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_magazin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//ProductTypeComboBox
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fruitShopDataSet.FruitTypes' table. You can move, or remove it, as needed.
            this.fruitTypesTableAdapter.Fill(this.fruitShopDataSet.FruitTypes);

        }

       

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ProdNumtxt.Clear();
            ProdNametxt.Clear();
            Desctxt.Clear();
            Pricetxt.Clear();
        }

        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ListBoxProducts.Items.Add(ProdNumtxt.Text);
            ListBoxProducts.Items.Add(ProdNametxt.Text);
            ListBoxProducts.Items.Add(Desctxt.Text);
            ListBoxProducts.Items.Add(Pricetxt.Text);
            ListBoxProducts.Items.Add(ProdTypecmb.SelectedItem);
            ListBoxProducts.Items.Add("---------");
        }

        private void DeleteListboxData_Click(object sender, EventArgs e)
        {
            ListBoxProducts.Items.Clear();
        }
    }
}
