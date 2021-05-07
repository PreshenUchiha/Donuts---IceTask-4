using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donuts
{
    class PaymentService
    {
        public void collectPayment(Order o)
        {
            MessageBox.Show("Collect payment from " + o.Name);
        }
    }
}
