﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFTiendaTest.VentaWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/WCFTiendaServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int co_productoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int nu_cantidadField;
        
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
        public int co_producto {
            get {
                return this.co_productoField;
            }
            set {
                if ((this.co_productoField.Equals(value) != true)) {
                    this.co_productoField = value;
                    this.RaisePropertyChanged("co_producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int nu_cantidad {
            get {
                return this.nu_cantidadField;
            }
            set {
                if ((this.nu_cantidadField.Equals(value) != true)) {
                    this.nu_cantidadField = value;
                    this.RaisePropertyChanged("nu_cantidad");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Venta", Namespace="http://schemas.datacontract.org/2004/07/WCFTiendaServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Venta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFTiendaTest.VentaWS.VentaDetalle[] DetallesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dt_fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFTiendaTest.VentaWS.Cliente nu_rucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal nu_totalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int nu_ventaField;
        
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
        public WCFTiendaTest.VentaWS.VentaDetalle[] Detalles {
            get {
                return this.DetallesField;
            }
            set {
                if ((object.ReferenceEquals(this.DetallesField, value) != true)) {
                    this.DetallesField = value;
                    this.RaisePropertyChanged("Detalles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dt_fecha {
            get {
                return this.dt_fechaField;
            }
            set {
                if ((this.dt_fechaField.Equals(value) != true)) {
                    this.dt_fechaField = value;
                    this.RaisePropertyChanged("dt_fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WCFTiendaTest.VentaWS.Cliente nu_ruc {
            get {
                return this.nu_rucField;
            }
            set {
                if ((object.ReferenceEquals(this.nu_rucField, value) != true)) {
                    this.nu_rucField = value;
                    this.RaisePropertyChanged("nu_ruc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal nu_total {
            get {
                return this.nu_totalField;
            }
            set {
                if ((this.nu_totalField.Equals(value) != true)) {
                    this.nu_totalField = value;
                    this.RaisePropertyChanged("nu_total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int nu_venta {
            get {
                return this.nu_ventaField;
            }
            set {
                if ((this.nu_ventaField.Equals(value) != true)) {
                    this.nu_ventaField = value;
                    this.RaisePropertyChanged("nu_venta");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WCFTiendaServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nu_rucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tx_direccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tx_nombreField;
        
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
        public string nu_ruc {
            get {
                return this.nu_rucField;
            }
            set {
                if ((object.ReferenceEquals(this.nu_rucField, value) != true)) {
                    this.nu_rucField = value;
                    this.RaisePropertyChanged("nu_ruc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tx_direccion {
            get {
                return this.tx_direccionField;
            }
            set {
                if ((object.ReferenceEquals(this.tx_direccionField, value) != true)) {
                    this.tx_direccionField = value;
                    this.RaisePropertyChanged("tx_direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tx_nombre {
            get {
                return this.tx_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.tx_nombreField, value) != true)) {
                    this.tx_nombreField = value;
                    this.RaisePropertyChanged("tx_nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VentaDetalle", Namespace="http://schemas.datacontract.org/2004/07/WCFTiendaServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class VentaDetalle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFTiendaTest.VentaWS.VentaDetallePK PkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int nu_cantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal nu_subtotalField;
        
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
        public WCFTiendaTest.VentaWS.VentaDetallePK Pk {
            get {
                return this.PkField;
            }
            set {
                if ((object.ReferenceEquals(this.PkField, value) != true)) {
                    this.PkField = value;
                    this.RaisePropertyChanged("Pk");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int nu_cantidad {
            get {
                return this.nu_cantidadField;
            }
            set {
                if ((this.nu_cantidadField.Equals(value) != true)) {
                    this.nu_cantidadField = value;
                    this.RaisePropertyChanged("nu_cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal nu_subtotal {
            get {
                return this.nu_subtotalField;
            }
            set {
                if ((this.nu_subtotalField.Equals(value) != true)) {
                    this.nu_subtotalField = value;
                    this.RaisePropertyChanged("nu_subtotal");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VentaDetallePK", Namespace="http://schemas.datacontract.org/2004/07/WCFTiendaServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class VentaDetallePK : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFTiendaTest.VentaWS.Producto co_productoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int nu_ventaField;
        
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
        public WCFTiendaTest.VentaWS.Producto co_producto {
            get {
                return this.co_productoField;
            }
            set {
                if ((object.ReferenceEquals(this.co_productoField, value) != true)) {
                    this.co_productoField = value;
                    this.RaisePropertyChanged("co_producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int nu_venta {
            get {
                return this.nu_ventaField;
            }
            set {
                if ((this.nu_ventaField.Equals(value) != true)) {
                    this.nu_ventaField = value;
                    this.RaisePropertyChanged("nu_venta");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://schemas.datacontract.org/2004/07/WCFTiendaServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Producto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int co_productoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal nu_precioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tx_descripcionField;
        
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
        public int co_producto {
            get {
                return this.co_productoField;
            }
            set {
                if ((this.co_productoField.Equals(value) != true)) {
                    this.co_productoField = value;
                    this.RaisePropertyChanged("co_producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal nu_precio {
            get {
                return this.nu_precioField;
            }
            set {
                if ((this.nu_precioField.Equals(value) != true)) {
                    this.nu_precioField = value;
                    this.RaisePropertyChanged("nu_precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tx_descripcion {
            get {
                return this.tx_descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.tx_descripcionField, value) != true)) {
                    this.tx_descripcionField = value;
                    this.RaisePropertyChanged("tx_descripcion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteInexistenteError", Namespace="http://schemas.datacontract.org/2004/07/WCFTiendaServices.Errores")]
    [System.SerializableAttribute()]
    public partial class ClienteInexistenteError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeErrorField;
        
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
        public int CodigoError {
            get {
                return this.CodigoErrorField;
            }
            set {
                if ((this.CodigoErrorField.Equals(value) != true)) {
                    this.CodigoErrorField = value;
                    this.RaisePropertyChanged("CodigoError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeError {
            get {
                return this.MensajeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeErrorField, value) != true)) {
                    this.MensajeErrorField = value;
                    this.RaisePropertyChanged("MensajeError");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VentaWS.IVentaService")]
    public interface IVentaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVentaService/Vender", ReplyAction="http://tempuri.org/IVentaService/VenderResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFTiendaTest.VentaWS.ClienteInexistenteError), Action="http://tempuri.org/IVentaService/VenderClienteInexistenteErrorFault", Name="ClienteInexistenteError", Namespace="http://schemas.datacontract.org/2004/07/WCFTiendaServices.Errores")]
        WCFTiendaTest.VentaWS.Venta Vender(string nu_ruc, WCFTiendaTest.VentaWS.Item[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVentaService/Vender", ReplyAction="http://tempuri.org/IVentaService/VenderResponse")]
        System.Threading.Tasks.Task<WCFTiendaTest.VentaWS.Venta> VenderAsync(string nu_ruc, WCFTiendaTest.VentaWS.Item[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVentaService/ListarVentas", ReplyAction="http://tempuri.org/IVentaService/ListarVentasResponse")]
        WCFTiendaTest.VentaWS.Venta[] ListarVentas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVentaService/ListarVentas", ReplyAction="http://tempuri.org/IVentaService/ListarVentasResponse")]
        System.Threading.Tasks.Task<WCFTiendaTest.VentaWS.Venta[]> ListarVentasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVentaServiceChannel : WCFTiendaTest.VentaWS.IVentaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VentaServiceClient : System.ServiceModel.ClientBase<WCFTiendaTest.VentaWS.IVentaService>, WCFTiendaTest.VentaWS.IVentaService {
        
        public VentaServiceClient() {
        }
        
        public VentaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VentaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VentaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VentaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFTiendaTest.VentaWS.Venta Vender(string nu_ruc, WCFTiendaTest.VentaWS.Item[] items) {
            return base.Channel.Vender(nu_ruc, items);
        }
        
        public System.Threading.Tasks.Task<WCFTiendaTest.VentaWS.Venta> VenderAsync(string nu_ruc, WCFTiendaTest.VentaWS.Item[] items) {
            return base.Channel.VenderAsync(nu_ruc, items);
        }
        
        public WCFTiendaTest.VentaWS.Venta[] ListarVentas() {
            return base.Channel.ListarVentas();
        }
        
        public System.Threading.Tasks.Task<WCFTiendaTest.VentaWS.Venta[]> ListarVentasAsync() {
            return base.Channel.ListarVentasAsync();
        }
    }
}
