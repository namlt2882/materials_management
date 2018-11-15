namespace MaterialsManagement.UI.CustomControl
{
    partial class MaterialUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.parentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSail = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sdk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // parentPanel
            // 
            this.parentPanel.Controls.Add(this.leftPanel);
            this.parentPanel.Controls.Add(this.rightPanel);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanel.Location = new System.Drawing.Point(0, 0);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(1250, 700);
            this.parentPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.btnSail);
            this.leftPanel.Controls.Add(this.btnCar);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(12, 50, 12, 12);
            this.leftPanel.Size = new System.Drawing.Size(200, 694);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.flowLayoutPanel1);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightPanel.Location = new System.Drawing.Point(209, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.rightPanel.Size = new System.Drawing.Size(1038, 694);
            this.rightPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1005, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(393, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(300, 40, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 35);
            this.textBox1.TabIndex = 1;
            // 
            // btnSail
            // 
            this.btnSail.AutoSize = true;
            this.btnSail.BackColor = System.Drawing.Color.LightGray;
            this.btnSail.BackgroundImage = global::MaterialsManagement.Properties.Resources.sail_50;
            this.btnSail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSail.Location = new System.Drawing.Point(15, 53);
            this.btnSail.Name = "btnSail";
            this.btnSail.Size = new System.Drawing.Size(165, 85);
            this.btnSail.TabIndex = 0;
            this.MyToolTip.SetToolTip(this.btnSail, "Tàu, thuyền");
            this.btnSail.UseVisualStyleBackColor = false;
            this.btnSail.Click += new System.EventHandler(this.btnSail_Click);
            // 
            // btnCar
            // 
            this.btnCar.AutoSize = true;
            this.btnCar.BackColor = System.Drawing.Color.LightGray;
            this.btnCar.BackgroundImage = global::MaterialsManagement.Properties.Resources.car_50;
            this.btnCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCar.Location = new System.Drawing.Point(15, 144);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(165, 85);
            this.btnCar.TabIndex = 1;
            this.MyToolTip.SetToolTip(this.btnCar, "Xe hơi");
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::MaterialsManagement.Properties.Resources.plus_24;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(40, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(40, 30, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.MyToolTip.SetToolTip(this.button1, "Thêm");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = global::MaterialsManagement.Properties.Resources.search_24;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(697, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 30, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 50);
            this.button2.TabIndex = 2;
            this.MyToolTip.SetToolTip(this.button2, "Tìm kiếm");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdk,
            this.model});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(33, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 585);
            this.dataGridView1.TabIndex = 1;
            // 
            // sdk
            // 
            this.sdk.HeaderText = "SDK";
            this.sdk.Name = "sdk";
            this.sdk.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // MaterialUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parentPanel);
            this.Name = "MaterialUC";
            this.Size = new System.Drawing.Size(1250, 700);
            this.parentPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel parentPanel;
        private System.Windows.Forms.FlowLayoutPanel leftPanel;
        private System.Windows.Forms.Button btnSail;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.FlowLayoutPanel rightPanel;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdk;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
    }
}
