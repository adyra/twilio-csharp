using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// ApplicationResource
    /// </summary>
    public class ApplicationResource : Resource 
    {
        private static Request BuildCreateRequest(CreateApplicationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Applications.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Create a new application within your account
        /// </summary>
        ///
        /// <param name="options"> Create Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static ApplicationResource Create(CreateApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Create a new application within your account
        /// </summary>
        ///
        /// <param name="options"> Create Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<ApplicationResource> CreateAsync(CreateApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Create a new application within your account
        /// </summary>
        ///
        /// <param name="friendlyName"> Human readable description of this resource </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="apiVersion"> The API version to use </param>
        /// <param name="voiceUrl"> URL Twilio will make requests to when relieving a call </param>
        /// <param name="voiceMethod"> HTTP method to use with the URL </param>
        /// <param name="voiceFallbackUrl"> Fallback URL </param>
        /// <param name="voiceFallbackMethod"> HTTP method to use with the fallback url </param>
        /// <param name="statusCallback"> URL to hit with status updates </param>
        /// <param name="statusCallbackMethod"> HTTP method to use with the status callback </param>
        /// <param name="voiceCallerIdLookup"> True or False </param>
        /// <param name="smsUrl"> URL Twilio will request when receiving an SMS </param>
        /// <param name="smsMethod"> HTTP method to use with sms_url </param>
        /// <param name="smsFallbackUrl"> Fallback URL if there's an error parsing TwiML </param>
        /// <param name="smsFallbackMethod"> HTTP method to use with sms_fallback_method </param>
        /// <param name="smsStatusCallback"> URL Twilio with request with status updates </param>
        /// <param name="messageStatusCallback"> URL to make requests to with status updates </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static ApplicationResource Create(string friendlyName, string pathAccountSid = null, string apiVersion = null, Uri voiceUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri statusCallback = null, Twilio.Http.HttpMethod statusCallbackMethod = null, bool? voiceCallerIdLookup = null, Uri smsUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri smsStatusCallback = null, Uri messageStatusCallback = null, ITwilioRestClient client = null)
        {
            var options = new CreateApplicationOptions(friendlyName){PathAccountSid = pathAccountSid, ApiVersion = apiVersion, VoiceUrl = voiceUrl, VoiceMethod = voiceMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceFallbackMethod = voiceFallbackMethod, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceCallerIdLookup = voiceCallerIdLookup, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsFallbackMethod = smsFallbackMethod, SmsStatusCallback = smsStatusCallback, MessageStatusCallback = messageStatusCallback};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Create a new application within your account
        /// </summary>
        ///
        /// <param name="friendlyName"> Human readable description of this resource </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="apiVersion"> The API version to use </param>
        /// <param name="voiceUrl"> URL Twilio will make requests to when relieving a call </param>
        /// <param name="voiceMethod"> HTTP method to use with the URL </param>
        /// <param name="voiceFallbackUrl"> Fallback URL </param>
        /// <param name="voiceFallbackMethod"> HTTP method to use with the fallback url </param>
        /// <param name="statusCallback"> URL to hit with status updates </param>
        /// <param name="statusCallbackMethod"> HTTP method to use with the status callback </param>
        /// <param name="voiceCallerIdLookup"> True or False </param>
        /// <param name="smsUrl"> URL Twilio will request when receiving an SMS </param>
        /// <param name="smsMethod"> HTTP method to use with sms_url </param>
        /// <param name="smsFallbackUrl"> Fallback URL if there's an error parsing TwiML </param>
        /// <param name="smsFallbackMethod"> HTTP method to use with sms_fallback_method </param>
        /// <param name="smsStatusCallback"> URL Twilio with request with status updates </param>
        /// <param name="messageStatusCallback"> URL to make requests to with status updates </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<ApplicationResource> CreateAsync(string friendlyName, string pathAccountSid = null, string apiVersion = null, Uri voiceUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri statusCallback = null, Twilio.Http.HttpMethod statusCallbackMethod = null, bool? voiceCallerIdLookup = null, Uri smsUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri smsStatusCallback = null, Uri messageStatusCallback = null, ITwilioRestClient client = null)
        {
            var options = new CreateApplicationOptions(friendlyName){PathAccountSid = pathAccountSid, ApiVersion = apiVersion, VoiceUrl = voiceUrl, VoiceMethod = voiceMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceFallbackMethod = voiceFallbackMethod, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceCallerIdLookup = voiceCallerIdLookup, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsFallbackMethod = smsFallbackMethod, SmsStatusCallback = smsStatusCallback, MessageStatusCallback = messageStatusCallback};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteApplicationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Applications/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Delete the application by the specified application sid
        /// </summary>
        ///
        /// <param name="options"> Delete Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static bool Delete(DeleteApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Delete the application by the specified application sid
        /// </summary>
        ///
        /// <param name="options"> Delete Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Delete the application by the specified application sid
        /// </summary>
        ///
        /// <param name="pathSid"> The application sid to delete </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteApplicationOptions(pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Delete the application by the specified application sid
        /// </summary>
        ///
        /// <param name="pathSid"> The application sid to delete </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteApplicationOptions(pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildFetchRequest(FetchApplicationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Applications/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch the application specified by the provided sid
        /// </summary>
        ///
        /// <param name="options"> Fetch Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static ApplicationResource Fetch(FetchApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch the application specified by the provided sid
        /// </summary>
        ///
        /// <param name="options"> Fetch Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<ApplicationResource> FetchAsync(FetchApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch the application specified by the provided sid
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique Application Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static ApplicationResource Fetch(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchApplicationOptions(pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch the application specified by the provided sid
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique Application Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<ApplicationResource> FetchAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchApplicationOptions(pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadApplicationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Applications.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of applications representing an application within the requesting account
        /// </summary>
        ///
        /// <param name="options"> Read Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static ResourceSet<ApplicationResource> Read(ReadApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<ApplicationResource>.FromJson("applications", response.Content);
            return new ResourceSet<ApplicationResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of applications representing an application within the requesting account
        /// </summary>
        ///
        /// <param name="options"> Read Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ApplicationResource>> ReadAsync(ReadApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<ApplicationResource>.FromJson("applications", response.Content);
            return new ResourceSet<ApplicationResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of applications representing an application within the requesting account
        /// </summary>
        ///
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="friendlyName"> Filter by friendly name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static ResourceSet<ApplicationResource> Read(string pathAccountSid = null, string friendlyName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadApplicationOptions{PathAccountSid = pathAccountSid, FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of applications representing an application within the requesting account
        /// </summary>
        ///
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="friendlyName"> Filter by friendly name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ApplicationResource>> ReadAsync(string pathAccountSid = null, string friendlyName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadApplicationOptions{PathAccountSid = pathAccountSid, FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
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
        public static Page<ApplicationResource> NextPage(Page<ApplicationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<ApplicationResource>.FromJson("applications", response.Content);
        }
    
        private static Request BuildUpdateRequest(UpdateApplicationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Applications/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Updates the application's properties
        /// </summary>
        ///
        /// <param name="options"> Update Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static ApplicationResource Update(UpdateApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Updates the application's properties
        /// </summary>
        ///
        /// <param name="options"> Update Application parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<ApplicationResource> UpdateAsync(UpdateApplicationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Updates the application's properties
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="friendlyName"> Human readable description of this resource </param>
        /// <param name="apiVersion"> The API version to use </param>
        /// <param name="voiceUrl"> URL Twilio will make requests to when relieving a call </param>
        /// <param name="voiceMethod"> HTTP method to use with the URL </param>
        /// <param name="voiceFallbackUrl"> Fallback URL </param>
        /// <param name="voiceFallbackMethod"> HTTP method to use with the fallback url </param>
        /// <param name="statusCallback"> URL to hit with status updates </param>
        /// <param name="statusCallbackMethod"> HTTP method to use with the status callback </param>
        /// <param name="voiceCallerIdLookup"> True or False </param>
        /// <param name="smsUrl"> URL Twilio will request when receiving an SMS </param>
        /// <param name="smsMethod"> HTTP method to use with sms_url </param>
        /// <param name="smsFallbackUrl"> Fallback URL if there's an error parsing TwiML </param>
        /// <param name="smsFallbackMethod"> HTTP method to use with sms_fallback_method </param>
        /// <param name="smsStatusCallback"> URL Twilio with request with status updates </param>
        /// <param name="messageStatusCallback"> URL to make requests to with status updates </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Application </returns> 
        public static ApplicationResource Update(string pathSid, string pathAccountSid = null, string friendlyName = null, string apiVersion = null, Uri voiceUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri statusCallback = null, Twilio.Http.HttpMethod statusCallbackMethod = null, bool? voiceCallerIdLookup = null, Uri smsUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri smsStatusCallback = null, Uri messageStatusCallback = null, ITwilioRestClient client = null)
        {
            var options = new UpdateApplicationOptions(pathSid){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, ApiVersion = apiVersion, VoiceUrl = voiceUrl, VoiceMethod = voiceMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceFallbackMethod = voiceFallbackMethod, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceCallerIdLookup = voiceCallerIdLookup, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsFallbackMethod = smsFallbackMethod, SmsStatusCallback = smsStatusCallback, MessageStatusCallback = messageStatusCallback};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Updates the application's properties
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="friendlyName"> Human readable description of this resource </param>
        /// <param name="apiVersion"> The API version to use </param>
        /// <param name="voiceUrl"> URL Twilio will make requests to when relieving a call </param>
        /// <param name="voiceMethod"> HTTP method to use with the URL </param>
        /// <param name="voiceFallbackUrl"> Fallback URL </param>
        /// <param name="voiceFallbackMethod"> HTTP method to use with the fallback url </param>
        /// <param name="statusCallback"> URL to hit with status updates </param>
        /// <param name="statusCallbackMethod"> HTTP method to use with the status callback </param>
        /// <param name="voiceCallerIdLookup"> True or False </param>
        /// <param name="smsUrl"> URL Twilio will request when receiving an SMS </param>
        /// <param name="smsMethod"> HTTP method to use with sms_url </param>
        /// <param name="smsFallbackUrl"> Fallback URL if there's an error parsing TwiML </param>
        /// <param name="smsFallbackMethod"> HTTP method to use with sms_fallback_method </param>
        /// <param name="smsStatusCallback"> URL Twilio with request with status updates </param>
        /// <param name="messageStatusCallback"> URL to make requests to with status updates </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Application </returns> 
        public static async System.Threading.Tasks.Task<ApplicationResource> UpdateAsync(string pathSid, string pathAccountSid = null, string friendlyName = null, string apiVersion = null, Uri voiceUrl = null, Twilio.Http.HttpMethod voiceMethod = null, Uri voiceFallbackUrl = null, Twilio.Http.HttpMethod voiceFallbackMethod = null, Uri statusCallback = null, Twilio.Http.HttpMethod statusCallbackMethod = null, bool? voiceCallerIdLookup = null, Uri smsUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, Uri smsStatusCallback = null, Uri messageStatusCallback = null, ITwilioRestClient client = null)
        {
            var options = new UpdateApplicationOptions(pathSid){PathAccountSid = pathAccountSid, FriendlyName = friendlyName, ApiVersion = apiVersion, VoiceUrl = voiceUrl, VoiceMethod = voiceMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceFallbackMethod = voiceFallbackMethod, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceCallerIdLookup = voiceCallerIdLookup, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsFallbackMethod = smsFallbackMethod, SmsStatusCallback = smsStatusCallback, MessageStatusCallback = messageStatusCallback};
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ApplicationResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ApplicationResource object represented by the provided JSON </returns> 
        public static ApplicationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ApplicationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// A string that uniquely identifies this resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The API version to use
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// Date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// Date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Human readable description of this resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// URL to make requests to with status updates
        /// </summary>
        [JsonProperty("message_status_callback")]
        public Uri MessageStatusCallback { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// HTTP method to use with sms_fallback_method
        /// </summary>
        [JsonProperty("sms_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; private set; }
        /// <summary>
        /// Fallback URL if there's an error parsing TwiML
        /// </summary>
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }
        /// <summary>
        /// HTTP method to use with sms_url
        /// </summary>
        [JsonProperty("sms_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsMethod { get; private set; }
        /// <summary>
        /// URL Twilio with request with status updates
        /// </summary>
        [JsonProperty("sms_status_callback")]
        public Uri SmsStatusCallback { get; private set; }
        /// <summary>
        /// URL Twilio will request when receiving an SMS
        /// </summary>
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }
        /// <summary>
        /// URL to hit with status updates
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// HTTP method to use with the status callback
        /// </summary>
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }
        /// <summary>
        /// URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// True or False
        /// </summary>
        [JsonProperty("voice_caller_id_lookup")]
        public bool? VoiceCallerIdLookup { get; private set; }
        /// <summary>
        /// HTTP method to use with the fallback url
        /// </summary>
        [JsonProperty("voice_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }
        /// <summary>
        /// Fallback URL
        /// </summary>
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }
        /// <summary>
        /// HTTP method to use with the URL
        /// </summary>
        [JsonProperty("voice_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }
        /// <summary>
        /// URL Twilio will make requests to when relieving a call
        /// </summary>
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }
    
        private ApplicationResource()
        {
        
        }
    }

}