using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip 
{

    /// <summary>
    /// DomainResource
    /// </summary>
    public class DomainResource : Resource 
    {
        private static Request BuildReadRequest(ReadDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of domains belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static ResourceSet<DomainResource> Read(ReadDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<DomainResource>.FromJson("domains", response.Content);
            return new ResourceSet<DomainResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of domains belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<DomainResource>> ReadAsync(ReadDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<DomainResource>.FromJson("domains", response.Content);
            return new ResourceSet<DomainResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of domains belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static ResourceSet<DomainResource> Read(string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadDomainOptions{PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of domains belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<DomainResource>> ReadAsync(string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadDomainOptions{PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<DomainResource> NextPage(Page<DomainResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<DomainResource>.FromJson("domains", response.Content);
        }
    
        private static Request BuildCreateRequest(CreateDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Create a new Domain
        /// </summary>
        ///
        /// <param name="options"> Create Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static DomainResource Create(CreateDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Create a new Domain
        /// </summary>
        ///
        /// <param name="options"> Create Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<DomainResource> CreateAsync(CreateDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Create a new Domain
        /// </summary>
        ///
        /// <param name="domainName"> The unique address on Twilio to route SIP traffic </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="friendlyName"> A user-specified, human-readable name for the trigger. </param>
        /// <param name="authType"> The types of authentication mapped to the domain </param>
        /// <param name="voiceUrl"> URL Twilio will request when receiving a call </param>
        /// <param name="voiceMethod"> HTTP method to use with voice_url </param>
        /// <param name="voiceFallbackUrl"> URL Twilio will request if an error occurs in executing TwiML </param>
        /// <param name="voiceFallbackMethod"> HTTP method used with voice_fallback_url </param>
        /// <param name="voiceStatusCallbackUrl"> URL that Twilio will request with status updates </param>
        /// <param name="voiceStatusCallbackMethod"> The voice_status_callback_method </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static DomainResource Create(string domainName, string pathAccountSid = null, string friendlyName = null, string authType = null, Uri voiceUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri voiceStatusCallbackUrl = null, Twilio.Http.HttpMethod voiceStatusCallbackMethod = null, ITwilioRestClient client = null)
        {
            var options = new CreateDomainOptions(domainName){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, AuthType = authType, VoiceUrl = voiceUrl, VoiceMethod = voiceMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceFallbackMethod = voiceFallbackMethod, VoiceStatusCallbackUrl = voiceStatusCallbackUrl, VoiceStatusCallbackMethod = voiceStatusCallbackMethod};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Create a new Domain
        /// </summary>
        ///
        /// <param name="domainName"> The unique address on Twilio to route SIP traffic </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="friendlyName"> A user-specified, human-readable name for the trigger. </param>
        /// <param name="authType"> The types of authentication mapped to the domain </param>
        /// <param name="voiceUrl"> URL Twilio will request when receiving a call </param>
        /// <param name="voiceMethod"> HTTP method to use with voice_url </param>
        /// <param name="voiceFallbackUrl"> URL Twilio will request if an error occurs in executing TwiML </param>
        /// <param name="voiceFallbackMethod"> HTTP method used with voice_fallback_url </param>
        /// <param name="voiceStatusCallbackUrl"> URL that Twilio will request with status updates </param>
        /// <param name="voiceStatusCallbackMethod"> The voice_status_callback_method </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<DomainResource> CreateAsync(string domainName, string pathAccountSid = null, string friendlyName = null, string authType = null, Uri voiceUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri voiceStatusCallbackUrl = null, Twilio.Http.HttpMethod voiceStatusCallbackMethod = null, ITwilioRestClient client = null)
        {
            var options = new CreateDomainOptions(domainName){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, AuthType = authType, VoiceUrl = voiceUrl, VoiceMethod = voiceMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceFallbackMethod = voiceFallbackMethod, VoiceStatusCallbackUrl = voiceStatusCallbackUrl, VoiceStatusCallbackMethod = voiceStatusCallbackMethod};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of a Domain
        /// </summary>
        ///
        /// <param name="options"> Fetch Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static DomainResource Fetch(FetchDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a Domain
        /// </summary>
        ///
        /// <param name="options"> Fetch Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<DomainResource> FetchAsync(FetchDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of a Domain
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique Domain Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static DomainResource Fetch(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchDomainOptions(pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a Domain
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique Domain Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<DomainResource> FetchAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchDomainOptions(pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Update the attributes of a domain
        /// </summary>
        ///
        /// <param name="options"> Update Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static DomainResource Update(UpdateDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Update the attributes of a domain
        /// </summary>
        ///
        /// <param name="options"> Update Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<DomainResource> UpdateAsync(UpdateDomainOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Update the attributes of a domain
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="authType"> The auth_type </param>
        /// <param name="friendlyName"> A user-specified, human-readable name for the trigger. </param>
        /// <param name="voiceFallbackMethod"> The voice_fallback_method </param>
        /// <param name="voiceFallbackUrl"> The voice_fallback_url </param>
        /// <param name="voiceMethod"> HTTP method to use with voice_url </param>
        /// <param name="voiceStatusCallbackMethod"> The voice_status_callback_method </param>
        /// <param name="voiceStatusCallbackUrl"> The voice_status_callback_url </param>
        /// <param name="voiceUrl"> The voice_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static DomainResource Update(string pathSid, string pathAccountSid = null, string authType = null, string friendlyName = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Twilio.Http.HttpMethod voiceStatusCallbackMethod = null, Uri voiceStatusCallbackUrl = null, Uri voiceUrl = null, ITwilioRestClient client = null)
        {
            var options = new UpdateDomainOptions(pathSid){PathAccountSid = pathAccountSid, AuthType = authType, FriendlyName = friendlyName, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceStatusCallbackMethod = voiceStatusCallbackMethod, VoiceStatusCallbackUrl = voiceStatusCallbackUrl, VoiceUrl = voiceUrl};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Update the attributes of a domain
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="authType"> The auth_type </param>
        /// <param name="friendlyName"> A user-specified, human-readable name for the trigger. </param>
        /// <param name="voiceFallbackMethod"> The voice_fallback_method </param>
        /// <param name="voiceFallbackUrl"> The voice_fallback_url </param>
        /// <param name="voiceMethod"> HTTP method to use with voice_url </param>
        /// <param name="voiceStatusCallbackMethod"> The voice_status_callback_method </param>
        /// <param name="voiceStatusCallbackUrl"> The voice_status_callback_url </param>
        /// <param name="voiceUrl"> The voice_url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<DomainResource> UpdateAsync(string pathSid, string pathAccountSid = null, string authType = null, string friendlyName = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Twilio.Http.HttpMethod voiceStatusCallbackMethod = null, Uri voiceStatusCallbackUrl = null, Uri voiceUrl = null, ITwilioRestClient client = null)
        {
            var options = new UpdateDomainOptions(pathSid){PathAccountSid = pathAccountSid, AuthType = authType, FriendlyName = friendlyName, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceStatusCallbackMethod = voiceStatusCallbackMethod, VoiceStatusCallbackUrl = voiceStatusCallbackUrl, VoiceUrl = voiceUrl};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteDomainOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static bool Delete(DeleteDomainOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Delete Domain parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteDomainOptions options, ITwilioRestClient client = null)
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
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Domain </returns> 
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteDomainOptions(pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Domain </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteDomainOptions(pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a DomainResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DomainResource object represented by the provided JSON </returns> 
        public static DomainResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<DomainResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The unique id of the account that sent the message
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The Twilio API version used to process the message
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The types of authentication mapped to the domain
        /// </summary>
        [JsonProperty("auth_type")]
        public string AuthType { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The unique address on Twilio to route SIP traffic
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; private set; }
        /// <summary>
        /// A user-specified, human-readable name for the trigger.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A string that uniquely identifies the SIP Domain
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// HTTP method used with voice_fallback_url
        /// </summary>
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }
        /// <summary>
        /// URL Twilio will request if an error occurs in executing TwiML
        /// </summary>
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }
        /// <summary>
        /// HTTP method to use with voice_url
        /// </summary>
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }
        /// <summary>
        /// The voice_status_callback_method
        /// </summary>
        [JsonProperty("voice_status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceStatusCallbackMethod { get; private set; }
        /// <summary>
        /// URL that Twilio will request with status updates
        /// </summary>
        [JsonProperty("voice_status_callback_url")]
        public Uri VoiceStatusCallbackUrl { get; private set; }
        /// <summary>
        /// URL Twilio will request when receiving a call
        /// </summary>
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }
        /// <summary>
        /// The subresource_uris
        /// </summary>
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }
    
        private DomainResource()
        {
        
        }
    }

}