namespace Garica0211
{
    partial class ActiveGrid
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
            this.dtgActive = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActive)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgActive
            // 
            this.dtgActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActive.Location = new System.Drawing.Point(147, 0);
            this.dtgActive.Name = "dtgActive";
            this.dtgActive.Size = new System.Drawing.Size(653, 311);
            this.dtgActive.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(129, 32);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnActive
            // 
            this.btnActive.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.Location = new System.Drawing.Point(12, 50);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(129, 32);
            this.btnActive.TabIndex = 14;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // ActiveGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.ControlBox = false;
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dtgActive);
            this.Name = "ActiveGrid";
            this.Text = "ActiveGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dtgActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgActive;
        public System.Windows.Forms.Button btnReturn;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnActive;
    }
}