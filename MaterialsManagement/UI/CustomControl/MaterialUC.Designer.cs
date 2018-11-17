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
            this.btnSail = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.actionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.parentPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // parentPanel
            // 
            this.parentPanel.AutoSize = true;
            this.parentPanel.Controls.Add(this.leftPanel);
            this.parentPanel.Controls.Add(this.rightPanel);
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentPanel.Location = new System.Drawing.Point(0, 0);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(1250, 750);
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
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.actionPanel);
            this.rightPanel.Controls.Add(this.gridData);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightPanel.Location = new System.Drawing.Point(209, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.rightPanel.Size = new System.Drawing.Size(1038, 694);
            this.rightPanel.TabIndex = 1;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnAdd);
            this.actionPanel.Controls.Add(this.tbSearch);
            this.actionPanel.Controls.Add(this.btnSearch);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionPanel.Location = new System.Drawing.Point(33, 3);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(1005, 100);
            this.actionPanel.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackgroundImage = global::MaterialsManagement.Properties.Resources.plus_24;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(40, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(40, 30, 3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 0;
            this.MyToolTip.SetToolTip(this.btnAdd, "Thêm");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(393, 40);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(300, 40, 3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(291, 35);
            this.tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackgroundImage = global::MaterialsManagement.Properties.Resources.search_24;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(697, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 30, 3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 50);
            this.btnSearch.TabIndex = 2;
            this.MyToolTip.SetToolTip(this.btnSearch, "Tìm kiếm");
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridData.Location = new System.Drawing.Point(33, 109);
            this.gridData.MultiSelect = false;
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowTemplate.Height = 28;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(1005, 585);
            this.gridData.TabIndex = 1;
            this.gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellClick);
            // 
            // MaterialUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.parentPanel);
            this.Name = "MaterialUC";
            this.Size = new System.Drawing.Size(1250, 750);
            this.parentPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel parentPanel;
        private System.Windows.Forms.FlowLayoutPanel leftPanel;
        private System.Windows.Forms.Button btnSail;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.FlowLayoutPanel rightPanel;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.FlowLayoutPanel actionPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridData;
    }
}
