using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Solution
{
  internal  class ReportingService
    {
        private readonly IReportGenerator _reportGenerator;

        public ReportingService(IReportGenerator reportGenerator) {
            _reportGenerator = reportGenerator;
        }

        public void GenerateRerport(List<Order> orders)
        {
            _reportGenerator.CreateReport(orders);
        }
    }

    public class Order
    {

    }
}
