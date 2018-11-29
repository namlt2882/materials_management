using MaterialsManagement.Common;
using MaterialsManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.ApiModel
{
    public class SingletonModelProvider
    {
        private static List<MaterialGroupLabel> materialGroupList;
        private static List<MaterialLabel> materialLabelList;
        private static List<MaterialUseStatus> materialUseStatusList;
        private static List<MaterialType> materialTypeList;
        public static MaterialGroupLabel GetMaterialGroupLabelModel(int value)
        {
            List<MaterialGroupLabel> l = GetMaterialGroupLabelModels();
            foreach(var i in l)
            {
                if (i.Id == value)
                {
                    return i;
                }
            }
            return null;
        }
        public static List<MaterialGroupLabel> GetMaterialGroupLabelModels()
        {
            if (materialGroupList != null)
            {
                return materialGroupList;
            }
            IEnumerable<MaterialGroupLabelEnum> enums = EnumExtensions
                .GetEnumList<MaterialGroupLabelEnum>(typeof(MaterialGroupLabelEnum));
            MaterialGroupLabel tmp;
            materialGroupList = new List<MaterialGroupLabel>();
            foreach (var e in enums)
            {
                tmp = new MaterialGroupLabel
                {
                    Id = (int)e,
                    Name = EnumExtensions.GetDisplayName(e)
                };
                materialGroupList.Add(tmp);
            }
            return materialGroupList;
        }
        public static MaterialLabel GetMaterialLabelModel(int value)
        {
            List<MaterialLabel> l = GetMaterialLabelModels();
            foreach (var i in l)
            {
                if (i.Id == value)
                {
                    return i;
                }
            }
            return null;
        }
        public static List<MaterialLabel> GetMaterialLabelModels()
        {
            if (materialLabelList != null)
            {
                return materialLabelList;
            }
            IEnumerable<MaterialLabelEnum> enums = EnumExtensions
                .GetEnumList<MaterialLabelEnum>(typeof(MaterialLabelEnum));
            MaterialLabel tmp;
            materialLabelList = new List<MaterialLabel>();
            foreach (var e in enums)
            {
                tmp = new MaterialLabel
                {
                    Id = (int)e,
                    Name = EnumExtensions.GetDisplayName(e)
                };
                materialLabelList.Add(tmp);
            }
            return materialLabelList;
        }
        public static MaterialUseStatus GetMaterialUseStatusModel(int value)
        {
            List<MaterialUseStatus> l = GetMaterialUseStatusModels();
            foreach (var i in l)
            {
                if (i.Id == value)
                {
                    return i;
                }
            }
            return null;
        }
        public static List<MaterialUseStatus> GetMaterialUseStatusModels()
        {
            if (materialUseStatusList != null)
            {
                return materialUseStatusList;
            }
            IEnumerable<MaterialUseStatusEnum> enums = EnumExtensions
                .GetEnumList<MaterialUseStatusEnum>(typeof(MaterialUseStatusEnum));
            MaterialUseStatus tmp;
            materialUseStatusList = new List<MaterialUseStatus>();
            foreach (var e in enums)
            {
                tmp = new MaterialUseStatus
                {
                    Id = (int)e,
                    Name = EnumExtensions.GetDisplayName(e)
                };
                materialUseStatusList.Add(tmp);
            }
            return materialUseStatusList;
        }
        public static MaterialType GetMaterialTypeModel(int value)
        {
            List<MaterialType> l = GetMaterialTypeModels();
            foreach (var i in l)
            {
                if (i.Id == value)
                {
                    return i;
                }
            }
            return null;
        }
        public static List<MaterialType> GetMaterialTypeModels()
        {
            if (materialTypeList != null)
            {
                return materialTypeList;
            }
            IEnumerable<MaterialTypeEnum> enums = EnumExtensions
                .GetEnumList<MaterialTypeEnum>(typeof(MaterialTypeEnum));
            MaterialType tmp;
            materialTypeList = new List<MaterialType>();
            foreach (var e in enums)
            {
                tmp = new MaterialType
                {
                    Id = (int)e,
                    Name = EnumExtensions.GetDisplayName(e)
                };
                materialTypeList.Add(tmp);
            }
            return materialTypeList;
        }
    }
}
