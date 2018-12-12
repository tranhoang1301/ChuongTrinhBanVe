using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanVeXemPhim
{
    public class KhachHang
    {
        public string Name { get; set; }
        public List<int> GheThuongs = new List<int>();
        public List<string> GheVips = new List<string>();
        public bool LaHSSV { get; set; }
        public DateTime TGD { get; set; }
        public double TinhTien
        {
            get
            {
                double tien = GheThuongs.Count * 50000 + GheVips.Count * 70000;
                if (LaHSSV)
                    tien = tien*0.8;
                return tien;
            }
        }
        public Phim PhimDat { get; set; }

        public override string ToString()
        {
            return Name + ". Tổng số ghế đặt:" + (GheThuongs.Count+GheVips.Count);
        }
        public DateTime ThoiGianDat
        {
            get
            {
                DateTime TGDat = new DateTime();
                TGDat = DateTime.Now;
                return TGDat;
            }
        }
    }
}
