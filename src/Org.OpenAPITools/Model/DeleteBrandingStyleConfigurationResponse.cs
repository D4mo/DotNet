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
    /// DeleteBrandingStyleConfigurationResponse
    /// </summary>
    [DataContract]
    public partial class DeleteBrandingStyleConfigurationResponse :  IEquatable<DeleteBrandingStyleConfigurationResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ResponseType
        /// </summary>
        [DataMember(Name="responseType", EmitDefaultValue=false)]
        public ResponseType? ResponseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBrandingStyleConfigurationResponse" /> class.
        /// </summary>
        /// <param name="clientRequestId">Echoes back the value in the request header for tracking..</param>
        /// <param name="apiTraceId">Request identifier in API, can be used to request logs from the support team..</param>
        /// <param name="responseType">responseType.</param>
        /// <param name="storeId">Store ID number..</param>
        /// <param name="status">Status from delete branding style configuration process..</param>
        public DeleteBrandingStyleConfigurationResponse(string clientRequestId = default(string), string apiTraceId = default(string), ResponseType? responseType = default(ResponseType?), string storeId = default(string), string status = default(string))
        {
            this.ClientRequestId = clientRequestId;
            this.ApiTraceId = apiTraceId;
            this.ResponseType = responseType;
            this.StoreId = storeId;
            this.Status = status;
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
        /// Store ID number.
        /// </summary>
        /// <value>Store ID number.</value>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Status from delete branding style configuration process.
        /// </summary>
        /// <value>Status from delete branding style configuration process.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteBrandingStyleConfigurationResponse {\n");
            sb.Append("  ClientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  ApiTraceId: ").Append(ApiTraceId).Append("\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as DeleteBrandingStyleConfigurationResponse);
        }

        /// <summary>
        /// Returns true if DeleteBrandingStyleConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteBrandingStyleConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteBrandingStyleConfigurationResponse input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
