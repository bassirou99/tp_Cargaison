using Bassirou_test.dao;
using Bassirou_test.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassirou_test.services
{ 
    class CargaisonService:IService
    {
        private dao.List.DaoCargaison daoCarg;
        private dao.List.DaoMarchandise daoMar;

        public CargaisonService()
        {
            daoCarg = new dao.List.DaoCargaison();
            daoMar = new dao.List.DaoMarchandise();
        }

        public bool addCargaison(Cargaison cargaison)
        {
            daoCarg.Add(cargaison);
            return true;
        }

        public List<Cargaison> ListerCargaison()
        {
            return daoCarg.getAll();
        }

        public void AddMarchandiseInCargaison(Marchandise mar)
        {
            daoMar.Add(mar);
        }

        public List<Marchandise> ListerMarchandiseDunenCargaison(Cargaison cargaison)
        {
            return daoMar.getMarchandiseByCargaison(cargaison);
        }

        internal object ListerMarchandiseDunenCargaison(object cargaisonSelect)
        {
            throw new NotImplementedException();
        }
    }
}
