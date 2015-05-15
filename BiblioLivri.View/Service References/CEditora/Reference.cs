﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioLivri.View.CEditora {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TBEditora", Namespace="http://schemas.datacontract.org/2004/07/BiblioLivri.Model")]
    [System.SerializableAttribute()]
    public partial class TBEditora : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EdNomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_EditoraField;
        
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
        public string EdNome {
            get {
                return this.EdNomeField;
            }
            set {
                if ((object.ReferenceEquals(this.EdNomeField, value) != true)) {
                    this.EdNomeField = value;
                    this.RaisePropertyChanged("EdNome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_Editora {
            get {
                return this.id_EditoraField;
            }
            set {
                if ((this.id_EditoraField.Equals(value) != true)) {
                    this.id_EditoraField = value;
                    this.RaisePropertyChanged("id_Editora");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CEditora.ICEditora")]
    public interface ICEditora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Incluir", ReplyAction="http://tempuri.org/ICEditora/IncluirResponse")]
        void Incluir(BiblioLivri.View.CEditora.TBEditora oEditora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Incluir", ReplyAction="http://tempuri.org/ICEditora/IncluirResponse")]
        System.Threading.Tasks.Task IncluirAsync(BiblioLivri.View.CEditora.TBEditora oEditora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Alterar", ReplyAction="http://tempuri.org/ICEditora/AlterarResponse")]
        void Alterar(BiblioLivri.View.CEditora.TBEditora oEditora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Alterar", ReplyAction="http://tempuri.org/ICEditora/AlterarResponse")]
        System.Threading.Tasks.Task AlterarAsync(BiblioLivri.View.CEditora.TBEditora oEditora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Excluir", ReplyAction="http://tempuri.org/ICEditora/ExcluirResponse")]
        void Excluir(BiblioLivri.View.CEditora.TBEditora oEditora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/Excluir", ReplyAction="http://tempuri.org/ICEditora/ExcluirResponse")]
        System.Threading.Tasks.Task ExcluirAsync(BiblioLivri.View.CEditora.TBEditora oEditora);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/SelecionaPK", ReplyAction="http://tempuri.org/ICEditora/SelecionaPKResponse")]
        BiblioLivri.View.CEditora.TBEditora SelecionaPK(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/SelecionaPK", ReplyAction="http://tempuri.org/ICEditora/SelecionaPKResponse")]
        System.Threading.Tasks.Task<BiblioLivri.View.CEditora.TBEditora> SelecionaPKAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/SelecionaTodos", ReplyAction="http://tempuri.org/ICEditora/SelecionaTodosResponse")]
        BiblioLivri.View.CEditora.TBEditora[] SelecionaTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICEditora/SelecionaTodos", ReplyAction="http://tempuri.org/ICEditora/SelecionaTodosResponse")]
        System.Threading.Tasks.Task<BiblioLivri.View.CEditora.TBEditora[]> SelecionaTodosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICEditoraChannel : BiblioLivri.View.CEditora.ICEditora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CEditoraClient : System.ServiceModel.ClientBase<BiblioLivri.View.CEditora.ICEditora>, BiblioLivri.View.CEditora.ICEditora {
        
        public CEditoraClient() {
        }
        
        public CEditoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CEditoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CEditoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CEditoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Incluir(BiblioLivri.View.CEditora.TBEditora oEditora) {
            base.Channel.Incluir(oEditora);
        }
        
        public System.Threading.Tasks.Task IncluirAsync(BiblioLivri.View.CEditora.TBEditora oEditora) {
            return base.Channel.IncluirAsync(oEditora);
        }
        
        public void Alterar(BiblioLivri.View.CEditora.TBEditora oEditora) {
            base.Channel.Alterar(oEditora);
        }
        
        public System.Threading.Tasks.Task AlterarAsync(BiblioLivri.View.CEditora.TBEditora oEditora) {
            return base.Channel.AlterarAsync(oEditora);
        }
        
        public void Excluir(BiblioLivri.View.CEditora.TBEditora oEditora) {
            base.Channel.Excluir(oEditora);
        }
        
        public System.Threading.Tasks.Task ExcluirAsync(BiblioLivri.View.CEditora.TBEditora oEditora) {
            return base.Channel.ExcluirAsync(oEditora);
        }
        
        public BiblioLivri.View.CEditora.TBEditora SelecionaPK(int codigo) {
            return base.Channel.SelecionaPK(codigo);
        }
        
        public System.Threading.Tasks.Task<BiblioLivri.View.CEditora.TBEditora> SelecionaPKAsync(int codigo) {
            return base.Channel.SelecionaPKAsync(codigo);
        }
        
        public BiblioLivri.View.CEditora.TBEditora[] SelecionaTodos() {
            return base.Channel.SelecionaTodos();
        }
        
        public System.Threading.Tasks.Task<BiblioLivri.View.CEditora.TBEditora[]> SelecionaTodosAsync() {
            return base.Channel.SelecionaTodosAsync();
        }
    }
}
