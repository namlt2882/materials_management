using MaterialsManagement.Common;
using MaterialsManagement.Model;
using MaterialsManagement.Repository;
using System;
using System.Collections.Generic;
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
            material.Status = (int)MaterialStatus.ACTIVE;
            Material rs = new MaterialRepository().Insert(material);
            return rs;
        }
    }
}
