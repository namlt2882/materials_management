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
using MaterialsManagement.Service;

namespace MaterialsManagement.UI.CustomControl
{
    public partial class QkUC : UserControl
    {
        private List<Component> gridComponents;
        public delegate void OnButtonClickEvent(Qk qk);
        public OnButtonClickEvent onButtonClick;
        public List<Qk> QkList;
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
            QkList = new QkService().GetAll();
            int Quantity = QkList.Count;
            int RowNumber = (int)Math.Ceiling(Quantity * 1.0 / 4);

            for (int i = 1; i < RowNumber; i++)
            {
                tableLayoutQkList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
            gridComponents = new List<Component> { };
            foreach (Qk qk in QkList)
            {
                CustomButton<Qk> btn = new CustomButton<Qk>
                {
                    obj = qk,
                    Text = qk.Name,
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
