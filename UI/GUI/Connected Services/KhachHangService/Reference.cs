﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.KhachHangService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="eKhachHang", Namespace="http://schemas.datacontract.org/2004/07/Entity")]
    [System.SerializableAttribute()]
    public partial class eKhachHang : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string diaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool gioiTinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idKHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ngaySinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string soDienThoaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tenKHField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string diaChi {
            get {
                return this.diaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.diaChiField, value) != true)) {
                    this.diaChiField = value;
                    this.RaisePropertyChanged("diaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool gioiTinh {
            get {
                return this.gioiTinhField;
            }
            set {
                if ((this.gioiTinhField.Equals(value) != true)) {
                    this.gioiTinhField = value;
                    this.RaisePropertyChanged("gioiTinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idKH {
            get {
                return this.idKHField;
            }
            set {
                if ((this.idKHField.Equals(value) != true)) {
                    this.idKHField = value;
                    this.RaisePropertyChanged("idKH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ngaySinh {
            get {
                return this.ngaySinhField;
            }
            set {
                if ((this.ngaySinhField.Equals(value) != true)) {
                    this.ngaySinhField = value;
                    this.RaisePropertyChanged("ngaySinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string soDienThoai {
            get {
                return this.soDienThoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.soDienThoaiField, value) != true)) {
                    this.soDienThoaiField = value;
                    this.RaisePropertyChanged("soDienThoai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tenKH {
            get {
                return this.tenKHField;
            }
            set {
                if ((object.ReferenceEquals(this.tenKHField, value) != true)) {
                    this.tenKHField = value;
                    this.RaisePropertyChanged("tenKH");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KhachHangService.IKhachHangWCF")]
    public interface IKhachHangWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/GetKhachHangs", ReplyAction="http://tempuri.org/IKhachHangWCF/GetKhachHangsResponse")]
        GUI.KhachHangService.eKhachHang[] GetKhachHangs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/GetKhachHangs", ReplyAction="http://tempuri.org/IKhachHangWCF/GetKhachHangsResponse")]
        System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang[]> GetKhachHangsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/AddKhachHang", ReplyAction="http://tempuri.org/IKhachHangWCF/AddKhachHangResponse")]
        int AddKhachHang(GUI.KhachHangService.eKhachHang kh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/AddKhachHang", ReplyAction="http://tempuri.org/IKhachHangWCF/AddKhachHangResponse")]
        System.Threading.Tasks.Task<int> AddKhachHangAsync(GUI.KhachHangService.eKhachHang kh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/UpdateKhachHang", ReplyAction="http://tempuri.org/IKhachHangWCF/UpdateKhachHangResponse")]
        int UpdateKhachHang(GUI.KhachHangService.eKhachHang kh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/UpdateKhachHang", ReplyAction="http://tempuri.org/IKhachHangWCF/UpdateKhachHangResponse")]
        System.Threading.Tasks.Task<int> UpdateKhachHangAsync(GUI.KhachHangService.eKhachHang kh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/TimKiemKH_theoTen", ReplyAction="http://tempuri.org/IKhachHangWCF/TimKiemKH_theoTenResponse")]
        GUI.KhachHangService.eKhachHang[] TimKiemKH_theoTen(string ten);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/TimKiemKH_theoTen", ReplyAction="http://tempuri.org/IKhachHangWCF/TimKiemKH_theoTenResponse")]
        System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang[]> TimKiemKH_theoTenAsync(string ten);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/TimKiemKH_theosoDT", ReplyAction="http://tempuri.org/IKhachHangWCF/TimKiemKH_theosoDTResponse")]
        GUI.KhachHangService.eKhachHang[] TimKiemKH_theosoDT(string sodt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/TimKiemKH_theosoDT", ReplyAction="http://tempuri.org/IKhachHangWCF/TimKiemKH_theosoDTResponse")]
        System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang[]> TimKiemKH_theosoDTAsync(string sodt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/TimKiemKH_theosoDT_equals", ReplyAction="http://tempuri.org/IKhachHangWCF/TimKiemKH_theosoDT_equalsResponse")]
        GUI.KhachHangService.eKhachHang TimKiemKH_theosoDT_equals(string sodt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/TimKiemKH_theosoDT_equals", ReplyAction="http://tempuri.org/IKhachHangWCF/TimKiemKH_theosoDT_equalsResponse")]
        System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang> TimKiemKH_theosoDT_equalsAsync(string sodt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/GetKhachHangs_byID", ReplyAction="http://tempuri.org/IKhachHangWCF/GetKhachHangs_byIDResponse")]
        GUI.KhachHangService.eKhachHang GetKhachHangs_byID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/GetKhachHangs_byID", ReplyAction="http://tempuri.org/IKhachHangWCF/GetKhachHangs_byIDResponse")]
        System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang> GetKhachHangs_byIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/add_getIDKhachHang_Cuoi", ReplyAction="http://tempuri.org/IKhachHangWCF/add_getIDKhachHang_CuoiResponse")]
        int add_getIDKhachHang_Cuoi(GUI.KhachHangService.eKhachHang obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKhachHangWCF/add_getIDKhachHang_Cuoi", ReplyAction="http://tempuri.org/IKhachHangWCF/add_getIDKhachHang_CuoiResponse")]
        System.Threading.Tasks.Task<int> add_getIDKhachHang_CuoiAsync(GUI.KhachHangService.eKhachHang obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKhachHangWCFChannel : GUI.KhachHangService.IKhachHangWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KhachHangWCFClient : System.ServiceModel.ClientBase<GUI.KhachHangService.IKhachHangWCF>, GUI.KhachHangService.IKhachHangWCF {
        
        public KhachHangWCFClient() {
        }
        
        public KhachHangWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KhachHangWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KhachHangWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KhachHangWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GUI.KhachHangService.eKhachHang[] GetKhachHangs() {
            return base.Channel.GetKhachHangs();
        }
        
        public System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang[]> GetKhachHangsAsync() {
            return base.Channel.GetKhachHangsAsync();
        }
        
        public int AddKhachHang(GUI.KhachHangService.eKhachHang kh) {
            return base.Channel.AddKhachHang(kh);
        }
        
        public System.Threading.Tasks.Task<int> AddKhachHangAsync(GUI.KhachHangService.eKhachHang kh) {
            return base.Channel.AddKhachHangAsync(kh);
        }
        
        public int UpdateKhachHang(GUI.KhachHangService.eKhachHang kh) {
            return base.Channel.UpdateKhachHang(kh);
        }
        
        public System.Threading.Tasks.Task<int> UpdateKhachHangAsync(GUI.KhachHangService.eKhachHang kh) {
            return base.Channel.UpdateKhachHangAsync(kh);
        }
        
        public GUI.KhachHangService.eKhachHang[] TimKiemKH_theoTen(string ten) {
            return base.Channel.TimKiemKH_theoTen(ten);
        }
        
        public System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang[]> TimKiemKH_theoTenAsync(string ten) {
            return base.Channel.TimKiemKH_theoTenAsync(ten);
        }
        
        public GUI.KhachHangService.eKhachHang[] TimKiemKH_theosoDT(string sodt) {
            return base.Channel.TimKiemKH_theosoDT(sodt);
        }
        
        public System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang[]> TimKiemKH_theosoDTAsync(string sodt) {
            return base.Channel.TimKiemKH_theosoDTAsync(sodt);
        }
        
        public GUI.KhachHangService.eKhachHang TimKiemKH_theosoDT_equals(string sodt) {
            return base.Channel.TimKiemKH_theosoDT_equals(sodt);
        }
        
        public System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang> TimKiemKH_theosoDT_equalsAsync(string sodt) {
            return base.Channel.TimKiemKH_theosoDT_equalsAsync(sodt);
        }
        
        public GUI.KhachHangService.eKhachHang GetKhachHangs_byID(int id) {
            return base.Channel.GetKhachHangs_byID(id);
        }
        
        public System.Threading.Tasks.Task<GUI.KhachHangService.eKhachHang> GetKhachHangs_byIDAsync(int id) {
            return base.Channel.GetKhachHangs_byIDAsync(id);
        }
        
        public int add_getIDKhachHang_Cuoi(GUI.KhachHangService.eKhachHang obj) {
            return base.Channel.add_getIDKhachHang_Cuoi(obj);
        }
        
        public System.Threading.Tasks.Task<int> add_getIDKhachHang_CuoiAsync(GUI.KhachHangService.eKhachHang obj) {
            return base.Channel.add_getIDKhachHang_CuoiAsync(obj);
        }
    }
}