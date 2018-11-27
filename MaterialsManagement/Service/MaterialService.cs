using MaterialsManagement.Common;
using MaterialsManagement.Model;
using MaterialsManagement.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Service
{
    public class MaterialService
    {
        public Material Add(Material material)
        {
            Random random = new Random();
            //format of new id: qkId + dvId + type + Current time + random number (0-9999)
            string newId = material.qk.Id.Trim() + "-" +
                material.dv.Id.Trim() + "-" + 
                material.Type + "-" + 
                DateTime.Now.Ticks + "-" + 
                random.Next(0, 9999).ToString("D4");
            material.Id = newId;
            material.Status = (int)MaterialStatusEnum.ACTIVE;
            DateTime now = DateTime.Now;
            material.InsertDate = now;
            material.LastUpdate = now;
            material.LastChangeOil = material.CurrentKm;
            Material rs = new MaterialRepository().Insert(material);
            return rs;
        }

        public void Update(Material material)
        {
            MaterialRepository repository = new MaterialRepository();
            Material origin = repository.Get(material.Id.Trim());
            Copy(material, origin);
            origin.LastUpdate = DateTime.Now;
            repository.Update(origin);
        }

        public void UpdateCurrentKm(Material material)
        {
            MaterialRepository repository = new MaterialRepository();
            Material origin = repository.Get(material.Id.Trim());
            origin.CurrentKm = material.CurrentKm;
            origin.LastChangeOil = material.LastChangeOil;
            origin.LastUpdate = DateTime.Now;
            repository.Update(origin);
        }

        public void Copy(Material origin, Material des)
        {
            des.RegisterCode = origin.RegisterCode;
            des.Model = origin.Model;
            des.Controller = origin.Controller;
            des.Origin = origin.Origin;
            des.ManufacturingDate = origin.ManufacturingDate;
            des.OilWarning = origin.OilWarning;
            des.Notes = origin.Notes;
        }

        public DataTable GetByTypeAsDataTable(string DvId, int Type)
        {
            MaterialRepository repository = new MaterialRepository(true);
            repository.GetByType(DvId, Type);
            DataTable rs = repository.dataTable;
            return rs;
        }
        public Material Get(string Id)
        {
            return new MaterialRepository().Get(Id);
        }
    }
}
