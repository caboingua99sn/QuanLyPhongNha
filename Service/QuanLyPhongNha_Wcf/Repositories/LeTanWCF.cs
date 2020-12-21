using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
using DAL.CodeFirst;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LeTanWCF" in both code and config file together.
    public class LeTanWCF : ILeTanWCF
    {
        DataContext db = new DataContext();
        public int AddLeTan(eLeTan leTan)
        {
            LeTan temp = new LeTan();
            temp.tenNV = leTan.tenNV;
            temp.soDienThoai = leTan.soDienThoai;
            temp.soCMND = leTan.soCMND;
            temp.diaChi = leTan.diaChi;
            temp.ngaySinh = leTan.ngaySinh;
            temp.gioiTinh = leTan.gioiTinh;
            temp.passWord = leTan.passWord;
            LeTan tam = db.letans.Where(x => x.useName.Equals(leTan.useName)).FirstOrDefault();
            if (tam != null)
            {
                return 0;
            }
            db.letans.Add(temp);
            return db.SaveChanges();
        }

        public List<eLeTan> getAllLeTan()
        {
            var ls = db.letans.Select(x => x).ToList();
            List<eLeTan> list = new List<eLeTan>();
            foreach (var item in ls)
            {
                eLeTan temp = new eLeTan();
                temp.idNV = item.idNV;
                temp.tenNV = item.tenNV;
                temp.soDienThoai = item.soDienThoai;
                temp.soCMND = item.soCMND;
                temp.diaChi = item.diaChi;
                temp.ngaySinh = item.ngaySinh;
                temp.gioiTinh = item.gioiTinh;
                temp.useName = item.useName;
                temp.passWord = item.passWord;
                list.Add(temp);
            }
            return list;
        }

        public eLeTan getLeTanByUse(string id, string pass)
        {
            LeTan temp = db.letans.Where(x => x.useName.Equals(id) && x.passWord.Equals(pass)).FirstOrDefault();
            eLeTan leTan = new eLeTan();
            if (temp != null)
            {
                leTan.idNV = temp.idNV;
                leTan.tenNV = temp.tenNV;
                leTan.soCMND = temp.soCMND;
                leTan.soDienThoai = temp.soDienThoai;
                leTan.diaChi = temp.diaChi;
                leTan.ngaySinh = temp.ngaySinh;
                leTan.passWord = temp.passWord;
                leTan.useName = temp.useName;
                leTan.gioiTinh = temp.gioiTinh;
            }
            return leTan;
        }

        public int RemoveLeTan(int id)
        {
            LeTan temp = db.letans.Where(x => x.idNV == id).FirstOrDefault();
            db.letans.Remove(temp);
            return db.SaveChanges();
        }

        public void UpdateLeTan(eLeTan leTan)
        {
            LeTan temp = db.letans.Where(x => x.idNV == leTan.idNV).FirstOrDefault();
            temp.tenNV = leTan.tenNV;
            temp.soDienThoai = leTan.soDienThoai;
            temp.soCMND = leTan.soCMND;
            temp.diaChi = leTan.diaChi;
            temp.ngaySinh = leTan.ngaySinh;
            temp.gioiTinh = leTan.gioiTinh;
            temp.passWord = leTan.passWord;
            db.SaveChanges();
        }
    }
}
