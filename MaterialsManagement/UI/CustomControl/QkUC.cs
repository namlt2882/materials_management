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
    public partial class QkUC : UserControl
    {
        private List<Component> gridComponents;

        public QkUC()
        {
            InitializeComponent();
            InitGridComponents();
        }

        private void InitGridComponents()
        {

            for (int i = 1; i < 4; i++)
            {
                tableLayoutQkList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
            gridComponents = new List<Component> { };
            for (int i = 0; i < 15; i++)
            {
                Button btn = new Button
                {
                    Text = "QK7",
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    Height = 80,
                    Width = 180,
                    Margin = new Padding(10),
                    AutoSizeMode = AutoSizeMode.GrowOnly,
                    BackColor = Color.DarkGreen,
                    ForeColor = Color.White,
                    AutoSize = false
                };
                gridComponents.Add(btn);
                tableLayoutQkList.Controls.Add(btn);
            }

        }
    }
}
