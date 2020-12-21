using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CodeFirst
{
    public class KhachHang
    {
        [Key]
        public int idKH { get; set; }
        public string tenKH { get; set; }
        public string diaChi { get; set; }
        public bool gioiTinh { get; set; }
        public string soDienThoai { get; set; }
        public DateTime ngaySinh { get; set; }

        public virtual ICollection<PhieuKham> khieukhams { get; set; }
    }
}
