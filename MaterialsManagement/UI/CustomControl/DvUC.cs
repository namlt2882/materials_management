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
    public partial class DvUC : UserControl
    {
        private List<Component> gridComponents;
        public delegate void OnButtonClickEvent(Dv qk);
        public OnButtonClickEvent onButtonClick;
        private Qk qk;
        private List<Dv> DvList;
        public DvUC(Qk qk,OnButtonClickEvent onButtonClick) : this()
        {
            this.qk = qk;
            this.onButtonClick = onButtonClick;
            InitGridComponents();
        }
        public DvUC()
        {
            InitializeComponent();
        }

        private void InitGridComponents()
        {
            DvList = new DvService().GetByQkId(qk.Id);
            int Quantity = DvList.Count;
            int RowNumber = (int)Math.Ceiling(Quantity * 1.0 / 4);
            for (int i = 1; i < RowNumber; i++)
            {
                tableLayoutQkList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
            gridComponents = new List<Component> { };
            foreach (Dv dv in DvList)
            {
                CustomButton<Dv> btn = new CustomButton<Dv>
                {
                    obj = dv,
                    Text = dv.Name,
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    Height = 80,
                    Width = 180,
                    Margin = new Padding(10),
                    AutoSizeMode = AutoSizeMode.GrowOnly,
                    BackColor = Color.Green,
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
                    CustomButton<Dv> btn = (CustomButton<Dv>)sender;
                    onButtonClick(btn.obj);
                }
            }
        }
    }
}
