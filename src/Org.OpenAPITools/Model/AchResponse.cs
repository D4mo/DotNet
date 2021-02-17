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
    /// ACH TeleCheck response.
    /// </summary>
    [DataContract]
    public partial class AchResponse : IEquatable<AchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AchResponse" /> class.
        /// </summary>
        /// <param name="responseCode">Response code for TeleCheck authentication decision in the sale response message..</param>
        /// <param name="approvalCode">Code provided if check is approved..</param>
        /// <param name="referenceNumber">Reference number..</param>
        /// <param name="preferredFlag">Preferred flag..</param>
        /// <param name="transactionStatus">Indicates the result of the requested authorization and is returned in the sale response..</param>
        public AchResponse(string responseCode = default(string), string approvalCode = default(string), string referenceNumber = default(string), string preferredFlag = default(string), string transactionStatus = default(string))
        {
            this.ResponseCode = responseCode;
            this.ApprovalCode = approvalCode;
            this.ReferenceNumber = referenceNumber;
            this.PreferredFlag = preferredFlag;
            this.TransactionStatus = transactionStatus;
        }

        /// <summary>
        /// Response code for TeleCheck authentication decision in the sale response message.
        /// </summary>
        /// <value>Response code for TeleCheck authentication decision in the sale response message.</value>
        [DataMember(Name = "responseCode", EmitDefaultValue = false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Code provided if check is approved.
        /// </summary>
        /// <value>Code provided if check is approved.</value>
        [DataMember(Name = "approvalCode", EmitDefaultValue = false)]
        public string ApprovalCode { get; set; }

        /// <summary>
        /// Reference number.
        /// </summary>
        /// <value>Reference number.</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Preferred flag.
        /// </summary>
        /// <value>Preferred flag.</value>
        [DataMember(Name = "preferredFlag", EmitDefaultValue = false)]
        public string PreferredFlag { get; set; }

        /// <summary>
        /// Indicates the result of the requested authorization and is returned in the sale response.
        /// </summary>
        /// <value>Indicates the result of the requested authorization and is returned in the sale response.</value>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public string TransactionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchResponse {\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  ApprovalCode: ").Append(ApprovalCode).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  PreferredFlag: ").Append(PreferredFlag).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
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
            return this.Equals(input as AchResponse);
        }

        /// <summary>
        /// Returns true if AchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseCode == input.ResponseCode ||
                    (this.ResponseCode != null &&
                    this.ResponseCode.Equals(input.ResponseCode))
                ) && 
                (
                    this.ApprovalCode == input.ApprovalCode ||
                    (this.ApprovalCode != null &&
                    this.ApprovalCode.Equals(input.ApprovalCode))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.PreferredFlag == input.PreferredFlag ||
                    (this.PreferredFlag != null &&
                    this.PreferredFlag.Equals(input.PreferredFlag))
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
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
                if (this.ResponseCode != null)
                    hashCode = hashCode * 59 + this.ResponseCode.GetHashCode();
                if (this.ApprovalCode != null)
                    hashCode = hashCode * 59 + this.ApprovalCode.GetHashCode();
                if (this.ReferenceNumber != null)
                    hashCode = hashCode * 59 + this.ReferenceNumber.GetHashCode();
                if (this.PreferredFlag != null)
                    hashCode = hashCode * 59 + this.PreferredFlag.GetHashCode();
                if (this.TransactionStatus != null)
                    hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
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
            // ResponseCode (string) maxLength
            if(this.ResponseCode != null && this.ResponseCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseCode, length must be less than 2.", new [] { "ResponseCode" });
            }

            // ApprovalCode (string) maxLength
            if(this.ApprovalCode != null && this.ApprovalCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApprovalCode, length must be less than 4.", new [] { "ApprovalCode" });
            }
            yield break;
        }
    }
}
