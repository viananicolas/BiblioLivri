﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioLivri.View.CCopiaLivro {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TBCopiaLivro", Namespace="http://schemas.datacontract.org/2004/07/BiblioLivri.Model")]
    [System.SerializableAttribute()]
    public partial class TBCopiaLivro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoAnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoEdicaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CoEmprestadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoIdiomaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CoNumCopiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataAquisicaoField;
        
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
        public string CoAno {
            get {
                return this.CoAnoField;
            }
            set {
                if ((object.ReferenceEquals(this.CoAnoField, value) != true)) {
                    this.CoAnoField = value;
                    this.RaisePropertyChanged("CoAno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CoEdicao {
            get {
                return this.CoEdicaoField;
            }
            set {
                if ((object.ReferenceEquals(this.CoEdicaoField, value) != true)) {
                    this.CoEdicaoField = value;
                    this.RaisePropertyChanged("CoEdicao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CoEmprestado {
            get {
                return this.CoEmprestadoField;
            }
            set {
                if ((this.CoEmprestadoField.Equals(value) != true)) {
                    this.CoEmprestadoField = value;
                    this.RaisePropertyChanged("CoEmprestado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CoISBN {
            get {
                return this.CoISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.CoISBNField, value) != true)) {
                    this.CoISBNField = value;
                    this.RaisePropertyChanged("CoISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CoIdioma {
            get {
                return this.CoIdiomaField;
            }
            set {
                if ((object.ReferenceEquals(this.CoIdiomaField, value) != true)) {
                    this.CoIdiomaField = value;
                    this.RaisePropertyChanged("CoIdioma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CoNumCopia {
            get {
                return this.CoNumCopiaField;
            }
            set {
                if ((this.CoNumCopiaField.Equals(value) != true)) {
                    this.CoNumCopiaField = value;
                    this.RaisePropertyChanged("CoNumCopia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataAquisicao {
            get {
                return this.DataAquisicaoField;
            }
            set {
                if ((this.DataAquisicaoField.Equals(value) != true)) {
                    this.DataAquisicaoField = value;
                    this.RaisePropertyChanged("DataAquisicao");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CCopiaLivro.ICCopiaLivro")]
    public interface ICCopiaLivro {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/Incluir", ReplyAction="http://tempuri.org/ICCopiaLivro/IncluirResponse")]
        void Incluir(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/Incluir", ReplyAction="http://tempuri.org/ICCopiaLivro/IncluirResponse")]
        System.Threading.Tasks.Task IncluirAsync(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/Alterar", ReplyAction="http://tempuri.org/ICCopiaLivro/AlterarResponse")]
        void Alterar(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/Alterar", ReplyAction="http://tempuri.org/ICCopiaLivro/AlterarResponse")]
        System.Threading.Tasks.Task AlterarAsync(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/Excluir", ReplyAction="http://tempuri.org/ICCopiaLivro/ExcluirResponse")]
        void Excluir(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/Excluir", ReplyAction="http://tempuri.org/ICCopiaLivro/ExcluirResponse")]
        System.Threading.Tasks.Task ExcluirAsync(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/SelecionaPK", ReplyAction="http://tempuri.org/ICCopiaLivro/SelecionaPKResponse")]
        BiblioLivri.View.CCopiaLivro.TBCopiaLivro SelecionaPK(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/SelecionaPK", ReplyAction="http://tempuri.org/ICCopiaLivro/SelecionaPKResponse")]
        System.Threading.Tasks.Task<BiblioLivri.View.CCopiaLivro.TBCopiaLivro> SelecionaPKAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/SelecionaTodos", ReplyAction="http://tempuri.org/ICCopiaLivro/SelecionaTodosResponse")]
        BiblioLivri.View.CCopiaLivro.TBCopiaLivro[] SelecionaTodos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/SelecionaTodos", ReplyAction="http://tempuri.org/ICCopiaLivro/SelecionaTodosResponse")]
        System.Threading.Tasks.Task<BiblioLivri.View.CCopiaLivro.TBCopiaLivro[]> SelecionaTodosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/SelecionaTodosCriterio", ReplyAction="http://tempuri.org/ICCopiaLivro/SelecionaTodosCriterioResponse")]
        BiblioLivri.View.CCopiaLivro.TBCopiaLivro[] SelecionaTodosCriterio(string Criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICCopiaLivro/SelecionaTodosCriterio", ReplyAction="http://tempuri.org/ICCopiaLivro/SelecionaTodosCriterioResponse")]
        System.Threading.Tasks.Task<BiblioLivri.View.CCopiaLivro.TBCopiaLivro[]> SelecionaTodosCriterioAsync(string Criterio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICCopiaLivroChannel : BiblioLivri.View.CCopiaLivro.ICCopiaLivro, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CCopiaLivroClient : System.ServiceModel.ClientBase<BiblioLivri.View.CCopiaLivro.ICCopiaLivro>, BiblioLivri.View.CCopiaLivro.ICCopiaLivro {
        
        public CCopiaLivroClient() {
        }
        
        public CCopiaLivroClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CCopiaLivroClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CCopiaLivroClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CCopiaLivroClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Incluir(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro) {
            base.Channel.Incluir(oCopiaLivro);
        }
        
        public System.Threading.Tasks.Task IncluirAsync(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro) {
            return base.Channel.IncluirAsync(oCopiaLivro);
        }
        
        public void Alterar(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro) {
            base.Channel.Alterar(oCopiaLivro);
        }
        
        public System.Threading.Tasks.Task AlterarAsync(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro) {
            return base.Channel.AlterarAsync(oCopiaLivro);
        }
        
        public void Excluir(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro) {
            base.Channel.Excluir(oCopiaLivro);
        }
        
        public System.Threading.Tasks.Task ExcluirAsync(BiblioLivri.View.CCopiaLivro.TBCopiaLivro oCopiaLivro) {
            return base.Channel.ExcluirAsync(oCopiaLivro);
        }
        
        public BiblioLivri.View.CCopiaLivro.TBCopiaLivro SelecionaPK(int codigo) {
            return base.Channel.SelecionaPK(codigo);
        }
        
        public System.Threading.Tasks.Task<BiblioLivri.View.CCopiaLivro.TBCopiaLivro> SelecionaPKAsync(int codigo) {
            return base.Channel.SelecionaPKAsync(codigo);
        }
        
        public BiblioLivri.View.CCopiaLivro.TBCopiaLivro[] SelecionaTodos() {
            return base.Channel.SelecionaTodos();
        }
        
        public System.Threading.Tasks.Task<BiblioLivri.View.CCopiaLivro.TBCopiaLivro[]> SelecionaTodosAsync() {
            return base.Channel.SelecionaTodosAsync();
        }
        
        public BiblioLivri.View.CCopiaLivro.TBCopiaLivro[] SelecionaTodosCriterio(string Criterio) {
            return base.Channel.SelecionaTodosCriterio(Criterio);
        }
        
        public System.Threading.Tasks.Task<BiblioLivri.View.CCopiaLivro.TBCopiaLivro[]> SelecionaTodosCriterioAsync(string Criterio) {
            return base.Channel.SelecionaTodosCriterioAsync(Criterio);
        }
    }
}
