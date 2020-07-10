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
    /// Used to request card information associated with a payment token.
    /// </summary>
    [DataContract]
    public partial class PaymentTokenInfoLookupRequest : AccountInfoLookupRequest,  IEquatable<PaymentTokenInfoLookupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenInfoLookupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTokenInfoLookupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenInfoLookupRequest" /> class.
        /// </summary>
        /// <param name="paymentToken">paymentToken (required).</param>
        public PaymentTokenInfoLookupRequest(UsePaymentToken paymentToken = default(UsePaymentToken), string requestType = default(string), string storeId = default(string)) : base(requestType, storeId)
        {
            // to ensure "paymentToken" is required (not null)
            if (paymentToken == null)
            {
                throw new InvalidDataException("paymentToken is a required property for PaymentTokenInfoLookupRequest and cannot be null");
            }
            else
            {
                this.PaymentToken = paymentToken;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets PaymentToken
        /// </summary>
        [DataMember(Name="paymentToken", EmitDefaultValue=true)]
        public UsePaymentToken PaymentToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTokenInfoLookupRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
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
            return this.Equals(input as PaymentTokenInfoLookupRequest);
        }

        /// <summary>
        /// Returns true if PaymentTokenInfoLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenInfoLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenInfoLookupRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PaymentToken == input.PaymentToken ||
                    (this.PaymentToken != null &&
                    this.PaymentToken.Equals(input.PaymentToken))
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
                if (this.PaymentToken != null)
                    hashCode = hashCode * 59 + this.PaymentToken.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
