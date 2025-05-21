namespace Garica0211
{
    partial class DataGrid
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
            this.dtgInfoSheet = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInfoSheet
            // 
            this.dtgInfoSheet.AllowUserToAddRows = false;
            this.dtgInfoSheet.AllowUserToDeleteRows = false;
            this.dtgInfoSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfoSheet.Location = new System.Drawing.Point(12, 55);
            this.dtgInfoSheet.Name = "dtgInfoSheet";
            this.dtgInfoSheet.ReadOnly = true;
            this.dtgInfoSheet.Size = new System.Drawing.Size(776, 341);
            this.dtgInfoSheet.TabIndex = 0;
            this.dtgInfoSheet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInfoSheet_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(660, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 33);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(442, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 33);
            this.txtSearch.TabIndex = 48;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(660, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 33);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(12, 409);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(128, 33);
            this.lblDelete.TabIndex = 50;
            this.lblDelete.Text = "Delete";
            this.lblDelete.UseVisualStyleBackColor = true;
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtgInfoSheet);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "DataGrid";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgInfoSheet;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button lblDelete;
    }
}