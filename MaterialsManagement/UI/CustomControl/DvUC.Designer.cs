namespace MaterialsManagement.UI.CustomControl
{
    partial class DvUC
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
            this.tableLayoutQkList = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutQkList
            // 
            this.tableLayoutQkList.AutoScroll = true;
            this.tableLayoutQkList.AutoSize = true;
            this.tableLayoutQkList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutQkList.ColumnCount = 4;
            this.tableLayoutQkList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutQkList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutQkList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutQkList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutQkList.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutQkList.Name = "tableLayoutQkList";
            this.tableLayoutQkList.RowCount = 1;
            this.tableLayoutQkList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutQkList.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutQkList.TabIndex = 0;
            // 
            // DvUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutQkList);
            this.Name = "DvUC";
            this.Size = new System.Drawing.Size(949, 189);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutQkList;
    }
}
