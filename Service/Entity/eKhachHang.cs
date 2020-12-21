using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eKhachHang
    {
        public int idKH { get; set; }
        public string tenKH { get; set; }
        public bool gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public DateTime ngaySinh { get; set; }
    }
}
