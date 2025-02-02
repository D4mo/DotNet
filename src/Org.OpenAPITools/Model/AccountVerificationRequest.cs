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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request to verify payment card or payment token. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    [JsonSubtypes.KnownSubType(typeof(PaymentCardVerificationRequest), "PaymentCardVerificationRequest")]
    [JsonSubtypes.KnownSubType(typeof(PaymentTokenVerificationRequest), "PaymentTokenVerificationRequest")]
    public partial class AccountVerificationRequest : IEquatable<AccountVerificationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountVerificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountVerificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountVerificationRequest" /> class.
        /// </summary>
        /// <param name="requestType">Object name of the account verification request. (required).</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="additionalDetails">additionalDetails.</param>
        public AccountVerificationRequest(string requestType = default(string), Address billingAddress = default(Address), string storeId = default(string), string merchantTransactionId = default(string), AdditionalDetails additionalDetails = default(AdditionalDetails))
        {
            // to ensure "requestType" is required (not null)
            this.RequestType = requestType ?? throw new ArgumentNullException("requestType is a required property for AccountVerificationRequest and cannot be null");
            this.BillingAddress = billingAddress;
            this.StoreId = storeId;
            this.MerchantTransactionId = merchantTransactionId;
            this.AdditionalDetails = additionalDetails;
        }

        /// <summary>
        /// Object name of the account verification request.
        /// </summary>
        /// <value>Object name of the account verification request.</value>
        [DataMember(Name = "requestType", EmitDefaultValue = false)]
        public string RequestType { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// An optional outlet ID for clients that support multiple stores in the same app.
        /// </summary>
        /// <value>An optional outlet ID for clients that support multiple stores in the same app.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// The unique merchant transaction ID from the request, if supplied.
        /// </summary>
        /// <value>The unique merchant transaction ID from the request, if supplied.</value>
        [DataMember(Name = "merchantTransactionId", EmitDefaultValue = false)]
        public string MerchantTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalDetails
        /// </summary>
        [DataMember(Name = "additionalDetails", EmitDefaultValue = false)]
        public AdditionalDetails AdditionalDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountVerificationRequest {\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  MerchantTransactionId: ").Append(MerchantTransactionId).Append("\n");
            sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
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
            return this.Equals(input as AccountVerificationRequest);
        }

        /// <summary>
        /// Returns true if AccountVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountVerificationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestType == input.RequestType ||
                    (this.RequestType != null &&
                    this.RequestType.Equals(input.RequestType))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.MerchantTransactionId == input.MerchantTransactionId ||
                    (this.MerchantTransactionId != null &&
                    this.MerchantTransactionId.Equals(input.MerchantTransactionId))
                ) && 
                (
                    this.AdditionalDetails == input.AdditionalDetails ||
                    (this.AdditionalDetails != null &&
                    this.AdditionalDetails.Equals(input.AdditionalDetails))
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
                if (this.RequestType != null)
                    hashCode = hashCode * 59 + this.RequestType.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.MerchantTransactionId != null)
                    hashCode = hashCode * 59 + this.MerchantTransactionId.GetHashCode();
                if (this.AdditionalDetails != null)
                    hashCode = hashCode * 59 + this.AdditionalDetails.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            // StoreId (string) maxLength
            if(this.StoreId != null && this.StoreId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreId, length must be less than 20.", new [] { "StoreId" });
            }

            // MerchantTransactionId (string) maxLength
            if(this.MerchantTransactionId != null && this.MerchantTransactionId.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantTransactionId, length must be less than 40.", new [] { "MerchantTransactionId" });
            }

            yield break;
        }
    }
}
