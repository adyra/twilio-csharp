using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip.Domain 
{

    /// <summary>
    /// IpAccessControlListMappingResource
    /// </summary>
    public class IpAccessControlListMappingResource : Resource 
    {
        private static Request BuildFetchRequest(FetchIpAccessControlListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/IpAccessControlListMappings/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch IpAccessControlListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlListMapping </returns> 
        public static IpAccessControlListMappingResource Fetch(FetchIpAccessControlListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch IpAccessControlListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlListMapping </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListMappingResource> FetchAsync(FetchIpAccessControlListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlListMapping </returns> 
        public static IpAccessControlListMappingResource Fetch(string pathDomainSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchIpAccessControlListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlListMapping </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListMappingResource> FetchAsync(string pathDomainSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchIpAccessControlListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildCreateRequest(CreateIpAccessControlListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/IpAccessControlListMappings.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create IpAccessControlListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlListMapping </returns> 
        public static IpAccessControlListMappingResource Create(CreateIpAccessControlListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create IpAccessControlListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlListMapping </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListMappingResource> CreateAsync(CreateIpAccessControlListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="ipAccessControlListSid"> The ip_access_control_list_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlListMapping </returns> 
        public static IpAccessControlListMappingResource Create(string pathDomainSid, string ipAccessControlListSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateIpAccessControlListMappingOptions(pathDomainSid, ipAccessControlListSid){PathAccountSid = pathAccountSid};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="ipAccessControlListSid"> The ip_access_control_list_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlListMapping </returns> 
        public static async System.Threading.Tasks.Task<IpAccessControlListMappingResource> CreateAsync(string pathDomainSid, string ipAccessControlListSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new CreateIpAccessControlListMappingOptions(pathDomainSid, ipAccessControlListSid){PathAccountSid = pathAccountSid};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadIpAccessControlListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/IpAccessControlListMappings.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read IpAccessControlListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlListMapping </returns> 
        public static ResourceSet<IpAccessControlListMappingResource> Read(ReadIpAccessControlListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<IpAccessControlListMappingResource>.FromJson("ip_access_control_list_mappings", response.Content);
            return new ResourceSet<IpAccessControlListMappingResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read IpAccessControlListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlListMapping </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<IpAccessControlListMappingResource>> ReadAsync(ReadIpAccessControlListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<IpAccessControlListMappingResource>.FromJson("ip_access_control_list_mappings", response.Content);
            return new ResourceSet<IpAccessControlListMappingResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlListMapping </returns> 
        public static ResourceSet<IpAccessControlListMappingResource> Read(string pathDomainSid, string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadIpAccessControlListMappingOptions(pathDomainSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlListMapping </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<IpAccessControlListMappingResource>> ReadAsync(string pathDomainSid, string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadIpAccessControlListMappingOptions(pathDomainSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<IpAccessControlListMappingResource> NextPage(Page<IpAccessControlListMappingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<IpAccessControlListMappingResource>.FromJson("ip_access_control_list_mappings", response.Content);
        }
    
        private static Request BuildDeleteRequest(DeleteIpAccessControlListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/IpAccessControlListMappings/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete IpAccessControlListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlListMapping </returns> 
        public static bool Delete(DeleteIpAccessControlListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete IpAccessControlListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlListMapping </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteIpAccessControlListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlListMapping </returns> 
        public static bool Delete(string pathDomainSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteIpAccessControlListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlListMapping </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathDomainSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteIpAccessControlListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a IpAccessControlListMappingResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> IpAccessControlListMappingResource object represented by the provided JSON </returns> 
        public static IpAccessControlListMappingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<IpAccessControlListMappingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
    
        private IpAccessControlListMappingResource()
        {
        
        }
    }

}