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

namespace MaterialsManagement.UI.CustomControl
{
    public partial class MaterialUC : UserControl
    {
        public Dv dv { get; set; }
        public int CurrentMaterialType = (int)MaterialEnum.Sail;
        private DataTable dataTable;
        public MaterialUC(Dv dv) : this()
        {
            this.dv = dv;
            InitGridView((int)MaterialEnum.Sail);
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
            var t = new Thread((ThreadStart)(() => {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedPath = folderDialog.SelectedPath;
                        System.IO.File.WriteAllText(selectedPath + "\\" + report.qks[0].Id + "_" + report.dvs[0].Id + "_" + contextMenuStrip.obj + DateTime.Today.ToString("ddMMyyyy") + ".json", Newtonsoft.Json.JsonConvert.SerializeObject(report));
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


        }
        public void InitContentScriptMenu()
        {
            CustomContextMenuStrip<int> cms = new CustomContextMenuStrip<int>();
            cms.Items.Add("Xuất Dữ Liệu " + MaterialEnum.Sail.GetDisplayName(), null, new EventHandler(btn_export));
            cms.Items.Add("Xuất Báo Cáo " + MaterialEnum.Sail.GetDisplayName(), null, new EventHandler(btn_report));
            cms.obj = (int)MaterialEnum.Sail;
            btnSail.ContextMenuStrip = cms;

            cms = new CustomContextMenuStrip<int>();
            cms.Items.Add("Xuất Dữ Liệu " + "Card", null, new EventHandler(btn_export));
            cms.Items.Add("Xuất Báo Cáo " + "Card", null, new EventHandler(btn_report));
            cms.obj = (int)MaterialEnum.Car;
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
            ResetMaterialButtonColor((Button)sender);
            CurrentMaterialType = (int)MaterialEnum.Sail;
            InitGridView(CurrentMaterialType);
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            ResetMaterialButtonColor((Button)sender);
            CurrentMaterialType = (int)MaterialEnum.Car;
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
            gridData.DataSource = dataTable;
            gridData.Columns[1].HeaderText = "SĐK";
            gridData.Columns[2].HeaderText = "Model";
            gridData.Columns[3].HeaderText = "Xuất xứ";
            gridData.Columns[4].HeaderText = "Ngày sản xuất";
            gridData.Columns[5].HeaderText = "Người điều khiển";
            gridData.Columns[6].HeaderText = "Lần cuối thay nhớt (km)";
        }

        private void AfterEditedAction(Material material)
        {
            MessageBox.Show("Cập nhật thành công chi tiết trang bị!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch(Exception ex)
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
                }
                gridData.CurrentCell = gridData.Rows[e.RowIndex].Cells[e.ColumnIndex];
                e.ContextMenuStrip = this.cms;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable = new MaterialService().SearchByTypeAsDataTable(dv.Id, CurrentMaterialType, tbSearch.Text);
                SetDataTable(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, không thể tải dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
