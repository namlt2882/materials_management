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
            this.icArrowDv = new System.Windows.Forms.PictureBox();
            this.icArrowQk = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addressPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.parentPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowDv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowQk)).BeginInit();
            this.addressPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.parentPanel.SuspendLayout();
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
            this.btnQk.Location = new System.Drawing.Point(107, 13);
            this.btnQk.Name = "btnQk";
            this.btnQk.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnQk.Size = new System.Drawing.Size(92, 40);
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
            this.btnDv.Location = new System.Drawing.Point(250, 13);
            this.btnDv.Name = "btnDv";
            this.btnDv.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDv.Size = new System.Drawing.Size(114, 40);
            this.btnDv.TabIndex = 4;
            this.btnDv.Text = "Tên đơn vị";
            this.btnDv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDv.UseVisualStyleBackColor = false;
            // 
            // icArrowDv
            // 
            this.icArrowDv.BackColor = System.Drawing.Color.Transparent;
            this.icArrowDv.BackgroundImage = global::MaterialsManagement.Properties.Resources.greater_24;
            this.icArrowDv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icArrowDv.Location = new System.Drawing.Point(205, 13);
            this.icArrowDv.Name = "icArrowDv";
            this.icArrowDv.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.icArrowDv.Size = new System.Drawing.Size(39, 35);
            this.icArrowDv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icArrowDv.TabIndex = 3;
            this.icArrowDv.TabStop = false;
            // 
            // icArrowQk
            // 
            this.icArrowQk.BackColor = System.Drawing.Color.Transparent;
            this.icArrowQk.BackgroundImage = global::MaterialsManagement.Properties.Resources.greater_24;
            this.icArrowQk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icArrowQk.Location = new System.Drawing.Point(64, 13);
            this.icArrowQk.Name = "icArrowQk";
            this.icArrowQk.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.icArrowQk.Size = new System.Drawing.Size(37, 35);
            this.icArrowQk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icArrowQk.TabIndex = 1;
            this.icArrowQk.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Location = new System.Drawing.Point(13, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 46);
            this.btnHome.TabIndex = 0;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(40, 20);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(399, 46);
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
            this.mainPanel.Location = new System.Drawing.Point(3, 215);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.mainPanel.MinimumSize = new System.Drawing.Size(1300, 500);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(1300, 500);
            this.mainPanel.TabIndex = 7;
            // 
            // addressPanel
            // 
            this.addressPanel.Controls.Add(this.btnHome);
            this.addressPanel.Controls.Add(this.icArrowQk);
            this.addressPanel.Controls.Add(this.btnQk);
            this.addressPanel.Controls.Add(this.icArrowDv);
            this.addressPanel.Controls.Add(this.btnDv);
            this.addressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressPanel.Location = new System.Drawing.Point(3, 3);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.addressPanel.Size = new System.Drawing.Size(1349, 100);
            this.addressPanel.TabIndex = 9;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.mainLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(3, 109);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1349, 100);
            this.titlePanel.TabIndex = 8;
            // 
            // parentPanel
            // 
            this.parentPanel.AutoScroll = true;
            this.parentPanel.Controls.Add(this.addressPanel);
            this.parentPanel.Controls.Add(this.titlePanel);
            this.parentPanel.Controls.Add(this.mainPanel);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanel.Location = new System.Drawing.Point(0, 0);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(1378, 844);
            this.parentPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.parentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lí vật tư bộ quốc phòng";
            ((System.ComponentModel.ISupportInitialize)(this.icArrowDv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowQk)).EndInit();
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.parentPanel.ResumeLayout(false);
            this.parentPanel.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel addressPanel;
        private System.Windows.Forms.FlowLayoutPanel titlePanel;
        private System.Windows.Forms.FlowLayoutPanel parentPanel;
    }
}