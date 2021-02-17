/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.1.0.20210122.001
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
    /// InitiateClearingResponseAllOf
    /// </summary>
    [DataContract]
    public partial class InitiateClearingResponseAllOf : IEquatable<InitiateClearingResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.
        /// </summary>
        /// <value>Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum PROCESSINGFAILED for value: PROCESSING_FAILED
            /// </summary>
            [EnumMember(Value = "PROCESSING_FAILED")]
            PROCESSINGFAILED = 2,

            /// <summary>
            /// Enum FAILURE for value: FAILURE
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            FAILURE = 3

        }

        /// <summary>
        /// Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.
        /// </summary>
        /// <value>Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details.</value>
        [DataMember(Name = "requestStatus", EmitDefaultValue = false)]
        public RequestStatusEnum? RequestStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateClearingResponseAllOf" /> class.
        /// </summary>
        /// <param name="requestStatus">Request status. If it is anything other than &#39;SUCCESS&#39;, please refer to 400s HTTP error codes or decline. See Error object for details..</param>
        /// <param name="clearingDetails">clearingDetails.</param>
        /// <param name="endpointResponses">The array holds response information of the involved endpoints..</param>
        public InitiateClearingResponseAllOf(RequestStatusEnum? requestStatus = null, ClearingDetails clearingDetails = default(ClearingDetails), List<EndpointResponse> endpointResponses = default(List<EndpointResponse>))
        {
            this.RequestStatus = requestStatus;
            this.ClearingDetails = clearingDetails;
            this.EndpointResponses = endpointResponses;
        }

        /// <summary>
        /// Gets or Sets ClearingDetails
        /// </summary>
        [DataMember(Name = "clearingDetails", EmitDefaultValue = false)]
        public ClearingDetails ClearingDetails { get; set; }

        /// <summary>
        /// The array holds response information of the involved endpoints.
        /// </summary>
        /// <value>The array holds response information of the involved endpoints.</value>
        [DataMember(Name = "endpointResponses", EmitDefaultValue = false)]
        public List<EndpointResponse> EndpointResponses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateClearingResponseAllOf {\n");
            sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
            sb.Append("  ClearingDetails: ").Append(ClearingDetails).Append("\n");
            sb.Append("  EndpointResponses: ").Append(EndpointResponses).Append("\n");
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
            return this.Equals(input as InitiateClearingResponseAllOf);
        }

        /// <summary>
        /// Returns true if InitiateClearingResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiateClearingResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateClearingResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestStatus == input.RequestStatus ||
                    (this.RequestStatus != null &&
                    this.RequestStatus.Equals(input.RequestStatus))
                ) && 
                (
                    this.ClearingDetails == input.ClearingDetails ||
                    (this.ClearingDetails != null &&
                    this.ClearingDetails.Equals(input.ClearingDetails))
                ) && 
                (
                    this.EndpointResponses == input.EndpointResponses ||
                    this.EndpointResponses != null &&
                    input.EndpointResponses != null &&
                    this.EndpointResponses.SequenceEqual(input.EndpointResponses)
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
                if (this.RequestStatus != null)
                    hashCode = hashCode * 59 + this.RequestStatus.GetHashCode();
                if (this.ClearingDetails != null)
                    hashCode = hashCode * 59 + this.ClearingDetails.GetHashCode();
                if (this.EndpointResponses != null)
                    hashCode = hashCode * 59 + this.EndpointResponses.GetHashCode();
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
