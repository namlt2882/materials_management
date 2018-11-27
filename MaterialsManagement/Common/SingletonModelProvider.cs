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
    }
}
