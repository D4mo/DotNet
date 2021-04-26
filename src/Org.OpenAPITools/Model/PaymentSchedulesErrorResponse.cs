/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.2.0.20210406.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Payment schedules response with error field included.
    /// </summary>
    [DataContract]
    public partial class PaymentSchedulesErrorResponse : IEquatable<PaymentSchedulesErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name = "responseType", EmitDefaultValue = false)]
        public ResponseType? ResponseType { get; set; }
        /// <summary>
        /// Result of requested operation. If it&#39;s anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.
        /// </summary>
        /// <value>Result of requested operation. If it&#39;s anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum VALIDATIONFAILED for value: VALIDATION_FAILED
            /// </summary>
            [EnumMember(Value = "VALIDATION_FAILED")]
            VALIDATIONFAILED = 2,

            /// <summary>
            /// Enum PROCESSINGFAILED for value: PROCESSING_FAILED
            /// </summary>
            [EnumMember(Value = "PROCESSING_FAILED")]
            PROCESSINGFAILED = 3,

            /// <summary>
            /// Enum FAILURE for value: FAILURE
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            FAILURE = 4,

            /// <summary>
            /// Enum DECLINED for value: DECLINED
            /// </summary>
            [EnumMember(Value = "DECLINED")]
            DECLINED = 5

        }

        /// <summary>
        /// Result of requested operation. If it&#39;s anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.
        /// </summary>
        /// <value>Result of requested operation. If it&#39;s anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.</value>
        [DataMember(Name = "requestStatus", EmitDefaultValue = false)]
        public RequestStatusEnum? RequestStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSchedulesErrorResponse" /> class.
        /// </summary>
        /// <param name="clientRequestId">Echoes back the value in the request header for tracking..</param>
        /// <param name="apiTraceId">Request identifier in API, can be used to request logs from the support team..</param>
        /// <param name="responseType">responseType.</param>
        /// <param name="requestStatus">Result of requested operation. If it&#39;s anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details..</param>
        /// <param name="orderId">Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM)..</param>
        /// <param name="transactionResponse">transactionResponse.</param>
        /// <param name="error">error.</param>
        public PaymentSchedulesErrorResponse(string clientRequestId = default(string), string apiTraceId = default(string), ResponseType responseType = default(ResponseType), RequestStatusEnum? requestStatus = null, string orderId = default(string), TransactionResponse transactionResponse = default(TransactionResponse), Error error = default(Error))
        {
            this.ClientRequestId = clientRequestId;
            this.ApiTraceId = apiTraceId;
            this.ResponseType = responseType;
            this.RequestStatus = requestStatus;
            this.OrderId = orderId;
            this.TransactionResponse = transactionResponse;
            this.Error = error;
        }

        /// <summary>
        /// Echoes back the value in the request header for tracking.
        /// </summary>
        /// <value>Echoes back the value in the request header for tracking.</value>
        [DataMember(Name = "clientRequestId", EmitDefaultValue = false)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Request identifier in API, can be used to request logs from the support team.
        /// </summary>
        /// <value>Request identifier in API, can be used to request logs from the support team.</value>
        [DataMember(Name = "apiTraceId", EmitDefaultValue = false)]
        public string ApiTraceId { get; set; }

        /// <summary>
        /// Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM).
        /// </summary>
        /// <value>Note - Client Order ID if supplied by client. If not supplied by client, IPG will generate. The first 12 alphanumeric digits are passed down to Fiserv Enterprise reporting tool, Clientline and Data File Manager (DFM).</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionResponse
        /// </summary>
        [DataMember(Name = "transactionResponse", EmitDefaultValue = false)]
        public TransactionResponse TransactionResponse { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public Error Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSchedulesErrorResponse {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  TransactionResponse: ").Append(TransactionResponse).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentSchedulesErrorResponse);
        }

        /// <summary>
        /// Returns true if PaymentSchedulesErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSchedulesErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSchedulesErrorResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
                ) && 
                (
                    this.ApiTraceId == input.ApiTraceId ||
                    (this.ApiTraceId != null &&
                    this.ApiTraceId.Equals(input.ApiTraceId))
                ) && 
                (
                    this.ResponseType == input.ResponseType ||
                    (this.ResponseType != null &&
                    this.ResponseType.Equals(input.ResponseType))
                ) && 
                (
                    this.RequestStatus == input.RequestStatus ||
                    (this.RequestStatus != null &&
                    this.RequestStatus.Equals(input.RequestStatus))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.TransactionResponse == input.TransactionResponse ||
                    (this.TransactionResponse != null &&
                    this.TransactionResponse.Equals(input.TransactionResponse))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.ApiTraceId != null)
                    hashCode = hashCode * 59 + this.ApiTraceId.GetHashCode();
                if (this.ResponseType != null)
                    hashCode = hashCode * 59 + this.ResponseType.GetHashCode();
                if (this.RequestStatus != null)
                    hashCode = hashCode * 59 + this.RequestStatus.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.TransactionResponse != null)
                    hashCode = hashCode * 59 + this.TransactionResponse.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
