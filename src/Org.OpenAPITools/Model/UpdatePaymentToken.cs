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
    /// Use this model to Update payment token.
    /// </summary>
    [DataContract]
    public partial class UpdatePaymentToken : IEquatable<UpdatePaymentToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePaymentToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePaymentToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePaymentToken" /> class.
        /// </summary>
        /// <param name="value">Client-supplied payment token value. (required).</param>
        /// <param name="reusable">If the token is reusable. (default to true).</param>
        /// <param name="declineDuplicates">Decline duplicate payment info if client token is supplied. (default to false).</param>
        /// <param name="paymentCard">paymentCard (required).</param>
        public UpdatePaymentToken(string value = default(string), bool reusable = true, bool declineDuplicates = false, PaymentCard paymentCard = default(PaymentCard))
        {
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for UpdatePaymentToken and cannot be null");
            // to ensure "paymentCard" is required (not null)
            this.PaymentCard = paymentCard ?? throw new ArgumentNullException("paymentCard is a required property for UpdatePaymentToken and cannot be null");
            // use default value if no "reusable" provided
            this.Reusable = reusable;
            // use default value if no "declineDuplicates" provided
            this.DeclineDuplicates = declineDuplicates;
        }

        /// <summary>
        /// Client-supplied payment token value.
        /// </summary>
        /// <value>Client-supplied payment token value.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// If the token is reusable.
        /// </summary>
        /// <value>If the token is reusable.</value>
        [DataMember(Name = "reusable", EmitDefaultValue = false)]
        public bool Reusable { get; set; }

        /// <summary>
        /// Decline duplicate payment info if client token is supplied.
        /// </summary>
        /// <value>Decline duplicate payment info if client token is supplied.</value>
        [DataMember(Name = "declineDuplicates", EmitDefaultValue = false)]
        public bool DeclineDuplicates { get; set; }

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
            sb.Append("class UpdatePaymentToken {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Reusable: ").Append(Reusable).Append("\n");
            sb.Append("  DeclineDuplicates: ").Append(DeclineDuplicates).Append("\n");
            sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
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
            return this.Equals(input as UpdatePaymentToken);
        }

        /// <summary>
        /// Returns true if UpdatePaymentToken instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePaymentToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePaymentToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Reusable == input.Reusable ||
                    (this.Reusable != null &&
                    this.Reusable.Equals(input.Reusable))
                ) && 
                (
                    this.DeclineDuplicates == input.DeclineDuplicates ||
                    (this.DeclineDuplicates != null &&
                    this.DeclineDuplicates.Equals(input.DeclineDuplicates))
                ) && 
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
                int hashCode = 41;
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Reusable != null)
                    hashCode = hashCode * 59 + this.Reusable.GetHashCode();
                if (this.DeclineDuplicates != null)
                    hashCode = hashCode * 59 + this.DeclineDuplicates.GetHashCode();
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
            yield break;
        }
    }
}
