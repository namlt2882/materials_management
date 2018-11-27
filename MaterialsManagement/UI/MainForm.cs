using MaterialsManagement.Model;
using MaterialsManagement.UI.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialsManagement.Service;
using System.Threading;

namespace MaterialsManagement
{
    public partial class MainForm : Form
    {
        private EventHandler qkOnClickEvent;
        private EventHandler dvOnClickEvent;

        public MainForm()
        {
            InitializeComponent();
            InitHomeScreen();
        }

        private void InitHomeScreen()
        {
            //change text of main label
            mainLabel.Text = "Danh sách quân khu";
            ResetAddressBar(false, false);
            InitMainPanel(new QkUC(OnItemQk_Click));
        }

        private void InitQkScreen(Qk qk)
        {
            //change text of current qk
            btnQk.Text = qk.Name;
            //change text of main label
            mainLabel.Text = "Danh sách đơn vị trực thuộc " + qk.Name;
            //change event when click on qk button in address bar
            if (qkOnClickEvent != null)
            {
                //remove old event
                btnQk.Click -= qkOnClickEvent;
            }
            //init new event
            qkOnClickEvent = delegate (object sender, EventArgs e)
            {
                InitQkScreen(qk);
            };
            //add event
            btnQk.Click += qkOnClickEvent;
            //reset address bar
            ResetAddressBar(true, false);
            //init main panel
            InitMainPanel(new DvUC(qk, OnItemDv_Click));
        }

        private void InitMainPanel(Control control)
        {
            mainPanel.Controls.Clear();
            mainPanel.RowStyles.Clear();
            mainPanel.Controls.Add(control);
        }

        private void InitDvScreen(Dv dv)
        {
            btnDv.Text = dv.Name;
            //change text of main label
            mainLabel.Text = "Danh sách trang bị của đơn vị " + dv.Name;
            if (dvOnClickEvent != null)
            {
                btnDv.Click -= dvOnClickEvent;
            }
            dvOnClickEvent = delegate (object sender, EventArgs e)
            {
                InitDvScreen(dv);
            };
            btnDv.Click += dvOnClickEvent;
            ResetAddressBar(true, true);
            InitMainPanel(new MaterialUC(dv));
        }

        private void ResetAddressBar(bool InQk, bool InDv)
        {
            if (InQk)
            {
                icArrowQk.Visible = true;
                btnQk.Visible = true;
            }
            else
            {
                icArrowQk.Visible = false;
                btnQk.Visible = false;
            }
            if (InDv)
            {
                icArrowDv.Visible = true;
                btnDv.Visible = true;
            }
            else
            {
                icArrowDv.Visible = false;
                btnDv.Visible = false;
            }
        }

        private void OnItemQk_Click(Qk qk)
        {
            InitQkScreen(qk);
        }

        private void OnItemDv_Click(Dv dv)
        {
            InitDvScreen(dv);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            InitHomeScreen();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var t = new Thread((ThreadStart)(() => {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    openFileDialog1.Title = "Browse Text Files";
                    openFileDialog1.CheckFileExists = true;
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        String path = System.IO.File.ReadAllText(openFileDialog1.FileName);
                        Report export = Newtonsoft.Json.JsonConvert.DeserializeObject<Report>(path);
                        QkService qkService = new QkService();
                        foreach (Qk qk in export.qks)
                        {
                            if (qkService.Get(qk.Id) != null)
                            {
                                qkService.Update(qk);
                            }
                            else
                            {
                                qkService.Add(qk);
                            }
                        }
                        DvService dvService = new DvService();
                        foreach (Dv dv in export.dvs)
                        {
                            if (dvService.Get(dv.Id) != null)
                            {
                                dvService.Update(dv);
                            }
                            else
                            {
                                dvService.Add(dv);
                            }
                        }
                        MaterialService materialService = new MaterialService();
                        foreach (Material material in export.materials)
                        {
                            if (materialService.Get(material.Id) != null)
                            {
                                materialService.UpdateFromOthers(material);
                            }
                            else
                            {
                                materialService.AddFromOthers(material);
                            }
                        }
                        MessageBox.Show("Chương Trình Sẽ Được Khởi Động Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        Application.Restart();

                    }
                }

            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            QkService qkService = new QkService();
            DvService dvService = new DvService();
            MaterialService materialService = new MaterialService();
            report.dvs.AddRange(dvService.GetAll());
            report.qks.AddRange(qkService.GetAll());
            report.materials.AddRange(materialService.GetAll());
            string selectedPath;
            var t = new Thread((ThreadStart)(() => {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedPath = folderDialog.SelectedPath;
                        System.IO.File.WriteAllText(selectedPath + "\\Toàn Bộ Các Quân Khu " + DateTime.Today.ToString("ddMMyyyy") + ".json", Newtonsoft.Json.JsonConvert.SerializeObject(report));
                        MessageBox.Show("Tải Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }

            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban Có Muốn Xóa Toàn Bộ Dữ Liệu", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
   MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (dialogResult == DialogResult.Yes)
            {
                QkService qkService = new QkService();
                qkService.Clear();
                MessageBox.Show("Chương Trình Sẽ Được Khởi Động Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                Application.Restart();
            }
        }
    }
}
