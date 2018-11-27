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
        private static readonly string QUERY_NO_CHECK_CONTAINT = "EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' ";
        private static readonly string QUERY_CLEAR = "EXEC sp_MSForEachTable 'DELETE FROM ?' ";
        private static readonly string QUERY_CHECK_CONTAINT = "EXEC sp_MSForEachTable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL' ";
        private static readonly string DatabaseConnection =
            "server=.\\SQLEXPRESS; database=BQP_Materials_Management; uid=sa; pwd=123456";
        protected SqlConnection connection;
        protected SqlCommand sqlCommand;
        protected SqlDataAdapter sqlDataAdapter;
        protected SqlDataReader sqlDataReader;
        public DataTable dataTable { get; set; }
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
        public void Clear()
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_CLEAR, GetSqlConnection());
                connection.Open();
                int status = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                CloseResources();
            }

        }
        public void TurnOffContaint()
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_NO_CHECK_CONTAINT, GetSqlConnection());
                connection.Open();
                int status = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                CloseResources();
            }

        }
        public void TurnOnContaint()
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_CHECK_CONTAINT, GetSqlConnection());
                connection.Open();
                int status = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                CloseResources();
            }

        }
        public abstract T Get(ID id);
        public abstract T Insert(T t);
        public abstract void Update(T t);
        public abstract List<T> GetAll();
        public abstract List<T> ReadValueFromReader();
    }
}
