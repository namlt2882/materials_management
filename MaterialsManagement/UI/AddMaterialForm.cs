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
            IEnumerable<MaterialEnum> enums = Enum.GetValues(typeof(MaterialEnum))
                .Cast<MaterialEnum>();
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
                ManufacturingDate = dtpManufactureDate.Value.Date,
                CurrentKm = Convert.ToInt32(nbCurrentKm.Value),
                OilWarning = Convert.ToInt32(nbOilWarning.Value),
                Notes = tbNote.Text,
                DvId = dv.Id
            };
            try
            {
                Material rs = new MaterialService().Add(material);
            }catch(Exception ex)
            {
                MessageBox.Show("Tác vụ không thành công, hãy thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
