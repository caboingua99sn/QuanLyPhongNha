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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NhaSiWCF" in both code and config file together.
    public class NhaSiWCF : INhaSiWCF
    {
        DataContext db = new DataContext();
        public int AddNhaSi(eNhaSi nhaSi)
        {
            NhaSi temp = new NhaSi();
            temp.tenNhaSi = nhaSi.tenNhaSi;
            temp.soDienThoai = nhaSi.soDienThoai;
            temp.soCMND = nhaSi.soCMND;
            temp.diaChi = nhaSi.diaChi;
            temp.ngaySinh = nhaSi.ngaySinh;
            temp.gioiTinh = nhaSi.gioiTinh;
            temp.useName = nhaSi.useName;
            temp.passWord = nhaSi.passWord;
            NhaSi tam = db.nhasis.Where(x => x.useName.Equals(nhaSi.useName)).FirstOrDefault();
            if (tam != null)
            {
                return 0;
            }
            db.nhasis.Add(temp);
            return db.SaveChanges();
        }

        public List<eNhaSi> getAllNhaSi()
        {
            var ls = db.nhasis.Select(x => x).ToList();
            List<eNhaSi> list = new List<eNhaSi>();
            foreach (var item in ls)
            {
                eNhaSi temp = new eNhaSi();
                temp.idNhaSi = item.idNhaSi;
                temp.tenNhaSi = item.tenNhaSi;
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

        public eNhaSi getNhabyID(int id)
        {
            NhaSi temp = db.nhasis.Where(x => x.idNhaSi == id).FirstOrDefault();
            eNhaSi nhaSi = new eNhaSi();
            if (temp != null)
            {
                nhaSi.idNhaSi = temp.idNhaSi;
                nhaSi.tenNhaSi = temp.tenNhaSi;
                nhaSi.soCMND = temp.soCMND;
                nhaSi.soDienThoai = temp.soDienThoai;
                nhaSi.diaChi = temp.diaChi;
                nhaSi.ngaySinh = temp.ngaySinh;
                nhaSi.useName = temp.useName;
                nhaSi.passWord = temp.passWord;
                nhaSi.gioiTinh = temp.gioiTinh;
            }
            return nhaSi;
        }

        public eNhaSi getNhaSiByUseName(string use, string pass)
        {
            NhaSi temp = db.nhasis.Where(x => x.useName.Equals(use) && x.passWord.Equals(pass)).FirstOrDefault();
            eNhaSi nhaSi = new eNhaSi();
            if (temp != null)
            {
                nhaSi.idNhaSi = temp.idNhaSi;
                nhaSi.tenNhaSi = temp.tenNhaSi;
                nhaSi.soCMND = temp.soCMND;
                nhaSi.soDienThoai = temp.soDienThoai;
                nhaSi.diaChi = temp.diaChi;
                nhaSi.ngaySinh = temp.ngaySinh;
                nhaSi.useName = temp.useName;
                nhaSi.passWord = temp.passWord;
                nhaSi.gioiTinh = temp.gioiTinh;
            }
            return nhaSi;
        }

        public int RemoveNhaSi(int id)
        {
            NhaSi temp = db.nhasis.Where(x => x.idNhaSi == id).FirstOrDefault();
            db.nhasis.Remove(temp);
            return db.SaveChanges();
        }

        public void UpdateNhaSi(eNhaSi nhaSi)
        {
            NhaSi temp = db.nhasis.Where(x => x.idNhaSi == nhaSi.idNhaSi).FirstOrDefault();
            temp.tenNhaSi = nhaSi.tenNhaSi;
            temp.soDienThoai = nhaSi.soDienThoai;
            temp.soCMND = nhaSi.soCMND;
            temp.diaChi = nhaSi.diaChi;
            temp.ngaySinh = nhaSi.ngaySinh;
            temp.gioiTinh = nhaSi.gioiTinh;
            temp.passWord = nhaSi.passWord;
            db.SaveChanges();
        }
    }
}
