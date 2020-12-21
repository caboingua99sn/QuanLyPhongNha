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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChiTietDonThuocWCF" in both code and config file together.
    public class ChiTietDonThuocWCF : IChiTietDonThuocWCF
    {
        DataContext db = new DataContext();
        public int AddChiTietDonThuoc(eChiTietDonThuoc item)
        {
            ChiTietDonThuoc temp = new ChiTietDonThuoc();
            temp.idDonThuoc = item.idDonThuoc;
            temp.idDV = item.idDV;
            if (item.idThuoc != 0)
            {
                temp.idThuoc = item.idThuoc;
            }
            else
            {
                temp.idThuoc = null;
            }
            temp.soLuong = item.soLuong;
            db.chitietdonthuocs.Add(temp);
            return db.SaveChanges();
        }

        public List<eChiTietDonThuoc> getChiTietDonThuocbyID(int id)
        {
            var list = db.chitietdonthuocs.Where(x => x.idDonThuoc == id);
            List<eChiTietDonThuoc> listkh = new List<eChiTietDonThuoc>();
            foreach (var item in list)
            {
                eChiTietDonThuoc temp = new eChiTietDonThuoc();
                temp.idDonThuoc = item.idDonThuoc;
                temp.idDV = item.idDV;
                if (item.idThuoc != null)
                {
                    temp.idThuoc = (int)item.idThuoc;
                }
                else
                {
                    temp.idThuoc = 0;
                }
                temp.soLuong = item.soLuong;
                listkh.Add(temp);
            }
            return listkh;
        }

        public List<eChiTietDonThuoc> GetChiTietDonThuocs()
        {
            var list = db.chitietdonthuocs.ToList();
            List<eChiTietDonThuoc> listkh = new List<eChiTietDonThuoc>();
            foreach (var item in list)
            {
                eChiTietDonThuoc temp = new eChiTietDonThuoc();
                temp.idDonThuoc = item.idDonThuoc;
                temp.idDV = item.idDV;
                temp.idThuoc = (int)item.idThuoc;
                temp.soLuong = item.soLuong;
                listkh.Add(temp);
            }
            return listkh;
        }
    }
}
