using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CodeFirst
{
    public class DichVuPhongKham
    {
        [Key]
        public int idDV { get; set; }
        public string tenDV { get; set; }
        public double donGia { get; set; }
    }
}
