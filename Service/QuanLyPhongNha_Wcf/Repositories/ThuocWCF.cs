using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
using DAL.CodeFirst;
using Entity;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ThuocWCF" in both code and config file together.
    public class ThuocWCF : IThuocWCF
    {
        DataContext db = new DataContext();

        public int AddThuoc(eThuoc item)
        {
            Thuoc temp = new Thuoc();
            temp.tenThuoc = item.tenThuoc;
            temp.donGia = item.donGia;
            temp.moTa = item.moTa;
            temp.donVi = item.donVi;
            db.thuocs.Add(temp);
            return db.SaveChanges();
        }

        public eThuoc getThuocbyID(int id)
        {
            Thuoc item = db.thuocs.Where(x => x.idThuoc == id).FirstOrDefault();
            if (item == null)
            {
                return null;
            }
            eThuoc temp = new eThuoc();
            temp.idThuoc = item.idThuoc;
            temp.tenThuoc = item.tenThuoc;
            temp.donGia = item.donGia;
            temp.moTa = item.moTa;
            temp.donVi = item.donVi;
            return temp;
        }

        public List<eThuoc> GetThuocs()
        {
            var list = db.thuocs.ToList();
            List<eThuoc> listkh = new List<eThuoc>();
            foreach (var item in list)
            {
                eThuoc temp = new eThuoc();
                temp.idThuoc = item.idThuoc;
                temp.tenThuoc = item.tenThuoc;
                temp.donGia = item.donGia;
                temp.moTa = item.moTa;
                temp.donVi = item.donVi;

                listkh.Add(temp);
            }
            return listkh;
        }
    }
}
