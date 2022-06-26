using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___L.Problem
{
    internal class Bike: Vehicle
    {
      
        public override void SpeedUP() {
        // Code to speedup
        }
        public override void Brake() {
        //Code
        }
       public override void Park() {

        //Code
        }
        public override void TakeOff() {
            throw new NotImplementedException();
        }
   
        public override void Land() {
            throw new NotImplementedException();
        }
  
   
    }
}
