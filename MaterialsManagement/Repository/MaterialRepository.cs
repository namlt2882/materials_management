using MaterialsManagement.Common;
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
    public class MaterialRepository : BaseRepository<string, Material>
    {
        public bool ReturnDataTable = false;
        private static readonly string INSERT_QUERY = "INSERT INTO " +
            "Material(Id, Type, RegisterCode, Model, Origin," +
            "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
            "DvId, InsertDate) " +
            "VALUES(@Id, @Type, @RegisterCode, @Model, @Origin," +
            "@ManufacturingDate, @CurrentKm, @OilWarning, @Notes, @Status," +
            "@DvId, @InsertDate)";
        private static readonly string QUERY_GET_BY_TYPE = "SELECT " +
            "Id, Type, RegisterCode, Model, Origin," +
            "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
            "DvId, InsertDate " +
            "FROM Material WHERE Type=@Type AND Status=" + (int)MaterialStatus.ACTIVE+
            " ORDER BY InsertDate DESC";
        public MaterialRepository(bool ReturnDataTable) : this()
        {
            this.ReturnDataTable = ReturnDataTable;
        }
        public MaterialRepository()
        {
        }
        public override Material Get(string id)
        {
            throw new NotImplementedException();
        }

        public override List<Material> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<Material> GetByType(int Type)
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_GET_BY_TYPE, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Type", Type);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                connection.Open();
                if (ReturnDataTable)
                {
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                }
                sqlDataReader = sqlCommand.ExecuteReader();
                List<Material> rs = ReadValueFromReader();
                return rs;
            }
            finally
            {
                CloseResources();
            }
        }
        public override Material Insert(Material t)
        {
            try
            {
                sqlCommand = new SqlCommand(INSERT_QUERY, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Id", t.Id);
                sqlCommand.Parameters.AddWithValue("@Type", t.Type);
                sqlCommand.Parameters.AddWithValue("@RegisterCode", t.RegisterCode);
                sqlCommand.Parameters.AddWithValue("@Model", t.Model);
                sqlCommand.Parameters.AddWithValue("@Origin", t.Origin);
                sqlCommand.Parameters.AddWithValue("@ManufacturingDate", t.ManufacturingDate);
                sqlCommand.Parameters.AddWithValue("@CurrentKm", t.CurrentKm);
                sqlCommand.Parameters.AddWithValue("@OilWarning", t.OilWarning);
                sqlCommand.Parameters.AddWithValue("@Notes", t.Notes);
                sqlCommand.Parameters.AddWithValue("@Status", t.Status);
                sqlCommand.Parameters.AddWithValue("@DvId", t.DvId);
                sqlCommand.Parameters.AddWithValue("@InsertDate", t.InsertDate);
                connection.Open();
                int status = sqlCommand.ExecuteNonQuery();
                if (status <= 0)
                {
                    throw new Exception("Fail to insert Material with id=" + t.Id);
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

        public override List<Material> ReadValueFromReader()
        {
            List<Material> rs = new List<Material>();
            Material material;
            while (sqlDataReader.Read())
            {
                material = new Material
                {
                    Id = sqlDataReader["Id"].ToString(),
                    Type = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Type")),
                    RegisterCode = sqlDataReader["RegisterCode"].ToString(),
                    Model = sqlDataReader["Model"].ToString(),
                    Origin = sqlDataReader["Origin"].ToString(),
                    ManufacturingDate = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("ManufacturingDate")),
                    CurrentKm = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("CurrentKm")),
                    OilWarning = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("OilWarning")),
                    Notes = sqlDataReader["Notes"].ToString(),
                    Status = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                    DvId = sqlDataReader["DvId"].ToString(),
                    InsertDate = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("InsertDate")),
                };
                rs.Add(material);
            }
            return rs;
        }
    }
}
