using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL.CodeFirst;
using DAL;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DichVuWCF" in both code and config file together.
    public class DichVuWCF : IDichVuWCF
    {
        DataContext db = new DataContext();

        public int AddDichVu(eDichVuPhongKham dv)
        {
            DichVuPhongKham temp = new DichVuPhongKham();
            temp.idDV = dv.idDV;
            temp.tenDV = dv.tenDV;
            temp.donGia = dv.donGia;
            db.dichvus.Add(temp);
            return db.SaveChanges();
        }

        public List<eDichVuPhongKham> GetDichVu()
        {
            var list = db.dichvus.ToList();
            List<eDichVuPhongKham> listkh = new List<eDichVuPhongKham>();
            foreach (var item in list)
            {
                eDichVuPhongKham temp = new eDichVuPhongKham();
                temp.idDV = item.idDV;
                temp.tenDV = item.tenDV;
                temp.donGia = item.donGia;
                listkh.Add(temp);
            }
            return listkh;
        }

        public eDichVuPhongKham getDVbyID(int id)
        {
            DichVuPhongKham dv = db.dichvus.Where(x => x.idDV == id).FirstOrDefault();
            eDichVuPhongKham temp = new eDichVuPhongKham();
            temp.idDV = dv.idDV;
            temp.tenDV = dv.tenDV;
            temp.donGia = dv.donGia;
            return temp;
        }

        public int RemoveDichVu(int id)
        {
            DichVuPhongKham temp = db.dichvus.Where(x => x.idDV == id).FirstOrDefault();
            db.dichvus.Remove(temp);
            return db.SaveChanges();
        }

        public void UpdateDichVu(eDichVuPhongKham dv)
        {
            DichVuPhongKham temp = db.dichvus.Where(x => x.idDV == dv.idDV).FirstOrDefault();
            temp.tenDV = dv.tenDV;
            temp.donGia = dv.donGia;
            db.SaveChanges();
        }
    }
}
