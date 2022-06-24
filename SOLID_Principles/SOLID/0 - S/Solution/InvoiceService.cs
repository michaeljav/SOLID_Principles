using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S.Solution
{
    interface IInvoiceService
    {
         Invoice  CreateInvoice(Order order);
    }
    class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            //Code to  create invoice
            return new Invoice();
        }
    }
}
