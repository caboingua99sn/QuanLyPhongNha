using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;
namespace QuanLyPhongNha_Wcf.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhieuKhamWCF" in both code and config file together.
    [ServiceContract]
    public interface IPhieuKhamWCF
    {
        [OperationContract]
        List<ePhieuKham> getPhieuKham_theoNgay();
        [OperationContract]
        List<ePhieuKham> getPhieuhen();
        [OperationContract]
        List<ePhieuKham> getPhieuhen_TrongNgay();
        [OperationContract]
        List<ePhieuKham> getPhieuhen_TimKiem(DateTime from, DateTime to);
        [OperationContract]
        int AddPhieuKham(ePhieuKham epk);
        [OperationContract]
        void UpdatePhieuKham(ePhieuKham epk);

        [OperationContract]
        int UpdateTinhTrang_PhieuKham(ePhieuKham epk, int tinhtrangnew);

        [OperationContract]
        ePhieuKham getPhieuKham_byID(int id);
        [OperationContract]
        int getIdLast();
    }
}
