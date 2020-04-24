using Bassirou_test.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassirou_test.services
{
    interface IService
    {
        bool addCargaison(Cargaison cargaison);
        List<Cargaison> ListerCargaison();
        void AddMarchandiseInCargaison(Marchandise mar);
        List<Marchandise> ListerMarchandiseDunenCargaison(Cargaison cargaison);

    }
}
