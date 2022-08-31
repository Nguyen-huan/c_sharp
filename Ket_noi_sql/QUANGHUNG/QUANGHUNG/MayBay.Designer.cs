namespace QUANGHUNG
{
    partial class MayBay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMayBay = new System.Windows.Forms.TextBox();
            this.txtMaHSX = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.dgvMayBay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hãng Sản Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Máy Bay";
            // 
            // txtMaMayBay
            // 
            this.txtMaMayBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMayBay.Location = new System.Drawing.Point(180, 20);
            this.txtMaMayBay.Name = "txtMaMayBay";
            this.txtMaMayBay.Size = new System.Drawing.Size(152, 38);
            this.txtMaMayBay.TabIndex = 0;
            // 
            // txtMaHSX
            // 
            this.txtMaHSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHSX.Location = new System.Drawing.Point(180, 64);
            this.txtMaHSX.Name = "txtMaHSX";
            this.txtMaHSX.Size = new System.Drawing.Size(152, 38);
            this.txtMaHSX.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(365, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(158, 42);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTimKiem_MouseClick);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.AutoSize = true;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChinhSua.Location = new System.Drawing.Point(358, 65);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(157, 42);
            this.btnChinhSua.TabIndex = 3;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // dgvMayBay
            // 
            this.dgvMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayBay.Location = new System.Drawing.Point(25, 128);
            this.dgvMayBay.Name = "dgvMayBay";
            this.dgvMayBay.RowHeadersWidth = 51;
            this.dgvMayBay.RowTemplate.Height = 24;
            this.dgvMayBay.Size = new System.Drawing.Size(661, 225);
            this.dgvMayBay.TabIndex = 6;
            // 
            // MayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 365);
            this.Controls.Add(this.dgvMayBay);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtMaHSX);
            this.Controls.Add(this.txtMaMayBay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MayBay";
            this.Text = "mAYbAY";
            this.Load += new System.EventHandler(this.mAYbAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMayBay;
        private System.Windows.Forms.TextBox txtMaHSX;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.DataGridView dgvMayBay;
    }
}