using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Solution
{
    internal class Program
    {
        public static void Main() {
            List<Order> orders = new List<Order>(); //Get Orders from data source

            ReportingService service = new  ReportingService(new ReportGeneratorPDF());//Send Implementation
            service.GenerateRerport(orders);
        }
    }
}
