using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CodeFirst
{
    public class NhaSi
    {
        [Key]
        public int idNhaSi { get; set; }
        public string tenNhaSi { get; set; }
        public string soCMND { get; set; }
        public string diaChi { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string soDienThoai { get; set; }
        public string useName { get; set; }
        public string passWord { get; set; }

        public virtual ICollection<DonThuoc> donthuocs { get; set; }
    }
}
