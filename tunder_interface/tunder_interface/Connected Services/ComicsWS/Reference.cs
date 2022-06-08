﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComicsWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", ConfigurationName="ComicsWS.ComicsPort")]
    public interface ComicsPort
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ComicsWS.getComicResponse1> getComicAsync(ComicsWS.getComicRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class getComicRequest
    {
        
        private int idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class comicsoap
    {
        
        private string nombreField;
        
        private string autorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string autor
        {
            get
            {
                return this.autorField;
            }
            set
            {
                this.autorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class getComicResponse
    {
        
        private comicsoap comicField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public comicsoap comic
        {
            get
            {
                return this.comicField;
            }
            set
            {
                this.comicField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getComicRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ComicsWS.getComicRequest getComicRequest;
        
        public getComicRequest1()
        {
        }
        
        public getComicRequest1(ComicsWS.getComicRequest getComicRequest)
        {
            this.getComicRequest = getComicRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getComicResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ComicsWS.getComicResponse getComicResponse;
        
        public getComicResponse1()
        {
        }
        
        public getComicResponse1(ComicsWS.getComicResponse getComicResponse)
        {
            this.getComicResponse = getComicResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface ComicsPortChannel : ComicsWS.ComicsPort, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ComicsPortClient : System.ServiceModel.ClientBase<ComicsWS.ComicsPort>, ComicsWS.ComicsPort
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ComicsPortClient() : 
                base(ComicsPortClient.GetDefaultBinding(), ComicsPortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ComicsPortSoap11.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComicsPortClient(EndpointConfiguration endpointConfiguration) : 
                base(ComicsPortClient.GetBindingForEndpoint(endpointConfiguration), ComicsPortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComicsPortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ComicsPortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComicsPortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ComicsPortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComicsPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ComicsWS.getComicResponse1> ComicsWS.ComicsPort.getComicAsync(ComicsWS.getComicRequest1 request)
        {
            return base.Channel.getComicAsync(request);
        }
        
        public System.Threading.Tasks.Task<ComicsWS.getComicResponse1> getComicAsync(ComicsWS.getComicRequest getComicRequest)
        {
            ComicsWS.getComicRequest1 inValue = new ComicsWS.getComicRequest1();
            inValue.getComicRequest = getComicRequest;
            return ((ComicsWS.ComicsPort)(this)).getComicAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.ComicsPortSoap11))
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
            if ((endpointConfiguration == EndpointConfiguration.ComicsPortSoap11))
            {
                return new System.ServiceModel.EndpointAddress("http://6851-186-118-24-19.ngrok.io:80/ws");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ComicsPortClient.GetBindingForEndpoint(EndpointConfiguration.ComicsPortSoap11);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ComicsPortClient.GetEndpointAddress(EndpointConfiguration.ComicsPortSoap11);
        }
        
        public enum EndpointConfiguration
        {
            
            ComicsPortSoap11,
        }
    }
}
