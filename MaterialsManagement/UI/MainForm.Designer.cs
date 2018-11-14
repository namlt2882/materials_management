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
            this.button1 = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowDv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowQk)).BeginInit();
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
            this.btnQk.Location = new System.Drawing.Point(158, 42);
            this.btnQk.Name = "btnQk";
            this.btnQk.Size = new System.Drawing.Size(92, 35);
            this.btnQk.TabIndex = 2;
            this.btnQk.Text = "Tên QK";
            this.btnQk.UseVisualStyleBackColor = false;
            // 
            // btnDv
            // 
            this.btnDv.AutoSize = true;
            this.btnDv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDv.BackColor = System.Drawing.SystemColors.Info;
            this.btnDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDv.Location = new System.Drawing.Point(310, 42);
            this.btnDv.Name = "btnDv";
            this.btnDv.Size = new System.Drawing.Size(114, 35);
            this.btnDv.TabIndex = 4;
            this.btnDv.Text = "Tên đơn vị";
            this.btnDv.UseVisualStyleBackColor = false;
            // 
            // icArrowDv
            // 
            this.icArrowDv.BackColor = System.Drawing.Color.Transparent;
            this.icArrowDv.BackgroundImage = global::MaterialsManagement.Properties.Resources.greater_24;
            this.icArrowDv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icArrowDv.Location = new System.Drawing.Point(266, 42);
            this.icArrowDv.Name = "icArrowDv";
            this.icArrowDv.Size = new System.Drawing.Size(28, 35);
            this.icArrowDv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icArrowDv.TabIndex = 3;
            this.icArrowDv.TabStop = false;
            // 
            // icArrowQk
            // 
            this.icArrowQk.BackColor = System.Drawing.Color.Transparent;
            this.icArrowQk.BackgroundImage = global::MaterialsManagement.Properties.Resources.greater_24;
            this.icArrowQk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icArrowQk.Location = new System.Drawing.Point(111, 42);
            this.icArrowQk.Name = "icArrowQk";
            this.icArrowQk.Size = new System.Drawing.Size(32, 35);
            this.icArrowQk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icArrowQk.TabIndex = 1;
            this.icArrowQk.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(50, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 46);
            this.button1.TabIndex = 0;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(81, 121);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(399, 46);
            this.mainLabel.TabIndex = 6;
            this.mainLabel.Text = "Danh sách quân khu";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSize = true;
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Location = new System.Drawing.Point(50, 193);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(1100, 700);
            this.mainPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.btnDv);
            this.Controls.Add(this.icArrowDv);
            this.Controls.Add(this.btnQk);
            this.Controls.Add(this.icArrowQk);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lí vật tư bộ quốc phòng";
            ((System.ComponentModel.ISupportInitialize)(this.icArrowDv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icArrowQk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox icArrowQk;
        private System.Windows.Forms.Button btnQk;
        private System.Windows.Forms.Button btnDv;
        private System.Windows.Forms.PictureBox icArrowDv;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
    }
}