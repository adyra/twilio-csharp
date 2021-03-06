using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Queue 
{

    /// <summary>
    /// MemberResource
    /// </summary>
    public class MemberResource : Resource 
    {
        private static Request BuildFetchRequest(FetchMemberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Queues/" + options.PathQueueSid + "/Members/" + options.PathCallSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch a specific members of the queue
        /// </summary>
        ///
        /// <param name="options"> Fetch Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Fetch(FetchMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a specific members of the queue
        /// </summary>
        ///
        /// <param name="options"> Fetch Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> FetchAsync(FetchMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch a specific members of the queue
        /// </summary>
        ///
        /// <param name="pathQueueSid"> The Queue in which to find the members </param>
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Fetch(string pathQueueSid, string pathCallSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchMemberOptions(pathQueueSid, pathCallSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch a specific members of the queue
        /// </summary>
        ///
        /// <param name="pathQueueSid"> The Queue in which to find the members </param>
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> FetchAsync(string pathQueueSid, string pathCallSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchMemberOptions(pathQueueSid, pathCallSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateMemberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Queues/" + options.PathQueueSid + "/Members/" + options.PathCallSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Dequeue a member from a queue and have the member's call begin executing the TwiML document at that URL
        /// </summary>
        ///
        /// <param name="options"> Update Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Update(UpdateMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Dequeue a member from a queue and have the member's call begin executing the TwiML document at that URL
        /// </summary>
        ///
        /// <param name="options"> Update Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> UpdateAsync(UpdateMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Dequeue a member from a queue and have the member's call begin executing the TwiML document at that URL
        /// </summary>
        ///
        /// <param name="pathQueueSid"> The Queue in which to find the members </param>
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="url"> The url </param>
        /// <param name="method"> The method </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static MemberResource Update(string pathQueueSid, string pathCallSid, Uri url, Twilio.Http.HttpMethod method, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new UpdateMemberOptions(pathQueueSid, pathCallSid, url, method){PathAccountSid = pathAccountSid};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Dequeue a member from a queue and have the member's call begin executing the TwiML document at that URL
        /// </summary>
        ///
        /// <param name="pathQueueSid"> The Queue in which to find the members </param>
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="url"> The url </param>
        /// <param name="method"> The method </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<MemberResource> UpdateAsync(string pathQueueSid, string pathCallSid, Uri url, Twilio.Http.HttpMethod method, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new UpdateMemberOptions(pathQueueSid, pathCallSid, url, method){PathAccountSid = pathAccountSid};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadMemberOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Queues/" + options.PathQueueSid + "/Members.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of members in the queue
        /// </summary>
        ///
        /// <param name="options"> Read Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static ResourceSet<MemberResource> Read(ReadMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<MemberResource>.FromJson("queue_members", response.Content);
            return new ResourceSet<MemberResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of members in the queue
        /// </summary>
        ///
        /// <param name="options"> Read Member parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MemberResource>> ReadAsync(ReadMemberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<MemberResource>.FromJson("queue_members", response.Content);
            return new ResourceSet<MemberResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of members in the queue
        /// </summary>
        ///
        /// <param name="pathQueueSid"> The Queue in which to find members </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Member </returns> 
        public static ResourceSet<MemberResource> Read(string pathQueueSid, string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMemberOptions(pathQueueSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of members in the queue
        /// </summary>
        ///
        /// <param name="pathQueueSid"> The Queue in which to find members </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Member </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<MemberResource>> ReadAsync(string pathQueueSid, string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadMemberOptions(pathQueueSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
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
        public static Page<MemberResource> NextPage(Page<MemberResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<MemberResource>.FromJson("queue_members", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a MemberResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MemberResource object represented by the provided JSON </returns> 
        public static MemberResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<MemberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// Unique string that identifies this resource
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// The date the member was enqueued
        /// </summary>
        [JsonProperty("date_enqueued")]
        public DateTime? DateEnqueued { get; private set; }
        /// <summary>
        /// This member's current position in the queue.
        /// </summary>
        [JsonProperty("position")]
        public int? Position { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The number of seconds the member has been in the queue.
        /// </summary>
        [JsonProperty("wait_time")]
        public int? WaitTime { get; private set; }
    
        private MemberResource()
        {
        
        }
    }

}