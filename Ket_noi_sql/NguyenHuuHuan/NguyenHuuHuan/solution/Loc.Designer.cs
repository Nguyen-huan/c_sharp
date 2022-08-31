namespace NguyenHuuHuan.solution
{
    partial class Loc
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
            this.dgvLoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoc
            // 
            this.dgvLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoc.Location = new System.Drawing.Point(16, 81);
            this.dgvLoc.Name = "dgvLoc";
            this.dgvLoc.RowHeadersWidth = 51;
            this.dgvLoc.RowTemplate.Height = 24;
            this.dgvLoc.Size = new System.Drawing.Size(877, 177);
            this.dgvLoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sau Khi Lọc Từ CSDL";
            // 
            // Loc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoc);
            this.Name = "Loc";
            this.Text = "Loc";
            this.Load += new System.EventHandler(this.Loc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoc;
        private System.Windows.Forms.Label label1;
    }
}