using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAcademia.DAO
{
    public static class ConnectionDB
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source = sql5097.site4now.net; Initial Catalog = DB_A69671_Pri1101; User ID = DB_A69671_Pri1101_admin; Password = asp.net@123";
            //SqlConnection conexao = new SqlConnection(strCon);
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = strCon;

            conexao.Open();
            return conexao;
        }
    }
}
