﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaRestoCashier.PizzaRestoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="itemlist", Namespace="http://schemas.datacontract.org/2004/07/PizzaPartyWCF.Models")]
    [System.SerializableAttribute()]
    public partial class itemlist : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string itemIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> priceField;
        
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
        public string itemID {
            get {
                return this.itemIDField;
            }
            set {
                if ((object.ReferenceEquals(this.itemIDField, value) != true)) {
                    this.itemIDField = value;
                    this.RaisePropertyChanged("itemID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="orderlist", Namespace="http://schemas.datacontract.org/2004/07/PizzaPartyWCF.Models")]
    [System.SerializableAttribute()]
    public partial class orderlist : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string itemIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> orderNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> qtyField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string itemID {
            get {
                return this.itemIDField;
            }
            set {
                if ((object.ReferenceEquals(this.itemIDField, value) != true)) {
                    this.itemIDField = value;
                    this.RaisePropertyChanged("itemID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> orderNo {
            get {
                return this.orderNoField;
            }
            set {
                if ((this.orderNoField.Equals(value) != true)) {
                    this.orderNoField = value;
                    this.RaisePropertyChanged("orderNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> qty {
            get {
                return this.qtyField;
            }
            set {
                if ((this.qtyField.Equals(value) != true)) {
                    this.qtyField = value;
                    this.RaisePropertyChanged("qty");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="kitchen", Namespace="http://schemas.datacontract.org/2004/07/PizzaPartyWCF.Models")]
    [System.SerializableAttribute()]
    public partial class kitchen : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string isCompletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> orderNoField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string isCompleted {
            get {
                return this.isCompletedField;
            }
            set {
                if ((object.ReferenceEquals(this.isCompletedField, value) != true)) {
                    this.isCompletedField = value;
                    this.RaisePropertyChanged("isCompleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> orderNo {
            get {
                return this.orderNoField;
            }
            set {
                if ((this.orderNoField.Equals(value) != true)) {
                    this.orderNoField = value;
                    this.RaisePropertyChanged("orderNo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PizzaRestoService.IPizzaResto")]
    public interface IPizzaResto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/AddCashierTransaction", ReplyAction="http://tempuri.org/IPizzaResto/AddCashierTransactionResponse")]
        int AddCashierTransaction(string cashName, string custName, double total, double cash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/AddCashierTransaction", ReplyAction="http://tempuri.org/IPizzaResto/AddCashierTransactionResponse")]
        System.Threading.Tasks.Task<int> AddCashierTransactionAsync(string cashName, string custName, double total, double cash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/GetItemList", ReplyAction="http://tempuri.org/IPizzaResto/GetItemListResponse")]
        PizzaRestoCashier.PizzaRestoService.itemlist[] GetItemList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/GetItemList", ReplyAction="http://tempuri.org/IPizzaResto/GetItemListResponse")]
        System.Threading.Tasks.Task<PizzaRestoCashier.PizzaRestoService.itemlist[]> GetItemListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/AddOrder", ReplyAction="http://tempuri.org/IPizzaResto/AddOrderResponse")]
        void AddOrder(string itemID, int qty, int orderNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/AddOrder", ReplyAction="http://tempuri.org/IPizzaResto/AddOrderResponse")]
        System.Threading.Tasks.Task AddOrderAsync(string itemID, int qty, int orderNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/GetOrderList", ReplyAction="http://tempuri.org/IPizzaResto/GetOrderListResponse")]
        PizzaRestoCashier.PizzaRestoService.orderlist[] GetOrderList(int orderNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/GetOrderList", ReplyAction="http://tempuri.org/IPizzaResto/GetOrderListResponse")]
        System.Threading.Tasks.Task<PizzaRestoCashier.PizzaRestoService.orderlist[]> GetOrderListAsync(int orderNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/AddKitchenOrder", ReplyAction="http://tempuri.org/IPizzaResto/AddKitchenOrderResponse")]
        void AddKitchenOrder(int orderNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/AddKitchenOrder", ReplyAction="http://tempuri.org/IPizzaResto/AddKitchenOrderResponse")]
        System.Threading.Tasks.Task AddKitchenOrderAsync(int orderNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/SetOrderComplete", ReplyAction="http://tempuri.org/IPizzaResto/SetOrderCompleteResponse")]
        void SetOrderComplete(int orderNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/SetOrderComplete", ReplyAction="http://tempuri.org/IPizzaResto/SetOrderCompleteResponse")]
        System.Threading.Tasks.Task SetOrderCompleteAsync(int orderNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/GetItem", ReplyAction="http://tempuri.org/IPizzaResto/GetItemResponse")]
        PizzaRestoCashier.PizzaRestoService.itemlist GetItem(string itemID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/GetItem", ReplyAction="http://tempuri.org/IPizzaResto/GetItemResponse")]
        System.Threading.Tasks.Task<PizzaRestoCashier.PizzaRestoService.itemlist> GetItemAsync(string itemID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/GetKitchenOrders", ReplyAction="http://tempuri.org/IPizzaResto/GetKitchenOrdersResponse")]
        PizzaRestoCashier.PizzaRestoService.kitchen[] GetKitchenOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaResto/GetKitchenOrders", ReplyAction="http://tempuri.org/IPizzaResto/GetKitchenOrdersResponse")]
        System.Threading.Tasks.Task<PizzaRestoCashier.PizzaRestoService.kitchen[]> GetKitchenOrdersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPizzaRestoChannel : PizzaRestoCashier.PizzaRestoService.IPizzaResto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PizzaRestoClient : System.ServiceModel.ClientBase<PizzaRestoCashier.PizzaRestoService.IPizzaResto>, PizzaRestoCashier.PizzaRestoService.IPizzaResto {
        
        public PizzaRestoClient() {
        }
        
        public PizzaRestoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PizzaRestoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaRestoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaRestoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddCashierTransaction(string cashName, string custName, double total, double cash) {
            return base.Channel.AddCashierTransaction(cashName, custName, total, cash);
        }
        
        public System.Threading.Tasks.Task<int> AddCashierTransactionAsync(string cashName, string custName, double total, double cash) {
            return base.Channel.AddCashierTransactionAsync(cashName, custName, total, cash);
        }
        
        public PizzaRestoCashier.PizzaRestoService.itemlist[] GetItemList() {
            return base.Channel.GetItemList();
        }
        
        public System.Threading.Tasks.Task<PizzaRestoCashier.PizzaRestoService.itemlist[]> GetItemListAsync() {
            return base.Channel.GetItemListAsync();
        }
        
        public void AddOrder(string itemID, int qty, int orderNo) {
            base.Channel.AddOrder(itemID, qty, orderNo);
        }
        
        public System.Threading.Tasks.Task AddOrderAsync(string itemID, int qty, int orderNo) {
            return base.Channel.AddOrderAsync(itemID, qty, orderNo);
        }
        
        public PizzaRestoCashier.PizzaRestoService.orderlist[] GetOrderList(int orderNo) {
            return base.Channel.GetOrderList(orderNo);
        }
        
        public System.Threading.Tasks.Task<PizzaRestoCashier.PizzaRestoService.orderlist[]> GetOrderListAsync(int orderNo) {
            return base.Channel.GetOrderListAsync(orderNo);
        }
        
        public void AddKitchenOrder(int orderNo) {
            base.Channel.AddKitchenOrder(orderNo);
        }
        
        public System.Threading.Tasks.Task AddKitchenOrderAsync(int orderNo) {
            return base.Channel.AddKitchenOrderAsync(orderNo);
        }
        
        public void SetOrderComplete(int orderNo) {
            base.Channel.SetOrderComplete(orderNo);
        }
        
        public System.Threading.Tasks.Task SetOrderCompleteAsync(int orderNo) {
            return base.Channel.SetOrderCompleteAsync(orderNo);
        }
        
        public PizzaRestoCashier.PizzaRestoService.itemlist GetItem(string itemID) {
            return base.Channel.GetItem(itemID);
        }
        
        public System.Threading.Tasks.Task<PizzaRestoCashier.PizzaRestoService.itemlist> GetItemAsync(string itemID) {
            return base.Channel.GetItemAsync(itemID);
        }
        
        public PizzaRestoCashier.PizzaRestoService.kitchen[] GetKitchenOrders() {
            return base.Channel.GetKitchenOrders();
        }
        
        public System.Threading.Tasks.Task<PizzaRestoCashier.PizzaRestoService.kitchen[]> GetKitchenOrdersAsync() {
            return base.Channel.GetKitchenOrdersAsync();
        }
    }
}