using MaterialsManagement.ApiModel;
using MaterialsManagement.Common;
using MaterialsManagement.Model;
using MaterialsManagement.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsManagement.UI
{
    public partial class AddMaterialForm : Form
    {
        public delegate void AfterAddCallBack(Material material);
        public AfterAddCallBack afterAddCallBack { get; set; }
        public Qk qk { get; set; }
        public Dv dv { get; set; }
        public int materialType;
        public AddMaterialForm(Dv dv, int DefaultMaterialType) : this()
        {
            this.dv = dv;
            qk = new QkService().Get(dv.QkId);
            InitFixedInfoPanel();
            SetSelectedMaterialType(DefaultMaterialType);
        }
        public AddMaterialForm()
        {
            InitializeComponent();
            InitTypeCombobox();
            DateTime currentTime = DateTime.Now;
            dtpManufactureDate.Value = currentTime;
            dtpRecentSclYear.Value = currentTime;
            dtpRegisterYear.Value = currentTime;
            dtpStartUsingYear.Value = currentTime;
        }
        private void InitFixedInfoPanel()
        {
            if (qk != null)
            {
                lbQk.Text = "Quân khu: " + qk.Name.Trim() + " (" + qk.Id.Trim() + ")";
            }
            if (dv != null)
            {
                lbDv.Text = "Đơn vị: " + dv.Name.Trim() + " (" + dv.Id.Trim() + ")";
            }
        }

        private void InitTypeCombobox()
        {
            IEnumerable<MaterialTypeEnum> enums = Enum.GetValues(typeof(MaterialTypeEnum))
                .Cast<MaterialTypeEnum>();
            MaterialType materialType;
            foreach (var enumItem in enums)
            {
                materialType = new MaterialType
                {
                    Id = (int)enumItem,
                    Name = EnumExtensions.GetDisplayName(enumItem)
                };
                cbType.Items.Add(materialType);
            }
            cbType.SelectedIndex = 0;

            var list1 = SingletonModelProvider.GetMaterialGroupLabelModels();
            foreach (var i in list1)
            {
                cbGroupLabel.Items.Add(i);
            }
            cbGroupLabel.SelectedIndex = 0;
            var list2 = SingletonModelProvider.GetMaterialLabelModels();
            foreach (var i in list2)
            {
                cbLabel.Items.Add(i);
            }
            cbLabel.SelectedIndex = 0;
            var list3 = SingletonModelProvider.GetMaterialUseStatusModels();
            foreach (var i in list3)
            {
                cbUseStatus.Items.Add(i);
            }
            cbUseStatus.SelectedIndex = 0;
        }

        private void SetSelectedMaterialType(int SelectedType)
        {
            int selectedIndex = 0;
            foreach (var i in cbType.Items)
            {
                var tmp = (MaterialType)i;
                if (tmp.Id == SelectedType)
                {
                    break;
                }
                selectedIndex++;
            }
            cbType.SelectedIndex = selectedIndex;
        }

        private MaterialType GetSelectedMaterialType()
        {
            return cbType.SelectedItem as MaterialType;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaterialType materialType = GetSelectedMaterialType();
            Material material = new Material
            {
                Type = materialType.Id,
                RegisterCode = tbRegisterCode.Text,
                Model = tbModel.Text,
                Origin = tbOrigin.Text,
                Controller = tbController.Text,
                ManufacturingDate = dtpManufactureDate.Value.Date,
                CurrentKm = Convert.ToInt32(nbCurrentKm.Value),
                OilWarning = Convert.ToInt32(nbOilWarning.Value),
                Notes = tbNote.Text,
                DvId = dv.Id,
                qk = this.qk,
                dv = this.dv,

                RegisterYear = dtpRegisterYear.Value.Date,
                Label = (cbLabel.SelectedItem as MaterialLabel).Id,
                FrameNumber = tbFrameNumber.Text,
                EIN = tbEIN.Text,
                OriginalExplanation = tbOriginExplanation.Text,
                StartUsingYear = dtpStartUsingYear.Value.Date,
                ClLevel = Convert.ToInt32(nbClLevel.Value),
                SclTime = Convert.ToInt32(nbSclTime.Value),
                RecentSclYear = dtpRecentSclYear.Value.Date,
                GroupLabel = (cbGroupLabel.SelectedItem as MaterialGroupLabel).Id,
                UseStatus = (cbUseStatus.SelectedItem as MaterialUseStatus).Id,
                GndkNumber = Convert.ToInt32(nbGndkNumber.Value),
                AcceptCode = tbAcceptCode.Text,
                TypeDescription = tbTypeDescription.Text
            };
            try
            {
                Material rs = new MaterialService().Add(material);
                if (afterAddCallBack != null)
                {
                    afterAddCallBack(rs);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tác vụ không thành công, hãy thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
