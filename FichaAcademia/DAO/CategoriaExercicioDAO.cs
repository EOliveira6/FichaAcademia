using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using FichaAcademia.Dominio.Models;

namespace FichaAcademia.DAO
{
    public class CategoriaExercicioDAO: Pattern<CategoriaExercicio>
    {

        public CategoriaExercicioDAO()
        {
            QueryName = "query_category";
        }

        protected override CategoriaExercicio BuildModel(DataRow dataRow)
        {
            return new CategoriaExercicio
            {
                CategoriaExercicioId = Convert.ToInt32(dataRow["CategoriaExercicioId"]),
                Nome = dataRow["Nome"].ToString()
            };
        }
    }
}
