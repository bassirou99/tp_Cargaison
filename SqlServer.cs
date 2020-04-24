using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassirou_test.dao.bd
{
    class SqlServer
    {
        private SqlConnection con= new SqlConnection();
        private SqlCommand cmd=new SqlCommand();
        private SqlDataAdapter da=new SqlDataAdapter();
        private DataSet  ds = new DataSet();
       // private DataTable dt;//
        private string tableName;

        public string TableName { get => tableName; set => tableName = value; }

        public void GetConnexion()
        {
            if (con.State == ConnectionState.Closed || con.State== ConnectionState.Broken) 
            {
                con.ConnectionString = @"Initial Catalog = Cargaison  ; Data Source = DESKTOP-3DVSK11 \SQLEXPRESS ; Integrated Security = True";
                con.Open();
            }

        }

        public void CloseConnexion()
        {
            if(con.State == ConnectionState.Open || con.State == ConnectionState.Connecting)
            {
                con.Close();

            }
           

        }

        public int ExecuteUpdate(string sql)
        {
            int nbreLigneModif = 0;
            GetConnexion();
            cmd.Connection = con;
            cmd.CommandText = sql;
            nbreLigneModif = cmd.ExecuteNonQuery();
            CloseConnexion();
            return nbreLigneModif;
        }

        public DataSet ExecuteSelect(string sql)
        {
            GetConnexion();

            cmd.Connection = con;

            cmd.CommandText = sql;
            da.SelectCommand = cmd;

            if(ds.Tables[tableName] != null)
            {
                ds.Tables[tableName].Clear();

            }
            da.Fill(ds, tableName);

            CloseConnexion();
            return ds;
        }



    }
}
