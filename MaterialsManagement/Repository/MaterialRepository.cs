using MaterialsManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Repository
{
    public class MaterialRepository : BaseRepository<string, Material>
    {
        private static readonly string INSERT_QUERY = "INSERT INTO " +
            "Material(Id, Type, RegisterCode, Model, Origin," +
            "ManufacturingDate, CurrentKm, OilWarning, Notes, Status," +
            "DvId, InsertDate) " +
            "VALUES(@Id, @Type, @RegisterCode, @Model, @Origin," +
            "@ManufacturingDate, @CurrentKm, @OilWarning, @Notes, @Status," +
            "@DvId, @InsertDate)";
        public override Material Get(string id)
        {
            throw new NotImplementedException();
        }

        public override List<Material> GetAll()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
