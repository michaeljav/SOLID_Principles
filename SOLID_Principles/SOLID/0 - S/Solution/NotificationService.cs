using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S.Solution
{
    interface INotificationService
    {
      bool  EmailInvoice(Invoice invoice);
    }
    class NotificationService : INotificationService
    {
        public bool  EmailInvoice(Invoice invoice)
        {
            //Code to  create invoice
            return true;
        }
    }
}
