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
            "UseStatus, GndkNumber, AcceptCode, TypeDescription, OwnedBy) " +
            "VALUES(@Id, @Type, @RegisterCode, @Model, @Origin," +
            "@ManufacturingDate, @CurrentKm, @OilWarning, @Notes, @Status," +
            "@DvId, @InsertDate, @Controller, @LastUpdate, @LastChangeOil," +
            "@RegisterYear, @Label, @FrameNumber, @EIN, @OriginalExplanation," +
            "@StartUsingYear, @ClLevel, @SclTime, @RecentSclYear, @GroupLabel," +
            "@UseStatus, @GndkNumber, @AcceptCode, @TypeDescription, @OwnedBy)";
        private static readonly string UPDATE_QUERY = "UPDATE Material " +
            "SET Type=@Type, RegisterCode=@RegisterCode, Model=@Model," +
            "Origin=@Origin, ManufacturingDate=@ManufacturingDate," +
            "CurrentKm=@CurrentKm, OilWarning=@OilWarning, Notes=@Notes," +
            "Status=@Status, DvId=@DvId, Controller=@Controller ," +
            "LastUpdate=@LastUpdate, LastChangeOil=@LastChangeOil, " +
            "RegisterYear=@RegisterYear, Label=@Label, FrameNumber=@FrameNumber, " +
            "EIN=@EIN, OriginalExplanation=@OriginalExplanation," +
            "StartUsingYear=@StartUsingYear, ClLevel=@ClLevel, " +
            "SclTime=@SclTime, RecentSclYear=@RecentSclYear, GroupLabel=@GroupLabel," +
            "UseStatus=@UseStatus, GndkNumber=@GndkNumber, " +
            "AcceptCode=@AcceptCode, TypeDescription=@TypeDescription, " +
            "OwnedBy=@OwnedBy " +
            "WHERE Id=@Id";
        private static readonly string QUERY_BY_TYPE_AND_DVID = "SELECT " +
            "Id, Type, RegisterCode, Model, Origin," +
            "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
            "DvId, InsertDate, Controller, LastUpdate, LastChangeOil, " +
            "RegisterYear, Label, FrameNumber, EIN, OriginalExplanation," +
            "StartUsingYear, ClLevel, SclTime, RecentSclYear, GroupLabel," +
            "UseStatus, GndkNumber, AcceptCode, TypeDescription, OwnedBy " +
            "FROM Material WHERE Type=@Type AND DvId=@DvId AND Status=" + (int)MaterialStatusEnum.ACTIVE +
            " ORDER BY InsertDate DESC";
        private static readonly string QUERY_BY_ID = "SELECT " +
            "Id, Type, RegisterCode, Model, Origin," +
            "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
            "DvId, InsertDate, Controller, LastUpdate, LastChangeOil, " +
            "RegisterYear, Label, FrameNumber, EIN, OriginalExplanation," +
            "StartUsingYear, ClLevel, SclTime, RecentSclYear, GroupLabel," +
            "UseStatus, GndkNumber, AcceptCode, TypeDescription, OwnedBy " +
            "FROM Material WHERE Id=@Id";
        private static readonly string QUERY_GET_ALL_BY_DV = "SELECT " +
        "Id, Type, RegisterCode, Model, Origin," +
        "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
        "DvId, InsertDate, Controller, LastUpdate, LastChangeOil, " +
            "RegisterYear, Label, FrameNumber, EIN, OriginalExplanation," +
            "StartUsingYear, ClLevel, SclTime, RecentSclYear, GroupLabel," +
            "UseStatus, GndkNumber, AcceptCode, TypeDescription, OwnedBy " +
        "FROM Material WHERE DvId=@DvId AND Status=" + (int)MaterialStatusEnum.ACTIVE;
        private static readonly string QUERY_GET_ALL = "SELECT " +
          "Id, Type, RegisterCode, Model, Origin," +
          "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
          "DvId, InsertDate, Controller, LastUpdate, LastChangeOil, " +
            "RegisterYear, Label, FrameNumber, EIN, OriginalExplanation," +
            "StartUsingYear, ClLevel, SclTime, RecentSclYear, GroupLabel," +
            "UseStatus, GndkNumber, AcceptCode, TypeDescription, OwnedBy " +
          "FROM Material";
        private static readonly string QUERY_SEARCH_BY_TYPE_AND_DVID = "SELECT " +
          "Id, Type, RegisterCode, Model, Origin," +
          "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
          "DvId, InsertDate, Controller, LastUpdate, LastChangeOil, " +
            "RegisterYear, Label, FrameNumber, EIN, OriginalExplanation," +
            "StartUsingYear, ClLevel, SclTime, RecentSclYear, GroupLabel," +
            "UseStatus, GndkNumber, AcceptCode, TypeDescription, OwnedBy " +
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
        public List<Material> GetByType(string DvId, int Type)
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
                AddWithValue("@Id", t.Id);
                AddWithValue("@Type", t.Type);
                AddWithValue("@RegisterCode", t.RegisterCode);
                AddWithValue("@Model", t.Model);
                AddWithValue("@Origin", t.Origin);
                AddWithValue("@Controller", t.Controller);
                AddWithValue("@ManufacturingDate", t.ManufacturingDate);
                AddWithValue("@CurrentKm", t.CurrentKm);
                AddWithValue("@LastChangeOil", t.LastChangeOil);
                AddWithValue("@OilWarning", t.OilWarning);
                AddWithValue("@Notes", t.Notes);
                AddWithValue("@Status", t.Status);
                AddWithValue("@DvId", t.DvId);
                AddWithValue("@InsertDate", t.InsertDate);
                AddWithValue("@LastUpdate", t.LastUpdate);

                AddWithValue("@RegisterYear", t.RegisterYear);
                AddWithValue("@Label", t.Label);
                AddWithValue("@FrameNumber", t.FrameNumber);
                AddWithValue("@EIN", t.EIN);
                AddWithValue("@OriginalExplanation", t.OriginalExplanation);
                AddWithValue("@StartUsingYear", t.StartUsingYear);
                AddWithValue("@ClLevel", t.ClLevel);
                AddWithValue("@SclTime", t.SclTime);
                AddWithValue("@RecentSclYear", t.RecentSclYear);
                AddWithValue("@GroupLabel", t.GroupLabel);
                AddWithValue("@UseStatus", t.UseStatus);
                AddWithValue("@GndkNumber", t.GndkNumber);
                AddWithValue("@AcceptCode", t.AcceptCode);
                AddWithValue("@TypeDescription", t.TypeDescription);

                AddWithValue("@OwnedBy", t.OwnedBy);
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
        string GetString(string columnName)
        {
            object o = sqlDataReader[columnName];
            if (o == DBNull.Value)
            {
                return null;
            }
            return (string)o;
        }
        public int GetInt32(int ordinal)
        {
            return (sqlDataReader.IsDBNull(ordinal) ? 0 : sqlDataReader.GetInt32(ordinal));
        }

        public DateTime GetDateTime(int ordinal)
        {
            return (sqlDataReader.IsDBNull(ordinal) ? DateTime.Now : sqlDataReader.GetDateTime(ordinal));
        }
        public override List<Material> ReadValueFromReader()
        {
            List<Material> rs = new List<Material>();
            Material material;
            while (sqlDataReader.Read())
            {
                material = new Material
                {
                    Id = GetString("Id"),
                    Type = GetInt32(sqlDataReader.GetOrdinal("Type")),
                    RegisterCode = GetString("RegisterCode"),
                    Model = GetString("Model"),
                    Origin = GetString("Origin"),
                    Controller = GetString("Controller"),
                    ManufacturingDate = GetDateTime(sqlDataReader.GetOrdinal("ManufacturingDate")),
                    CurrentKm = GetInt32(sqlDataReader.GetOrdinal("CurrentKm")),
                    LastChangeOil = GetInt32(sqlDataReader.GetOrdinal("LastChangeOil")),
                    OilWarning = GetInt32(sqlDataReader.GetOrdinal("OilWarning")),
                    Notes = GetString("Notes"),
                    Status = GetInt32(sqlDataReader.GetOrdinal("Status")),
                    DvId = GetString("DvId"),
                    InsertDate = GetDateTime(sqlDataReader.GetOrdinal("InsertDate")),
                    LastUpdate = GetDateTime(sqlDataReader.GetOrdinal("LastUpdate")),

                    RegisterYear = GetDateTime(sqlDataReader.GetOrdinal("RegisterYear")),
                    Label = GetInt32(sqlDataReader.GetOrdinal("Label")),
                    FrameNumber = GetString("FrameNumber"),
                    EIN = GetString("EIN"),
                    OriginalExplanation = GetString("OriginalExplanation"),
                    StartUsingYear = GetDateTime(sqlDataReader.GetOrdinal("StartUsingYear")),
                    ClLevel = GetInt32(sqlDataReader.GetOrdinal("ClLevel")),
                    SclTime = GetInt32(sqlDataReader.GetOrdinal("SclTime")),
                    RecentSclYear = GetDateTime(sqlDataReader.GetOrdinal("RecentSclYear")),
                    GroupLabel = GetInt32(sqlDataReader.GetOrdinal("GroupLabel")),
                    UseStatus = GetInt32(sqlDataReader.GetOrdinal("UseStatus")),
                    GndkNumber = GetInt32(sqlDataReader.GetOrdinal("GndkNumber")),
                    AcceptCode = GetString("AcceptCode"),
                    TypeDescription = GetString("TypeDescription"),
                    OwnedBy = GetString("OwnedBy")
                };
                rs.Add(material);
            }
            return rs;
        }
        void AddWithValue(string ColumnName, object o)
        {
            if (o != null)
            {
                sqlCommand.Parameters.AddWithValue(ColumnName, o);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue(ColumnName, DBNull.Value);
            }
        }
        public override void Update(Material t)
        {
            try
            {
                sqlCommand = new SqlCommand(UPDATE_QUERY, GetSqlConnection());
                AddWithValue("@Id", t.Id);
                AddWithValue("@Type", t.Type);
                AddWithValue("@RegisterCode", t.RegisterCode);
                AddWithValue("@Model", t.Model);

                AddWithValue("@Origin", t.Origin);
                AddWithValue("@Controller", t.Controller);
                AddWithValue("@ManufacturingDate", t.ManufacturingDate);
                AddWithValue("@CurrentKm", t.CurrentKm);
                AddWithValue("@LastChangeOil", t.LastChangeOil);
                AddWithValue("@OilWarning", t.OilWarning);
                AddWithValue("@Notes", t.Notes);
                AddWithValue("@Status", t.Status);
                AddWithValue("@DvId", t.DvId);
                AddWithValue("@LastUpdate", t.LastUpdate);

                AddWithValue("@RegisterYear", t.RegisterYear);
                AddWithValue("@Label", t.Label);
                AddWithValue("@FrameNumber", t.FrameNumber);
                AddWithValue("@EIN", t.EIN);
                AddWithValue("@OriginalExplanation", t.OriginalExplanation);
                AddWithValue("@StartUsingYear", t.StartUsingYear);
                AddWithValue("@ClLevel", t.ClLevel);
                AddWithValue("@SclTime", t.SclTime);
                AddWithValue("@RecentSclYear", t.RecentSclYear);
                AddWithValue("@GroupLabel", t.GroupLabel);
                AddWithValue("@UseStatus", t.UseStatus);
                AddWithValue("@GndkNumber", t.GndkNumber);
                AddWithValue("@AcceptCode", t.AcceptCode);
                AddWithValue("@TypeDescription", t.TypeDescription);

                AddWithValue("@OwnedBy", t.OwnedBy);
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
