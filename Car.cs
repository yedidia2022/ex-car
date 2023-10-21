using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gvbh
{
    //base class
    abstract class Car
    {

      
        private double speed;
        public double Speed
        {
            get { return speed; } // getter
            set { if (value>0) speed = value; } // setter
        }
        public Car(double value)
        {
            this.Speed = value;
        }

        public void getSpeed()
        {
            Console.WriteLine("the speed of my car is :{0}", this.Speed);
        }

        //אולי להפוך לוירטואל
        public virtual void AccelerationSpeed()
        {
            this.Speed++;

        }
        public void DecelerationSpeed()
        {  if(this .Speed >= 1) 
            this.Speed--;

        }
        public void StopCar()
        {
            this.Speed = 0;
        }
        public override string ToString()
        {
            return   "  my speed is "+ this.Speed;
        }

    }
}
