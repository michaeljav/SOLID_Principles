using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___L.Solution
{
    class Bike: ISpeedUp,IBrake,IPark
    {
        void SpeedUp() { }
        void Brake() { }
        void Park() { }

    }
}
