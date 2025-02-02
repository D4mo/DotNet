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
    /// Request to update payment token for one or more cards.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    public partial class PaymentCardPaymentTokenUpdateRequest : IEquatable<PaymentCardPaymentTokenUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPaymentTokenUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardPaymentTokenUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPaymentTokenUpdateRequest" /> class.
        /// </summary>
        /// <param name="requestType">Object name of tokenization request. (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        /// <param name="paymentTokens">List of payment tokens to be updated in the request. (required).</param>
        public PaymentCardPaymentTokenUpdateRequest(string requestType = default(string), string storeId = default(string), List<UpdatePaymentToken> paymentTokens = default(List<UpdatePaymentToken>))
        {
            // to ensure "requestType" is required (not null)
            this.RequestType = requestType ?? throw new ArgumentNullException("requestType is a required property for PaymentCardPaymentTokenUpdateRequest and cannot be null");
            // to ensure "paymentTokens" is required (not null)
            this.PaymentTokens = paymentTokens ?? throw new ArgumentNullException("paymentTokens is a required property for PaymentCardPaymentTokenUpdateRequest and cannot be null");
            this.StoreId = storeId;
        }

        /// <summary>
        /// Object name of tokenization request.
        /// </summary>
        /// <value>Object name of tokenization request.</value>
        [DataMember(Name = "requestType", EmitDefaultValue = false)]
        public string RequestType { get; set; }

        /// <summary>
        /// An optional outlet ID for clients that support multiple stores in the same app.
        /// </summary>
        /// <value>An optional outlet ID for clients that support multiple stores in the same app.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// List of payment tokens to be updated in the request.
        /// </summary>
        /// <value>List of payment tokens to be updated in the request.</value>
        [DataMember(Name = "paymentTokens", EmitDefaultValue = false)]
        public List<UpdatePaymentToken> PaymentTokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardPaymentTokenUpdateRequest {\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  PaymentTokens: ").Append(PaymentTokens).Append("\n");
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
            return this.Equals(input as PaymentCardPaymentTokenUpdateRequest);
        }

        /// <summary>
        /// Returns true if PaymentCardPaymentTokenUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardPaymentTokenUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardPaymentTokenUpdateRequest input)
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
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.PaymentTokens == input.PaymentTokens ||
                    this.PaymentTokens != null &&
                    input.PaymentTokens != null &&
                    this.PaymentTokens.SequenceEqual(input.PaymentTokens)
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.PaymentTokens != null)
                    hashCode = hashCode * 59 + this.PaymentTokens.GetHashCode();
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

            yield break;
        }
    }
}
