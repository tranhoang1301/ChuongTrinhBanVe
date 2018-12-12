namespace PhanMemBanVeXemPhim
{
    partial class frmDanhMucPhim
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDanhSachPhim = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSoPhong = new System.Windows.Forms.ComboBox();
            this.btnDongDanhMucPhim = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLuuPhim = new System.Windows.Forms.Button();
            this.btnXoaPhim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDanhSachPhim);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phim";
            // 
            // lstDanhSachPhim
            // 
            this.lstDanhSachPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDanhSachPhim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstDanhSachPhim.FormattingEnabled = true;
            this.lstDanhSachPhim.ItemHeight = 21;
            this.lstDanhSachPhim.Location = new System.Drawing.Point(3, 23);
            this.lstDanhSachPhim.Name = "lstDanhSachPhim";
            this.lstDanhSachPhim.Size = new System.Drawing.Size(199, 143);
            this.lstDanhSachPhim.TabIndex = 0;
            this.lstDanhSachPhim.SelectedIndexChanged += new System.EventHandler(this.lstDanhSachPhim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(247, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên phim: ";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhim.Location = new System.Drawing.Point(352, 35);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(211, 26);
            this.txtTenPhim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(228, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn số phòng: ";
            // 
            // cbbSoPhong
            // 
            this.cbbSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbSoPhong.FormattingEnabled = true;
            this.cbbSoPhong.Location = new System.Drawing.Point(352, 93);
            this.cbbSoPhong.Name = "cbbSoPhong";
            this.cbbSoPhong.Size = new System.Drawing.Size(211, 28);
            this.cbbSoPhong.TabIndex = 4;
            // 
            // btnDongDanhMucPhim
            // 
            this.btnDongDanhMucPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDongDanhMucPhim.Image = global::PhanMemBanVeXemPhim.Properties.Resources.Button_Close_icon__1_;
            this.btnDongDanhMucPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongDanhMucPhim.Location = new System.Drawing.Point(478, 139);
            this.btnDongDanhMucPhim.Name = "btnDongDanhMucPhim";
            this.btnDongDanhMucPhim.Size = new System.Drawing.Size(85, 41);
            this.btnDongDanhMucPhim.TabIndex = 7;
            this.btnDongDanhMucPhim.Text = "Đóng";
            this.btnDongDanhMucPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongDanhMucPhim.UseVisualStyleBackColor = true;
            this.btnDongDanhMucPhim.Click += new System.EventHandler(this.btnDongDanhMucPhim_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLuuPhim
            // 
            this.btnLuuPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuPhim.Image = global::PhanMemBanVeXemPhim.Properties.Resources.Save_icon;
            this.btnLuuPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPhim.Location = new System.Drawing.Point(267, 139);
            this.btnLuuPhim.Name = "btnLuuPhim";
            this.btnLuuPhim.Size = new System.Drawing.Size(85, 41);
            this.btnLuuPhim.TabIndex = 5;
            this.btnLuuPhim.Text = "Lưu";
            this.btnLuuPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuPhim.UseVisualStyleBackColor = true;
            this.btnLuuPhim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoaPhim
            // 
            this.btnXoaPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaPhim.Image = global::PhanMemBanVeXemPhim.Properties.Resources.Misc_Delete_Database_icon;
            this.btnXoaPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhim.Location = new System.Drawing.Point(375, 139);
            this.btnXoaPhim.Name = "btnXoaPhim";
            this.btnXoaPhim.Size = new System.Drawing.Size(85, 41);
            this.btnXoaPhim.TabIndex = 6;
            this.btnXoaPhim.Text = "Xóa";
            this.btnXoaPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhim.UseVisualStyleBackColor = true;
            this.btnXoaPhim.Click += new System.EventHandler(this.btnXoaPhim_Click);
            // 
            // frmDanhMucPhim
            // 
            this.AcceptButton = this.btnLuuPhim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 192);
            this.Controls.Add(this.btnDongDanhMucPhim);
            this.Controls.Add(this.btnXoaPhim);
            this.Controls.Add(this.btnLuuPhim);
            this.Controls.Add(this.cbbSoPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmDanhMucPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật danh sách phim";
            this.Load += new System.EventHandler(this.frmDanhMucPhim_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDanhSachPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSoPhong;
        private System.Windows.Forms.Button btnLuuPhim;
        private System.Windows.Forms.Button btnXoaPhim;
        private System.Windows.Forms.Button btnDongDanhMucPhim;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}