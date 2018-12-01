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
using MaterialsManagement.ApiModel;

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
            nbClLevel.ReadOnly = true;
            nbGndkNumber.ReadOnly = true;
            nbOilWarning.ReadOnly = true;
            nbSclTime.ReadOnly = true;
            nbClLevel.Increment = 0;
            nbGndkNumber.Increment = 0;
            nbOilWarning.Increment = 0;
            nbSclTime.Increment = 0;
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
            List<MaterialType> types = SingletonModelProvider.GetMaterialTypeModels();
            foreach (MaterialType type in types)
            {
                if (material.Type == type.Id)
                {
                    lbType.Text = type.Name;
                    break;
                }
            }
            //material attribute
            lbId.Text = material.Id;
            tbRegisterCode.Text = StringUtility.TrimIfPresent(material.RegisterCode);
            tbModel.Text = StringUtility.TrimIfPresent(material.Model);
            tbOrigin.Text = StringUtility.TrimIfPresent(material.Origin);
            dtpManufactureDate.Value = material.ManufacturingDate;
            nbOilWarning.Value = material.OilWarning;
            tbNote.Text = StringUtility.TrimIfPresent(material.Notes);
            tbController.Text = StringUtility.TrimIfPresent(material.Controller);
            lbLastChangeOil.Text = material.LastChangeOil + " Km";
            //Huy QRCode: 11/19/2018 Add Start
            QRCodeService qr = new QRCodeService();
            if (qr != null)
            {
                Bitmap img = qr.GenerateQRCode(material.ToString(), 10, pbQRCode.Height, pbQRCode.Width);
                pbQRCode.Image = img;
            }
            //Huy QRCode: 11/19/2018 Add End
            dtpRegisterYear.Value = material.RegisterYear;
            tbFrameNumber.Text = StringUtility.TrimIfPresent(material.FrameNumber);
            tbEIN.Text = StringUtility.TrimIfPresent(material.EIN);
            nbGndkNumber.Value = material.GndkNumber;
            tbTypeDescription.Text = StringUtility.TrimIfPresent(material.TypeDescription);
            tbAcceptCode.Text = StringUtility.TrimIfPresent(material.AcceptCode);
            nbClLevel.Value = material.ClLevel;
            nbSclTime.Value = material.SclTime;
            dtpRecentSclYear.Value = material.RecentSclYear;
            dtpStartUsingYear.Value = material.StartUsingYear;
            lbCurrentKm.Text = material.CurrentKm + " Km";
            tbOriginExplanation.Text = StringUtility.TrimIfPresent(material.OriginalExplanation);
            var list1 = SingletonModelProvider.GetMaterialGroupLabelModels();
            int index = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                var item = list1[i];
                if (item.Id == material.GroupLabel)
                {
                    index = i;
                }
                cbGroupLabel.Items.Add(item);
            }
            cbGroupLabel.SelectedIndex = index;
            var list2 = SingletonModelProvider.GetMaterialLabelModels();
            index = 0;
            for (int i = 0; i < list2.Count; i++)
            {
                var item = list2[i];
                if (item.Id == material.Label)
                {
                    index = i;
                }
                cbLabel.Items.Add(item);
            }
            cbLabel.SelectedIndex = index;
            var list3 = SingletonModelProvider.GetMaterialUseStatusModels();
            index = 0;
            for (int i = 0; i < list3.Count; i++)
            {
                var item = list3[i];
                if (item.Id == material.UseStatus)
                {
                    index = i;
                }
                cbUseStatus.Items.Add(item);
            }
            cbUseStatus.SelectedIndex = index;
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

            material.RegisterYear = dtpRegisterYear.Value;
            material.Label = (cbLabel.SelectedItem as MaterialLabel).Id;
            material.FrameNumber = tbFrameNumber.Text;
            material.EIN = tbEIN.Text;
            material.OriginalExplanation = tbOriginExplanation.Text;
            material.StartUsingYear = dtpStartUsingYear.Value;
            material.ClLevel = Convert.ToInt32(nbClLevel.Value);
            material.SclTime = Convert.ToInt32(nbSclTime.Value);
            material.RecentSclYear = dtpRecentSclYear.Value;
            material.GroupLabel = (cbGroupLabel.SelectedItem as MaterialGroupLabel).Id;
            material.UseStatus = (cbUseStatus.SelectedItem as MaterialUseStatus).Id;
            material.GndkNumber = Convert.ToInt32(nbGndkNumber.Value);
            material.AcceptCode = tbAcceptCode.Text;
            material.TypeDescription = tbTypeDescription.Text;
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
            tbNote.ReadOnly = false;
            btnUpdate.Visible = true;
            btnUpdateEnable.Visible = false;
            dtpRegisterYear.Enabled = true;
            tbFrameNumber.ReadOnly = false;
            tbEIN.ReadOnly = false;
            
            tbTypeDescription.ReadOnly = false;
            tbAcceptCode.ReadOnly = false;
            dtpRecentSclYear.Enabled = true;
            dtpStartUsingYear.Enabled = true;
            tbOriginExplanation.ReadOnly = false;
            cbGroupLabel.Enabled = true;
            cbLabel.Enabled = true;
            cbUseStatus.Enabled = true;

            nbOilWarning.ReadOnly = false;
            nbGndkNumber.ReadOnly = false;
            nbClLevel.ReadOnly = false;
            nbSclTime.ReadOnly = false;
            nbClLevel.Increment = 1;
            nbGndkNumber.Increment = 1;
            nbOilWarning.Increment = 1;
            nbSclTime.Increment = 1;
        }

        private void btnGetQrCode_Click(object sender, EventArgs e)
        {
            //Huy QRCode: 11/20/2018 Add Start
            string selectedPath;
            var t = new Thread((ThreadStart)(() =>
            {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedPath = folderDialog.SelectedPath;
                        QRCodeService qr = new QRCodeService();
                        if (qr != null)
                        {
                            qr.GenerateQRCode(material.ToString(), 10, 300, 300).Save(selectedPath + "\\" + StringUtility.TrimIfPresent(material.Id) + "-" + DateTime.Today.ToString("ddMMyyyy") + ".png");
                            MessageBox.Show("Tải QRCode Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            MessageBox.Show("Không Thể Tải QRCode", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error,
     MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                }

            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void btnChangeCurrentKm_Click(object sender, EventArgs e)
        {
            MaterialUpdateCurrentKmForm form = new MaterialUpdateCurrentKmForm(material)
            {
                afterEditedCallBack = AfterUpdateCurrentKmAction
            };
            form.Show();
        }

        private void AfterUpdateCurrentKmAction(Material material)
        {
            lbCurrentKm.Text = material.CurrentKm + " Km";
            lbLastChangeOil.Text = material.LastChangeOil + " Km";
            MessageBox.Show("Cập nhật thành công công-tơ-mét trang bị!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
