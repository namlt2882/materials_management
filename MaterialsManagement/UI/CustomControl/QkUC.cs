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

namespace MaterialsManagement.UI.CustomControl
{
    public partial class QkUC : UserControl
    {
        private List<Component> gridComponents;
        public delegate void OnButtonClickEvent(Qk qk);
        public OnButtonClickEvent onButtonClick;

        public QkUC(OnButtonClickEvent onButtonClick) : this()
        {
            this.onButtonClick = onButtonClick;
        }

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
                CustomButton<Qk> btn = new CustomButton<Qk>
                {
                    obj = new Qk(null, "QK7"),
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
                btn.Click += new EventHandler(btn_Click);
                gridComponents.Add(btn);
                tableLayoutQkList.Controls.Add(btn);
            }

            void btn_Click(object sender, EventArgs e)
            {
                if (onButtonClick != null)
                {
                    CustomButton<Qk> btn = (CustomButton<Qk>)sender;
                    onButtonClick(btn.obj);
                }
            }

        }
    }
}
