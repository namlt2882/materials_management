namespace MaterialsManagement
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.btnQk = new System.Windows.Forms.Button();
            this.btnDv = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addressPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.actionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.parentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.icArrowQk = new System.Windows.Forms.PictureBox();
            this.icArrowDv = new System.Windows.Forms.PictureBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.addressPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.parentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowQk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowDv)).BeginInit();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "home-page-24.png");
            // 
            // btnQk
            // 
            this.btnQk.AutoSize = true;
            this.btnQk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQk.BackColor = System.Drawing.SystemColors.Info;
            this.btnQk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQk.Location = new System.Drawing.Point(65, 2);
            this.btnQk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQk.Name = "btnQk";
            this.btnQk.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnQk.Size = new System.Drawing.Size(67, 30);
            this.btnQk.TabIndex = 2;
            this.btnQk.Text = "Tên QK";
            this.btnQk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQk.UseVisualStyleBackColor = false;
            // 
            // btnDv
            // 
            this.btnDv.AutoSize = true;
            this.btnDv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDv.BackColor = System.Drawing.SystemColors.Info;
            this.btnDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDv.Location = new System.Drawing.Point(166, 2);
            this.btnDv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDv.Name = "btnDv";
            this.btnDv.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnDv.Size = new System.Drawing.Size(85, 30);
            this.btnDv.TabIndex = 4;
            this.btnDv.Text = "Tên đơn vị";
            this.btnDv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDv.UseVisualStyleBackColor = false;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(27, 13);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(27, 13, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(285, 32);
            this.mainLabel.TabIndex = 6;
            this.mainLabel.Text = "Danh sách quân khu";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(2, 140);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 19);
            this.mainPanel.MinimumSize = new System.Drawing.Size(867, 325);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(867, 325);
            this.mainPanel.TabIndex = 7;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.addressPanel);
            this.headerPanel.Controls.Add(this.actionPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(2, 2);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(7, 6, 0, 0);
            this.headerPanel.Size = new System.Drawing.Size(899, 65);
            this.headerPanel.TabIndex = 9;
            // 
            // addressPanel
            // 
            this.addressPanel.Controls.Add(this.btnHome);
            this.addressPanel.Controls.Add(this.icArrowQk);
            this.addressPanel.Controls.Add(this.btnQk);
            this.addressPanel.Controls.Add(this.icArrowDv);
            this.addressPanel.Controls.Add(this.btnDv);
            this.addressPanel.Location = new System.Drawing.Point(9, 8);
            this.addressPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(629, 48);
            this.addressPanel.TabIndex = 8;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnImport);
            this.actionPanel.Controls.Add(this.btnExport);
            this.actionPanel.Controls.Add(this.btnClear);
            this.actionPanel.Location = new System.Drawing.Point(642, 8);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(126, 48);
            this.actionPanel.TabIndex = 7;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.mainLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(2, 71);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(899, 65);
            this.titlePanel.TabIndex = 8;
            // 
            // parentPanel
            // 
            this.parentPanel.AutoScroll = true;
            this.parentPanel.Controls.Add(this.headerPanel);
            this.parentPanel.Controls.Add(this.titlePanel);
            this.parentPanel.Controls.Add(this.mainPanel);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanel.Location = new System.Drawing.Point(0, 0);
            this.parentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(913, 487);
            this.parentPanel.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Location = new System.Drawing.Point(2, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 30);
            this.btnHome.TabIndex = 0;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // icArrowQk
            // 
            this.icArrowQk.BackColor = System.Drawing.Color.Transparent;
            this.icArrowQk.BackgroundImage = global::MaterialsManagement.Properties.Resources.greater_24;
            this.icArrowQk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icArrowQk.Location = new System.Drawing.Point(36, 2);
            this.icArrowQk.Margin = new System.Windows.Forms.Padding(2);
            this.icArrowQk.Name = "icArrowQk";
            this.icArrowQk.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.icArrowQk.Size = new System.Drawing.Size(25, 23);
            this.icArrowQk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icArrowQk.TabIndex = 1;
            this.icArrowQk.TabStop = false;
            // 
            // icArrowDv
            // 
            this.icArrowDv.BackColor = System.Drawing.Color.Transparent;
            this.icArrowDv.BackgroundImage = global::MaterialsManagement.Properties.Resources.greater_24;
            this.icArrowDv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icArrowDv.Location = new System.Drawing.Point(136, 2);
            this.icArrowDv.Margin = new System.Windows.Forms.Padding(2);
            this.icArrowDv.Name = "icArrowDv";
            this.icArrowDv.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.icArrowDv.Size = new System.Drawing.Size(26, 23);
            this.icArrowDv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icArrowDv.TabIndex = 3;
            this.icArrowDv.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImage = global::MaterialsManagement.Properties.Resources.synchronize_24;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImport.Location = new System.Drawing.Point(2, 2);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(31, 30);
            this.btnImport.TabIndex = 5;
            this.MyToolTip.SetToolTip(this.btnImport, "Đồng bộ dữ liệu từ file");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::MaterialsManagement.Properties.Resources.export_24;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExport.Location = new System.Drawing.Point(37, 2);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(33, 30);
            this.btnExport.TabIndex = 6;
            this.MyToolTip.SetToolTip(this.btnExport, "Xuất dữ liệu");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::MaterialsManagement.Properties.Resources.documents;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Location = new System.Drawing.Point(74, 2);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(33, 30);
            this.btnClear.TabIndex = 7;
            this.MyToolTip.SetToolTip(this.btnClear, "Xuất dữ liệu");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.parentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lí trang bị bộ quốc phòng";
            this.headerPanel.ResumeLayout(false);
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.parentPanel.ResumeLayout(false);
            this.parentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowQk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowDv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox icArrowQk;
        private System.Windows.Forms.Button btnQk;
        private System.Windows.Forms.Button btnDv;
        private System.Windows.Forms.PictureBox icArrowDv;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel headerPanel;
        private System.Windows.Forms.FlowLayoutPanel titlePanel;
        private System.Windows.Forms.FlowLayoutPanel parentPanel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FlowLayoutPanel actionPanel;
        private System.Windows.Forms.FlowLayoutPanel addressPanel;
        private System.Windows.Forms.Button btnClear;
    }
}