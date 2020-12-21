using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CodeFirst
{
    public class ChiTietDonThuoc
    {
        [Key]
        [Column(Order = 1)]
        public int idDonThuoc { get; set; }
        public virtual DonThuoc donthuoc { get; set; }
        [Key]
        [Column(Order = 2)]
        public int idDV { get; set; }
        public virtual DichVuPhongKham dichvu { get; set; }
        [Column(Order = 3)]
        public int? idThuoc { get; set; }
        public virtual Thuoc thuoc { get; set; }
        public int soLuong { get; set; }
    }
}
