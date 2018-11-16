namespace MaterialsManagement.UI
{
    partial class AddMaterialForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fixedInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbQk = new System.Windows.Forms.Label();
            this.lbDv = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterName = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.detailPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nbOilWarning = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.RichTextBox();
            this.dtpManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.actionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.fixedInfoPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.detailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbOilWarning)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fixedInfoPanel);
            this.flowLayoutPanel1.Controls.Add(this.infoPanel);
            this.flowLayoutPanel1.Controls.Add(this.detailPanel);
            this.flowLayoutPanel1.Controls.Add(this.actionPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(978, 744);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fixedInfoPanel
            // 
            this.fixedInfoPanel.ColumnCount = 1;
            this.fixedInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fixedInfoPanel.Controls.Add(this.lbQk, 0, 0);
            this.fixedInfoPanel.Controls.Add(this.lbDv, 0, 1);
            this.fixedInfoPanel.Location = new System.Drawing.Point(53, 53);
            this.fixedInfoPanel.Name = "fixedInfoPanel";
            this.fixedInfoPanel.RowCount = 2;
            this.fixedInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fixedInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fixedInfoPanel.Size = new System.Drawing.Size(867, 100);
            this.fixedInfoPanel.TabIndex = 3;
            // 
            // lbQk
            // 
            this.lbQk.AutoSize = true;
            this.lbQk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQk.Location = new System.Drawing.Point(3, 0);
            this.lbQk.Name = "lbQk";
            this.lbQk.Size = new System.Drawing.Size(407, 32);
            this.lbQk.TabIndex = 0;
            this.lbQk.Text = "Quân khu: Quân khu 7 (QK7)";
            // 
            // lbDv
            // 
            this.lbDv.AutoSize = true;
            this.lbDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDv.Location = new System.Drawing.Point(3, 50);
            this.lbDv.Name = "lbDv";
            this.lbDv.Size = new System.Drawing.Size(296, 32);
            this.lbDv.TabIndex = 1;
            this.lbDv.Text = "Đơn vị: Long An (LA)";
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 2;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.7713F));
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.2287F));
            this.infoPanel.Controls.Add(this.label3, 0, 2);
            this.infoPanel.Controls.Add(this.label1, 0, 0);
            this.infoPanel.Controls.Add(this.cbType, 1, 0);
            this.infoPanel.Controls.Add(this.label2, 0, 1);
            this.infoPanel.Controls.Add(this.tbRegisterName, 1, 1);
            this.infoPanel.Controls.Add(this.tbModel, 1, 2);
            this.infoPanel.Location = new System.Drawing.Point(53, 159);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 3;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.5545F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.4455F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.infoPanel.Size = new System.Drawing.Size(443, 266);
            this.infoPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại trang bị:";
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(165, 3);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(223, 34);
            this.cbType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số đăng kí:";
            // 
            // tbRegisterName
            // 
            this.tbRegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterName.Location = new System.Drawing.Point(165, 96);
            this.tbRegisterName.Name = "tbRegisterName";
            this.tbRegisterName.Size = new System.Drawing.Size(223, 32);
            this.tbRegisterName.TabIndex = 3;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(165, 176);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(223, 32);
            this.tbModel.TabIndex = 4;
            // 
            // detailPanel
            // 
            this.detailPanel.ColumnCount = 2;
            this.detailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.08134F));
            this.detailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.91866F));
            this.detailPanel.Controls.Add(this.label4, 0, 0);
            this.detailPanel.Controls.Add(this.label5, 0, 1);
            this.detailPanel.Controls.Add(this.tbOrigin, 1, 0);
            this.detailPanel.Controls.Add(this.label6, 0, 2);
            this.detailPanel.Controls.Add(this.nbOilWarning, 1, 2);
            this.detailPanel.Controls.Add(this.label7, 0, 3);
            this.detailPanel.Controls.Add(this.tbNote, 1, 3);
            this.detailPanel.Controls.Add(this.dtpManufactureDate, 1, 1);
            this.detailPanel.Location = new System.Drawing.Point(502, 159);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.RowCount = 4;
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.96429F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.03571F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.detailPanel.Size = new System.Drawing.Size(418, 396);
            this.detailPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nơi sản xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 52);
            this.label5.TabIndex = 1;
            this.label5.Text = "Năm sản xuất:";
            // 
            // tbOrigin
            // 
            this.tbOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigin.Location = new System.Drawing.Point(158, 3);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(200, 32);
            this.tbOrigin.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 78);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khoảng cách mỗi lần thay nhớt(km):";
            // 
            // nbOilWarning
            // 
            this.nbOilWarning.Location = new System.Drawing.Point(158, 177);
            this.nbOilWarning.Name = "nbOilWarning";
            this.nbOilWarning.Size = new System.Drawing.Size(149, 26);
            this.nbOilWarning.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú:";
            // 
            // tbNote
            // 
            this.tbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(158, 267);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(257, 126);
            this.tbNote.TabIndex = 7;
            this.tbNote.Text = "";
            // 
            // dtpManufactureDate
            // 
            this.dtpManufactureDate.Location = new System.Drawing.Point(158, 76);
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            this.dtpManufactureDate.Size = new System.Drawing.Size(200, 26);
            this.dtpManufactureDate.TabIndex = 8;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnAdd);
            this.actionPanel.Location = new System.Drawing.Point(53, 561);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(867, 100);
            this.actionPanel.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(450, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(450, 20, 20, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.btnAdd.Size = new System.Drawing.Size(146, 79);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm trang bị";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.fixedInfoPanel.ResumeLayout(false);
            this.fixedInfoPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbOilWarning)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel infoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegisterName;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TableLayoutPanel detailPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbOilWarning;
        private System.Windows.Forms.TableLayoutPanel fixedInfoPanel;
        private System.Windows.Forms.Label lbQk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbNote;
        private System.Windows.Forms.FlowLayoutPanel actionPanel;
        private System.Windows.Forms.Label lbDv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpManufactureDate;
    }
}