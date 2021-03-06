﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.ProductoWS {
    using System.Runtime.Serialization;
    using System;
    
    
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductoWS.IProductoService")]
    public interface IProductoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/CrearProducto", ReplyAction="http://tempuri.org/IProductoService/CrearProductoResponse")]
        Proyecto.ProductoWS.Producto CrearProducto(Proyecto.ProductoWS.Producto productoACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/CrearProducto", ReplyAction="http://tempuri.org/IProductoService/CrearProductoResponse")]
        System.Threading.Tasks.Task<Proyecto.ProductoWS.Producto> CrearProductoAsync(Proyecto.ProductoWS.Producto productoACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/ObtenerProducto", ReplyAction="http://tempuri.org/IProductoService/ObtenerProductoResponse")]
        Proyecto.ProductoWS.Producto ObtenerProducto(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/ObtenerProducto", ReplyAction="http://tempuri.org/IProductoService/ObtenerProductoResponse")]
        System.Threading.Tasks.Task<Proyecto.ProductoWS.Producto> ObtenerProductoAsync(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/ModificarProducto", ReplyAction="http://tempuri.org/IProductoService/ModificarProductoResponse")]
        Proyecto.ProductoWS.Producto ModificarProducto(Proyecto.ProductoWS.Producto productoAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/ModificarProducto", ReplyAction="http://tempuri.org/IProductoService/ModificarProductoResponse")]
        System.Threading.Tasks.Task<Proyecto.ProductoWS.Producto> ModificarProductoAsync(Proyecto.ProductoWS.Producto productoAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/EliminarProducto", ReplyAction="http://tempuri.org/IProductoService/EliminarProductoResponse")]
        void EliminarProducto(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/EliminarProducto", ReplyAction="http://tempuri.org/IProductoService/EliminarProductoResponse")]
        System.Threading.Tasks.Task EliminarProductoAsync(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/ListarProductos", ReplyAction="http://tempuri.org/IProductoService/ListarProductosResponse")]
        Proyecto.ProductoWS.Producto[] ListarProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductoService/ListarProductos", ReplyAction="http://tempuri.org/IProductoService/ListarProductosResponse")]
        System.Threading.Tasks.Task<Proyecto.ProductoWS.Producto[]> ListarProductosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductoServiceChannel : Proyecto.ProductoWS.IProductoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductoServiceClient : System.ServiceModel.ClientBase<Proyecto.ProductoWS.IProductoService>, Proyecto.ProductoWS.IProductoService {
        
        public ProductoServiceClient() {
        }
        
        public ProductoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Proyecto.ProductoWS.Producto CrearProducto(Proyecto.ProductoWS.Producto productoACrear) {
            return base.Channel.CrearProducto(productoACrear);
        }
        
        public System.Threading.Tasks.Task<Proyecto.ProductoWS.Producto> CrearProductoAsync(Proyecto.ProductoWS.Producto productoACrear) {
            return base.Channel.CrearProductoAsync(productoACrear);
        }
        
        public Proyecto.ProductoWS.Producto ObtenerProducto(string codigo) {
            return base.Channel.ObtenerProducto(codigo);
        }
        
        public System.Threading.Tasks.Task<Proyecto.ProductoWS.Producto> ObtenerProductoAsync(string codigo) {
            return base.Channel.ObtenerProductoAsync(codigo);
        }
        
        public Proyecto.ProductoWS.Producto ModificarProducto(Proyecto.ProductoWS.Producto productoAModificar) {
            return base.Channel.ModificarProducto(productoAModificar);
        }
        
        public System.Threading.Tasks.Task<Proyecto.ProductoWS.Producto> ModificarProductoAsync(Proyecto.ProductoWS.Producto productoAModificar) {
            return base.Channel.ModificarProductoAsync(productoAModificar);
        }
        
        public void EliminarProducto(string codigo) {
            base.Channel.EliminarProducto(codigo);
        }
        
        public System.Threading.Tasks.Task EliminarProductoAsync(string codigo) {
            return base.Channel.EliminarProductoAsync(codigo);
        }
        
        public Proyecto.ProductoWS.Producto[] ListarProductos() {
            return base.Channel.ListarProductos();
        }
        
        public System.Threading.Tasks.Task<Proyecto.ProductoWS.Producto[]> ListarProductosAsync() {
            return base.Channel.ListarProductosAsync();
        }
    }
}
