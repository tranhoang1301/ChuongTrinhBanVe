namespace PhanMemBanVeXemPhim
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.chkLaHSSV = new System.Windows.Forms.CheckBox();
            this.btnXacNhanKH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKH.Location = new System.Drawing.Point(155, 18);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(192, 27);
            this.txtTenKH.TabIndex = 1;
            // 
            // chkLaHSSV
            // 
            this.chkLaHSSV.AutoSize = true;
            this.chkLaHSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkLaHSSV.Location = new System.Drawing.Point(16, 57);
            this.chkLaHSSV.Name = "chkLaHSSV";
            this.chkLaHSSV.Size = new System.Drawing.Size(189, 26);
            this.chkLaHSSV.TabIndex = 2;
            this.chkLaHSSV.Text = "Học sinh - Sinh viên";
            this.chkLaHSSV.UseVisualStyleBackColor = true;
            // 
            // btnXacNhanKH
            // 
            this.btnXacNhanKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhanKH.Image = global::PhanMemBanVeXemPhim.Properties.Resources.Ok_icon;
            this.btnXacNhanKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhanKH.Location = new System.Drawing.Point(223, 77);
            this.btnXacNhanKH.Name = "btnXacNhanKH";
            this.btnXacNhanKH.Size = new System.Drawing.Size(114, 37);
            this.btnXacNhanKH.TabIndex = 3;
            this.btnXacNhanKH.Text = "Xác nhận";
            this.btnXacNhanKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhanKH.UseVisualStyleBackColor = true;
            this.btnXacNhanKH.Click += new System.EventHandler(this.btnXacNhanKH_Click);
            // 
            // frmKhachHang
            // 
            this.AcceptButton = this.btnXacNhanKH;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 121);
            this.Controls.Add(this.btnXacNhanKH);
            this.Controls.Add(this.chkLaHSSV);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhanKH;
        public System.Windows.Forms.TextBox txtTenKH;
        public System.Windows.Forms.CheckBox chkLaHSSV;
    }
}