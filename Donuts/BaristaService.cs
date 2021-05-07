using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donuts
{
    class BaristaService
    {
        public void makeCoffee(Order o)
        {
            MessageBox.Show("Making coffees - " + o.Coffee);
        }
    }
}
