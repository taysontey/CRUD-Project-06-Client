﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto.Web.ServiceReferenceTime {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeModelCadastro", Namespace="http://schemas.datacontract.org/2004/07/Projeto.Web.Models")]
    [System.SerializableAttribute()]
    public partial class TimeModelCadastro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataFundacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public System.DateTime DataFundacao {
            get {
                return this.DataFundacaoField;
            }
            set {
                if ((this.DataFundacaoField.Equals(value) != true)) {
                    this.DataFundacaoField = value;
                    this.RaisePropertyChanged("DataFundacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeModelConsulta", Namespace="http://schemas.datacontract.org/2004/07/Projeto.Web.Models")]
    [System.SerializableAttribute()]
    public partial class TimeModelConsulta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataFundacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public string DataFundacao {
            get {
                return this.DataFundacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DataFundacaoField, value) != true)) {
                    this.DataFundacaoField = value;
                    this.RaisePropertyChanged("DataFundacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTime {
            get {
                return this.IdTimeField;
            }
            set {
                if ((this.IdTimeField.Equals(value) != true)) {
                    this.IdTimeField = value;
                    this.RaisePropertyChanged("IdTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeModelEdicao", Namespace="http://schemas.datacontract.org/2004/07/Projeto.Web.Models")]
    [System.SerializableAttribute()]
    public partial class TimeModelEdicao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataFundacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public System.DateTime DataFundacao {
            get {
                return this.DataFundacaoField;
            }
            set {
                if ((this.DataFundacaoField.Equals(value) != true)) {
                    this.DataFundacaoField = value;
                    this.RaisePropertyChanged("DataFundacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTime {
            get {
                return this.IdTimeField;
            }
            set {
                if ((this.IdTimeField.Equals(value) != true)) {
                    this.IdTimeField = value;
                    this.RaisePropertyChanged("IdTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceTime.ITimeService")]
    public interface ITimeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Cadastrar", ReplyAction="http://tempuri.org/ITimeService/CadastrarResponse")]
        string Cadastrar(Projeto.Web.ServiceReferenceTime.TimeModelCadastro model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Cadastrar", ReplyAction="http://tempuri.org/ITimeService/CadastrarResponse")]
        System.Threading.Tasks.Task<string> CadastrarAsync(Projeto.Web.ServiceReferenceTime.TimeModelCadastro model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Editar", ReplyAction="http://tempuri.org/ITimeService/EditarResponse")]
        Projeto.Web.ServiceReferenceTime.TimeModelConsulta Editar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Editar", ReplyAction="http://tempuri.org/ITimeService/EditarResponse")]
        System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceTime.TimeModelConsulta> EditarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Atualizar", ReplyAction="http://tempuri.org/ITimeService/AtualizarResponse")]
        string Atualizar(Projeto.Web.ServiceReferenceTime.TimeModelEdicao model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Atualizar", ReplyAction="http://tempuri.org/ITimeService/AtualizarResponse")]
        System.Threading.Tasks.Task<string> AtualizarAsync(Projeto.Web.ServiceReferenceTime.TimeModelEdicao model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Excluir", ReplyAction="http://tempuri.org/ITimeService/ExcluirResponse")]
        string Excluir(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Excluir", ReplyAction="http://tempuri.org/ITimeService/ExcluirResponse")]
        System.Threading.Tasks.Task<string> ExcluirAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Consultar", ReplyAction="http://tempuri.org/ITimeService/ConsultarResponse")]
        Projeto.Web.ServiceReferenceTime.TimeModelConsulta[] Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITimeService/Consultar", ReplyAction="http://tempuri.org/ITimeService/ConsultarResponse")]
        System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceTime.TimeModelConsulta[]> ConsultarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITimeServiceChannel : Projeto.Web.ServiceReferenceTime.ITimeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TimeServiceClient : System.ServiceModel.ClientBase<Projeto.Web.ServiceReferenceTime.ITimeService>, Projeto.Web.ServiceReferenceTime.ITimeService {
        
        public TimeServiceClient() {
        }
        
        public TimeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TimeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Cadastrar(Projeto.Web.ServiceReferenceTime.TimeModelCadastro model) {
            return base.Channel.Cadastrar(model);
        }
        
        public System.Threading.Tasks.Task<string> CadastrarAsync(Projeto.Web.ServiceReferenceTime.TimeModelCadastro model) {
            return base.Channel.CadastrarAsync(model);
        }
        
        public Projeto.Web.ServiceReferenceTime.TimeModelConsulta Editar(int id) {
            return base.Channel.Editar(id);
        }
        
        public System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceTime.TimeModelConsulta> EditarAsync(int id) {
            return base.Channel.EditarAsync(id);
        }
        
        public string Atualizar(Projeto.Web.ServiceReferenceTime.TimeModelEdicao model) {
            return base.Channel.Atualizar(model);
        }
        
        public System.Threading.Tasks.Task<string> AtualizarAsync(Projeto.Web.ServiceReferenceTime.TimeModelEdicao model) {
            return base.Channel.AtualizarAsync(model);
        }
        
        public string Excluir(int id) {
            return base.Channel.Excluir(id);
        }
        
        public System.Threading.Tasks.Task<string> ExcluirAsync(int id) {
            return base.Channel.ExcluirAsync(id);
        }
        
        public Projeto.Web.ServiceReferenceTime.TimeModelConsulta[] Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceTime.TimeModelConsulta[]> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
    }
}
