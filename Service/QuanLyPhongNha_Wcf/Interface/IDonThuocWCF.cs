using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDonThuocWCF" in both code and config file together.
    [ServiceContract]
    public interface IDonThuocWCF
    {
        [OperationContract]
        List<eDonThuoc> GetDonThuocs();

        [OperationContract]
        int AddDonThuoc(eDonThuoc kh);

        [OperationContract]
        int UpdateDonThuoc(eDonThuoc kh);
        [OperationContract]
        int getIdLast();
    }
}
