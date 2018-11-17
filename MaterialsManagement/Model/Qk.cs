using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Model
{
    public class Qk
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Qk(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Qk()
        {
        }
    }
}
