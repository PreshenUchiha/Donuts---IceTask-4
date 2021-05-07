using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donuts
{
    class DBService
    {
        public void WriteToDB(Order o)
        {
            MessageBox.Show("Writing to DB : " + o.ToString());
        }
    }
}
