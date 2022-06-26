using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___I.Problem
{
    internal class BurgerOrderService: IFoodOrderService
    {

        public void OrderBurger(int quantity)
        {
            //COde
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException("Can't order salad from this service");
        }
        public void OrderStreak(int quantity)
        {
            throw new NotImplementedException("Can't order a steak from this service");
        }


    }
}
