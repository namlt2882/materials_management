using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Repository
{
    public abstract class BaseRepository<ID,T>
    {
        private static readonly string DatabaseConnection =
            "server=.\\SQLEXPRESS; database=BQP_Materials_Management; uid=sa; pwd=123456";
        protected SqlConnection connection;
        protected SqlCommand sqlCommand;
        protected SqlDataAdapter sqlDataAdapter;
        protected SqlDataReader sqlDataReader;
        protected SqlConnection GetSqlConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(DatabaseConnection);
            }
            return connection;
        }

        protected void CloseResources()
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
            }
            
        }

        public abstract T Get(ID id);
        public abstract T Insert(T t);
        public abstract List<T> GetAll();
        public abstract List<T> ReadValueFromReader();
    }
}
