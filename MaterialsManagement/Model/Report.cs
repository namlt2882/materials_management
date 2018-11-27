Report

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Model
{
    class Report
    {
        public List<Qk> qks { get; set; }
        public List<Dv> dvs { get; set; }
        public List<Material> materials { get; set; }
        public Report(List<Qk> qks, List<Dv> dvs, List<Material> materials)
        {
            this.qks = qks;
            this.dvs = dvs;
            this.materials = materials;
        }
        public Report()
        {
            qks = new List<Qk>();
            dvs = new List<Dv>();
            materials = new List<Material>();
        }
    }
}
