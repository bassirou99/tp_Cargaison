using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassirou_test.models
{

    class Marchandise
    {
        private static int nbreMarchandise; 
        private int numero;
        private double poids;
        private double volume;
        private Cargaison cargaison; 

        public Marchandise()
        {
            numero = ++nbreMarchandise;
        }

        public static int NbreMarchandise { get => nbreMarchandise; set => nbreMarchandise = value; }
        public int Numero { get => numero; set => numero = value; }
        public double Poids { get => poids; set => poids = value; }
        public double Volume { get => volume; set => volume = value; }
        public Cargaison Cargaison { get => cargaison; set => cargaison = value; }

    }
}
