using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INhaSiWCF" in both code and config file together.
    [ServiceContract]
    public interface INhaSiWCF
    {
        [OperationContract]
        int AddNhaSi(eNhaSi nhaSi);
        [OperationContract]
        void UpdateNhaSi(eNhaSi nhaSi);
        [OperationContract]
        int RemoveNhaSi(int id);
        [OperationContract]
        List<eNhaSi> getAllNhaSi();
        [OperationContract]
        eNhaSi getNhaSiByUseName(string use,string pass);
        [OperationContract]
        eNhaSi getNhabyID(int id);
    }
}
