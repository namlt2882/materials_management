using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialsManagement.UI.CustomControl
{
    public partial class MaterialUC : UserControl
    {
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
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            ResetMaterialButtonColor((Button)sender);
        }
    }
}
