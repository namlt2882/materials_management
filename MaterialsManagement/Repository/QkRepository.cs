using MaterialsManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Repository
{
    public class QkRepository : BaseRepository<string, Qk>
    {
        private static readonly string QUERY_GET_ALL = "SELECT Id,Name FROM Qk";
        private static readonly string QUERY_BY_ID = "SELECT Id,Name FROM Qk WHERE Id=@Id";
        private static readonly string INSERT_QUERY = "INSERT INTO " +
       "Qk(Id, Name) " +
       "VALUES(@Id, @Name)";
        private static readonly string UPDATE_QUERY = "UPDATE Qk " +
          "SET Name=@Name " +
          "WHERE Id=@Id";
        public QkRepository()
        {
        }

        public override Qk Get(string Id)
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_BY_ID, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Id", Id);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                connection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                List<Qk> rs = ReadValueFromReader();
                return rs.DefaultIfEmpty(null).FirstOrDefault();
            }
            finally
            {
                CloseResources();
            }
        }

        public override List<Qk> GetAll()
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_GET_ALL, GetSqlConnection());
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                connection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                List<Qk> rs = ReadValueFromReader();
                return rs;
            }
            finally
            {
                CloseResources();
            }
        }

        public override Qk Insert(Qk t)
        {
            try
            {
                sqlCommand = new SqlCommand(INSERT_QUERY, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Id", t.Id.Trim());
                sqlCommand.Parameters.AddWithValue("@Name", t.Name.Trim());
                connection.Open();
                int status = sqlCommand.ExecuteNonQuery();
                if (status <= 0)
                {
                    throw new Exception("Fail to insert Qk with id=" + t.Id);
                }
                else
                {
                    return t;
                }
            }
            finally
            {
                CloseResources();
            }
        }

        public override List<Qk> ReadValueFromReader()
        {
            List<Qk> rs = new List<Qk>();
            Qk qk;
            while (sqlDataReader.Read())
            {
                qk = new Qk
                {
                    Id = sqlDataReader[0].ToString(),
                    Name = sqlDataReader[1].ToString()
                };
                rs.Add(qk);
            }
            return rs;
        }

        public override void Update(Qk t)
        {
            try
            {
                sqlCommand = new SqlCommand(UPDATE_QUERY, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Name", t.Name.Trim());
                sqlCommand.Parameters.AddWithValue("@Id", t.Id);
                connection.Open();
                int status = sqlCommand.ExecuteNonQuery();
                if (status <= 0)
                {
                    throw new Exception("Fail to update Qk with id=" + t.Id);
                }
            }
            finally
            {
                CloseResources();
            }
        }
    }
}
