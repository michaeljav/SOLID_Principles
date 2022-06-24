using SOLID._0___S.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Problem
{
    enum ReportType_2
    {
        PDF,
        EXCEL,
        JSON,
        XML

    }

    internal class ReportGeneratorExcel
    {
        public void GenerarReport(List<Order> orders, ReportType_2 type)
        {
            //Genirc code to create report

            //Specific conversion depending on type
            if (type == ReportType_2.PDF)
            {
                CreatePDFReport(orders);
            }
            else
            if (type == ReportType_2.EXCEL)
            {
                CreateExcelReport(orders);
            }
            else
            if (type == ReportType_2.JSON)
            {
                CreateJsonReport(orders);
            }
            else
            if (type == ReportType_2.XML)
            {
                CreateXMLReport(orders);
            }
        }

        private void CreateXMLReport(List<Order> orders)
        {
            throw new NotImplementedException();
        }

        private void CreateJsonReport(List<Order> orders)
        {
            throw new NotImplementedException();
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
