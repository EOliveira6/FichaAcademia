using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAcademia.DAO
{
    public abstract class Pattern<T>
    {
        protected abstract T BuildModel(DataRow dataRow);

        protected string QueryName;

        public T Consulta(SortedList<string, object> sqlParameters)
        {

            SqlParameter[] sqlParametersList = new SqlParameter[sqlParameters.Count];

            int i = 0;
            foreach (var kvp in sqlParameters)
            {
                sqlParametersList[i] = new SqlParameter(kvp.Key, kvp.Value);
                i++;
            }

            var tabela = HelperDAO.ExecutaProcSelect(QueryName, sqlParametersList);
            if (tabela.Rows.Count == 0)
                return default(T);
            else
                return BuildModel(tabela.Rows[0]);
        }

        public List<T> Filter(SortedList<string, object> sqlParameters)
        {
            SqlParameter[] sqlParametersList = new SqlParameter[sqlParameters.Count];

            int i = 0;
            foreach (var kvp in sqlParameters)
            {
                sqlParametersList[i] = new SqlParameter(kvp.Key, kvp.Value);
                i++;
            }

            var tabela = HelperDAO.ExecutaProcSelect(QueryName, sqlParametersList);
            List<T> lista = new List<T>();
            foreach (DataRow registro in tabela.Rows)
            {
                lista.Add(BuildModel(registro));
            }
            return lista;
        }
    }
}
