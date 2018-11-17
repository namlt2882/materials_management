﻿using MaterialsManagement.Common;
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
            tbRegisterCode.Text = material.RegisterCode.Trim();
            tbModel.Text = material.Model.Trim();
            tbOrigin.Text = material.Origin.Trim();
            dtpManufactureDate.Value = material.ManufacturingDate;
            nbOilWarning.Value = material.OilWarning;
            tbNote.Text = material.Notes.Trim();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}