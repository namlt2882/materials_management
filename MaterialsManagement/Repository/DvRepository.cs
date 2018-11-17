﻿using MaterialsManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Repository
{
    public class DvRepository : BaseRepository<string, Dv>
    {
        private static readonly string QUERY_GET_ALL = "SELECT Id,Name,QkId FROM Dv";
        private static readonly string QUERY_BY_QK_ID = "SELECT Id,Name,QkId,Priority FROM Dv WHERE QkId=@QkId " +
            "ORDER BY Priority ASC";
        private static readonly string QUERY_BY_ID = "SELECT Id,Name,QkId FROM Dv WHERE Id=@Id";
        public DvRepository()
        {
        }

        public override Dv Get(string Id)
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_BY_ID, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Id", Id);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                connection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                List<Dv> rs = ReadValueFromReader();
                return rs.DefaultIfEmpty(null).First();
            }
            finally
            {
                CloseResources();
            }
        }

        public override List<Dv> GetAll()
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_GET_ALL, GetSqlConnection());
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                connection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                List<Dv> rs = ReadValueFromReader();
                return rs;
            }
            finally
            {
                CloseResources();
            }
        }

        public List<Dv> GetByQkId(string QkId)
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_BY_QK_ID, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@QkId", QkId);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                connection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                List<Dv> rs = ReadValueFromReader();
                return rs;
            }
            finally
            {
                CloseResources();
            }
        }

        public override Dv Insert(Dv t)
        {
            throw new NotImplementedException();
        }

        public override List<Dv> ReadValueFromReader()
        {
            List<Dv> rs = new List<Dv>();
            Dv dv;
            while (sqlDataReader.Read())
            {
                dv = new Dv
                {
                    Id = sqlDataReader[0].ToString(),
                    Name = sqlDataReader[1].ToString(),
                    QkId = sqlDataReader[2].ToString(),
                    Priority = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Priority"))
                };
                rs.Add(dv);
            }
            return rs;
        }
    }
}
