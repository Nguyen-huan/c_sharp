namespace BaiThi.solution
{
    partial class Bai_thi
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
            this.txtMamb = new System.Windows.Forms.TextBox();
            this.txtMaHSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMayBay = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Máy Bay";
            // 
            // txtMamb
            // 
            this.txtMamb.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMamb.Location = new System.Drawing.Point(312, 15);
            this.txtMamb.Name = "txtMamb";
            this.txtMamb.Size = new System.Drawing.Size(125, 43);
            this.txtMamb.TabIndex = 0;
            this.txtMamb.TextChanged += new System.EventHandler(this.txtMamb_TextChanged);
            this.txtMamb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMamb_KeyPress);
            // 
            // txtMaHSX
            // 
            this.txtMaHSX.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHSX.Location = new System.Drawing.Point(312, 67);
            this.txtMaHSX.Name = "txtMaHSX";
            this.txtMaHSX.Size = new System.Drawing.Size(125, 43);
            this.txtMaHSX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hãng Sản Xuất";
            // 
            // dgvMayBay
            // 
            this.dgvMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayBay.Location = new System.Drawing.Point(15, 132);
            this.dgvMayBay.Name = "dgvMayBay";
            this.dgvMayBay.RowHeadersWidth = 51;
            this.dgvMayBay.RowTemplate.Height = 29;
            this.dgvMayBay.Size = new System.Drawing.Size(635, 188);
            this.dgvMayBay.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.Location = new System.Drawing.Point(498, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(152, 48);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTimKiem_MouseClick);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(498, 69);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(152, 48);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Chỉnh Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSua_MouseClick);
            // 
            // Bai_thi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 332);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvMayBay);
            this.Controls.Add(this.txtMaHSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMamb);
            this.Controls.Add(this.label1);
            this.Name = "Bai_thi";
            this.Text = "Bai_thi";
            this.Load += new System.EventHandler(this.Bai_thi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtMamb;
        private TextBox txtMaHSX;
        private Label label2;
        private DataGridView dgvMayBay;
        private Button btnTimKiem;
        private Button btnSua;
    }
}