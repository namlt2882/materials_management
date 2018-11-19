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
using System.Threading;


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
            //Huy QRCode: 11/19/2018 Add Start
            QRCodeService qr = new QRCodeService();
            if(qr != null) {
                Bitmap img = qr.GenerateQRCode(material.ToString(),10, pbQRCode.Height, pbQRCode.Width);
                pbQRCode.Image = img;
            }
            
            //Huy QRCode: 11/19/2018 Add End
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

        private void btnGetQrCode_Click(object sender, EventArgs e)
        {
            //Huy QRCode: 11/20/2018 Add Start
            string selectedPath;
            var t = new Thread((ThreadStart)(() => {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedPath = folderDialog.SelectedPath;
                         QRCodeService qr = new QRCodeService();
                        if (qr != null)
                        {
                            qr.GenerateQRCode(material.ToString(),10,300,300).Save(selectedPath+"\\"+ StringUtility.TrimIfPresent(material.Id)+"-"+ DateTime.Today.ToString("ddMMyyyy")+".png");
                            MessageBox.Show("Tải QRCode Thành Công","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            MessageBox.Show("Không Thể Tải QRCode","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error,
     MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                }

            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            //Huy QRCode: 11/20/2018 Add End
        }
    }
}
