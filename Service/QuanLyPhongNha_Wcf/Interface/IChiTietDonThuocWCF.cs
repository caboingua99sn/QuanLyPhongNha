using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChiTietDonThuocWCF" in both code and config file together.
    [ServiceContract]
    public interface IChiTietDonThuocWCF
    {
        [OperationContract]
        List<eChiTietDonThuoc> GetChiTietDonThuocs();

        [OperationContract]
        int AddChiTietDonThuoc(eChiTietDonThuoc kh);
        [OperationContract]
        List<eChiTietDonThuoc> getChiTietDonThuocbyID(int id);
    }
}
