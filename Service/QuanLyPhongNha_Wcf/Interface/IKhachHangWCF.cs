using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL.CodeFirst;
using Entity;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKhachHangWCF" in both code and config file together.
    [ServiceContract]
    public interface IKhachHangWCF
    {
        [OperationContract]
        List<eKhachHang> GetKhachHangs();

        [OperationContract]
        int AddKhachHang(eKhachHang kh);

        [OperationContract]
        int UpdateKhachHang(eKhachHang kh);

        [OperationContract]
        List<eKhachHang> TimKiemKH_theoTen(string ten);

        [OperationContract]
        List<eKhachHang> TimKiemKH_theosoDT(string sodt);

        [OperationContract]
        eKhachHang TimKiemKH_theosoDT_equals(string sodt);

        [OperationContract]
        eKhachHang GetKhachHangs_byID(int id);

        [OperationContract]
        int add_getIDKhachHang_Cuoi(eKhachHang obj);
    }
}
