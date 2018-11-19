namespace MaterialsManagement.UI
{
    partial class MaterialUpdateCurrentKmForm
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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nbNewKm = new System.Windows.Forms.NumericUpDown();
            this.cbIsChangeOil = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCurrentKm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOilWarning = new System.Windows.Forms.TextBox();
            this.actionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastChangeOil = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNewKm)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainPanel.Controls.Add(this.actionPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(40);
            this.mainPanel.Size = new System.Drawing.Size(578, 544);
            this.mainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09369F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90631F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbCurrentKm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbOilWarning, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbLastChangeOil, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 385);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Km mới:";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(196, 3);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(231, 32);
            this.tbId.TabIndex = 3;
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbType.Location = new System.Drawing.Point(196, 53);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(231, 32);
            this.tbType.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nbNewKm);
            this.flowLayoutPanel1.Controls.Add(this.cbIsChangeOil);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(196, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(264, 82);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // nbNewKm
            // 
            this.nbNewKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbNewKm.Location = new System.Drawing.Point(3, 3);
            this.nbNewKm.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.nbNewKm.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbNewKm.Name = "nbNewKm";
            this.nbNewKm.Size = new System.Drawing.Size(138, 32);
            this.nbNewKm.TabIndex = 5;
            // 
            // cbIsChangeOil
            // 
            this.cbIsChangeOil.AutoSize = true;
            this.cbIsChangeOil.Location = new System.Drawing.Point(3, 48);
            this.cbIsChangeOil.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbIsChangeOil.Name = "cbIsChangeOil";
            this.cbIsChangeOil.Size = new System.Drawing.Size(126, 24);
            this.cbIsChangeOil.TabIndex = 6;
            this.cbIsChangeOil.Text = "Đã thay nhớt";
            this.cbIsChangeOil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại trang bị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Km hiện tại:";
            // 
            // tbCurrentKm
            // 
            this.tbCurrentKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentKm.Location = new System.Drawing.Point(196, 103);
            this.tbCurrentKm.Name = "tbCurrentKm";
            this.tbCurrentKm.ReadOnly = true;
            this.tbCurrentKm.Size = new System.Drawing.Size(231, 32);
            this.tbCurrentKm.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 52);
            this.label5.TabIndex = 9;
            this.label5.Text = "Khoảng cách mỗi lần thay nhớt:";
            // 
            // tbOilWarning
            // 
            this.tbOilWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOilWarning.Location = new System.Drawing.Point(196, 153);
            this.tbOilWarning.Name = "tbOilWarning";
            this.tbOilWarning.ReadOnly = true;
            this.tbOilWarning.Size = new System.Drawing.Size(231, 32);
            this.tbOilWarning.TabIndex = 10;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnUpdate);
            this.actionPanel.Location = new System.Drawing.Point(43, 434);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(479, 100);
            this.actionPanel.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(300, 20);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(300, 20, 3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 63);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 52);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lần cuối thay nhớt:";
            // 
            // tbLastChangeOil
            // 
            this.tbLastChangeOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastChangeOil.Location = new System.Drawing.Point(196, 223);
            this.tbLastChangeOil.Name = "tbLastChangeOil";
            this.tbLastChangeOil.ReadOnly = true;
            this.tbLastChangeOil.Size = new System.Drawing.Size(231, 32);
            this.tbLastChangeOil.TabIndex = 12;
            // 
            // MaterialUpdateCurrentKmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.mainPanel);
            this.Name = "MaterialUpdateCurrentKmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật Công-tơ-mét";
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNewKm)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.NumericUpDown nbNewKm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbIsChangeOil;
        private System.Windows.Forms.FlowLayoutPanel actionPanel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCurrentKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOilWarning;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLastChangeOil;
    }
}