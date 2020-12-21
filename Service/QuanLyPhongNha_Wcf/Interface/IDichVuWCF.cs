using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDichVuWCF" in both code and config file together.
    [ServiceContract]
    public interface IDichVuWCF
    {
        [OperationContract]
        int AddDichVu(eDichVuPhongKham dv);
        [OperationContract]
        void UpdateDichVu(eDichVuPhongKham dv);
        [OperationContract]
        int RemoveDichVu(int id);
        [OperationContract]
        List<eDichVuPhongKham> GetDichVu();
        [OperationContract]
        eDichVuPhongKham getDVbyID(int id);
    }
}
