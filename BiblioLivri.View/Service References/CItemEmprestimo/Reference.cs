﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioLivri.View.CItemEmprestimo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TBItemEmprestimo", Namespace="http://schemas.datacontract.org/2004/07/BiblioLivri.Model")]
    [System.SerializableAttribute()]
    public partial class TBItemEmprestimo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ItemDataEmprestimoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemNumCopiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemNumEmprestimoField;
        
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
        public System.DateTime ItemDataEmprestimo {
            get {
                return this.ItemDataEmprestimoField;
            }
            set {
                if ((this.ItemDataEmprestimoField.Equals(value) != true)) {
                    this.ItemDataEmprestimoField = value;
                    this.RaisePropertyChanged("ItemDataEmprestimo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemNumCopia {
            get {
                return this.ItemNumCopiaField;
            }
            set {
                if ((this.ItemNumCopiaField.Equals(value) != true)) {
                    this.ItemNumCopiaField = value;
                    this.RaisePropertyChanged("ItemNumCopia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemNumEmprestimo {
            get {
                return this.ItemNumEmprestimoField;
            }
            set {
                if ((this.ItemNumEmprestimoField.Equals(value) != true)) {
                    this.ItemNumEmprestimoField = value;
                    this.RaisePropertyChanged("ItemNumEmprestimo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CItemEmprestimo.ICItemEmprestimo")]
    public interface ICItemEmprestimo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/Incluir", ReplyAction="http://tempuri.org/ICItemEmprestimo/IncluirResponse")]
        void Incluir(BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo oItemEmprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/Incluir", ReplyAction="http://tempuri.org/ICItemEmprestimo/IncluirResponse")]
        System.Threading.Tasks.Task IncluirAsync(BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo oItemEmprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/IncluirTodos", ReplyAction="http://tempuri.org/ICItemEmprestimo/IncluirTodosResponse")]
        void IncluirTodos(BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[] oItemEmprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/IncluirTodos", ReplyAction="http://tempuri.org/ICItemEmprestimo/IncluirTodosResponse")]
        System.Threading.Tasks.Task IncluirTodosAsync(BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[] oItemEmprestimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/SelecionaPK", ReplyAction="http://tempuri.org/ICItemEmprestimo/SelecionaPKResponse")]
        BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo SelecionaPK(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/SelecionaPK", ReplyAction="http://tempuri.org/ICItemEmprestimo/SelecionaPKResponse")]
        System.Threading.Tasks.Task<BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo> SelecionaPKAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/SelecionaTodos", ReplyAction="http://tempuri.org/ICItemEmprestimo/SelecionaTodosResponse")]
        BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[] SelecionaTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/SelecionaTodos", ReplyAction="http://tempuri.org/ICItemEmprestimo/SelecionaTodosResponse")]
        System.Threading.Tasks.Task<BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[]> SelecionaTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/SelecionaTodosCriterio", ReplyAction="http://tempuri.org/ICItemEmprestimo/SelecionaTodosCriterioResponse")]
        BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[] SelecionaTodosCriterio(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICItemEmprestimo/SelecionaTodosCriterio", ReplyAction="http://tempuri.org/ICItemEmprestimo/SelecionaTodosCriterioResponse")]
        System.Threading.Tasks.Task<BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[]> SelecionaTodosCriterioAsync(int codigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICItemEmprestimoChannel : BiblioLivri.View.CItemEmprestimo.ICItemEmprestimo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CItemEmprestimoClient : System.ServiceModel.ClientBase<BiblioLivri.View.CItemEmprestimo.ICItemEmprestimo>, BiblioLivri.View.CItemEmprestimo.ICItemEmprestimo {
        
        public CItemEmprestimoClient() {
        }
        
        public CItemEmprestimoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CItemEmprestimoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CItemEmprestimoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CItemEmprestimoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Incluir(BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo oItemEmprestimo) {
            base.Channel.Incluir(oItemEmprestimo);
        }
        
        public System.Threading.Tasks.Task IncluirAsync(BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo oItemEmprestimo) {
            return base.Channel.IncluirAsync(oItemEmprestimo);
        }
        
        public void IncluirTodos(BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[] oItemEmprestimo) {
            base.Channel.IncluirTodos(oItemEmprestimo);
        }
        
        public System.Threading.Tasks.Task IncluirTodosAsync(BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[] oItemEmprestimo) {
            return base.Channel.IncluirTodosAsync(oItemEmprestimo);
        }
        
        public BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo SelecionaPK(int codigo) {
            return base.Channel.SelecionaPK(codigo);
        }
        
        public System.Threading.Tasks.Task<BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo> SelecionaPKAsync(int codigo) {
            return base.Channel.SelecionaPKAsync(codigo);
        }
        
        public BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[] SelecionaTodos() {
            return base.Channel.SelecionaTodos();
        }
        
        public System.Threading.Tasks.Task<BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[]> SelecionaTodosAsync() {
            return base.Channel.SelecionaTodosAsync();
        }
        
        public BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[] SelecionaTodosCriterio(int codigo) {
            return base.Channel.SelecionaTodosCriterio(codigo);
        }
        
        public System.Threading.Tasks.Task<BiblioLivri.View.CItemEmprestimo.TBItemEmprestimo[]> SelecionaTodosCriterioAsync(int codigo) {
            return base.Channel.SelecionaTodosCriterioAsync(codigo);
        }
    }
}
