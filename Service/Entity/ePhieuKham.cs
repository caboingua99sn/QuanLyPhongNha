using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ePhieuKham
    {
        public int idPhieuKham { get; set; }
        public DateTime ngayDKKham { get; set; }
        public string moTa { get; set; }
        public int tinhTrang { get; set; }
        public int idNV { get; set; }
        public int idKH { get; set; }
        public string truyenMa { get; set; }
    }
}
