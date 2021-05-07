using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donuts
{
    class ProcessOrder
    {
        public delegate void ProcessOrderDelegate(Order o);
        public event ProcessOrderDelegate OrderSubmitted;


        public void ProcessTheOrder(Order o)
        {
            PaymentService ps = new PaymentService();
            BaristaService bs = new BaristaService();
            DonuteerService ds = new DonuteerService();
            DBService dbs = new DBService();

            OrderSubmitted += ps.collectPayment;
            OrderSubmitted += bs.makeCoffee;
            OrderSubmitted += ds.packDonuts;
            OrderSubmitted += dbs.WriteToDB;


           /* //let cashier know to collect cash
            ps.collectPayment(o);
            //let barista know to make coffee
            bs.makeCoffee(o);
            //let donuteer know to pack donuts
            ds.packDonuts(o); */

            OnOrderSubmitted(o);

        }

        protected virtual void OnOrderSubmitted(Order o)
        {
            if (OrderSubmitted != null)
            {
                OrderSubmitted(o);
            }
        }
    }
}
