using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using FichaAcademia.Dominio.Models;

namespace FichaAcademia.DAO
{
    public class ObjetivoDAO: Pattern<Objetivo>
    {
        public ObjetivoDAO()
        {
            QueryName = "query_goals";
        }

        protected override Objetivo BuildModel(DataRow dataRow)
        {
            return new Objetivo
            {
                ObjetivoId = Convert.ToInt32(dataRow["ObjetivoId"]),
                Nome = dataRow["Nome"].ToString(),
                Descricao = dataRow["Descricao"].ToString()
            };
        }
    }
}
