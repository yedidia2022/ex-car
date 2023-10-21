using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gvbh
{
    internal class AudiCar:Car
    {
        public AudiCar(double speed) 
        :base(speed)
        {
        
        }

        public override void AccelerationSpeed()
        {
            base.AccelerationSpeed();
            base.AccelerationSpeed();

        }
        public override string ToString()
        {
            return base.ToString() + "and my car is Audi";
        }
    }
}
