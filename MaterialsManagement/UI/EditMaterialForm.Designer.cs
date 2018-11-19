namespace MaterialsManagement.UI
{
    partial class EditMaterialForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.fixedInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbQk = new System.Windows.Forms.Label();
            this.lbDv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nbOilWarning = new System.Windows.Forms.NumericUpDown();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterCode = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.btnGetQrCode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.dtpManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.RichTextBox();
            this.detailPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbController = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbLastChangeOil = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.leftActionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdateEnable = new System.Windows.Forms.Button();
            this.rightActionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.scrollPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fixedInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbOilWarning)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.detailPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.leftActionPanel.SuspendLayout();
            this.rightActionPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(20, 20);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 78);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // fixedInfoPanel
            // 
            this.fixedInfoPanel.ColumnCount = 1;
            this.fixedInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fixedInfoPanel.Controls.Add(this.lbQk, 0, 0);
            this.fixedInfoPanel.Controls.Add(this.lbDv, 0, 1);
            this.fixedInfoPanel.Location = new System.Drawing.Point(4, 5);
            this.fixedInfoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fixedInfoPanel.Name = "fixedInfoPanel";
            this.fixedInfoPanel.RowCount = 2;
            this.fixedInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.77778F));
            this.fixedInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.22222F));
            this.fixedInfoPanel.Size = new System.Drawing.Size(1072, 138);
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
            this.lbDv.Location = new System.Drawing.Point(3, 65);
            this.lbDv.Name = "lbDv";
            this.lbDv.Size = new System.Drawing.Size(296, 32);
            this.lbDv.TabIndex = 1;
            this.lbDv.Text = "Đơn vị: Long An (LA)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khoảng cách mỗi lần thay nhớt(km):";
            // 
            // nbOilWarning
            // 
            this.nbOilWarning.Location = new System.Drawing.Point(180, 155);
            this.nbOilWarning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nbOilWarning.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbOilWarning.Name = "nbOilWarning";
            this.nbOilWarning.ReadOnly = true;
            this.nbOilWarning.Size = new System.Drawing.Size(170, 26);
            this.nbOilWarning.TabIndex = 13;
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 2;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.08578F));
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.91422F));
            this.infoPanel.Controls.Add(this.label8, 0, 0);
            this.infoPanel.Controls.Add(this.label3, 0, 3);
            this.infoPanel.Controls.Add(this.label1, 0, 1);
            this.infoPanel.Controls.Add(this.label2, 0, 2);
            this.infoPanel.Controls.Add(this.tbRegisterCode, 1, 2);
            this.infoPanel.Controls.Add(this.tbModel, 1, 3);
            this.infoPanel.Controls.Add(this.tbId, 1, 0);
            this.infoPanel.Controls.Add(this.tbType, 1, 1);
            this.infoPanel.Controls.Add(this.label9, 0, 4);
            this.infoPanel.Controls.Add(this.flowLayoutPanel2, 1, 4);
            this.infoPanel.Location = new System.Drawing.Point(4, 153);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 5;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.infoPanel.Size = new System.Drawing.Size(442, 415);
            this.infoPanel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại trang bị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số đăng kí:";
            // 
            // tbRegisterCode
            // 
            this.tbRegisterCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterCode.Location = new System.Drawing.Point(153, 103);
            this.tbRegisterCode.MaxLength = 30;
            this.tbRegisterCode.Name = "tbRegisterCode";
            this.tbRegisterCode.ReadOnly = true;
            this.tbRegisterCode.Size = new System.Drawing.Size(223, 32);
            this.tbRegisterCode.TabIndex = 9;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(153, 153);
            this.tbModel.MaxLength = 50;
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(223, 32);
            this.tbModel.TabIndex = 10;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(153, 3);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(223, 32);
            this.tbId.TabIndex = 7;
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbType.Location = new System.Drawing.Point(153, 53);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(223, 32);
            this.tbType.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã QR:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pbQRCode);
            this.flowLayoutPanel2.Controls.Add(this.btnGetQrCode);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(153, 203);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 9, 10, 9);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(286, 209);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // pbQRCode
            // 
            this.pbQRCode.AccessibleName = "";
            this.pbQRCode.BackgroundImage = global::MaterialsManagement.Properties.Resources.qr_code_48;
            this.pbQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQRCode.InitialImage = global::MaterialsManagement.Properties.Resources.qr_code_48;
            this.pbQRCode.Location = new System.Drawing.Point(3, 12);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(176, 180);
            this.pbQRCode.TabIndex = 0;
            this.pbQRCode.TabStop = false;
            // 
            // btnGetQrCode
            // 
            this.btnGetQrCode.AutoSize = true;
            this.btnGetQrCode.BackgroundImage = global::MaterialsManagement.Properties.Resources.download_26;
            this.btnGetQrCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGetQrCode.Location = new System.Drawing.Point(185, 71);
            this.btnGetQrCode.Margin = new System.Windows.Forms.Padding(3, 62, 3, 3);
            this.btnGetQrCode.Name = "btnGetQrCode";
            this.btnGetQrCode.Size = new System.Drawing.Size(56, 58);
            this.btnGetQrCode.TabIndex = 100;
            this.MyToolTip.SetToolTip(this.btnGetQrCode, "Tải xuống");
            this.btnGetQrCode.UseVisualStyleBackColor = true;
            this.btnGetQrCode.Click += new System.EventHandler(this.btnGetQrCode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Năm sản xuất:";
            // 
            // tbOrigin
            // 
            this.tbOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigin.Location = new System.Drawing.Point(180, 55);
            this.tbOrigin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOrigin.MaxLength = 100;
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.ReadOnly = true;
            this.tbOrigin.Size = new System.Drawing.Size(434, 32);
            this.tbOrigin.TabIndex = 12;
            // 
            // dtpManufactureDate
            // 
            this.dtpManufactureDate.Enabled = false;
            this.dtpManufactureDate.Location = new System.Drawing.Point(180, 105);
            this.dtpManufactureDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            this.dtpManufactureDate.Size = new System.Drawing.Size(434, 26);
            this.dtpManufactureDate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú:";
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(180, 255);
            this.tbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNote.MaxLength = 200;
            this.tbNote.Name = "tbNote";
            this.tbNote.ReadOnly = true;
            this.tbNote.Size = new System.Drawing.Size(442, 152);
            this.tbNote.TabIndex = 14;
            this.tbNote.Text = "";
            // 
            // detailPanel
            // 
            this.detailPanel.ColumnCount = 2;
            this.detailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.13765F));
            this.detailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.86235F));
            this.detailPanel.Controls.Add(this.label4, 0, 1);
            this.detailPanel.Controls.Add(this.label5, 0, 2);
            this.detailPanel.Controls.Add(this.tbOrigin, 1, 1);
            this.detailPanel.Controls.Add(this.dtpManufactureDate, 1, 2);
            this.detailPanel.Controls.Add(this.nbOilWarning, 1, 3);
            this.detailPanel.Controls.Add(this.label6, 0, 3);
            this.detailPanel.Controls.Add(this.label7, 0, 5);
            this.detailPanel.Controls.Add(this.tbNote, 1, 5);
            this.detailPanel.Controls.Add(this.label10, 0, 0);
            this.detailPanel.Controls.Add(this.tbController, 1, 0);
            this.detailPanel.Controls.Add(this.label11, 0, 4);
            this.detailPanel.Controls.Add(this.lbLastChangeOil, 1, 4);
            this.detailPanel.Location = new System.Drawing.Point(454, 153);
            this.detailPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.RowCount = 6;
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.detailPanel.Size = new System.Drawing.Size(626, 412);
            this.detailPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nơi sản xuất:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 50);
            this.label10.TabIndex = 9;
            this.label10.Text = "Người điều khiển:";
            // 
            // tbController
            // 
            this.tbController.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbController.Location = new System.Drawing.Point(180, 5);
            this.tbController.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbController.MaxLength = 100;
            this.tbController.Name = "tbController";
            this.tbController.ReadOnly = true;
            this.tbController.Size = new System.Drawing.Size(434, 32);
            this.tbController.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 200);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 50);
            this.label11.TabIndex = 16;
            this.label11.Text = "Lần cuối thay nhớt:";
            // 
            // lbLastChangeOil
            // 
            this.lbLastChangeOil.AutoSize = true;
            this.lbLastChangeOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastChangeOil.Location = new System.Drawing.Point(180, 200);
            this.lbLastChangeOil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLastChangeOil.Name = "lbLastChangeOil";
            this.lbLastChangeOil.Size = new System.Drawing.Size(64, 26);
            this.lbLastChangeOil.TabIndex = 17;
            this.lbLastChangeOil.Text = "0 km";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.leftActionPanel);
            this.actionPanel.Controls.Add(this.rightActionPanel);
            this.actionPanel.Location = new System.Drawing.Point(4, 578);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(1090, 127);
            this.actionPanel.TabIndex = 2;
            // 
            // leftActionPanel
            // 
            this.leftActionPanel.Controls.Add(this.btnUpdateEnable);
            this.leftActionPanel.Location = new System.Drawing.Point(4, 5);
            this.leftActionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftActionPanel.Name = "leftActionPanel";
            this.leftActionPanel.Size = new System.Drawing.Size(660, 115);
            this.leftActionPanel.TabIndex = 18;
            // 
            // btnUpdateEnable
            // 
            this.btnUpdateEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEnable.Location = new System.Drawing.Point(240, 20);
            this.btnUpdateEnable.Margin = new System.Windows.Forms.Padding(240, 20, 20, 20);
            this.btnUpdateEnable.Name = "btnUpdateEnable";
            this.btnUpdateEnable.Size = new System.Drawing.Size(188, 80);
            this.btnUpdateEnable.TabIndex = 17;
            this.btnUpdateEnable.Text = "Sửa";
            this.btnUpdateEnable.UseVisualStyleBackColor = true;
            this.btnUpdateEnable.Click += new System.EventHandler(this.btnUpdateEnable_Click);
            // 
            // rightActionPanel
            // 
            this.rightActionPanel.Controls.Add(this.btnUpdate);
            this.rightActionPanel.Location = new System.Drawing.Point(671, 3);
            this.rightActionPanel.Name = "rightActionPanel";
            this.rightActionPanel.Size = new System.Drawing.Size(405, 117);
            this.rightActionPanel.TabIndex = 19;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.scrollPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1128, 764);
            this.mainPanel.TabIndex = 1;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoSize = true;
            this.scrollPanel.Controls.Add(this.fixedInfoPanel);
            this.scrollPanel.Controls.Add(this.infoPanel);
            this.scrollPanel.Controls.Add(this.detailPanel);
            this.scrollPanel.Controls.Add(this.actionPanel);
            this.scrollPanel.Location = new System.Drawing.Point(4, 5);
            this.scrollPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(1098, 710);
            this.scrollPanel.TabIndex = 4;
            // 
            // EditMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 764);
            this.Controls.Add(this.mainPanel);
            this.Name = "EditMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết thông tin trang bị";
            this.fixedInfoPanel.ResumeLayout(false);
            this.fixedInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbOilWarning)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.leftActionPanel.ResumeLayout(false);
            this.rightActionPanel.ResumeLayout(false);
            this.rightActionPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.scrollPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel fixedInfoPanel;
        private System.Windows.Forms.Label lbQk;
        private System.Windows.Forms.Label lbDv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbOilWarning;
        private System.Windows.Forms.TableLayoutPanel infoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegisterCode;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.DateTimePicker dtpManufactureDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbNote;
        private System.Windows.Forms.TableLayoutPanel detailPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel actionPanel;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Button btnGetQrCode;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbController;
        private System.Windows.Forms.Button btnUpdateEnable;
        private System.Windows.Forms.FlowLayoutPanel leftActionPanel;
        private System.Windows.Forms.FlowLayoutPanel rightActionPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbLastChangeOil;
        private System.Windows.Forms.FlowLayoutPanel scrollPanel;
    }
}