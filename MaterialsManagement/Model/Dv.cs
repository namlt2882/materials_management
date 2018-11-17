using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Model
{
    public class Dv
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string QkId { get; set; }
        public int Priority { get; set; }
        public Dv(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Dv()
        {
        }
    }
}
