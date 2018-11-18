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
            gridData.DataSource = dataTable;
            gridData.Columns[1].HeaderText = "SĐK";
            gridData.Columns[2].HeaderText = "Model";
            gridData.Columns[3].HeaderText = "Xuất xứ";
            gridData.Columns[4].HeaderText = "Ngày sản xuất";
            gridData.Columns[5].HeaderText = "Người điều khiển";
        }

        private void AfterEditedAction(Material material)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void ViewDetail_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridData.SelectedRows[0];
            string materialId = row.Cells["Id"].Value.ToString();
            Material material = new MaterialService().Get(materialId);
            EditMaterialForm form = new EditMaterialForm(material);
            form.afterEditedCallBack = AfterEditedAction;
            form.Show();
        }
        private void UpdateCurrentKm_Click(object sender, EventArgs e)
        {

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
    }
}
