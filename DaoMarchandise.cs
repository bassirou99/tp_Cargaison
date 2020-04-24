using Bassirou_test.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassirou_test.dao.bd
{

    class DaoMarchandise :SqlServer, ICargaison<Marchandise>
    {
        private dao.bd.DaoCargaison daoCarg = new DaoCargaison();

        public DaoMarchandise()
        {
            TableName = "marchandise";
        }

        public bool Add(Marchandise marchandise)
        {
            string sql =string.Format("insert into marchandise(poids,volume,cargaison_id) values({0},{1},{2})" , marchandise.Poids,marchandise.Volume,marchandise.Cargaison.Id);
            return base.ExecuteUpdate(sql) != 0;
        }

        public List<Marchandise> getAll()
        {
            return null;
        }

        public Marchandise getById(int id)
        {
            return null; ;
        }

        public List<Marchandise> getMarchandiseByCargaison(Cargaison cargaison)
        {
            List<Marchandise> marchandises = new List<Marchandise>();
            string sql =string.Format("select * from marchandise where cargaison_id = {0}",cargaison.Id);
            DataSet ds = base.ExecuteSelect(sql);
            DataTable dt = ds.Tables[TableName];
            foreach (DataRow row in dt.Rows)
            {
                int cargaison_id = int.Parse(row.ItemArray[3].ToString().Trim());
                Marchandise marchandise = new Marchandise()
                {
                    Numero = int.Parse(row.ItemArray[0].ToString().Trim()),
                    Poids = double.Parse(row.ItemArray[1].ToString().Trim()),
                    Volume  = double.Parse(row.ItemArray[2].ToString().Trim()),
                    Cargaison= daoCarg.getById(cargaison_id)

                };
                marchandises.Add(marchandise);
            } 

            return marchandises;
        }
        
    }
}
   