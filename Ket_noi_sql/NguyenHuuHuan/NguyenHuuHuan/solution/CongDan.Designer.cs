namespace NguyenHuuHuan.solution
{
    partial class CongDan
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
            this.dgvCongDan = new System.Windows.Forms.DataGridView();
            this.btnSapXep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongDan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCongDan
            // 
            this.dgvCongDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongDan.Location = new System.Drawing.Point(12, 12);
            this.dgvCongDan.Name = "dgvCongDan";
            this.dgvCongDan.RowHeadersWidth = 51;
            this.dgvCongDan.RowTemplate.Height = 24;
            this.dgvCongDan.Size = new System.Drawing.Size(773, 225);
            this.dgvCongDan.TabIndex = 0;
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSapXep.Location = new System.Drawing.Point(29, 256);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(240, 60);
            this.btnSapXep.TabIndex = 1;
            this.btnSapXep.Text = "Click To Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSapXep_MouseClick);
            // 
            // CongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 332);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.dgvCongDan);
            this.Name = "CongDan";
            this.Text = "CongDan";
            this.Load += new System.EventHandler(this.CongDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongDan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCongDan;
        private System.Windows.Forms.Button btnSapXep;
    }
}