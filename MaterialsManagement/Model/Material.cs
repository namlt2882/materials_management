using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Model
{
    public class Material
    {
        public string Id { get; set; }
        public int Type { get; set; }
        public string RegisterCode { get; set; }
        public string Model { get; set; }
        public string Origin { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int CurrentKm { get; set; }
        public int LastChangeOil { get; set; }
        public int OilWarning { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; }
        public string DvId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public Dv dv { get; set; }
        public Qk qk { get; set; }
        public string Controller { get; set; }
        public Material()
        {
        }
    }
}
