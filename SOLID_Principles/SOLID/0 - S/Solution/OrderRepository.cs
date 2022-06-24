using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S.Solution
{
    interface IOrderRepository
    {
         bool InsertOrder(Order order);
    }
    class OrderRepository:IOrderRepository
    {
        public bool InsertOrder(Order order) {
            //Code to insert the order on the database
            return true;
        }
    }
}
