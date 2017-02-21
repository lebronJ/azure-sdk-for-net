// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// The Azure event log entries are of type EventData
    /// </summary>
    public partial class EventData
    {
        /// <summary>
        /// Initializes a new instance of the EventData class.
        /// </summary>
        public EventData() { }

        /// <summary>
        /// Initializes a new instance of the EventData class.
        /// </summary>
        /// <param name="channels">the event channels. The regular event logs,
        /// that you see in the Azure Management Portals, flow through the
        /// 'Operation' channel. Possible values include: 'Admin', 'Operation',
        /// 'Debug', 'Analytics'</param>
        /// <param name="level">the event level. Possible values include:
        /// 'Critical', 'Error', 'Warning', 'Informational', 'Verbose'</param>
        /// <param name="eventTimestamp">the timestamp of when the event was
        /// generated by the Azure service processing the request corresponding
        /// the event. It in ISO 8601 format.</param>
        /// <param name="submissionTimestamp">the timestamp of when the event
        /// became available for querying via this API. It is in ISO 8601
        /// format. This value should not be confused eventTimestamp. As there
        /// might be a delay between the occurence time of the event, and the
        /// time that the event is submitted to the Azure logging
        /// infrastructure.</param>
        /// <param name="authorization">the authorization used by the user who
        /// has performed the operation that led to this event. This captures
        /// the RBAC properties of the event. These usually include the
        /// 'action', 'role' and the 'scope'</param>
        /// <param name="claims">key value pairs to identify ARM
        /// permissions.</param>
        /// <param name="caller">the email address of the user who has
        /// performed the operation, the UPN claim or SPN claim based on
        /// availability.</param>
        /// <param name="description">the description of the event.</param>
        /// <param name="id">the Id of this event as required by ARM for RBAC.
        /// It contains the EventDataID and a timestamp information.</param>
        /// <param name="eventDataId">the event data Id. This is a unique
        /// identifier for an event.</param>
        /// <param name="correlationId">the correlation Id, usually a GUID in
        /// the string format. The correlation Id is shared among the events
        /// that belong to the same uber operation.</param>
        /// <param name="eventName">the event name. This value should not be
        /// confused with OperationName. For practical purposes, OperationName
        /// might be more appealing to end users.</param>
        /// <param name="category">the event category.</param>
        /// <param name="httpRequest">the HTTP request info. Usually includes
        /// the 'clientRequestId', 'clientIpAddress' (IP address of the user
        /// who initiated the event) and 'method' (HTTP method e.g.
        /// PUT).</param>
        /// <param name="resourceGroupName">the resource group name of the
        /// impacted resource.</param>
        /// <param name="resourceProviderName">the resource provider name of
        /// the impacted resource.</param>
        /// <param name="resourceId">the resource uri that uniquely identifies
        /// the resource that caused this event.</param>
        /// <param name="resourceType">the resource type</param>
        /// <param name="operationId">It is usually a GUID shared among the
        /// events corresponding to single operation. This value should not be
        /// confused with EventName.</param>
        /// <param name="operationName">the operation name.</param>
        /// <param name="properties">the set of &lt;Key, Value&gt; pairs
        /// (usually a Dictionary&lt;String, String&gt;) that includes details
        /// about the event.</param>
        /// <param name="status">a string describing the status of the
        /// operation. Some typical values are: Started, In progress,
        /// Succeeded, Failed, Resolved.</param>
        /// <param name="subStatus">the event sub status. Most of the time,
        /// when included, this captures the HTTP status code of the REST call.
        /// Common values are: OK (HTTP Status Code: 200), Created (HTTP Status
        /// Code: 201), Accepted (HTTP Status Code: 202), No Content (HTTP
        /// Status Code: 204), Bad Request(HTTP Status Code: 400), Not Found
        /// (HTTP Status Code: 404), Conflict (HTTP Status Code: 409), Internal
        /// Server Error (HTTP Status Code: 500), Service Unavailable (HTTP
        /// Status Code:503), Gateway Timeout (HTTP Status Code: 504)</param>
        /// <param name="subscriptionId">the Azure subscription Id usually a
        /// GUID.</param>
        /// <param name="tenantId">the Azure tenant Id</param>
        public EventData(EventChannels channels, EventLevel level, System.DateTime eventTimestamp, System.DateTime submissionTimestamp, SenderAuthorization authorization = default(SenderAuthorization), System.Collections.Generic.IDictionary<string, string> claims = default(System.Collections.Generic.IDictionary<string, string>), string caller = default(string), string description = default(string), string id = default(string), string eventDataId = default(string), string correlationId = default(string), LocalizableString eventName = default(LocalizableString), LocalizableString category = default(LocalizableString), HttpRequestInfo httpRequest = default(HttpRequestInfo), string resourceGroupName = default(string), LocalizableString resourceProviderName = default(LocalizableString), string resourceId = default(string), LocalizableString resourceType = default(LocalizableString), string operationId = default(string), LocalizableString operationName = default(LocalizableString), System.Collections.Generic.IDictionary<string, string> properties = default(System.Collections.Generic.IDictionary<string, string>), LocalizableString status = default(LocalizableString), LocalizableString subStatus = default(LocalizableString), string subscriptionId = default(string), string tenantId = default(string))
        {
            Authorization = authorization;
            Channels = channels;
            Claims = claims;
            Caller = caller;
            Description = description;
            Id = id;
            EventDataId = eventDataId;
            CorrelationId = correlationId;
            EventName = eventName;
            Category = category;
            HttpRequest = httpRequest;
            Level = level;
            ResourceGroupName = resourceGroupName;
            ResourceProviderName = resourceProviderName;
            ResourceId = resourceId;
            ResourceType = resourceType;
            OperationId = operationId;
            OperationName = operationName;
            Properties = properties;
            Status = status;
            SubStatus = subStatus;
            EventTimestamp = eventTimestamp;
            SubmissionTimestamp = submissionTimestamp;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
        }

        /// <summary>
        /// Gets or sets the authorization used by the user who has performed
        /// the operation that led to this event. This captures the RBAC
        /// properties of the event. These usually include the 'action', 'role'
        /// and the 'scope'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "authorization")]
        public SenderAuthorization Authorization { get; set; }

        /// <summary>
        /// Gets or sets the event channels. The regular event logs, that you
        /// see in the Azure Management Portals, flow through the 'Operation'
        /// channel. Possible values include: 'Admin', 'Operation', 'Debug',
        /// 'Analytics'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "channels")]
        public EventChannels Channels { get; set; }

        /// <summary>
        /// Gets or sets key value pairs to identify ARM permissions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "claims")]
        public System.Collections.Generic.IDictionary<string, string> Claims { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user who has performed the
        /// operation, the UPN claim or SPN claim based on availability.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "caller")]
        public string Caller { get; set; }

        /// <summary>
        /// Gets or sets the description of the event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Id of this event as required by ARM for RBAC. It
        /// contains the EventDataID and a timestamp information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the event data Id. This is a unique identifier for an
        /// event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eventDataId")]
        public string EventDataId { get; set; }

        /// <summary>
        /// Gets or sets the correlation Id, usually a GUID in the string
        /// format. The correlation Id is shared among the events that belong
        /// to the same uber operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the event name. This value should not be confused with
        /// OperationName. For practical purposes, OperationName might be more
        /// appealing to end users.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eventName")]
        public LocalizableString EventName { get; set; }

        /// <summary>
        /// Gets or sets the event category.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "category")]
        public LocalizableString Category { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request info. Usually includes the
        /// 'clientRequestId', 'clientIpAddress' (IP address of the user who
        /// initiated the event) and 'method' (HTTP method e.g. PUT).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "httpRequest")]
        public HttpRequestInfo HttpRequest { get; set; }

        /// <summary>
        /// Gets or sets the event level. Possible values include: 'Critical',
        /// 'Error', 'Warning', 'Informational', 'Verbose'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "level")]
        public EventLevel Level { get; set; }

        /// <summary>
        /// Gets or sets the resource group name of the impacted resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the resource provider name of the impacted resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceProviderName")]
        public LocalizableString ResourceProviderName { get; set; }

        /// <summary>
        /// Gets or sets the resource uri that uniquely identifies the resource
        /// that caused this event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the resource type
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceType")]
        public LocalizableString ResourceType { get; set; }

        /// <summary>
        /// Gets or sets it is usually a GUID shared among the events
        /// corresponding to single operation. This value should not be
        /// confused with EventName.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets the operation name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operationName")]
        public LocalizableString OperationName { get; set; }

        /// <summary>
        /// Gets or sets the set of &amp;lt;Key, Value&amp;gt; pairs (usually a
        /// Dictionary&amp;lt;String, String&amp;gt;) that includes details
        /// about the event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets a string describing the status of the operation. Some
        /// typical values are: Started, In progress, Succeeded, Failed,
        /// Resolved.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public LocalizableString Status { get; set; }

        /// <summary>
        /// Gets or sets the event sub status. Most of the time, when included,
        /// this captures the HTTP status code of the REST call. Common values
        /// are: OK (HTTP Status Code: 200), Created (HTTP Status Code: 201),
        /// Accepted (HTTP Status Code: 202), No Content (HTTP Status Code:
        /// 204), Bad Request(HTTP Status Code: 400), Not Found (HTTP Status
        /// Code: 404), Conflict (HTTP Status Code: 409), Internal Server Error
        /// (HTTP Status Code: 500), Service Unavailable (HTTP Status
        /// Code:503), Gateway Timeout (HTTP Status Code: 504)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subStatus")]
        public LocalizableString SubStatus { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of when the event was generated by the
        /// Azure service processing the request corresponding the event. It in
        /// ISO 8601 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eventTimestamp")]
        public System.DateTime EventTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of when the event became available for
        /// querying via this API. It is in ISO 8601 format. This value should
        /// not be confused eventTimestamp. As there might be a delay between
        /// the occurence time of the event, and the time that the event is
        /// submitted to the Azure logging infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "submissionTimestamp")]
        public System.DateTime SubmissionTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the Azure subscription Id usually a GUID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the Azure tenant Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.EventName != null)
            {
                this.EventName.Validate();
            }
            if (this.Category != null)
            {
                this.Category.Validate();
            }
            if (this.ResourceProviderName != null)
            {
                this.ResourceProviderName.Validate();
            }
            if (this.ResourceType != null)
            {
                this.ResourceType.Validate();
            }
            if (this.OperationName != null)
            {
                this.OperationName.Validate();
            }
            if (this.Status != null)
            {
                this.Status.Validate();
            }
            if (this.SubStatus != null)
            {
                this.SubStatus.Validate();
            }
        }
    }
}