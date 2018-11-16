using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Common
{
    public enum MaterialEnum
    {
        [Display(Name = "Tàu, thuyền")]
        Sail = 1,
        [Display(Name = "Ô tô")]
        Car = 2,
        [Display(Name = "Vũ khí")]
        Weapon = 3
    }
}
