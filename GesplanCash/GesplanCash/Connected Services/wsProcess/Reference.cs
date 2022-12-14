//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConectorRM.wsProcess {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="wsProcess.IRMSServer")]
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
    public interface IRMSServerChannel : ConectorRM.wsProcess.IRMSServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RMSServerClient : System.ServiceModel.ClientBase<ConectorRM.wsProcess.IRMSServer>, ConectorRM.wsProcess.IRMSServer {
        
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="wsProcess.IwsBase")]
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
    public interface IwsBaseChannel : ConectorRM.wsProcess.IwsBase, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwsBaseClient : System.ServiceModel.ClientBase<ConectorRM.wsProcess.IwsBase>, ConectorRM.wsProcess.IwsBase {
        
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.totvs.com/", ConfigurationName="wsProcess.IwsProcess")]
    public interface IwsProcess {
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/GetSchema", ReplyAction="http://www.totvs.com/IwsProcess/GetSchemaResponse")]
        string GetSchema(string ProcessServerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/GetSchema", ReplyAction="http://www.totvs.com/IwsProcess/GetSchemaResponse")]
        System.Threading.Tasks.Task<string> GetSchemaAsync(string ProcessServerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/GetSchema2", ReplyAction="http://www.totvs.com/IwsProcess/GetSchema2Response")]
        string GetSchema2(string ProcessServerName, string ownerData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/GetSchema2", ReplyAction="http://www.totvs.com/IwsProcess/GetSchema2Response")]
        System.Threading.Tasks.Task<string> GetSchema2Async(string ProcessServerName, string ownerData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteProcess", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteProcessResponse")]
        string ExecuteProcess(string ProcessServerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteProcess", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteProcessResponse")]
        System.Threading.Tasks.Task<string> ExecuteProcessAsync(string ProcessServerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteWithParams", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteWithParamsResponse")]
        string ExecuteWithParams(string ProcessServerName, string strXmlParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteWithParams", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteWithParamsResponse")]
        System.Threading.Tasks.Task<string> ExecuteWithParamsAsync(string ProcessServerName, string strXmlParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteWithParamsAsync", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteWithParamsAsyncResponse")]
        string ExecuteWithParamsAsync(string ProcessServerName, string strXmlParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteWithParamsAsync", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteWithParamsAsyncResponse")]
        System.Threading.Tasks.Task<string> ExecuteWithParamsAsyncAsync(string ProcessServerName, string strXmlParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteWithXmlParams", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteWithXmlParamsResponse")]
        string ExecuteWithXmlParams(string ProcessServerName, string strXmlParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteWithXmlParams", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteWithXmlParamsResponse")]
        System.Threading.Tasks.Task<string> ExecuteWithXmlParamsAsync(string ProcessServerName, string strXmlParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteWithXmlParamsAsync", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteWithXmlParamsAsyncResponse")]
        string ExecuteWithXmlParamsAsync(string ProcessServerName, string strXmlParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/ExecuteWithXmlParamsAsync", ReplyAction="http://www.totvs.com/IwsProcess/ExecuteWithXmlParamsAsyncResponse")]
        System.Threading.Tasks.Task<string> ExecuteWithXmlParamsAsyncAsync(string ProcessServerName, string strXmlParams);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/GetProcessStatus", ReplyAction="http://www.totvs.com/IwsProcess/GetProcessStatusResponse")]
        string GetProcessStatus(int jobId, int execId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.totvs.com/IwsProcess/GetProcessStatus", ReplyAction="http://www.totvs.com/IwsProcess/GetProcessStatusResponse")]
        System.Threading.Tasks.Task<string> GetProcessStatusAsync(int jobId, int execId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwsProcessChannel : ConectorRM.wsProcess.IwsProcess, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwsProcessClient : System.ServiceModel.ClientBase<ConectorRM.wsProcess.IwsProcess>, ConectorRM.wsProcess.IwsProcess {
        
        public IwsProcessClient() {
        }
        
        public IwsProcessClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwsProcessClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsProcessClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsProcessClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public string GetSchema(string ProcessServerName) {
            return base.Channel.GetSchema(ProcessServerName);
        }
        
        public System.Threading.Tasks.Task<string> GetSchemaAsync(string ProcessServerName) {
            return base.Channel.GetSchemaAsync(ProcessServerName);
        }
        
        public string GetSchema2(string ProcessServerName, string ownerData) {
            return base.Channel.GetSchema2(ProcessServerName, ownerData);
        }
        
        public System.Threading.Tasks.Task<string> GetSchema2Async(string ProcessServerName, string ownerData) {
            return base.Channel.GetSchema2Async(ProcessServerName, ownerData);
        }
        
        public string ExecuteProcess(string ProcessServerName) {
            return base.Channel.ExecuteProcess(ProcessServerName);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteProcessAsync(string ProcessServerName) {
            return base.Channel.ExecuteProcessAsync(ProcessServerName);
        }
        
        public string ExecuteWithParams(string ProcessServerName, string strXmlParams) {
            return base.Channel.ExecuteWithParams(ProcessServerName, strXmlParams);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteWithParamsAsync(string ProcessServerName, string strXmlParams) {
            return base.Channel.ExecuteWithParamsAsync(ProcessServerName, strXmlParams);
        }
        
        public string ExecuteWithParamsAsync(string ProcessServerName, string strXmlParams) {
            return base.Channel.ExecuteWithParamsAsync(ProcessServerName, strXmlParams);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteWithParamsAsyncAsync(string ProcessServerName, string strXmlParams) {
            return base.Channel.ExecuteWithParamsAsyncAsync(ProcessServerName, strXmlParams);
        }
        
        public string ExecuteWithXmlParams(string ProcessServerName, string strXmlParams) {
            return base.Channel.ExecuteWithXmlParams(ProcessServerName, strXmlParams);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteWithXmlParamsAsync(string ProcessServerName, string strXmlParams) {
            return base.Channel.ExecuteWithXmlParamsAsync(ProcessServerName, strXmlParams);
        }
        
        public string ExecuteWithXmlParamsAsync(string ProcessServerName, string strXmlParams) {
            return base.Channel.ExecuteWithXmlParamsAsync(ProcessServerName, strXmlParams);
        }
        
        public System.Threading.Tasks.Task<string> ExecuteWithXmlParamsAsyncAsync(string ProcessServerName, string strXmlParams) {
            return base.Channel.ExecuteWithXmlParamsAsyncAsync(ProcessServerName, strXmlParams);
        }
        
        public string GetProcessStatus(int jobId, int execId) {
            return base.Channel.GetProcessStatus(jobId, execId);
        }
        
        public System.Threading.Tasks.Task<string> GetProcessStatusAsync(int jobId, int execId) {
            return base.Channel.GetProcessStatusAsync(jobId, execId);
        }
    }
}
