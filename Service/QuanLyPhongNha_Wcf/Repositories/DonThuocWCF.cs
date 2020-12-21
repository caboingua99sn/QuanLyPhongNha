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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DonThuocWCF" in both code and config file together.
    public class DonThuocWCF : IDonThuocWCF
    {
        DataContext db = new DataContext();

        public int AddDonThuoc(eDonThuoc item)
        {
            DonThuoc temp = new DonThuoc();
            temp.idNhaSi = item.idNhaSi;
            temp.idPhieuKham = item.idPhieuKham;
            temp.ngayLap = item.ngayLap;
            temp.tinhTrang = item.tinhTrang;
            db.donthuocs.Add(temp);
            return db.SaveChanges();
        }

        public List<eDonThuoc> GetDonThuocs()
        {
            var list = db.donthuocs.ToList();
            List<eDonThuoc> listkh = new List<eDonThuoc>();
            foreach (var item in list)
            {
                eDonThuoc temp = new eDonThuoc();
                temp.idDonThuoc = item.idDonThuoc;
                temp.idNhaSi = item.idNhaSi;
                temp.idPhieuKham = item.idPhieuKham;
                temp.ngayLap = item.ngayLap;
                temp.tinhTrang = item.tinhTrang;
                listkh.Add(temp);
            }
            return listkh;
        }

        public int getIdLast()
        {
            DonThuoc temp = db.donthuocs.OrderByDescending(x => x.idDonThuoc).FirstOrDefault();
            return temp.idDonThuoc;
        }

        public int UpdateDonThuoc(eDonThuoc item)
        {
            DonThuoc temp = db.donthuocs.Where(x => x.idDonThuoc.Equals(item.idDonThuoc)).FirstOrDefault();
            temp.idDonThuoc = item.idDonThuoc;
            temp.idNhaSi = item.idNhaSi;
            temp.idPhieuKham = item.idPhieuKham;
            temp.ngayLap = item.ngayLap;
            temp.tinhTrang = item.tinhTrang;
            return db.SaveChanges();
        }
    }
}
