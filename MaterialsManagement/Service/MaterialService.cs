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
        public Material AddFromOthers(Material material)
        {
            Material rs = new MaterialRepository().Insert(material);
            return rs;
        }

        public void UpdateFromOthers(Material material)
        {
            MaterialRepository repository = new MaterialRepository();
            repository.Update(material);
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

            des.RegisterYear = origin.RegisterYear;
            des.Label = origin.Label;
            des.FrameNumber = origin.FrameNumber;
            des.EIN = origin.EIN;
            des.OriginalExplanation = origin.OriginalExplanation;
            des.StartUsingYear = origin.StartUsingYear;
            des.ClLevel = origin.ClLevel;
            des.SclTime = origin.SclTime;
            des.RecentSclYear = origin.RecentSclYear;
            des.GroupLabel = origin.GroupLabel;
            des.UseStatus = origin.UseStatus;
            des.GndkNumber = origin.GndkNumber;
            des.AcceptCode = origin.AcceptCode;
            des.TypeDescription = origin.TypeDescription;
            des.OwnedBy = origin.OwnedBy;
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
        public DataTable SearchByTypeAsDataTable(string DvId, int Type, String searchValue)
        {
            MaterialRepository repository = new MaterialRepository(true);
            repository.SearchByType(DvId, Type, searchValue);
            DataTable rs = repository.dataTable;
            return rs;
        }
        public List<Material> GetByType(string DvId, int Type)
        {
            MaterialRepository repository = new MaterialRepository(true);
            return repository.GetByType(DvId, Type);
        }
        
        public List<Material> GetAllByDv(String dv)
        {
            return new MaterialRepository().GetAllByQkDv(dv);
        }
        public List<Material> GetAll()
        {
            return new MaterialRepository().GetAll();
        }

        public void Delete(string id)
        {
            if (id== null)
                {
                throw new Exception("Null Id");
                }
            MaterialRepository repository = new MaterialRepository();
            Material origin = repository.Get(id.Trim());
            origin.Status = (int)MaterialStatusEnum.DISABLE;
            repository.Update(origin);
        }

    }
}
