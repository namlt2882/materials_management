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
using System.Threading;

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
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.Items.Add("Xuất Dữ Liệu " + qk.Name, null, new EventHandler(btn_export));
                cms.Items.Add("Xuất Báo Cáo " + qk.Name, null, new EventHandler(btn_report));

                btn.ContextMenuStrip = cms;
                gridComponents.Add(btn);
                tableLayoutQkList.Controls.Add(btn);
            }
        }

            void btn_Click(object sender, EventArgs e)
            {
                if (onButtonClick != null)
                {
                    CustomButton<Qk> btn = (CustomButton<Qk>)sender;
                    onButtonClick(btn.obj);
                }
            }
            void btn_export(Object sender, EventArgs e)
            {
                ToolStripMenuItem item = (sender as ToolStripMenuItem);
                ContextMenuStrip contextMenuStrip = (item.Owner as ContextMenuStrip);
                CustomButton<Qk> customButton = contextMenuStrip.SourceControl as CustomButton<Qk>;
                Report report = new Report();
                QkService qkService = new QkService();
                DvService dvService = new DvService();
                MaterialService materialService = new MaterialService();
                report.qks.Add(qkService.Get(customButton.obj.Id));
                report.dvs.AddRange(dvService.GetByQkId(report.qks[0].Id));
                foreach (Dv dv in report.dvs)
                {
                    report.materials.AddRange(materialService.GetAllByDv(dv.Id));
                }
                string selectedPath;
                var t = new Thread((ThreadStart)(() => {
                    using (var folderDialog = new OpenFileDialog())
                    {
                        folderDialog.CheckFileExists = false;
                        folderDialog.FileName = String.Format("Dữ Liệu {0}.{1}", DateTime.Today.ToString("ddMMyyyy"), "json");
                        if (folderDialog.ShowDialog() == DialogResult.OK)
                        {
                            selectedPath = folderDialog.FileName;
                            System.IO.File.WriteAllText(selectedPath, Newtonsoft.Json.JsonConvert.SerializeObject(report));
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
                try
                {
                    ToolStripMenuItem item = (sender as ToolStripMenuItem);
                    ContextMenuStrip contextMenuStrip = (item.Owner as ContextMenuStrip);
                    CustomButton<Qk> customButton = contextMenuStrip.SourceControl as CustomButton<Qk>;
                    Report report = new Report();
                    QkService qkService = new QkService();
                    DvService dvService = new DvService();
                    MaterialService materialService = new MaterialService();
                    ReportExcelService reportExcel = new ReportExcelService(false);
                    report.qks.Add(qkService.Get(customButton.obj.Id));
                    report.dvs.AddRange(dvService.GetByQkId(report.qks[0].Id));
                    reportExcel.GenerateTitle("Báo cáo số chất lượng trang bị xe - máy và tàu - thuyền theo số đăng ký");
                    for (int i = 0; i < report.dvs.Count; i++)
                    {
                        Dv dv = report.dvs[i];

                        List<Material> list = materialService.GetAllByDv(dv.Id);
                        if (list.Count == 0) continue;
                        reportExcel.GenerateTable(String.Format("Đơn Vị {0} Thuộc Quân Khu {1}",report.qks[0].Name,dv.Name), list);
                    }
                    string selectedPath;
                    var t = new Thread((ThreadStart)(() => {
                        using (var folderDialog = new OpenFileDialog())
                        {
                            folderDialog.CheckFileExists = false;
                            folderDialog.FileName = String.Format("Báo cáo {0}.{1}", DateTime.Today.ToString("ddMMyyyy"),"xls");
                            if (folderDialog.ShowDialog() == DialogResult.OK)
                            {
                                selectedPath = folderDialog.FileName;
                                reportExcel.DownLoad(selectedPath);
                                MessageBox.Show("Tải Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            }
                        }

                    }));
                    t.SetApartmentState(ApartmentState.STA);
                    t.Start();
                    t.Join();
                }
                catch (Exception ex)
                {

                }

            }

    }
}
