using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBanVeXemPhim
{
    public class Phim
    {
        public string TenPhim { get; set; }
        public Phong ChieuTai { get; set; }
        public override string ToString()
        {
            return TenPhim ;
        }
    }
}
