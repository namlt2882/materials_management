using MaterialsManagement.Common;
using MaterialsManagement.Model;
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
                lbQk.Text = "Quân khu: " + qk.Name + " (" + qk.Id + ")";
            }
            if (dv != null)
            {
                lbDv.Text = "Đơn vị: " + dv.Name + " (" + dv.Id + ")";
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
        }
    }
}
