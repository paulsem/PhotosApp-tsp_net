﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.InterfacePhotosApp")]
    public interface InterfacePhotosApp
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhotosApp/addDetails", ReplyAction="http://tempuri.org/InterfacePhotosApp/addDetailsResponse")]
        System.Threading.Tasks.Task addDetailsAsync(string a, string b, string c, System.DateTime data, System.Collections.Generic.List<string> x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhotosApp/checkPath", ReplyAction="http://tempuri.org/InterfacePhotosApp/checkPathResponse")]
        System.Threading.Tasks.Task<bool> checkPathAsync(string a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhotosApp/insertNewImage", ReplyAction="http://tempuri.org/InterfacePhotosApp/insertNewImageResponse")]
        System.Threading.Tasks.Task insertNewImageAsync(string path, string locatie, string anotimp, System.DateTime data, System.Collections.Generic.List<string> persoane);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhotosApp/updateDetails", ReplyAction="http://tempuri.org/InterfacePhotosApp/updateDetailsResponse")]
        System.Threading.Tasks.Task updateDetailsAsync(string a, string b, string c, System.DateTime data, System.Collections.Generic.List<string> x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhotosApp/deleteDetails", ReplyAction="http://tempuri.org/InterfacePhotosApp/deleteDetailsResponse")]
        System.Threading.Tasks.Task deleteDetailsAsync(string a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhotosApp/getDetails", ReplyAction="http://tempuri.org/InterfacePhotosApp/getDetailsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getDetailsAsync(string a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhotosApp/getPaths", ReplyAction="http://tempuri.org/InterfacePhotosApp/getPathsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getPathsAsync(string a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhotosApp/getAllDetails", ReplyAction="http://tempuri.org/InterfacePhotosApp/getAllDetailsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getAllDetailsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface InterfacePhotosAppChannel : ServiceReference1.InterfacePhotosApp, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class InterfacePhotosAppClient : System.ServiceModel.ClientBase<ServiceReference1.InterfacePhotosApp>, ServiceReference1.InterfacePhotosApp
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InterfacePhotosAppClient() : 
                base(InterfacePhotosAppClient.GetDefaultBinding(), InterfacePhotosAppClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_InterfacePhotosApp.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfacePhotosAppClient(EndpointConfiguration endpointConfiguration) : 
                base(InterfacePhotosAppClient.GetBindingForEndpoint(endpointConfiguration), InterfacePhotosAppClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfacePhotosAppClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(InterfacePhotosAppClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfacePhotosAppClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(InterfacePhotosAppClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InterfacePhotosAppClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task addDetailsAsync(string a, string b, string c, System.DateTime data, System.Collections.Generic.List<string> x)
        {
            return base.Channel.addDetailsAsync(a, b, c, data, x);
        }
        
        public System.Threading.Tasks.Task<bool> checkPathAsync(string a)
        {
            return base.Channel.checkPathAsync(a);
        }
        
        public System.Threading.Tasks.Task insertNewImageAsync(string path, string locatie, string anotimp, System.DateTime data, System.Collections.Generic.List<string> persoane)
        {
            return base.Channel.insertNewImageAsync(path, locatie, anotimp, data, persoane);
        }
        
        public System.Threading.Tasks.Task updateDetailsAsync(string a, string b, string c, System.DateTime data, System.Collections.Generic.List<string> x)
        {
            return base.Channel.updateDetailsAsync(a, b, c, data, x);
        }
        
        public System.Threading.Tasks.Task deleteDetailsAsync(string a)
        {
            return base.Channel.deleteDetailsAsync(a);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getDetailsAsync(string a)
        {
            return base.Channel.getDetailsAsync(a);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getPathsAsync(string a)
        {
            return base.Channel.getPathsAsync(a);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getAllDetailsAsync()
        {
            return base.Channel.getAllDetailsAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InterfacePhotosApp))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_InterfacePhotosApp))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return InterfacePhotosAppClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_InterfacePhotosApp);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return InterfacePhotosAppClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_InterfacePhotosApp);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_InterfacePhotosApp,
        }
    }
}
