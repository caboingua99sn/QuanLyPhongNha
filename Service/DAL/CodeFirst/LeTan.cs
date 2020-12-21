using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CodeFirst
{
    public class LeTan
    {
        [Key]
        public int idNV { get; set; }
        public string tenNV { get; set; }
        public string diaChi { get; set; }
        public DateTime ngaySinh { get; set; }
        public bool gioiTinh { get; set; }
        public string soDienThoai { get; set; }
        public string soCMND { get; set; }
        public string useName { get; set; }
        public string passWord { get; set; }
        public virtual ICollection<PhieuKham> phieukhams { get; set; }
    }
}
