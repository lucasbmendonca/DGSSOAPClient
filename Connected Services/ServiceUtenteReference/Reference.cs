﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceUtenteReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Utente", Namespace="http://schemas.datacontract.org/2004/07/DGSSOAP.Models")]
    public partial class Utente : object
    {
        
        private string[] ContactosField;
        
        private string NomeField;
        
        private string UtenteIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Contactos
        {
            get
            {
                return this.ContactosField;
            }
            set
            {
                this.ContactosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                this.NomeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UtenteId
        {
            get
            {
                return this.UtenteIdField;
            }
            set
            {
                this.UtenteIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceUtenteReference.IUtente")]
    public interface IUtente
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUtente/Get", ReplyAction="http://tempuri.org/IUtente/GetResponse")]
        ServiceUtenteReference.Utente Get(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUtente/Get", ReplyAction="http://tempuri.org/IUtente/GetResponse")]
        System.Threading.Tasks.Task<ServiceUtenteReference.Utente> GetAsync(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUtente/GetAll", ReplyAction="http://tempuri.org/IUtente/GetAllResponse")]
        ServiceUtenteReference.Utente[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUtente/GetAll", ReplyAction="http://tempuri.org/IUtente/GetAllResponse")]
        System.Threading.Tasks.Task<ServiceUtenteReference.Utente[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUtente/Set", ReplyAction="http://tempuri.org/IUtente/SetResponse")]
        bool Set(string codigo, string[] contactos, int addressId, int teamId, bool isolationStatus, bool irregularity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUtente/Set", ReplyAction="http://tempuri.org/IUtente/SetResponse")]
        System.Threading.Tasks.Task<bool> SetAsync(string codigo, string[] contactos, int addressId, int teamId, bool isolationStatus, bool irregularity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface IUtenteChannel : ServiceUtenteReference.IUtente, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class UtenteClient : System.ServiceModel.ClientBase<ServiceUtenteReference.IUtente>, ServiceUtenteReference.IUtente
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UtenteClient() : 
                base(UtenteClient.GetDefaultBinding(), UtenteClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUtente.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UtenteClient(EndpointConfiguration endpointConfiguration) : 
                base(UtenteClient.GetBindingForEndpoint(endpointConfiguration), UtenteClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UtenteClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UtenteClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UtenteClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UtenteClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UtenteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceUtenteReference.Utente Get(string codigo)
        {
            return base.Channel.Get(codigo);
        }
        
        public System.Threading.Tasks.Task<ServiceUtenteReference.Utente> GetAsync(string codigo)
        {
            return base.Channel.GetAsync(codigo);
        }
        
        public ServiceUtenteReference.Utente[] GetAll()
        {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ServiceUtenteReference.Utente[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public bool Set(string codigo, string[] contactos, int addressId, int teamId, bool isolationStatus, bool irregularity)
        {
            return base.Channel.Set(codigo, contactos, addressId, teamId, isolationStatus, irregularity);
        }
        
        public System.Threading.Tasks.Task<bool> SetAsync(string codigo, string[] contactos, int addressId, int teamId, bool isolationStatus, bool irregularity)
        {
            return base.Channel.SetAsync(codigo, contactos, addressId, teamId, isolationStatus, irregularity);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUtente))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUtente))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:59308/Services/UtenteService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UtenteClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUtente);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UtenteClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUtente);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IUtente,
        }
    }
}