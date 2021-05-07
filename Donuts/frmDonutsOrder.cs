using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donuts
{
    public partial class frmDonutsOrder : Form
    {
        public frmDonutsOrder()
        {
            InitializeComponent();
        }

        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            int coffee = Convert.ToInt32(txbCoffee.Text);
            int donuts = Convert.ToInt32(txbDonuts.Text);

            Order o = new Order(name, donuts, coffee);

            ProcessOrder p = new ProcessOrder();

            p.ProcessTheOrder(o);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
