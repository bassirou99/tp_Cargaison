using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassirou_test.models
{
    class Routiere : Cargaison
    {
        public Routiere()
        {
            type = "Routiere";
        }

        public override double Cout()
        {
            int val;
            if (VolumeTotal > 380000)
            {
                val = 6;
            }
            else
            {
                val = 4;
            }
            return val * Distance * PoidsTotal;
        }

        public override string ToString()
        {
            return base.ToString()+"Cout: " + Cout();
        }
    }
}
