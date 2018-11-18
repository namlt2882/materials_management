using MaterialsManagement.Common;
using MaterialsManagement.Model;
using MaterialsManagement.Service;
using MaterialsManagement.Utility;
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
    public partial class EditMaterialForm : Form
    {
        public delegate void AfterEditedCallBack(Material material);
        public AfterEditedCallBack afterEditedCallBack { get; set; }
        public Qk qk { get; set; }
        public Dv dv { get; set; }
        public Material material { get; set; }
        public int materialType;
        public EditMaterialForm(Material material) : this()
        {
            this.material = material;
            dv = new DvService().Get(material.DvId);
            qk = new QkService().Get(dv.QkId);
            InitOriginInfo();
        }
        public EditMaterialForm()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }
        private void InitOriginInfo()
        {
            if (qk != null)
            {
                lbQk.Text = "Quân khu: " + qk.Name.Trim() + " (" + qk.Id.Trim() + ")";
            }
            if (dv != null)
            {
                lbDv.Text = "Đơn vị: " + dv.Name.Trim() + " (" + dv.Id.Trim() + ")";
            }
            //set type text box
            IEnumerable<MaterialEnum> enums = Enum.GetValues(typeof(MaterialEnum))
                .Cast<MaterialEnum>();
            foreach (MaterialEnum e in enums)
            {
                if (material.Type == (int)e)
                {
                    tbType.Text = EnumExtensions.GetDisplayName(e);
                    break;
                }
            }
            //material attribute
            tbId.Text = material.Id;
            tbRegisterCode.Text = StringUtility.TrimIfPresent(material.RegisterCode);
            tbModel.Text = StringUtility.TrimIfPresent(material.Model);
            tbOrigin.Text = StringUtility.TrimIfPresent(material.Origin);
            dtpManufactureDate.Value = material.ManufacturingDate;
            nbOilWarning.Value = material.OilWarning;
            tbNote.Text = StringUtility.TrimIfPresent(material.Notes);
            tbController.Text = StringUtility.TrimIfPresent(material.Controller);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            material.RegisterCode = tbRegisterCode.Text;
            material.Model = tbModel.Text;
            material.Controller = tbController.Text;
            material.Origin = tbOrigin.Text;
            material.ManufacturingDate = dtpManufactureDate.Value;
            material.OilWarning = Convert.ToInt32(nbOilWarning.Value);
            material.Notes = tbNote.Text;
            try
            {
                new MaterialService().Update(material);
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

        private void btnUpdateEnable_Click(object sender, EventArgs e)
        {
            tbRegisterCode.ReadOnly = false;
            tbModel.ReadOnly = false;
            tbController.ReadOnly = false;
            tbOrigin.ReadOnly = false;
            dtpManufactureDate.Enabled = true;
            nbOilWarning.ReadOnly = false;
            tbNote.ReadOnly = false;
            btnUpdate.Visible = true;
            btnUpdateEnable.Visible = false;
            
        }
    }
}
