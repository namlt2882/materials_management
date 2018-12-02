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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.resizePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fixedInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbQk = new System.Windows.Forms.Label();
            this.lbDv = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterCode = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLabel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpRegisterYear = new System.Windows.Forms.DateTimePicker();
            this.tbFrameNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEIN = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nbClLevel = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nbSclTime = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpRecentSclYear = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.cbGroupLabel = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbAcceptCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbTypeDescription = new System.Windows.Forms.TextBox();
            this.nbGndkNumber = new System.Windows.Forms.NumericUpDown();
            this.detailPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.nbCurrentKm = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.dtpManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbController = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nbOilWarning = new System.Windows.Forms.NumericUpDown();
            this.tbOriginExplanation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpStartUsingYear = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.cbUseStatus = new System.Windows.Forms.ComboBox();
            this.actionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.resizePanel.SuspendLayout();
            this.fixedInfoPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbClLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSclTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGndkNumber)).BeginInit();
            this.detailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbCurrentKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbOilWarning)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.resizePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(764, 487);
            this.mainPanel.TabIndex = 0;
            // 
            // resizePanel
            // 
            this.resizePanel.AutoSize = true;
            this.resizePanel.Controls.Add(this.fixedInfoPanel);
            this.resizePanel.Controls.Add(this.infoPanel);
            this.resizePanel.Controls.Add(this.detailPanel);
            this.resizePanel.Controls.Add(this.actionPanel);
            this.resizePanel.Location = new System.Drawing.Point(2, 2);
            this.resizePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resizePanel.Name = "resizePanel";
            this.resizePanel.Padding = new System.Windows.Forms.Padding(27, 26, 27, 26);
            this.resizePanel.Size = new System.Drawing.Size(735, 663);
            this.resizePanel.TabIndex = 4;
            // 
            // fixedInfoPanel
            // 
            this.fixedInfoPanel.ColumnCount = 1;
            this.fixedInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fixedInfoPanel.Controls.Add(this.lbQk, 0, 0);
            this.fixedInfoPanel.Controls.Add(this.lbDv, 0, 1);
            this.fixedInfoPanel.Location = new System.Drawing.Point(29, 28);
            this.fixedInfoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fixedInfoPanel.Name = "fixedInfoPanel";
            this.fixedInfoPanel.RowCount = 2;
            this.fixedInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fixedInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fixedInfoPanel.Size = new System.Drawing.Size(642, 65);
            this.fixedInfoPanel.TabIndex = 3;
            // 
            // lbQk
            // 
            this.lbQk.AutoSize = true;
            this.lbQk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQk.Location = new System.Drawing.Point(2, 0);
            this.lbQk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQk.Name = "lbQk";
            this.lbQk.Size = new System.Drawing.Size(281, 24);
            this.lbQk.TabIndex = 0;
            this.lbQk.Text = "Quân khu: Quân khu 7 (QK7)";
            // 
            // lbDv
            // 
            this.lbDv.AutoSize = true;
            this.lbDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDv.Location = new System.Drawing.Point(2, 32);
            this.lbDv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDv.Name = "lbDv";
            this.lbDv.Size = new System.Drawing.Size(205, 24);
            this.lbDv.TabIndex = 1;
            this.lbDv.Text = "Đơn vị: Long An (LA)";
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 2;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.7713F));
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.2287F));
            this.infoPanel.Controls.Add(this.label3, 0, 9);
            this.infoPanel.Controls.Add(this.cbType, 1, 0);
            this.infoPanel.Controls.Add(this.label2, 0, 1);
            this.infoPanel.Controls.Add(this.tbRegisterCode, 1, 1);
            this.infoPanel.Controls.Add(this.tbModel, 1, 9);
            this.infoPanel.Controls.Add(this.label11, 0, 10);
            this.infoPanel.Controls.Add(this.cbLabel, 1, 10);
            this.infoPanel.Controls.Add(this.label10, 0, 2);
            this.infoPanel.Controls.Add(this.dtpRegisterYear, 1, 2);
            this.infoPanel.Controls.Add(this.tbFrameNumber, 1, 3);
            this.infoPanel.Controls.Add(this.label12, 0, 3);
            this.infoPanel.Controls.Add(this.label13, 0, 4);
            this.infoPanel.Controls.Add(this.tbEIN, 1, 4);
            this.infoPanel.Controls.Add(this.label16, 0, 11);
            this.infoPanel.Controls.Add(this.nbClLevel, 1, 11);
            this.infoPanel.Controls.Add(this.label17, 0, 12);
            this.infoPanel.Controls.Add(this.nbSclTime, 1, 12);
            this.infoPanel.Controls.Add(this.label18, 0, 13);
            this.infoPanel.Controls.Add(this.dtpRecentSclYear, 1, 13);
            this.infoPanel.Controls.Add(this.label19, 0, 6);
            this.infoPanel.Controls.Add(this.cbGroupLabel, 1, 6);
            this.infoPanel.Controls.Add(this.label21, 0, 5);
            this.infoPanel.Controls.Add(this.label22, 0, 8);
            this.infoPanel.Controls.Add(this.tbAcceptCode, 1, 8);
            this.infoPanel.Controls.Add(this.label1, 0, 0);
            this.infoPanel.Controls.Add(this.label23, 0, 7);
            this.infoPanel.Controls.Add(this.tbTypeDescription, 1, 7);
            this.infoPanel.Controls.Add(this.nbGndkNumber, 1, 5);
            this.infoPanel.Location = new System.Drawing.Point(29, 97);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 14;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.infoPanel.Size = new System.Drawing.Size(331, 457);
            this.infoPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(123, 2);
            this.cbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(150, 23);
            this.cbType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số đăng kí:";
            // 
            // tbRegisterCode
            // 
            this.tbRegisterCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterCode.Location = new System.Drawing.Point(123, 34);
            this.tbRegisterCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRegisterCode.MaxLength = 20;
            this.tbRegisterCode.Name = "tbRegisterCode";
            this.tbRegisterCode.Size = new System.Drawing.Size(150, 21);
            this.tbRegisterCode.TabIndex = 3;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(123, 290);
            this.tbModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbModel.MaxLength = 50;
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(150, 21);
            this.tbModel.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 320);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nhãn xe chuyên dùng:";
            // 
            // cbLabel
            // 
            this.cbLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLabel.FormattingEnabled = true;
            this.cbLabel.Location = new System.Drawing.Point(123, 322);
            this.cbLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLabel.Name = "cbLabel";
            this.cbLabel.Size = new System.Drawing.Size(121, 23);
            this.cbLabel.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Thời gian đăng kí:";
            // 
            // dtpRegisterYear
            // 
            this.dtpRegisterYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegisterYear.Location = new System.Drawing.Point(123, 66);
            this.dtpRegisterYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRegisterYear.Name = "dtpRegisterYear";
            this.dtpRegisterYear.Size = new System.Drawing.Size(206, 21);
            this.dtpRegisterYear.TabIndex = 9;
            // 
            // tbFrameNumber
            // 
            this.tbFrameNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFrameNumber.Location = new System.Drawing.Point(123, 98);
            this.tbFrameNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFrameNumber.MaxLength = 20;
            this.tbFrameNumber.Name = "tbFrameNumber";
            this.tbFrameNumber.Size = new System.Drawing.Size(150, 21);
            this.tbFrameNumber.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Số khung:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 128);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Số máy:";
            // 
            // tbEIN
            // 
            this.tbEIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEIN.Location = new System.Drawing.Point(123, 130);
            this.tbEIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEIN.MaxLength = 20;
            this.tbEIN.Name = "tbEIN";
            this.tbEIN.Size = new System.Drawing.Size(150, 21);
            this.tbEIN.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(2, 352);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Phân cấp CL:";
            // 
            // nbClLevel
            // 
            this.nbClLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbClLevel.Location = new System.Drawing.Point(123, 354);
            this.nbClLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbClLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nbClLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbClLevel.Name = "nbClLevel";
            this.nbClLevel.Size = new System.Drawing.Size(65, 21);
            this.nbClLevel.TabIndex = 17;
            this.nbClLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(2, 384);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 15);
            this.label17.TabIndex = 18;
            this.label17.Text = "Đã qua SCL lần:";
            // 
            // nbSclTime
            // 
            this.nbSclTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbSclTime.Location = new System.Drawing.Point(123, 386);
            this.nbSclTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbSclTime.Name = "nbSclTime";
            this.nbSclTime.Size = new System.Drawing.Size(65, 21);
            this.nbSclTime.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(2, 416);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "Năm SCL gần nhất:";
            // 
            // dtpRecentSclYear
            // 
            this.dtpRecentSclYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRecentSclYear.Location = new System.Drawing.Point(123, 418);
            this.dtpRecentSclYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRecentSclYear.Name = "dtpRecentSclYear";
            this.dtpRecentSclYear.Size = new System.Drawing.Size(206, 21);
            this.dtpRecentSclYear.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(2, 192);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 15);
            this.label19.TabIndex = 22;
            this.label19.Text = "Nhóm xe:";
            // 
            // cbGroupLabel
            // 
            this.cbGroupLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupLabel.FormattingEnabled = true;
            this.cbGroupLabel.Location = new System.Drawing.Point(123, 194);
            this.cbGroupLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGroupLabel.Name = "cbGroupLabel";
            this.cbGroupLabel.Size = new System.Drawing.Size(121, 23);
            this.cbGroupLabel.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(2, 160);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "Số GCNĐK:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(2, 256);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 15);
            this.label22.TabIndex = 26;
            this.label22.Text = "Số quyết định:";
            // 
            // tbAcceptCode
            // 
            this.tbAcceptCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAcceptCode.Location = new System.Drawing.Point(123, 258);
            this.tbAcceptCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAcceptCode.MaxLength = 20;
            this.tbAcceptCode.Name = "tbAcceptCode";
            this.tbAcceptCode.Size = new System.Drawing.Size(150, 21);
            this.tbAcceptCode.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại trang bị:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(2, 224);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 15);
            this.label23.TabIndex = 28;
            this.label23.Text = "Loại xe:";
            // 
            // tbTypeDescription
            // 
            this.tbTypeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTypeDescription.Location = new System.Drawing.Point(123, 226);
            this.tbTypeDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTypeDescription.MaxLength = 50;
            this.tbTypeDescription.Name = "tbTypeDescription";
            this.tbTypeDescription.Size = new System.Drawing.Size(150, 21);
            this.tbTypeDescription.TabIndex = 29;
            // 
            // nbGndkNumber
            // 
            this.nbGndkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbGndkNumber.Location = new System.Drawing.Point(123, 162);
            this.nbGndkNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbGndkNumber.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nbGndkNumber.Name = "nbGndkNumber";
            this.nbGndkNumber.Size = new System.Drawing.Size(80, 21);
            this.nbGndkNumber.TabIndex = 30;
            // 
            // detailPanel
            // 
            this.detailPanel.ColumnCount = 2;
            this.detailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.29572F));
            this.detailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.70428F));
            this.detailPanel.Controls.Add(this.label4, 0, 3);
            this.detailPanel.Controls.Add(this.nbCurrentKm, 1, 6);
            this.detailPanel.Controls.Add(this.label8, 0, 6);
            this.detailPanel.Controls.Add(this.label5, 0, 4);
            this.detailPanel.Controls.Add(this.tbOrigin, 1, 3);
            this.detailPanel.Controls.Add(this.dtpManufactureDate, 1, 4);
            this.detailPanel.Controls.Add(this.label9, 0, 0);
            this.detailPanel.Controls.Add(this.label7, 0, 8);
            this.detailPanel.Controls.Add(this.tbController, 1, 0);
            this.detailPanel.Controls.Add(this.tbNote, 1, 8);
            this.detailPanel.Controls.Add(this.label6, 0, 7);
            this.detailPanel.Controls.Add(this.nbOilWarning, 1, 7);
            this.detailPanel.Controls.Add(this.tbOriginExplanation, 1, 2);
            this.detailPanel.Controls.Add(this.label14, 0, 2);
            this.detailPanel.Controls.Add(this.label15, 0, 5);
            this.detailPanel.Controls.Add(this.dtpStartUsingYear, 1, 5);
            this.detailPanel.Controls.Add(this.label20, 0, 1);
            this.detailPanel.Controls.Add(this.cbUseStatus, 1, 1);
            this.detailPanel.Location = new System.Drawing.Point(364, 97);
            this.detailPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.RowCount = 9;
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.detailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.detailPanel.Size = new System.Drawing.Size(342, 457);
            this.detailPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nơi sản xuất:";
            // 
            // nbCurrentKm
            // 
            this.nbCurrentKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbCurrentKm.Location = new System.Drawing.Point(112, 207);
            this.nbCurrentKm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbCurrentKm.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nbCurrentKm.Name = "nbCurrentKm";
            this.nbCurrentKm.Size = new System.Drawing.Size(101, 21);
            this.nbCurrentKm.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số Km hiện tại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Năm sản xuất:";
            // 
            // tbOrigin
            // 
            this.tbOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigin.Location = new System.Drawing.Point(112, 98);
            this.tbOrigin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOrigin.MaxLength = 100;
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(153, 21);
            this.tbOrigin.TabIndex = 3;
            // 
            // dtpManufactureDate
            // 
            this.dtpManufactureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpManufactureDate.Location = new System.Drawing.Point(112, 130);
            this.dtpManufactureDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            this.dtpManufactureDate.Size = new System.Drawing.Size(211, 21);
            this.dtpManufactureDate.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Người điều khiển:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú:";
            // 
            // tbController
            // 
            this.tbController.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbController.Location = new System.Drawing.Point(112, 2);
            this.tbController.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbController.MaxLength = 100;
            this.tbController.Name = "tbController";
            this.tbController.Size = new System.Drawing.Size(150, 21);
            this.tbController.TabIndex = 7;
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNote.Location = new System.Drawing.Point(112, 310);
            this.tbNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNote.MaxLength = 300;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(223, 142);
            this.tbNote.TabIndex = 7;
            this.tbNote.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khoảng cách mỗi lần thay nhớt(km):";
            // 
            // nbOilWarning
            // 
            this.nbOilWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbOilWarning.Location = new System.Drawing.Point(112, 252);
            this.nbOilWarning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbOilWarning.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nbOilWarning.Name = "nbOilWarning";
            this.nbOilWarning.Size = new System.Drawing.Size(101, 21);
            this.nbOilWarning.TabIndex = 6;
            // 
            // tbOriginExplanation
            // 
            this.tbOriginExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOriginExplanation.Location = new System.Drawing.Point(112, 66);
            this.tbOriginExplanation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOriginExplanation.MaxLength = 100;
            this.tbOriginExplanation.Name = "tbOriginExplanation";
            this.tbOriginExplanation.Size = new System.Drawing.Size(153, 21);
            this.tbOriginExplanation.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Nguồn gốc:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 173);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 30);
            this.label15.TabIndex = 11;
            this.label15.Text = "Năm bắt đầu sử dụng:";
            // 
            // dtpStartUsingYear
            // 
            this.dtpStartUsingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartUsingYear.Location = new System.Drawing.Point(112, 175);
            this.dtpStartUsingYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStartUsingYear.Name = "dtpStartUsingYear";
            this.dtpStartUsingYear.Size = new System.Drawing.Size(209, 21);
            this.dtpStartUsingYear.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(2, 32);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 30);
            this.label20.TabIndex = 13;
            this.label20.Text = "Trạng thái sử dụng:";
            // 
            // cbUseStatus
            // 
            this.cbUseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUseStatus.FormattingEnabled = true;
            this.cbUseStatus.Location = new System.Drawing.Point(112, 34);
            this.cbUseStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUseStatus.Name = "cbUseStatus";
            this.cbUseStatus.Size = new System.Drawing.Size(103, 23);
            this.cbUseStatus.TabIndex = 14;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnAdd);
            this.actionPanel.Location = new System.Drawing.Point(29, 558);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(677, 77);
            this.actionPanel.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(300, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(300, 13, 13, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(20, 13, 20, 13);
            this.btnAdd.Size = new System.Drawing.Size(99, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 487);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AddMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm trang bị";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.resizePanel.ResumeLayout(false);
            this.fixedInfoPanel.ResumeLayout(false);
            this.fixedInfoPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbClLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSclTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGndkNumber)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbCurrentKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbOilWarning)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel infoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegisterCode;
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
        private System.Windows.Forms.Label lbDv;
        private System.Windows.Forms.DateTimePicker dtpManufactureDate;
        private System.Windows.Forms.NumericUpDown nbCurrentKm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbController;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpRegisterYear;
        private System.Windows.Forms.TextBox tbFrameNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEIN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nbClLevel;
        private System.Windows.Forms.TextBox tbOriginExplanation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpStartUsingYear;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nbSclTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpRecentSclYear;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbGroupLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbAcceptCode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbUseStatus;
        private System.Windows.Forms.FlowLayoutPanel resizePanel;
        private System.Windows.Forms.FlowLayoutPanel actionPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbTypeDescription;
        private System.Windows.Forms.NumericUpDown nbGndkNumber;
    }
}