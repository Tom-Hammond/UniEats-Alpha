using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniEats_Alpha
{
    public partial class LibraryCafe : Form
    {
        public LibraryCafe()
        {
            InitializeComponent();
        }

        private void SparShop_Load(object sender, EventArgs e)
        {

        }

        private void ColdDrinks_Click(object sender, EventArgs e)
        {
            HotDrinksBox.Visible = false;
            HotSnacksBox.Visible = false;
            ColdSnacksBox.Visible = false;
            DessertsBox.Visible = false;
            ColdDrinksBox.Show();
        }

        private void HotDrinks_Click(object sender, EventArgs e)
        {
            ColdDrinksBox.Visible = false;
            HotSnacksBox.Visible = false;
            ColdSnacksBox.Visible = false;
            DessertsBox.Visible = false;
            HotDrinksBox.Show();
        }

        private void HotSnacks_Click(object sender, EventArgs e)
        {
            ColdDrinksBox.Visible = false;
            HotDrinksBox.Visible = false;
            ColdSnacksBox.Visible = false;
            DessertsBox.Visible = false;
            HotSnacksBox.Show();

        }

        private void ColdSnacks_Click(object sender, EventArgs e)
        {
            ColdDrinksBox.Visible = false;
            HotDrinksBox.Visible = false;
            HotSnacksBox.Visible = false;
            DessertsBox.Visible = false;
            ColdSnacksBox.Show();
        }

        private void DessertsButton_Click(object sender, EventArgs e)
        {
            ColdDrinksBox.Visible = false;
            HotDrinksBox.Visible = false;
            HotSnacksBox.Visible = false;
            ColdSnacksBox.Visible = false;
            DessertsBox.Show();
        }
    }
}
