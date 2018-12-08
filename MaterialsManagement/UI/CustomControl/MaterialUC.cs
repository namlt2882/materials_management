using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialsManagement.Model;
using MaterialsManagement.Common;
using MaterialsManagement.Service;
using System.Threading;
using MaterialsManagement.Utility;

namespace MaterialsManagement.UI.CustomControl
{
    public partial class MaterialUC : UserControl
    {
        public Dv dv { get; set; }
        public int CurrentMaterialType = (int)MaterialTypeEnum.Sail;
        private DataTable dataTable;
        private String searchValue = "";
        public MaterialUC(Dv dv) : this()
        {
            this.dv = dv;
            InitGridView((int)MaterialTypeEnum.Sail);
            var topLeftHeaderCell = gridData.TopLeftHeaderCell;
        }

        public MaterialUC()
        {
            InitializeComponent();
            ResetMaterialButtonColor(btnSail);
            InitContentScriptMenu();
        }
        void btn_export(Object sender, EventArgs e)
        {
            ToolStripMenuItem item = (sender as ToolStripMenuItem);
            CustomContextMenuStrip<int> contextMenuStrip = (item.Owner as CustomContextMenuStrip<int>);

            Report report = new Report();
            QkService qkService = new QkService();
            DvService dvService = new DvService();
            MaterialService materialService = new MaterialService();

            report.dvs.Add(dvService.Get(dv.Id));
            report.qks.Add(qkService.Get(report.dvs[0].QkId));
            report.materials.AddRange(materialService.GetByType(dv.Id, contextMenuStrip.obj));
            string selectedPath;
            var t = new Thread((ThreadStart)(() =>
            {
                using (var folderDialog = new OpenFileDialog())
                {
                    folderDialog.CheckFileExists = false;
                    folderDialog.FileName = String.Format("Dữ Liệu {0}.{1}", DateTime.Today.ToString("ddMMyyyy"), "json");
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedPath = folderDialog.FileName;
                        System.IO.File.WriteAllText(selectedPath, Newtonsoft.Json.JsonConvert.SerializeObject(report));
                        MessageBox.Show("Tải Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }

            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();


        }
        void btn_report(Object sender, EventArgs e)
        {

            ToolStripMenuItem item = (sender as ToolStripMenuItem);
            CustomContextMenuStrip<int> contextMenuStrip = (item.Owner as CustomContextMenuStrip<int>);

            Report report = new Report();
            QkService qkService = new QkService();
            DvService dvService = new DvService();
            MaterialService materialService = new MaterialService();
            ReportExcelService reportExcel = new ReportExcelService(false);
            report.dvs.Add(dvService.Get(dv.Id));
            report.qks.Add(qkService.Get(report.dvs[0].QkId));
            reportExcel.GenerateTitle("Báo cáo số chất lượng trang bị theo số đăng ký");
            if (report.dvs.Count != 0)
                reportExcel.GenerateTable(String.Format("Đơn Vị {1} Thuộc Quân Khu {0}", report.qks[0].Name, report.dvs[0].Name), materialService.GetByType(dv.Id, contextMenuStrip.obj));
            string selectedPath;
            var t = new Thread((ThreadStart)(() =>
            {
                using (var folderDialog = new OpenFileDialog())
                {
                    folderDialog.CheckFileExists = false;
                    folderDialog.FileName = String.Format("Báo cáo {0}.{1}", DateTime.Today.ToString("ddMMyyyy"), "xls");
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedPath = folderDialog.FileName;
                        reportExcel.DownLoad(selectedPath);
                        MessageBox.Show("Tải Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information,
 MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }

            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

        }
        public void DownQR(Object sender, EventArgs e)
        {
            ToolStripMenuItem item = (sender as ToolStripMenuItem);
            CustomContextMenuStrip<int> contextMenuStrip = (item.Owner as CustomContextMenuStrip<int>);

            Report report = new Report();
            QkService qkService = new QkService();
            DvService dvService = new DvService();
            MaterialService materialService = new MaterialService();

            report.dvs.Add(dvService.Get(dv.Id));
            report.qks.Add(qkService.Get(report.dvs[0].QkId));
            report.materials.AddRange(materialService.GetByType(dv.Id, contextMenuStrip.obj));
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
                            foreach (Material material in report.materials)
                            {
                                qr.GenerateQRCode(material.ToString(), 10, 300, 300).Save(selectedPath + "\\" + StringUtility.TrimIfPresent(material.Id) + "-" + DateTime.Today.ToString("ddMMyyyy") + ".png");
                            }
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
        public void InitContentScriptMenu()
        {
            CustomContextMenuStrip<int> cms = new CustomContextMenuStrip<int>();
            cms.Items.Add("Xuất Dữ Liệu " + MaterialTypeEnum.Sail.GetDisplayName(), null, new EventHandler(btn_export));
            cms.Items.Add("Xuất Báo Cáo " + MaterialTypeEnum.Sail.GetDisplayName(), null, new EventHandler(btn_report));
            cms.Items.Add("Xuất QR " + MaterialTypeEnum.Sail.GetDisplayName(), null, new EventHandler(DownQR));
            cms.obj = (int)MaterialTypeEnum.Sail;
            btnSail.ContextMenuStrip = cms;

            cms = new CustomContextMenuStrip<int>();
            cms.Items.Add("Xuất Dữ Liệu " + MaterialTypeEnum.Car.GetDisplayName(), null, new EventHandler(btn_export));
            cms.Items.Add("Xuất Báo Cáo " + MaterialTypeEnum.Car.GetDisplayName(), null, new EventHandler(btn_report));
            cms.Items.Add("Xuất QR " + MaterialTypeEnum.Car.GetDisplayName(), null, new EventHandler(DownQR));
            cms.obj = (int)MaterialTypeEnum.Car;
            btnCar.ContextMenuStrip = cms;
        }

        private void ResetMaterialButtonColor(Button component)
        {
            ResetMaterialButtonColor();
            component.BackColor = System.Drawing.Color.LightGreen;
        }
        private void ResetMaterialButtonColor()
        {
            btnCar.BackColor = System.Drawing.Color.LightGray;
            btnSail.BackColor = System.Drawing.Color.LightGray;
        }

        private void btnSail_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            searchValue = "";
            ResetMaterialButtonColor((Button)sender);
            CurrentMaterialType = (int)MaterialTypeEnum.Sail;
            InitGridView(CurrentMaterialType);
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            searchValue = "";
            ResetMaterialButtonColor((Button)sender);
            CurrentMaterialType = (int)MaterialTypeEnum.Car;
            InitGridView(CurrentMaterialType);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMaterialForm form = new AddMaterialForm(dv, CurrentMaterialType);
            form.afterAddCallBack = AfterAddedAction;
            form.Show();
        }

        private void AfterAddedAction(Material material)
        {
            EditMaterialForm form = new EditMaterialForm(material);
            form.afterEditedCallBack = AfterEditedAction;
            form.Show();
            dataTable = new MaterialService().SearchByTypeAsDataTable(dv.Id, CurrentMaterialType, searchValue);
            SetDataTable(dataTable);
        }

        private void InitGridView(int type)
        {
            try
            {
                dataTable = new MaterialService().GetByTypeAsDataTable(dv.Id, type);
                SetDataTable(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, không thể tải dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetDataTable(DataTable dataTable)
        {
            dataTable.Columns.Remove("Type");
            dataTable.Columns.Remove("CurrentKm");
            dataTable.Columns.Remove("OilWarning");
            dataTable.Columns.Remove("Notes");
            dataTable.Columns.Remove("Status");
            dataTable.Columns.Remove("DvId");
            dataTable.Columns.Remove("InsertDate");
            dataTable.Columns.Remove("LastUpdate");

            dataTable.Columns.Remove("RegisterYear");
            dataTable.Columns.Remove("Label");
            dataTable.Columns.Remove("FrameNumber");
            dataTable.Columns.Remove("EIN");
            dataTable.Columns.Remove("OriginalExplanation");
            dataTable.Columns.Remove("StartUsingYear");
            dataTable.Columns.Remove("ClLevel");
            dataTable.Columns.Remove("SclTime");
            dataTable.Columns.Remove("RecentSclYear");
            dataTable.Columns.Remove("GroupLabel");
            dataTable.Columns.Remove("UseStatus");
            dataTable.Columns.Remove("GndkNumber");
            dataTable.Columns.Remove("AcceptCode");
            dataTable.Columns.Remove("TypeDescription");
            dataTable.Columns.Remove("Origin");
            dataTable.Columns.Remove("LastChangeOil");

            gridData.DataSource = dataTable;
            gridData.Columns[1].HeaderText = "SĐK";
            gridData.Columns[2].HeaderText = "Model";
            gridData.Columns[3].HeaderText = "Ngày sản xuất";
            gridData.Columns[4].HeaderText = "Người điều khiển";
            gridData.Columns[5].HeaderText = "Biên chế ở";
        }

        private void AfterEditedAction(Material material)
        {
            MessageBox.Show("Cập nhật thành công chi tiết trang bị!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataTable = new MaterialService().SearchByTypeAsDataTable(dv.Id, CurrentMaterialType,searchValue);
            SetDataTable(dataTable);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void ViewDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridData.SelectedRows[0];
            string materialId = row.Cells["Id"].Value.ToString();
            try
            {
                Material material = new MaterialService().Get(materialId);
                EditMaterialForm form = new EditMaterialForm(material)
                {
                    afterEditedCallBack = AfterEditedAction
                };
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi. Thao tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCurrentKm_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridData.SelectedRows[0];
            string materialId = row.Cells["Id"].Value.ToString();
            try
            {
                Material material = new MaterialService().Get(materialId);
                MaterialUpdateCurrentKmForm form = new MaterialUpdateCurrentKmForm(material)
                {
                    afterEditedCallBack = AfterUpdateCurrentKmAction
                };
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi. Thao tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfterUpdateCurrentKmAction(Material material)
        {
            MessageBox.Show("Cập nhật thành công công-tơ-mét trang bị!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private ContextMenuStrip cms;
        private void gridData_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (cms == null)
                {
                    cms = new ContextMenuStrip();
                    cms.Items.Add("Xem chi tiết", null, new EventHandler(ViewDetail_Click));
                    cms.Items.Add("Cập nhật công-tơ-mét", null, new EventHandler(UpdateCurrentKm_Click));
                    cms.Items.Add("Xóa", null, new EventHandler(DeleteMaterial_Click));
                }
                gridData.CurrentCell = gridData.Rows[e.RowIndex].Cells[e.ColumnIndex];
                e.ContextMenuStrip = this.cms;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable = new MaterialService().SearchByTypeAsDataTable(dv.Id, CurrentMaterialType, tbSearch.Text.Trim());
                SetDataTable(dataTable);
                searchValue = tbSearch.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, không thể tải dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMaterial_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Phương tiện sẽ được xóa, bạn chắc chứ?",
                                         "Cảnh báo",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            //get current id
            DataGridViewRow row = gridData.SelectedRows[0];
            string materialId = row.Cells["Id"].Value.ToString();
            try
            {
                MaterialService service = new MaterialService();
                service.Delete(materialId);
                gridData.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi. Thao tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
