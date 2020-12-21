using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entity;

namespace QuanLyPhongNha_Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILeTanWCF" in both code and config file together.
    [ServiceContract]
    public interface ILeTanWCF
    {
        [OperationContract]
        int AddLeTan(eLeTan leTan);
        [OperationContract]
        void UpdateLeTan(eLeTan leTan);
        [OperationContract]
        int RemoveLeTan(int id);
        [OperationContract]
        List<eLeTan> getAllLeTan();
        [OperationContract]
        eLeTan getLeTanByUse(string id, string pass);
    }
}
