﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto.Web.ServiceReferenceJogador {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeModelDropDown", Namespace="http://schemas.datacontract.org/2004/07/Projeto.Web.Models")]
    [System.SerializableAttribute()]
    public partial class TimeModelDropDown : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="JogadorModelCadastro", Namespace="http://schemas.datacontract.org/2004/07/Projeto.Web.Models")]
    [System.SerializableAttribute()]
    public partial class JogadorModelCadastro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApelidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosicaoField;
        
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
        public string Apelido {
            get {
                return this.ApelidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApelidoField, value) != true)) {
                    this.ApelidoField = value;
                    this.RaisePropertyChanged("Apelido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataNascimento {
            get {
                return this.DataNascimentoField;
            }
            set {
                if ((this.DataNascimentoField.Equals(value) != true)) {
                    this.DataNascimentoField = value;
                    this.RaisePropertyChanged("DataNascimento");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Posicao {
            get {
                return this.PosicaoField;
            }
            set {
                if ((object.ReferenceEquals(this.PosicaoField, value) != true)) {
                    this.PosicaoField = value;
                    this.RaisePropertyChanged("Posicao");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="JogadorModelConsulta", Namespace="http://schemas.datacontract.org/2004/07/Projeto.Web.Models")]
    [System.SerializableAttribute()]
    public partial class JogadorModelConsulta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApelidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdJogadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosicaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeField;
        
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
        public string Apelido {
            get {
                return this.ApelidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApelidoField, value) != true)) {
                    this.ApelidoField = value;
                    this.RaisePropertyChanged("Apelido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DataNascimento {
            get {
                return this.DataNascimentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DataNascimentoField, value) != true)) {
                    this.DataNascimentoField = value;
                    this.RaisePropertyChanged("DataNascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdJogador {
            get {
                return this.IdJogadorField;
            }
            set {
                if ((this.IdJogadorField.Equals(value) != true)) {
                    this.IdJogadorField = value;
                    this.RaisePropertyChanged("IdJogador");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Posicao {
            get {
                return this.PosicaoField;
            }
            set {
                if ((object.ReferenceEquals(this.PosicaoField, value) != true)) {
                    this.PosicaoField = value;
                    this.RaisePropertyChanged("Posicao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Time {
            get {
                return this.TimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeField, value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="JogadorModelEdicao", Namespace="http://schemas.datacontract.org/2004/07/Projeto.Web.Models")]
    [System.SerializableAttribute()]
    public partial class JogadorModelEdicao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApelidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdJogadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PosicaoField;
        
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
        public string Apelido {
            get {
                return this.ApelidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApelidoField, value) != true)) {
                    this.ApelidoField = value;
                    this.RaisePropertyChanged("Apelido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataNascimento {
            get {
                return this.DataNascimentoField;
            }
            set {
                if ((this.DataNascimentoField.Equals(value) != true)) {
                    this.DataNascimentoField = value;
                    this.RaisePropertyChanged("DataNascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdJogador {
            get {
                return this.IdJogadorField;
            }
            set {
                if ((this.IdJogadorField.Equals(value) != true)) {
                    this.IdJogadorField = value;
                    this.RaisePropertyChanged("IdJogador");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Posicao {
            get {
                return this.PosicaoField;
            }
            set {
                if ((object.ReferenceEquals(this.PosicaoField, value) != true)) {
                    this.PosicaoField = value;
                    this.RaisePropertyChanged("Posicao");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceJogador.IJogadorService")]
    public interface IJogadorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/CarregarTimes", ReplyAction="http://tempuri.org/IJogadorService/CarregarTimesResponse")]
        Projeto.Web.ServiceReferenceJogador.TimeModelDropDown[] CarregarTimes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/CarregarTimes", ReplyAction="http://tempuri.org/IJogadorService/CarregarTimesResponse")]
        System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceJogador.TimeModelDropDown[]> CarregarTimesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Cadastrar", ReplyAction="http://tempuri.org/IJogadorService/CadastrarResponse")]
        string Cadastrar(Projeto.Web.ServiceReferenceJogador.JogadorModelCadastro model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Cadastrar", ReplyAction="http://tempuri.org/IJogadorService/CadastrarResponse")]
        System.Threading.Tasks.Task<string> CadastrarAsync(Projeto.Web.ServiceReferenceJogador.JogadorModelCadastro model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Editar", ReplyAction="http://tempuri.org/IJogadorService/EditarResponse")]
        Projeto.Web.ServiceReferenceJogador.JogadorModelConsulta Editar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Editar", ReplyAction="http://tempuri.org/IJogadorService/EditarResponse")]
        System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceJogador.JogadorModelConsulta> EditarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Atualizar", ReplyAction="http://tempuri.org/IJogadorService/AtualizarResponse")]
        string Atualizar(Projeto.Web.ServiceReferenceJogador.JogadorModelEdicao model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Atualizar", ReplyAction="http://tempuri.org/IJogadorService/AtualizarResponse")]
        System.Threading.Tasks.Task<string> AtualizarAsync(Projeto.Web.ServiceReferenceJogador.JogadorModelEdicao model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Excluir", ReplyAction="http://tempuri.org/IJogadorService/ExcluirResponse")]
        string Excluir(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Excluir", ReplyAction="http://tempuri.org/IJogadorService/ExcluirResponse")]
        System.Threading.Tasks.Task<string> ExcluirAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Consultar", ReplyAction="http://tempuri.org/IJogadorService/ConsultarResponse")]
        Projeto.Web.ServiceReferenceJogador.JogadorModelConsulta[] Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJogadorService/Consultar", ReplyAction="http://tempuri.org/IJogadorService/ConsultarResponse")]
        System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceJogador.JogadorModelConsulta[]> ConsultarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJogadorServiceChannel : Projeto.Web.ServiceReferenceJogador.IJogadorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JogadorServiceClient : System.ServiceModel.ClientBase<Projeto.Web.ServiceReferenceJogador.IJogadorService>, Projeto.Web.ServiceReferenceJogador.IJogadorService {
        
        public JogadorServiceClient() {
        }
        
        public JogadorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JogadorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JogadorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JogadorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Projeto.Web.ServiceReferenceJogador.TimeModelDropDown[] CarregarTimes() {
            return base.Channel.CarregarTimes();
        }
        
        public System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceJogador.TimeModelDropDown[]> CarregarTimesAsync() {
            return base.Channel.CarregarTimesAsync();
        }
        
        public string Cadastrar(Projeto.Web.ServiceReferenceJogador.JogadorModelCadastro model) {
            return base.Channel.Cadastrar(model);
        }
        
        public System.Threading.Tasks.Task<string> CadastrarAsync(Projeto.Web.ServiceReferenceJogador.JogadorModelCadastro model) {
            return base.Channel.CadastrarAsync(model);
        }
        
        public Projeto.Web.ServiceReferenceJogador.JogadorModelConsulta Editar(int id) {
            return base.Channel.Editar(id);
        }
        
        public System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceJogador.JogadorModelConsulta> EditarAsync(int id) {
            return base.Channel.EditarAsync(id);
        }
        
        public string Atualizar(Projeto.Web.ServiceReferenceJogador.JogadorModelEdicao model) {
            return base.Channel.Atualizar(model);
        }
        
        public System.Threading.Tasks.Task<string> AtualizarAsync(Projeto.Web.ServiceReferenceJogador.JogadorModelEdicao model) {
            return base.Channel.AtualizarAsync(model);
        }
        
        public string Excluir(int id) {
            return base.Channel.Excluir(id);
        }
        
        public System.Threading.Tasks.Task<string> ExcluirAsync(int id) {
            return base.Channel.ExcluirAsync(id);
        }
        
        public Projeto.Web.ServiceReferenceJogador.JogadorModelConsulta[] Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<Projeto.Web.ServiceReferenceJogador.JogadorModelConsulta[]> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
    }
}
