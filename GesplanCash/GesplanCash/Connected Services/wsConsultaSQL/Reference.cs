﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConectorRM.wsConsultaSQL {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="wsConsultaSQL.IRMSServer")]
    public interface IRMSServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        bool Implements(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        bool CheckServiceActivity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        System.Threading.Tasks.Task<bool> CheckServiceActivityAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRMSServerChannel : ConectorRM.wsConsultaSQL.IRMSServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RMSServerClient : System.ServiceModel.ClientBase<ConectorRM.wsConsultaSQL.IRMSServer>, ConectorRM.wsConsultaSQL.IRMSServer {
        
        public RMSServerClient() {
        }
        
        public RMSServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RMSServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RMSServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RMSServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Implements(System.Type type) {
            return base.Channel.Implements(type);
        }
        
        public System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type) {
            return base.Channel.ImplementsAsync(type);
        }
        
        public bool CheckServiceActivity() {
            return base.Channel.CheckServiceActivity();
        }
        
        public System.Threading.Tasks.Task<bool> CheckServiceActivityAsync() {
            return base.Channel.CheckServiceActivityAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="wsConsultaSQL.IwsBase")]
    public interface IwsBase {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        bool Implements(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        bool CheckServiceActivity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        System.Threading.Tasks.Task<bool> CheckServiceActivityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsBase/AutenticaAcesso", ReplyAction="http://www.totvs.com/IwsBase/AutenticaAcessoResponse")]
        string AutenticaAcesso();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsBase/AutenticaAcesso", ReplyAction="http://www.totvs.com/IwsBase/AutenticaAcessoResponse")]
        System.Threading.Tasks.Task<string> AutenticaAcessoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwsBaseChannel : ConectorRM.wsConsultaSQL.IwsBase, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwsBaseClient : System.ServiceModel.ClientBase<ConectorRM.wsConsultaSQL.IwsBase>, ConectorRM.wsConsultaSQL.IwsBase {
        
        public IwsBaseClient() {
        }
        
        public IwsBaseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwsBaseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsBaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsBaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Implements(System.Type type) {
            return base.Channel.Implements(type);
        }
        
        public System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type) {
            return base.Channel.ImplementsAsync(type);
        }
        
        public bool CheckServiceActivity() {
            return base.Channel.CheckServiceActivity();
        }
        
        public System.Threading.Tasks.Task<bool> CheckServiceActivityAsync() {
            return base.Channel.CheckServiceActivityAsync();
        }
        
        public string AutenticaAcesso() {
            return base.Channel.AutenticaAcesso();
        }
        
        public System.Threading.Tasks.Task<string> AutenticaAcessoAsync() {
            return base.Channel.AutenticaAcessoAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="wsConsultaSQL.IwsConsultaSQL")]
    public interface IwsConsultaSQL {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        bool Implements(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/Implements", ReplyAction="http://www.totvs.com/IRMSServer/ImplementsResponse")]
        System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        bool CheckServiceActivity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IRMSServer/CheckServiceActivity", ReplyAction="http://www.totvs.com/IRMSServer/CheckServiceActivityResponse")]
        System.Threading.Tasks.Task<bool> CheckServiceActivityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsConsultaSQL/RealizarConsultaSQL", ReplyAction="http://www.totvs.com/IwsConsultaSQL/RealizarConsultaSQLResponse")]
        string RealizarConsultaSQL(string codSentenca, int codColigada, string codSistema, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsConsultaSQL/RealizarConsultaSQL", ReplyAction="http://www.totvs.com/IwsConsultaSQL/RealizarConsultaSQLResponse")]
        System.Threading.Tasks.Task<string> RealizarConsultaSQLAsync(string codSentenca, int codColigada, string codSistema, string parameters);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwsConsultaSQLChannel : ConectorRM.wsConsultaSQL.IwsConsultaSQL, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwsConsultaSQLClient : System.ServiceModel.ClientBase<ConectorRM.wsConsultaSQL.IwsConsultaSQL>, ConectorRM.wsConsultaSQL.IwsConsultaSQL {
        
        public IwsConsultaSQLClient() {
        }
        
        public IwsConsultaSQLClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwsConsultaSQLClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsConsultaSQLClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsConsultaSQLClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Implements(System.Type type) {
            return base.Channel.Implements(type);
        }
        
        public System.Threading.Tasks.Task<bool> ImplementsAsync(System.Type type) {
            return base.Channel.ImplementsAsync(type);
        }
        
        public bool CheckServiceActivity() {
            return base.Channel.CheckServiceActivity();
        }
        
        public System.Threading.Tasks.Task<bool> CheckServiceActivityAsync() {
            return base.Channel.CheckServiceActivityAsync();
        }
        
        public string RealizarConsultaSQL(string codSentenca, int codColigada, string codSistema, string parameters) {
            return base.Channel.RealizarConsultaSQL(codSentenca, codColigada, codSistema, parameters);
        }
        
        public System.Threading.Tasks.Task<string> RealizarConsultaSQLAsync(string codSentenca, int codColigada, string codSistema, string parameters) {
            return base.Channel.RealizarConsultaSQLAsync(codSentenca, codColigada, codSistema, parameters);
        }
    }
}