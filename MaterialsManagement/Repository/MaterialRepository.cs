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
            "DvId, InsertDate, Controller, LastUpdate, LastChangeOil," +
            "RegisterYear, Label, FrameNumber, EIN, OriginalExplanation," +
            "StartUsingYear, ClLevel, SclTime, RecentSclYear, GroupLabel," +
            "UseStatus, GndkNumber, AcceptCode, TypeDescription) " +
            "VALUES(@Id, @Type, @RegisterCode, @Model, @Origin," +
            "@ManufacturingDate, @CurrentKm, @OilWarning, @Notes, @Status," +
            "@DvId, @InsertDate, @Controller, @LastUpdate, @LastChangeOil," +
            "@RegisterYear, @Label, @FrameNumber, @EIN, @OriginalExplanation," +
            "@StartUsingYear, @ClLevel, @SclTime, @RecentSclYear, @GroupLabel," +
            "@UseStatus, @GndkNumber, @AcceptCode, @TypeDescription)";
        private static readonly string UPDATE_QUERY = "UPDATE Material " +
            "SET Type=@Type, RegisterCode=@RegisterCode, Model=@Model," +
            "Origin=@Origin, ManufacturingDate=@ManufacturingDate," +
            "CurrentKm=@CurrentKm, OilWarning=@OilWarning, Notes=@Notes," +
            "Status=@Status, DvId=@DvId, Controller=@Controller ," +
            "LastUpdate=@LastUpdate, LastChangeOil=@LastChangeOil " +
            "WHERE Id=@Id";
        private static readonly string QUERY_BY_TYPE_AND_DVID = "SELECT " +
            "Id, Type, RegisterCode, Model, Origin," +
            "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
            "DvId, InsertDate, Controller, LastUpdate, LastChangeOil " +
            "FROM Material WHERE Type=@Type AND DvId=@DvId AND Status=" + (int)MaterialStatusEnum.ACTIVE+
            " ORDER BY InsertDate DESC";
        private static readonly string QUERY_BY_ID = "SELECT " +
            "Id, Type, RegisterCode, Model, Origin," +
            "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
            "DvId, InsertDate, Controller, LastUpdate, LastChangeOil " +
            "FROM Material WHERE Id=@Id";
        private static readonly string QUERY_GET_ALL_BY_DV = "SELECT " +
        "Id, Type, RegisterCode, Model, Origin," +
        "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
        "DvId, InsertDate, Controller, LastUpdate, LastChangeOil " +
        "FROM Material WHERE DvId=@DvId AND Status=" + (int)MaterialStatusEnum.ACTIVE;
        private static readonly string QUERY_GET_ALL = "SELECT " +
          "Id, Type, RegisterCode, Model, Origin," +
          "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
          "DvId, InsertDate, Controller, LastUpdate, LastChangeOil " +
          "FROM Material";
        private static readonly string QUERY_SEARCH_BY_TYPE_AND_DVID = "SELECT " +
          "Id, Type, RegisterCode, Model, Origin," +
          "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
          "DvId, InsertDate, Controller, LastUpdate, LastChangeOil " +
          "FROM Material WHERE Type=@Type AND DvId=@DvId AND (Id=@Id OR Model like @Model) AND Status=" + (int)MaterialStatusEnum.ACTIVE +
          " ORDER BY InsertDate DESC";
        public MaterialRepository(bool ReturnDataTable) : this()
        {
            this.ReturnDataTable = ReturnDataTable;
        }
        public MaterialRepository()
        {
        }
        public override Material Get(string Id)
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_BY_ID, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Id", Id);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                connection.Open();
                if (ReturnDataTable)
                {
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                }
                sqlDataReader = sqlCommand.ExecuteReader();
                List<Material> rs = ReadValueFromReader();
                return rs.DefaultIfEmpty(null).First();
            }
            finally
            {
                CloseResources();
            }
        }

        public override List<Material> GetAll()
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_GET_ALL, GetSqlConnection());
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
        public List<Material> GetAllByQkDv(String dv)
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_GET_ALL_BY_DV, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@dvId", dv.Trim());
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
        public List<Material> GetByType(string DvId,int Type)
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_BY_TYPE_AND_DVID, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Type", Type);
                sqlCommand.Parameters.AddWithValue("@DvId", DvId);
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
        public List<Material> SearchByType(string DvId, int Type, string searchValue)
        {
            try
            {
                sqlCommand = new SqlCommand(QUERY_SEARCH_BY_TYPE_AND_DVID, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Type", Type);
                sqlCommand.Parameters.AddWithValue("@DvId", DvId.Trim());
                sqlCommand.Parameters.AddWithValue("@Id", searchValue.Trim());
                sqlCommand.Parameters.AddWithValue("@Model", "%" + searchValue.Trim() + "%");
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
                sqlCommand.Parameters.AddWithValue("@Controller", t.Controller);
                sqlCommand.Parameters.AddWithValue("@ManufacturingDate", t.ManufacturingDate);
                sqlCommand.Parameters.AddWithValue("@CurrentKm", t.CurrentKm);
                sqlCommand.Parameters.AddWithValue("@LastChangeOil", t.LastChangeOil);
                sqlCommand.Parameters.AddWithValue("@OilWarning", t.OilWarning);
                sqlCommand.Parameters.AddWithValue("@Notes", t.Notes);
                sqlCommand.Parameters.AddWithValue("@Status", t.Status);
                sqlCommand.Parameters.AddWithValue("@DvId", t.DvId);
                sqlCommand.Parameters.AddWithValue("@InsertDate", t.InsertDate);
                sqlCommand.Parameters.AddWithValue("@LastUpdate", t.LastUpdate);

                sqlCommand.Parameters.AddWithValue("@RegisterYear", t.RegisterYear);
                sqlCommand.Parameters.AddWithValue("@Label", t.Label);
                sqlCommand.Parameters.AddWithValue("@FrameNumber", t.FrameNumber);
                sqlCommand.Parameters.AddWithValue("@EIN", t.EIN);
                sqlCommand.Parameters.AddWithValue("@OriginalExplanation", t.OriginalExplanation);
                sqlCommand.Parameters.AddWithValue("@StartUsingYear", t.StartUsingYear);
                sqlCommand.Parameters.AddWithValue("@ClLevel", t.ClLevel);
                sqlCommand.Parameters.AddWithValue("@SclTime", t.SclTime);
                sqlCommand.Parameters.AddWithValue("@RecentSclYear", t.RecentSclYear);
                sqlCommand.Parameters.AddWithValue("@GroupLabel", t.GroupLabel);
                sqlCommand.Parameters.AddWithValue("@UseStatus", t.UseStatus);
                sqlCommand.Parameters.AddWithValue("@GndkNumber", t.GndkNumber);
                sqlCommand.Parameters.AddWithValue("@AcceptCode", t.AcceptCode);
                sqlCommand.Parameters.AddWithValue("@TypeDescription", t.TypeDescription);
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
                    Controller = sqlDataReader["Controller"].ToString(),
                    ManufacturingDate = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("ManufacturingDate")),
                    CurrentKm = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("CurrentKm")),
                    LastChangeOil = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("LastChangeOil")),
                    OilWarning = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("OilWarning")),
                    Notes = sqlDataReader["Notes"].ToString(),
                    Status = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                    DvId = sqlDataReader["DvId"].ToString(),
                    InsertDate = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("InsertDate")),
                    LastUpdate = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("LastUpdate")),
                };
                rs.Add(material);
            }
            return rs;
        }

        public override void Update(Material t)
        {
            try
            {
                sqlCommand = new SqlCommand(UPDATE_QUERY, GetSqlConnection());
                sqlCommand.Parameters.AddWithValue("@Id", t.Id);
                sqlCommand.Parameters.AddWithValue("@Type", t.Type);
                sqlCommand.Parameters.AddWithValue("@RegisterCode", t.RegisterCode);
                sqlCommand.Parameters.AddWithValue("@Model", t.Model);
                sqlCommand.Parameters.AddWithValue("@Origin", t.Origin);
                sqlCommand.Parameters.AddWithValue("@Controller", t.Controller);
                sqlCommand.Parameters.AddWithValue("@ManufacturingDate", t.ManufacturingDate);
                sqlCommand.Parameters.AddWithValue("@CurrentKm", t.CurrentKm);
                sqlCommand.Parameters.AddWithValue("@LastChangeOil", t.LastChangeOil);
                sqlCommand.Parameters.AddWithValue("@OilWarning", t.OilWarning);
                sqlCommand.Parameters.AddWithValue("@Notes", t.Notes);
                sqlCommand.Parameters.AddWithValue("@Status", t.Status);
                sqlCommand.Parameters.AddWithValue("@DvId", t.DvId);
                sqlCommand.Parameters.AddWithValue("@LastUpdate", t.LastUpdate);
                connection.Open();
                int status = sqlCommand.ExecuteNonQuery();
                if (status <= 0)
                {
                    throw new Exception("Fail to update Material with id=" + t.Id);
                }
            }
            finally
            {
                CloseResources();
            }
        }
    }
}
