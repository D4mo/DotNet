/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.12.0.20200605.001
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
    /// Response from a shared secret configuration request.
    /// </summary>
    [DataContract]
    public partial class SharedSecretConfigurationResponse :  IEquatable<SharedSecretConfigurationResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name="responseType", EmitDefaultValue=false)]
        public ResponseType? ResponseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSecretConfigurationResponse" /> class.
        /// </summary>
        /// <param name="clientRequestId">Echoes back the value in the request header for tracking..</param>
        /// <param name="apiTraceId">Request identifier in API, can be used to request logs from the support team..</param>
        /// <param name="responseType">responseType.</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="sharedSecret">Shared secret/password for Connect..</param>
        /// <param name="responseMessage">The message/status received after updating shared secret service config..</param>
        /// <param name="responseTimestamp">Response timestamp..</param>
        public SharedSecretConfigurationResponse(string clientRequestId = default(string), string apiTraceId = default(string), ResponseType? responseType = default(ResponseType?), string storeId = default(string), string sharedSecret = default(string), string responseMessage = default(string), long responseTimestamp = default(long))
        {
            this.ClientRequestId = clientRequestId;
            this.ApiTraceId = apiTraceId;
            this.ResponseType = responseType;
            this.StoreId = storeId;
            this.SharedSecret = sharedSecret;
            this.ResponseMessage = responseMessage;
            this.ResponseTimestamp = responseTimestamp;
        }
        
        /// <summary>
        /// Echoes back the value in the request header for tracking.
        /// </summary>
        /// <value>Echoes back the value in the request header for tracking.</value>
        [DataMember(Name="clientRequestId", EmitDefaultValue=false)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Request identifier in API, can be used to request logs from the support team.
        /// </summary>
        /// <value>Request identifier in API, can be used to request logs from the support team.</value>
        [DataMember(Name="apiTraceId", EmitDefaultValue=false)]
        public string ApiTraceId { get; set; }


        /// <summary>
        /// An optional outlet ID for clients that support multiple stores in the same developer app.
        /// </summary>
        /// <value>An optional outlet ID for clients that support multiple stores in the same developer app.</value>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Shared secret/password for Connect.
        /// </summary>
        /// <value>Shared secret/password for Connect.</value>
        [DataMember(Name="sharedSecret", EmitDefaultValue=false)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// The message/status received after updating shared secret service config.
        /// </summary>
        /// <value>The message/status received after updating shared secret service config.</value>
        [DataMember(Name="responseMessage", EmitDefaultValue=false)]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Response timestamp.
        /// </summary>
        /// <value>Response timestamp.</value>
        [DataMember(Name="responseTimestamp", EmitDefaultValue=false)]
        public long ResponseTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedSecretConfigurationResponse {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
            sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
            sb.Append("  ResponseTimestamp: ").Append(ResponseTimestamp).Append("\n");
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
            return this.Equals(input as SharedSecretConfigurationResponse);
        }

        /// <summary>
        /// Returns true if SharedSecretConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedSecretConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedSecretConfigurationResponse input)
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
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.SharedSecret == input.SharedSecret ||
                    (this.SharedSecret != null &&
                    this.SharedSecret.Equals(input.SharedSecret))
                ) && 
                (
                    this.ResponseMessage == input.ResponseMessage ||
                    (this.ResponseMessage != null &&
                    this.ResponseMessage.Equals(input.ResponseMessage))
                ) && 
                (
                    this.ResponseTimestamp == input.ResponseTimestamp ||
                    (this.ResponseTimestamp != null &&
                    this.ResponseTimestamp.Equals(input.ResponseTimestamp))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.SharedSecret != null)
                    hashCode = hashCode * 59 + this.SharedSecret.GetHashCode();
                if (this.ResponseMessage != null)
                    hashCode = hashCode * 59 + this.ResponseMessage.GetHashCode();
                if (this.ResponseTimestamp != null)
                    hashCode = hashCode * 59 + this.ResponseTimestamp.GetHashCode();
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
