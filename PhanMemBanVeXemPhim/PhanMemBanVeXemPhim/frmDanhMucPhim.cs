using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemBanVeXemPhim
{
    public partial class frmDanhMucPhim : Form
    {
        public static bool Cothaydoi = false;
       // List<Phong> phongdachon = new List<Phong>();
        public frmDanhMucPhim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenPhim, "");
            errorProvider1.SetError(cbbSoPhong, "");
            if (txtTenPhim.Text != "" && cbbSoPhong.SelectedIndex!=-1)
            {
                Phim phi = new Phim();
                phi.TenPhim = txtTenPhim.Text;
                Phong room = cbbSoPhong.SelectedItem as Phong;
                phi.ChieuTai = room;
                Form1.dsphim.Add(phi);
                Form1.dsphong.Remove(room);
            }
            else
            {
                if (txtTenPhim.Text == "")
                    errorProvider1.SetError(txtTenPhim, "Bạn chưa nhập tên phim!");
                if (cbbSoPhong.SelectedIndex==-1)
                    errorProvider1.SetError(cbbSoPhong, "Cần chọn một phòng");
            }

            HienThiDanhSachPhimLenListBox();
            HiemThiPhongLenCombobox();
            txtTenPhim.Text = "";
            cbbSoPhong.Text = "";
            cbbSoPhong.SelectedIndex = -1;
            txtTenPhim.Focus();
            Cothaydoi = true;
        }

        private void HienThiDanhSachPhimLenListBox()
        {
            lstDanhSachPhim.Items.Clear();
            foreach (Phim phi in Form1.dsphim)
            {
                lstDanhSachPhim.Items.Add(phi);
            }
        }

        private void frmDanhMucPhim_Load(object sender, EventArgs e)
        {
            HienThiDanhSachPhimLenListBox();
            HiemThiPhongLenCombobox();
           
          
        }

        private void HiemThiPhongLenCombobox()
        {
            cbbSoPhong.Items.Clear();
            foreach (Phong room in Form1.dsphong)
            {
                cbbSoPhong.Items.Add(room);
            }
        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            if (lstDanhSachPhim.SelectedIndex != -1)
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa phim này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    Phim phi = lstDanhSachPhim.SelectedItem as Phim;
                    lstDanhSachPhim.Items.Remove(phi);
                    Form1.dsphim.Remove(phi);
                    txtTenPhim.Text = "";
                    cbbSoPhong.Text = "";
                    Form1.dsphong.Add(phi.ChieuTai);
                    cbbSoPhong.SelectedIndex = -1;
                    HienThiDanhSachPhimLenListBox();
                    HiemThiPhongLenCombobox();
                }
            }
            Cothaydoi = true;
        }

        private void btnDongDanhMucPhim_Click(object sender, EventArgs e)
        {

            if (Cothaydoi == true)
                DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Cancel;
        }

        private void lstDanhSachPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSachPhim.SelectedIndex == -1)
                return;
            Phim phi = lstDanhSachPhim.SelectedItem as Phim;
            txtTenPhim.Text = phi.TenPhim;
            cbbSoPhong.Text=phi.ChieuTai.ToString();
        }
    }
}
