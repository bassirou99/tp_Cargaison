using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassirou_test.models
{
    class Aerienne : Cargaison
    {
        public Aerienne()
        {
            type= "Aerienne";
        }

        public override double Cout()
        {
            int val;
            if(VolumeTotal > 80000)
            {
                val = 12;
            }
            else
            {
                val=10;
            }
            return val * Distance * PoidsTotal;
        }

        public override string ToString()
        {
            return base.ToString()+"Cout: " + Cout();
        }
    }
}
