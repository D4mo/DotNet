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
    /// A JSON object that holds info about the payment registration card.
    /// </summary>
    [DataContract]
    public partial class FraudRegistrationCard : IEquatable<FraudRegistrationCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudRegistrationCard" /> class.
        /// </summary>
        /// <param name="cardholderName">The cardholder name as it appears on the card..</param>
        /// <param name="cardNumber">Use this field to send clear PAN or tokens other than TransArmor Token..</param>
        /// <param name="expDate">Payment method expiration date. Format is MMYYYY..</param>
        /// <param name="cvvPresent">CVV present indicator..</param>
        /// <param name="issuer">The company (usually a bank) that issued the card..</param>
        /// <param name="cardReissuedNumber">A number that distinguishes between two plastic cards with the same card number in the event of the card being re-issued..</param>
        public FraudRegistrationCard(string cardholderName = default(string), string cardNumber = default(string), string expDate = default(string), string cvvPresent = default(string), string issuer = default(string), string cardReissuedNumber = default(string))
        {
            this.CardholderName = cardholderName;
            this.CardNumber = cardNumber;
            this.ExpDate = expDate;
            this.CvvPresent = cvvPresent;
            this.Issuer = issuer;
            this.CardReissuedNumber = cardReissuedNumber;
        }

        /// <summary>
        /// The cardholder name as it appears on the card.
        /// </summary>
        /// <value>The cardholder name as it appears on the card.</value>
        [DataMember(Name = "cardholderName", EmitDefaultValue = false)]
        public string CardholderName { get; set; }

        /// <summary>
        /// Use this field to send clear PAN or tokens other than TransArmor Token.
        /// </summary>
        /// <value>Use this field to send clear PAN or tokens other than TransArmor Token.</value>
        [DataMember(Name = "cardNumber", EmitDefaultValue = false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Payment method expiration date. Format is MMYYYY.
        /// </summary>
        /// <value>Payment method expiration date. Format is MMYYYY.</value>
        [DataMember(Name = "expDate", EmitDefaultValue = false)]
        public string ExpDate { get; set; }

        /// <summary>
        /// CVV present indicator.
        /// </summary>
        /// <value>CVV present indicator.</value>
        [DataMember(Name = "cvvPresent", EmitDefaultValue = false)]
        public string CvvPresent { get; set; }

        /// <summary>
        /// The company (usually a bank) that issued the card.
        /// </summary>
        /// <value>The company (usually a bank) that issued the card.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// A number that distinguishes between two plastic cards with the same card number in the event of the card being re-issued.
        /// </summary>
        /// <value>A number that distinguishes between two plastic cards with the same card number in the event of the card being re-issued.</value>
        [DataMember(Name = "cardReissuedNumber", EmitDefaultValue = false)]
        public string CardReissuedNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudRegistrationCard {\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  ExpDate: ").Append(ExpDate).Append("\n");
            sb.Append("  CvvPresent: ").Append(CvvPresent).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  CardReissuedNumber: ").Append(CardReissuedNumber).Append("\n");
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
            return this.Equals(input as FraudRegistrationCard);
        }

        /// <summary>
        /// Returns true if FraudRegistrationCard instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudRegistrationCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudRegistrationCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardholderName == input.CardholderName ||
                    (this.CardholderName != null &&
                    this.CardholderName.Equals(input.CardholderName))
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.ExpDate == input.ExpDate ||
                    (this.ExpDate != null &&
                    this.ExpDate.Equals(input.ExpDate))
                ) && 
                (
                    this.CvvPresent == input.CvvPresent ||
                    (this.CvvPresent != null &&
                    this.CvvPresent.Equals(input.CvvPresent))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.CardReissuedNumber == input.CardReissuedNumber ||
                    (this.CardReissuedNumber != null &&
                    this.CardReissuedNumber.Equals(input.CardReissuedNumber))
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
                if (this.CardholderName != null)
                    hashCode = hashCode * 59 + this.CardholderName.GetHashCode();
                if (this.CardNumber != null)
                    hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.ExpDate != null)
                    hashCode = hashCode * 59 + this.ExpDate.GetHashCode();
                if (this.CvvPresent != null)
                    hashCode = hashCode * 59 + this.CvvPresent.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.CardReissuedNumber != null)
                    hashCode = hashCode * 59 + this.CardReissuedNumber.GetHashCode();
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
