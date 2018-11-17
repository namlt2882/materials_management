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

namespace MaterialsManagement.UI.CustomControl
{
    public partial class MaterialUC : UserControl
    {
        public Dv dv { get; set; }
        public int CurrentMaterialType = (int)MaterialEnum.Sail;
        public MaterialUC(Dv dv) : this()
        {
            this.dv = dv;
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
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            ResetMaterialButtonColor((Button)sender);
            CurrentMaterialType = (int)MaterialEnum.Car;
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
    }
}
