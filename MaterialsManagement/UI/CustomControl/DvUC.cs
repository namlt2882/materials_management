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
using MaterialsManagement.Common;
using System.Threading;

namespace MaterialsManagement.UI.CustomControl
{
    public partial class DvUC : UserControl
    {
        private List<Component> gridComponents;
        public delegate void OnButtonClickEvent(Dv qk);
        public OnButtonClickEvent onButtonClick;
        private Qk qk;
        private List<Dv> DvList;
        public DvUC(Qk qk, OnButtonClickEvent onButtonClick) : this()
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
                    ForeColor = Color.White,
                    AutoSize = false
                };
                switch (dv.Priority)
                {
                    case (int)DvPriority.OFFICE:
                        btn.BackColor = Color.Red;
                        break;
                    case (int)DvPriority.TP:
                        btn.BackColor = Color.Blue;
                        break;
                    case (int)DvPriority.CTY:
                        btn.BackColor = Color.BlueViolet;
                        break;
                    default:
                        btn.BackColor = Color.Green;
                        break;
                }
                btn.Click += new EventHandler(btn_Click);
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.Items.Add("Xuất Dữ Liệu " + dv.Name, null, new EventHandler(btn_export));
                cms.Items.Add("Xuất Báo Cáo " + dv.Name, null, new EventHandler(btn_report));
                btn.ContextMenuStrip = cms;
                gridComponents.Add(btn);
                tableLayoutQkList.Controls.Add(btn);
            }
        }

            void btn_export(Object sender, EventArgs e)
            {
                ToolStripMenuItem item = (sender as ToolStripMenuItem);
                ContextMenuStrip contextMenuStrip = (item.Owner as ContextMenuStrip);
                CustomButton<Dv> customButton = contextMenuStrip.SourceControl as CustomButton<Dv>;
                Report report = new Report();
                QkService qkService = new QkService();
                DvService dvService = new DvService();
                MaterialService materialService = new MaterialService();
                report.qks.Add(qkService.Get(qk.Id));
                report.dvs.Add(dvService.Get(customButton.obj.Id));
                report.materials.AddRange(materialService.GetAllByDv(report.dvs[0].Id));
                string selectedPath;
                var t = new Thread((ThreadStart)(() => {
                    using (var folderDialog = new OpenFileDialog())
                    {
                        folderDialog.CheckFileExists = false;
                        folderDialog.FileName = String.Format("Dữ Liệu{0}.{1}", DateTime.Today.ToString("ddMMyyyy"), "json");
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
                ToolStripMenuItem item = (sender as ToolStripMenuItem);
                ContextMenuStrip contextMenuStrip = (item.Owner as ContextMenuStrip);
                CustomButton<Dv> customButton = contextMenuStrip.SourceControl as CustomButton<Dv>;
                Report report = new Report();
                QkService qkService = new QkService();
                DvService dvService = new DvService();
                MaterialService materialService = new MaterialService();
                ReportExcelService reportExcel = new ReportExcelService(false);
                report.qks.Add(qkService.Get(qk.Id));
                report.dvs.Add(dvService.Get(customButton.obj.Id));
                reportExcel.GenerateTitle("Báo cáo số chất lượng trang bị xe - máy và tàu - thuyền theo số đăng ký");
                    if (report.dvs.Count != 0) 
                    reportExcel.GenerateTable(String.Format("Đơn Vị {0} Thuộc Quân Khu {1}", report.qks[0].Name, report.dvs[0].Name), materialService.GetAllByDv(report.dvs[0].Id));
                string selectedPath;
                var t = new Thread((ThreadStart)(() => {
                    using (var folderDialog = new OpenFileDialog())
                    {
                        folderDialog.CheckFileExists = false;
                        folderDialog.FileName = String.Format("Báo cáo {0}.{1}", DateTime.Today.ToString("ddMMyyyy"), "xls");
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
