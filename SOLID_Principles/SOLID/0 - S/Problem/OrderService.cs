using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S.Problem
{
   internal class OrderService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                this.InsertOrder(order);

                var invoice = this.CreateInvoice(order);

                this.EmailInvoice(invoice);

                File.WriteAllText(@"c:\InfoLog.txt", "The order has been complete");
            }
            catch (Exception e)
            {

                File.WriteAllText(@"c:\ErrorLog.txt", e.Message );
            }
          
        }

        public bool InsertOrder(Order order)
            {
                //Code to Insert the Order on the database
                return true;
            }

        private Invoice CreateInvoice(Order order)
        {
            //Code to create invoice
            return new Invoice();
        }
        private bool EmailInvoice(Invoice invoice)
        {
            //Code to email invoice
            return true;
        }
    }

    public class Order
    {

    }
    public class Invoice
    {

    }

}
