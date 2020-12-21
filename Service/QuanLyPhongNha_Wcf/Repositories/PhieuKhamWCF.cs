using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;
using DAL.CodeFirst;
using DAL;
namespace QuanLyPhongNha_Wcf.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PhieuKhamWCF" in both code and config file together.
    public class PhieuKhamWCF : IPhieuKhamWCF
    {

        DataContext db = new DataContext();
        public List<ePhieuKham> getPhieuKham_theoNgay()
        {
            List<PhieuKham> list = db.phieukhams.Select(x => x).ToList();
            List<ePhieuKham> l = new List<ePhieuKham>();
            foreach (var item in list)
            {
                int day = item.ngayDKKham.Day;
                int month = item.ngayDKKham.Month;
                int year = item.ngayDKKham.Year;
                if (day == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year && (item.tinhTrang == 1))
                {
                    ePhieuKham p = new ePhieuKham();
                    p.idKH = item.idKH;
                    p.idNV = item.idNV;
                    p.idPhieuKham = item.idPhieuKham;
                    p.ngayDKKham = item.ngayDKKham;
                    p.tinhTrang = item.tinhTrang;
                    p.moTa = item.moTa;
                    l.Add(p);
                }

            }
            return l;
        }

        public int AddPhieuKham(ePhieuKham epk)
        {
            PhieuKham item = new PhieuKham();
            item.idKH = epk.idKH;
            item.idNV = epk.idNV;
            item.moTa = epk.moTa;
            item.ngayDKKham = epk.ngayDKKham;
            item.tinhTrang = epk.tinhTrang;
            db.phieukhams.Add(item);
            return db.SaveChanges();
        }

        public List<ePhieuKham> getPhieuhen()
        {
            List<PhieuKham> list = db.phieukhams.Select(x => x).ToList();
            List<ePhieuKham> l = new List<ePhieuKham>();
            foreach (var item in list)
            {
                if (item.ngayDKKham > DateTime.Today && item.tinhTrang == 2)
                {
                    ePhieuKham p = new ePhieuKham();
                    p.idKH = item.idKH;
                    p.idNV = item.idNV;
                    p.idPhieuKham = item.idPhieuKham;
                    p.ngayDKKham = item.ngayDKKham;
                    p.tinhTrang = item.tinhTrang;
                    p.moTa = item.moTa;
                    l.Add(p);
                }
            }
            return l;
        }

        public List<ePhieuKham> getPhieuhen_TrongNgay()
        {
            List<PhieuKham> list = db.phieukhams.Select(x => x).ToList();
            List<ePhieuKham> l = new List<ePhieuKham>();
            foreach (var item in list)
            {
                int day = item.ngayDKKham.Day;
                int month = item.ngayDKKham.Month;
                int year = item.ngayDKKham.Year;

                if (day == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year && item.tinhTrang == 2)
                {
                    ePhieuKham p = new ePhieuKham();
                    p.idKH = item.idKH;
                    p.idNV = item.idNV;
                    p.idPhieuKham = item.idPhieuKham;
                    p.ngayDKKham = item.ngayDKKham;
                    p.tinhTrang = item.tinhTrang;
                    p.moTa = item.moTa;
                    l.Add(p);
                }
            }
            return l;
        }

        public List<ePhieuKham> getPhieuhen_TimKiem(DateTime datefrom, DateTime dateto)
        {
            List<PhieuKham> list = db.phieukhams.Select(x => x).ToList();
            List<ePhieuKham> l = new List<ePhieuKham>();
            foreach (var item in list)
            {
                if (item.tinhTrang == 2 && (item.ngayDKKham >= datefrom) && (item.ngayDKKham <= dateto))
                {
                    ePhieuKham p = new ePhieuKham();
                    p.idKH = item.idKH;
                    p.idNV = item.idNV;
                    p.idPhieuKham = item.idPhieuKham;
                    p.ngayDKKham = item.ngayDKKham;
                    p.tinhTrang = item.tinhTrang;
                    p.moTa = item.moTa;
                    l.Add(p);
                }
            }
            return l;
        }

        public void UpdatePhieuKham(ePhieuKham epk)
        {
            PhieuKham temp = db.phieukhams.Where(x => x.idPhieuKham.Equals(epk.idPhieuKham)).FirstOrDefault();
            temp.moTa = epk.moTa;
            temp.ngayDKKham = epk.ngayDKKham;
            db.SaveChanges();
        }

        public ePhieuKham getPhieuKham_byID(int id)
        {
            PhieuKham kh = db.phieukhams.Where(x => x.idPhieuKham == id).FirstOrDefault();
            ePhieuKham k = new ePhieuKham();
            k.idKH = kh.idKH;
            k.moTa = kh.moTa;
            k.idNV = kh.idNV;
            k.idPhieuKham = kh.idPhieuKham;
            k.ngayDKKham = kh.ngayDKKham;
            k.tinhTrang = kh.tinhTrang;
            return k;
        }

        public int UpdateTinhTrang_PhieuKham(ePhieuKham epk, int tinhtrangnew)
        {
            PhieuKham temp = db.phieukhams.Where(x => x.idPhieuKham.Equals(epk.idPhieuKham)).FirstOrDefault();
            temp.tinhTrang = tinhtrangnew;
            return db.SaveChanges();
        }

        public int getIdLast()
        {
            PhieuKham temp = db.phieukhams.OrderByDescending(x => x.idPhieuKham).FirstOrDefault();
            return temp.idPhieuKham;
        }
    }
}
