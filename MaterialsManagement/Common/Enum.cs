using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Common
{
    public enum MaterialTypeEnum
    {
        [Display(Name = "Tàu, thuyền")]
        Sail = 1,
        [Display(Name = "Ô tô")]
        Car = 2,
        //[Display(Name = "Vũ khí")]
        //Weapon = 3
    }
    public enum MaterialStatusEnum
    {
        DISABLE = 0,
        ACTIVE = 1
    }
    public enum MaterialLabelEnum
    {
        [Display(Name = "Chỉ huy")]
        CHI_HUY = 1,
        [Display(Name = "Du lịch")]
        DU_LICH = 2,
        [Display(Name = "Xe ca")]
        XE_CA = 3,
        [Display(Name = "Vận tải")]
        VAN_TAI = 4,
        [Display(Name = "Cứu thương")]
        CUU_THUONG = 5,
        [Display(Name = "Khử độc")]
        KHU_DOC = 6,
        [Display(Name = "Cẩu")]
        CAU = 7,
        [Display(Name = "STEC")]
        STEC = 8
    }
    public enum MaterialGroupLabelEnum
    {
        [Display(Name = "Bảo đảm")]
        BAO_DAM = 1,
        [Display(Name = "Tác chiến")]
        TAC_CHIEN = 2,
        [Display(Name = "Thường xuyên")]
        THUONG_XUYEN = 3
    }
    public enum MaterialUseStatusEnum
    {
        [Display(Name = "Bảo đảm")]
        BAO_DAM = 1,
        [Display(Name = "Tác chiến")]
        TAC_CHIEN = 2,
        [Display(Name = "Thường xuyên")]
        THUONG_XUYEN = 3
    }
    public enum DvPriority
    {
        OFFICE = 1,
        SU_DOAN = 2,
        LU_DOAN = 3,
        TRUNG_DOAN = 4,
        TIEU_DOAN = 5,
        TP = 10,
        CTY = 11
    }
}
