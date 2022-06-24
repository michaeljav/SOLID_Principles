using SOLID._0___S.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Problem
{
        
        
    enum ReportType
    {
        PDF,
        EXCEL

    }
    internal class ReportingService
    {

        public void GenerarReport(List<Order> orders, ReportType type)
        {
            //Genirc code to create report

            //Specific conversion depending on type
            if (type == ReportType.PDF)
            {
                CreatePDFReport(orders);
            }
            else
            if(type == ReportType.EXCEL){
                CreateExcelReport(orders);
            }
        }

        private void CreateExcelReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        private void CreatePDFReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }
    }
}
