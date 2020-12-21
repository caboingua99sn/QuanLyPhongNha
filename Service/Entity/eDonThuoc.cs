using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eDonThuoc
    {
        public int idDonThuoc { get; set; }
        public DateTime ngayLap { get; set; }
        public int idPhieuKham { get; set; }
        public int idNhaSi { get; set; }
        public bool tinhTrang { get; set; }
        public string mom { get; set; }
    }
}
