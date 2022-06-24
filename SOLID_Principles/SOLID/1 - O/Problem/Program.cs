using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Problem
{
   internal  class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>(); //Get orders from data source3

            ReportingService service = new ReportingService();
            service.GenerarReport(orders, ReportType.PDF);
        }
    }
}
