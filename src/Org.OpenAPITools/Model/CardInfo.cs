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
    /// Card information.
    /// </summary>
    [DataContract]
    public partial class CardInfo : IEquatable<CardInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CardFunction
        /// </summary>
        [DataMember(Name = "cardFunction", EmitDefaultValue = false)]
        public CardFunction? CardFunction { get; set; }
        /// <summary>
        /// Indicates whether it is a corporate or non-corporate card.
        /// </summary>
        /// <value>Indicates whether it is a corporate or non-corporate card.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommercialCardEnum
        {
            /// <summary>
            /// Enum CORPORATE for value: CORPORATE
            /// </summary>
            [EnumMember(Value = "CORPORATE")]
            CORPORATE = 1,

            /// <summary>
            /// Enum NONCORPORATE for value: NON_CORPORATE
            /// </summary>
            [EnumMember(Value = "NON_CORPORATE")]
            NONCORPORATE = 2

        }

        /// <summary>
        /// Indicates whether it is a corporate or non-corporate card.
        /// </summary>
        /// <value>Indicates whether it is a corporate or non-corporate card.</value>
        [DataMember(Name = "commercialCard", EmitDefaultValue = false)]
        public CommercialCardEnum? CommercialCard { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardInfo" /> class.
        /// </summary>
        /// <param name="brand">The card brand..</param>
        /// <param name="brandProductId">The product ID of the brand..</param>
        /// <param name="cardFunction">cardFunction.</param>
        /// <param name="commercialCard">Indicates whether it is a corporate or non-corporate card..</param>
        /// <param name="issuerCountry">The country of the issuer..</param>
        /// <param name="issuerName">The name of the issuer..</param>
        public CardInfo(string brand = default(string), string brandProductId = default(string), CardFunction cardFunction = default(CardFunction), CommercialCardEnum? commercialCard = null, string issuerCountry = default(string), string issuerName = default(string))
        {
            this.Brand = brand;
            this.BrandProductId = brandProductId;
            this.CardFunction = cardFunction;
            this.CommercialCard = commercialCard;
            this.IssuerCountry = issuerCountry;
            this.IssuerName = issuerName;
        }

        /// <summary>
        /// The card brand.
        /// </summary>
        /// <value>The card brand.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// The product ID of the brand.
        /// </summary>
        /// <value>The product ID of the brand.</value>
        [DataMember(Name = "brandProductId", EmitDefaultValue = false)]
        public string BrandProductId { get; set; }

        /// <summary>
        /// The country of the issuer.
        /// </summary>
        /// <value>The country of the issuer.</value>
        [DataMember(Name = "issuerCountry", EmitDefaultValue = false)]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// The name of the issuer.
        /// </summary>
        /// <value>The name of the issuer.</value>
        [DataMember(Name = "issuerName", EmitDefaultValue = false)]
        public string IssuerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardInfo {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  BrandProductId: ").Append(BrandProductId).Append("\n");
            sb.Append("  CardFunction: ").Append(CardFunction).Append("\n");
            sb.Append("  CommercialCard: ").Append(CommercialCard).Append("\n");
            sb.Append("  IssuerCountry: ").Append(IssuerCountry).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
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
            return this.Equals(input as CardInfo);
        }

        /// <summary>
        /// Returns true if CardInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CardInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.BrandProductId == input.BrandProductId ||
                    (this.BrandProductId != null &&
                    this.BrandProductId.Equals(input.BrandProductId))
                ) && 
                (
                    this.CardFunction == input.CardFunction ||
                    (this.CardFunction != null &&
                    this.CardFunction.Equals(input.CardFunction))
                ) && 
                (
                    this.CommercialCard == input.CommercialCard ||
                    (this.CommercialCard != null &&
                    this.CommercialCard.Equals(input.CommercialCard))
                ) && 
                (
                    this.IssuerCountry == input.IssuerCountry ||
                    (this.IssuerCountry != null &&
                    this.IssuerCountry.Equals(input.IssuerCountry))
                ) && 
                (
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))
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
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.BrandProductId != null)
                    hashCode = hashCode * 59 + this.BrandProductId.GetHashCode();
                if (this.CardFunction != null)
                    hashCode = hashCode * 59 + this.CardFunction.GetHashCode();
                if (this.CommercialCard != null)
                    hashCode = hashCode * 59 + this.CommercialCard.GetHashCode();
                if (this.IssuerCountry != null)
                    hashCode = hashCode * 59 + this.IssuerCountry.GetHashCode();
                if (this.IssuerName != null)
                    hashCode = hashCode * 59 + this.IssuerName.GetHashCode();
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
