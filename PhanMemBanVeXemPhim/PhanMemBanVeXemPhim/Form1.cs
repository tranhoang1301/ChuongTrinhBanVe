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
    public partial class Form1 : Form
    {
        public static List<Phong> dsphong = new List<Phong>();
        public static List<Phim> dsphim = new List<Phim>();
        public static List<TableLayoutPanel> dspn = new List<TableLayoutPanel>();
        public static List<ListBox> dslstKH = new List<ListBox>();
        List<KhachHang> dskh = new List<KhachHang>();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0; i<cbbDanhSachPhim.Items.Count;i++)
            {
                if (cbbDanhSachPhim.SelectedIndex == i)
                {

                    Phim phi = cbbDanhSachPhim.SelectedItem as Phim;
                    lblHienThiSoPhong.Text = phi.ChieuTai + "";
                    groupBox3.Text = "Sơ đồ ghế tại: " + phi.ChieuTai;
                    groupBox2.Text = "Danh sách khách hàng tại " + phi.ChieuTai;
                    dslstKH[i].Visible = true;
                    dspn[i].Visible = true;

                }
                else
                {
                    dspn[i].Visible = false;
                    dslstKH[i].Visible = false;
                }
            }
        }

        private void btnLuuSoPhong_Click(object sender, EventArgs e)
        {
            if (txtSoPhong.Text != null)
            {
                try
                {

                    dsphong.Clear();
                    int sophong = int.Parse(txtSoPhong.Text);
                    for (int i = 1; i <= sophong; i++)
                    {
                        Phong room = new Phong();
                        room.TenPhong = "Phòng Số " + i;
                        dsphong.Add(room);
                    }

                    MessageBox.Show("Đã lưu!");
                }
                catch
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSoPhong.ReadOnly = false;
            lblGiaVe.Text = "--GIÁ VÉ--\r\nGhế thường: 50000 VNĐ\r\nGhế VIP:70000 VNĐ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDanhMucPhim frmDMP = new frmDanhMucPhim();
            frmDanhMucPhim.Cothaydoi = false;
            frmDMP.ShowDialog();
            if (frmDanhMucPhim.Cothaydoi == true)
            {
                cbbDanhSachPhim.Items.Clear();
                foreach (Phim phi in dsphim)
                {
                    cbbDanhSachPhim.Items.Add(phi);
                }
                VeGheLenGiaoDien();
            }
            if(cbbDanhSachPhim.Items.Count!=0)
                txtSoPhong.ReadOnly = true;

        }

        private void VeGheLenGiaoDien()
        {
            TableLayoutPanel[] arrpn = new TableLayoutPanel[dsphim.Count];
            ListBox[] arrlst = new ListBox[dsphim.Count];
            for (int i = 0; i < dsphim.Count; i++)
            {
                arrpn[i] = new TableLayoutPanel();
                arrpn[i].Dock = DockStyle.Fill;
                arrpn[i].ColumnCount = 8;
                arrpn[i].RowCount = 10;
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                arrpn[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                arrpn[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                arrpn[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                arrpn[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                arrpn[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                arrpn[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                arrpn[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                arrpn[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                arrpn[i].BackColor = Color.Yellow;
                arrlst[i] = new ListBox();
                arrlst[i].Dock = DockStyle.Fill;
                arrlst[i].BackColor = Color.Brown; 
                dslstKH.Add(arrlst[i]);
                groupBox2.Controls.Add(arrlst[i]);
                dspn.Add(arrpn[i]);
                groupBox3.Controls.Add(arrpn[i]);
                VeLabelLenPn(arrpn[i]);
            }
        }

        private void VeLabelLenPn(TableLayoutPanel pnGhe)
        {
            int ghe = 1;
            for (int i = 0; i < pnGhe.RowCount; i++)
            {
                for (int j = 0; j < pnGhe.ColumnCount; j++)
                {
                    Label lbl = new Label();
                    lbl.AutoSize = false;
                    lbl.Dock = DockStyle.Fill;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Text = ghe + "";
                    lbl.BackColor = Color.WhiteSmoke;
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    if(i==pnGhe.RowCount-1)
                    {
                        lbl.Text = ghe + " (VIP)";
                    }
                    pnGhe.Controls.Add(lbl, j, i);
                    ghe++;
                    lbl.Click += Lbl_Click;
                }

            }
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl.BackColor == Color.WhiteSmoke)
                lbl.BackColor = Color.Green;
            else if (lbl.BackColor == Color.Green)
                lbl.BackColor = Color.WhiteSmoke;
            else if (lbl.BackColor == Color.Yellow)
                MessageBox.Show("Ghế [" + lbl.Text + "] đã có người chọn!");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbDanhSachPhim.SelectedIndex != -1)
            {
                frmKhachHang frmKH = new frmKhachHang();
                if (frmKH.ShowDialog() == DialogResult.OK)
                {
                    KhachHang kh = new KhachHang();
                    kh.Name = frmKH.txtTenKH.Text;
                    kh.TGD = kh.ThoiGianDat;
                    Phim phi = cbbDanhSachPhim.SelectedItem as Phim;
                    kh.PhimDat = phi;
                    if (frmKH.chkLaHSSV.Checked)
                    {
                        kh.LaHSSV = true;
                    }
                    else
                        kh.LaHSSV = false;
                    bool select = false;
                    int j = cbbDanhSachPhim.SelectedIndex;
                    for (int i = 0; i < dspn[j].Controls.Count; i++)
                    {
                        Label lbl = dspn[j].Controls[i] as Label;
                        if (lbl.BackColor == Color.Green)
                        {
                            select = true;
                            lbl.BackColor = Color.Yellow;
                            string txtlbl = lbl.Text;
                            if (txtlbl.Length > 2)
                            {
                                kh.GheVips.Add(txtlbl);
                            }
                            else
                                kh.GheThuongs.Add(int.Parse(lbl.Text));
                        }

                    }
                    if (select == true)
                    {
                        dskh.Add(kh);
                        HienThiThanhTien(kh);

                    }
                    HienThiKhachHangLenListBox(dslstKH[j], phi.ChieuTai);
                    dslstKH[j].SelectedIndexChanged += Form1_SelectedIndexChanged;
                }
            }
        }

        private void HienThiThanhTien(KhachHang kh)
        {
            if (kh.LaHSSV)
            {
                lblThanhTien.Text = kh.GheThuongs.Count + " ghế thường + "
                    + kh.GheVips.Count + " ghế VIP [-20%]\r\n\r\n" +
                   "Thành tiền:\t " + kh.TinhTien + " VNĐ";
            }
            else
            {
                lblThanhTien.Text = kh.GheThuongs.Count + " ghế thường + "
                    + kh.GheVips.Count + " ghế VIP\r\n\r\n" +
                   "Thành tiền:\t " + kh.TinhTien + " VNĐ";
            }
        }

        private void Form1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            if (lst.SelectedIndex != -1)
            {
                KhachHang kh = lst.SelectedItem as KhachHang;
                HienThiThanhTien(kh);
            }
        }

        private void HienThiKhachHangLenListBox(ListBox lst,Phong room)
        {
            lst.Items.Clear();
            foreach (KhachHang kh in dskh)
            {
                if(kh.PhimDat.ChieuTai==room)
                        lst.Items.Add(kh);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int vt = cbbDanhSachPhim.SelectedIndex;
            
            if (dslstKH[vt].SelectedIndex != -1)
            {
                KhachHang kh = dslstKH[vt].SelectedItem as KhachHang;
                DateTime ThoiGianHuy = DateTime.Now;

                TimeSpan Hieu = new TimeSpan();
                //DateTime Hieu = new DateTime();
                Hieu = ThoiGianHuy - kh.TGD;
                if (Hieu.Seconds < 10)
                {
                    for (int i = 0; i < dspn[vt].Controls.Count; i++)
                    {
                        Label lbl = dspn[vt].Controls[i] as Label;
                        while ((kh.GheThuongs.Count+kh.GheVips.Count) > 0)
                        {
                            int kt = 0;
                            try
                            {
                                if (lbl.Text.CompareTo(kh.GheVips[0]) == 0)
                                {
                                    lbl.BackColor = Color.WhiteSmoke;
                                    kh.GheVips.Remove(kh.GheVips[0]);
                                    kt = 1;
                                }
                            }
                            catch { }
                            try
                            {
                                if ((int.Parse(lbl.Text) == kh.GheThuongs[0]))
                                {
                                    lbl.BackColor = Color.WhiteSmoke;
                                    kh.GheThuongs.Remove(kh.GheThuongs[0]);
                                    kt = 1;
                                }
                            }
                            catch { }
                            if(kt==0)
                                break;
                        }
                    }
                    dskh.Remove(kh);
                    HienThiKhachHangLenListBox(dslstKH[vt],dsphim[vt].ChieuTai);
                    lblThanhTien.Text = "";
                }
                else
                    MessageBox.Show("Quá thời hạn hủy!");
            }
            else
                MessageBox.Show("Chưa chọn khách hàng!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
                Close();
        }

        private void txtSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
