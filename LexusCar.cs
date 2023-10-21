using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gvbh
{
    internal class LexusCar:Car
    {
        public Boolean IsSongWork { get; set; }
        public LexusCar(double speed)
            : base(speed)
        {

        }
        public void playSong()
        {
            this.IsSongWork = true;
        }
        public void pauseSong()
        {
            this.IsSongWork = false;
        }
        public override string ToString()
        {
            return base.ToString() +" " + "and my car is lexus";
        }




    }
}
