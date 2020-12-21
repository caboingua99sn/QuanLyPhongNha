using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CodeFirst
{
    public class DonThuoc
    {
        [Key]
        public int idDonThuoc { get; set; }
        public DateTime ngayLap { get; set; }
        [Column(Order =1)]
        public int idPhieuKham { get; set; }
        [Column(Order = 2)]
        public int idNhaSi { get; set; }
        public bool tinhTrang { get; set; }
        public virtual NhaSi nhasi { get; set; }
        public virtual PhieuKham phieukham { get; set; }       
    }
}
