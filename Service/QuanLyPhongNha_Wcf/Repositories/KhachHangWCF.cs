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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KhachHangWCF" in both code and config file together.
    public class KhachHangWCF : IKhachHangWCF
    {
        DataContext db = new DataContext();

        public int AddKhachHang(eKhachHang kh)
        {
            KhachHang temp = new KhachHang();
            temp.tenKH = kh.tenKH;
            temp.soDienThoai = kh.soDienThoai;
            temp.diaChi = kh.diaChi;
            temp.ngaySinh = kh.ngaySinh;
            db.khachhangs.Add(temp);
            return db.SaveChanges();
        }

        public List<eKhachHang> GetKhachHangs()
        {
            var list = db.khachhangs.ToList();
            List<eKhachHang> listkh = new List<eKhachHang>();
            foreach (var item in list)
            {
                eKhachHang temp = new eKhachHang();
                temp.idKH = item.idKH;
                temp.tenKH = item.tenKH;
                temp.soDienThoai = item.soDienThoai;
                temp.diaChi = item.diaChi;
                temp.ngaySinh = item.ngaySinh;
                listkh.Add(temp);
            }
            return listkh;
        }

        public int UpdateKhachHang(eKhachHang kh)
        {
            KhachHang temp = db.khachhangs.Where(x => x.idKH.Equals(kh.idKH)).FirstOrDefault();
            temp.tenKH = kh.tenKH;
            temp.ngaySinh = kh.ngaySinh;
            temp.soDienThoai = kh.soDienThoai;
            temp.diaChi = kh.diaChi;
            return db.SaveChanges();
        }
        public List<eKhachHang> TimKiemKH_theoTen(string ten)
        {
            List<KhachHang> list = db.khachhangs.Where(x => x.tenKH.Contains(ten)).ToList();
            List<eKhachHang> l = new List<eKhachHang>();
            foreach (var item in list)
            {
                eKhachHang k = new eKhachHang();
                k.idKH = item.idKH;
                k.tenKH = item.tenKH;
                k.soDienThoai = item.soDienThoai;
                k.ngaySinh = item.ngaySinh;
                k.diaChi = item.diaChi;
                l.Add(k);          
            }
            return l;
        }

        public List<eKhachHang> TimKiemKH_theocmnd(string sdt)
        {
            List<KhachHang> list = db.khachhangs.Where(x => x.soDienThoai.Contains(sdt)).ToList();
            List<eKhachHang> l = new List<eKhachHang>();
            foreach (var item in list)
            {
                eKhachHang k = new eKhachHang();
                k.idKH = item.idKH;
                k.tenKH = item.tenKH;
                k.soDienThoai = item.soDienThoai;
                k.ngaySinh = item.ngaySinh;
                k.diaChi = item.diaChi;
                l.Add(k);
            }
            return l;
        }

        public List<eKhachHang> TimKiemKH_theosoDT(string sodt)
        {
            List<KhachHang> list = db.khachhangs.Where(x => x.soDienThoai.Contains(sodt)).ToList();
            List<eKhachHang> l = new List<eKhachHang>();
            foreach (var item in list)
            {
                eKhachHang k = new eKhachHang();
                k.idKH = item.idKH;
                k.tenKH = item.tenKH;
                k.soDienThoai = item.soDienThoai;
                k.ngaySinh = item.ngaySinh;
                k.diaChi = item.diaChi;
                l.Add(k);
            }
            return l;
        }

        public eKhachHang TimKiemKH_theosoDT_equals(string sodt)
        {
            KhachHang kh = db.khachhangs.Where(x => x.soDienThoai.Equals(sodt)).FirstOrDefault();
            if (kh != null)
            {
                eKhachHang k = new eKhachHang();
                k.diaChi = kh.diaChi;
                k.gioiTinh = kh.gioiTinh;
                k.idKH = kh.idKH;
                k.ngaySinh = kh.ngaySinh;
                k.soDienThoai = kh.soDienThoai;
                k.tenKH = kh.tenKH;
                return k;
            }
            return null;
        }

        public eKhachHang GetKhachHangs_byID(int id)
        {
            KhachHang kh = db.khachhangs.Where(x => x.idKH == id).FirstOrDefault();
            eKhachHang k = new eKhachHang();
            k.idKH = kh.idKH;
            k.gioiTinh = kh.gioiTinh;
            k.ngaySinh = kh.ngaySinh;
            k.soDienThoai = kh.soDienThoai;
            k.tenKH = kh.tenKH;
            k.diaChi = kh.diaChi;
            return k;
        }

        public int add_getIDKhachHang_Cuoi(eKhachHang obj)
        {
            KhachHang temp = new KhachHang();
            temp.tenKH = obj.tenKH;
            temp.soDienThoai = obj.soDienThoai;
            temp.diaChi = obj.diaChi;
            temp.ngaySinh = obj.ngaySinh;
            db.khachhangs.Add(temp);
            if (db.SaveChanges() == 1)
            {
                var id = db.khachhangs.OrderByDescending(x => x.idKH).FirstOrDefault();
                return id.idKH;
            }
            return -1;
        }
    }
}
