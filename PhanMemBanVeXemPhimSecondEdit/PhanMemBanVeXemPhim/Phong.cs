using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanVeXemPhim
{
    public class Phong
    {
        public string TenPhong { get; set; }
        public int TongSoPhong { get; set; }
        public override string ToString()
        {
            return TenPhong;
        }
    }
}
