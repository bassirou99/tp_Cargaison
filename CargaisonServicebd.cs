using Bassirou_test.dao;
using Bassirou_test.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassirou_test.services
{ 
    class CargaisonServicebd:IService
    {
        private dao.bd.DaoCargaison daoCarg;
        private dao.bd.DaoMarchandise daoMar;

        public CargaisonServicebd()
        {
            daoCarg = new dao.bd.DaoCargaison();
            daoMar = new dao.bd.DaoMarchandise();
        }

        public bool addCargaison(Cargaison cargaison)
        {
            return daoCarg.Add(cargaison);
            
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
