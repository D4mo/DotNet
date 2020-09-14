/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.13.0.20200810.001
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
    /// Used to request account verification using a payment card. The expiryDate in paymentCard object is required to perform a PaymentCardVerificationRequest.
    /// </summary>
    [DataContract]
    public partial class PaymentCardVerificationRequest : AccountVerificationRequest, IEquatable<PaymentCardVerificationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardVerificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardVerificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardVerificationRequest" /> class.
        /// </summary>
        /// <param name="paymentCard">paymentCard (required).</param>
        /// <param name="requestType">Object name of the account verification request. (required).</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="additionalDetails">additionalDetails.</param>
        public PaymentCardVerificationRequest(PaymentCard paymentCard = default(PaymentCard), string requestType = default(string), Address billingAddress = default(Address), string storeId = default(string), string merchantTransactionId = default(string), AdditionalDetails additionalDetails = default(AdditionalDetails)) : base(requestType, billingAddress, storeId, merchantTransactionId, additionalDetails)
        {
            // to ensure "paymentCard" is required (not null)
            this.PaymentCard = paymentCard ?? throw new ArgumentNullException("paymentCard is a required property for PaymentCardVerificationRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PaymentCard
        /// </summary>
        [DataMember(Name = "paymentCard", EmitDefaultValue = false)]
        public PaymentCard PaymentCard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardVerificationRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as PaymentCardVerificationRequest);
        }

        /// <summary>
        /// Returns true if PaymentCardVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardVerificationRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PaymentCard == input.PaymentCard ||
                    (this.PaymentCard != null &&
                    this.PaymentCard.Equals(input.PaymentCard))
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
                int hashCode = base.GetHashCode();
                if (this.PaymentCard != null)
                    hashCode = hashCode * 59 + this.PaymentCard.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
