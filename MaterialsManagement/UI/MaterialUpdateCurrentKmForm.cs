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
    public partial class MaterialUpdateCurrentKmForm : Form
    {
        public delegate void AfterEditedCallBack(Material material);
        public AfterEditedCallBack afterEditedCallBack { get; set; }
        public Material material { get; set; }

        public MaterialUpdateCurrentKmForm(Material material) : this()
        {
            this.material = material;
            InitFixedInfo();
        }

        public MaterialUpdateCurrentKmForm()
        {
            InitializeComponent();
        }

        private void InitFixedInfo()
        {
            //set type text box
            IEnumerable<MaterialTypeEnum> enums = Enum.GetValues(typeof(MaterialTypeEnum))
                .Cast<MaterialTypeEnum>();
            foreach (MaterialTypeEnum e in enums)
            {
                if (material.Type == (int)e)
                {
                    tbType.Text = EnumExtensions.GetDisplayName(e);
                    break;
                }
            }
            //set other attributes
            tbId.Text = material.Id;
            tbCurrentKm.Text = material.CurrentKm + " Km";
            tbOilWarning.Text = material.OilWarning + " Km";
            tbLastChangeOil.Text = material.LastChangeOil + " Km";
            nbNewKm.Minimum = material.CurrentKm;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int limit = material.LastChangeOil + material.OilWarning;
            int newKm = Convert.ToInt32(nbNewKm.Value);
            if (!cbIsChangeOil.Checked)
            {
                if (newKm >= limit)
                {
                    //update without change oil
                    var confirmResult = MessageBox.Show("Phương tiện này nên được thay nhớt, tiếp tục cập nhật?",
                                         "Cảnh báo",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            else
            {
                //update but change oil
                material.LastChangeOil = newKm;
            }
            material.CurrentKm = newKm;
            try
            {
                new MaterialService().UpdateCurrentKm(material);
                if (afterEditedCallBack != null)
                {
                    afterEditedCallBack(material);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi. Thao tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
