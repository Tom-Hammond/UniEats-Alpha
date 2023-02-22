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
    public partial class ViewRestaurants : Form
    {
        public ViewRestaurants()
        {
            InitializeComponent();
        }

        private void shopButtonClick1_Click(object sender, EventArgs e)
        {
            this.Close();
            SparShop sparShopOpen = new SparShop();
            sparShopOpen.Show();
        }
    }


}
