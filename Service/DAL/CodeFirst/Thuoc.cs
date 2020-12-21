using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CodeFirst
{
    public class Thuoc
    {
        [Key]
        public int idThuoc { get; set; }
        public string tenThuoc { get; set; }
        public double donGia { get; set; }
        public string donVi { get; set; }
        public string moTa { get; set; }
    }
}
