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
    public enum MaterialStatus
    {
        DISABLE = 0,
        ACTIVE = 1
    }
    public enum DvPriority
    {
        OFFICE=1,
        SU_DOAN=2,
        LU_DOAN=3,
        TRUNG_DOAN=4,
        TIEU_DOAN=5,
        TP=10,
        CTY=11
    }
}
