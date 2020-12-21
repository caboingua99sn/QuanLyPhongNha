using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IThuocWCF" in both code and config file together.
    [ServiceContract]
    public interface IThuocWCF
    {
        [OperationContract]
        List<eThuoc> GetThuocs();

        [OperationContract]
        int AddThuoc(eThuoc kh);
        [OperationContract]
        eThuoc getThuocbyID(int id);
    }
}
