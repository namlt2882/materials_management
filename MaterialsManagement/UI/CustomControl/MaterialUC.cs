﻿using System;
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
        }

        public MaterialUC()
        {
            InitializeComponent();
            ResetMaterialButtonColor(btnSail);
            InitGridView((int)MaterialEnum.Sail);
            var topLeftHeaderCell = gridData.TopLeftHeaderCell;
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

        }

        private void InitGridView(int type)
        {
            try
            {
                dataTable = new MaterialService().GetByTypeAsDataTable(type);
                SetDataTable(dataTable);
            }
            catch(Exception ex)
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
            gridData.Columns[1].HeaderText = "SĐk";
            gridData.Columns[2].HeaderText = "Model";
            gridData.Columns[3].HeaderText = "Xuất xứ";
            gridData.Columns[4].HeaderText = "Ngày sản xuất";
        }
    }
}