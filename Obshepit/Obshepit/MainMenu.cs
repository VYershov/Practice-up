using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obshepit
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void dishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dishes dishes = new Dishes();
            dishes.Show(this);
        }

        private void ResipeStripMenuItem5_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe();
            recipe.Show(this);
        }

        private void ToDStripMenuItem6_Click(object sender, EventArgs e)
        {
            Types_of_dishes ToD = new Types_of_dishes();
            ToD.Show(this);
        }

        private void PrepStripMenuItem7_Click(object sender, EventArgs e)
        {
            Preparation preparation = new Preparation();
            preparation.Show(this);
        }

        private void ProductsStripMenuItem8_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show(this);
        }

        private void CoDStripMenuItem9_Click(object sender, EventArgs e)
        {
            Composition_of_dish CoD = new Composition_of_dish();
            CoD.Show(this);

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
