using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donuts
{
    class DonuteerService
    {
        public void packDonuts(Order o)
        {
            MessageBox.Show("Packing Donuts - " + o.Donuts);
        }
    }
}
