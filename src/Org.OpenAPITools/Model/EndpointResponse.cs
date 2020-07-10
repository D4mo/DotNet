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
    /// Provides clearing response information for the specific endpoint.
    /// </summary>
    [DataContract]
    public partial class EndpointResponse :  IEquatable<EndpointResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines the clearing status of an endpoint.
        /// </summary>
        /// <value>Defines the clearing status of an endpoint.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 1,

            /// <summary>
            /// Enum DECLINED for value: DECLINED
            /// </summary>
            [EnumMember(Value = "DECLINED")]
            DECLINED = 2,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 3

        }

        /// <summary>
        /// Defines the clearing status of an endpoint.
        /// </summary>
        /// <value>Defines the clearing status of an endpoint.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointResponse" /> class.
        /// </summary>
        /// <param name="endpointID">Specifies the identifier of an endpoint..</param>
        /// <param name="status">Defines the clearing status of an endpoint..</param>
        /// <param name="batchNumber">Defines the batch number of an endpoint clearing process..</param>
        public EndpointResponse(string endpointID = default(string), StatusEnum? status = default(StatusEnum?), string batchNumber = default(string))
        {
            this.EndpointID = endpointID;
            this.Status = status;
            this.BatchNumber = batchNumber;
        }
        
        /// <summary>
        /// Specifies the identifier of an endpoint.
        /// </summary>
        /// <value>Specifies the identifier of an endpoint.</value>
        [DataMember(Name="endpointID", EmitDefaultValue=false)]
        public string EndpointID { get; set; }


        /// <summary>
        /// Defines the batch number of an endpoint clearing process.
        /// </summary>
        /// <value>Defines the batch number of an endpoint clearing process.</value>
        [DataMember(Name="batchNumber", EmitDefaultValue=false)]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointResponse {\n");
            sb.Append("  EndpointID: ").Append(EndpointID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BatchNumber: ").Append(BatchNumber).Append("\n");
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
            return this.Equals(input as EndpointResponse);
        }

        /// <summary>
        /// Returns true if EndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndpointID == input.EndpointID ||
                    (this.EndpointID != null &&
                    this.EndpointID.Equals(input.EndpointID))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.BatchNumber == input.BatchNumber ||
                    (this.BatchNumber != null &&
                    this.BatchNumber.Equals(input.BatchNumber))
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
                if (this.EndpointID != null)
                    hashCode = hashCode * 59 + this.EndpointID.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BatchNumber != null)
                    hashCode = hashCode * 59 + this.BatchNumber.GetHashCode();
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
