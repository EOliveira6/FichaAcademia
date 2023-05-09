using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using FichaAcademia.Dominio.Models;

namespace FichaAcademia.DAO
{
    public class ExercicioDAO: Pattern<Exercicio>
    {

        public ExercicioDAO()
        {
            QueryName = "query_exercises";
        }

        protected override Exercicio BuildModel(DataRow dataRow)
        {
            Exercicio exercicio = new Exercicio
            {
                ExercicioId = Convert.ToInt32(dataRow["ExercicioId"]),
                Nome = dataRow["ExercicioNome"].ToString(),
            };

            CategoriaExercicio categoriaExercicio = new CategoriaExercicio();
            categoriaExercicio.CategoriaExercicioId = Convert.ToInt32(dataRow["CategoriaExercicioId"]);
            categoriaExercicio.Nome = dataRow["CategoriaExercicioNome"].ToString();

            exercicio.CategoriaExercicio = categoriaExercicio;

            return exercicio;
        }
    }
}
