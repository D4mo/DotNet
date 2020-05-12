/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.10.1.20200226.002
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
    /// The payment object for SEPA Local Payment.
    /// </summary>
    [DataContract]
    public partial class Sepa :  IEquatable<Sepa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sepa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Sepa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sepa" /> class.
        /// </summary>
        /// <param name="iban">Bank account in IBAN format. (required).</param>
        /// <param name="name">The name of the payer. (required).</param>
        /// <param name="country">Country of residence of the payer using the ISO 3166 standard. (required).</param>
        /// <param name="email">The email address of the payer..</param>
        /// <param name="mandate">mandate (required).</param>
        public Sepa(string iban = default(string), string name = default(string), string country = default(string), string email = default(string), SepaMandate mandate = default(SepaMandate))
        {
            // to ensure "iban" is required (not null)
            if (iban == null)
            {
                throw new InvalidDataException("iban is a required property for Sepa and cannot be null");
            }
            else
            {
                this.Iban = iban;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Sepa and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for Sepa and cannot be null");
            }
            else
            {
                this.Country = country;
            }

            // to ensure "mandate" is required (not null)
            if (mandate == null)
            {
                throw new InvalidDataException("mandate is a required property for Sepa and cannot be null");
            }
            else
            {
                this.Mandate = mandate;
            }

            this.Email = email;
        }
        
        /// <summary>
        /// Bank account in IBAN format.
        /// </summary>
        /// <value>Bank account in IBAN format.</value>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// The name of the payer.
        /// </summary>
        /// <value>The name of the payer.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Country of residence of the payer using the ISO 3166 standard.
        /// </summary>
        /// <value>Country of residence of the payer using the ISO 3166 standard.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The email address of the payer.
        /// </summary>
        /// <value>The email address of the payer.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name="mandate", EmitDefaultValue=false)]
        public SepaMandate Mandate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sepa {\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
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
            return this.Equals(input as Sepa);
        }

        /// <summary>
        /// Returns true if Sepa instances are equal
        /// </summary>
        /// <param name="input">Instance of Sepa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sepa input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Mandate == input.Mandate ||
                    (this.Mandate != null &&
                    this.Mandate.Equals(input.Mandate))
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
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Mandate != null)
                    hashCode = hashCode * 59 + this.Mandate.GetHashCode();
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
            // Iban (string) maxLength
            if(this.Iban != null && this.Iban.Length > 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Iban, length must be less than 34.", new [] { "Iban" });
            }

            // Iban (string) pattern
            Regex regexIban = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexIban.Match(this.Iban).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Iban, must match a pattern of " + regexIban, new [] { "Iban" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 96)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 96.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 3.", new [] { "Country" });
            }

            // Country (string) pattern
            Regex regexCountry = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new [] { "Country" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 254)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 254.", new [] { "Email" });
            }

            yield break;
        }
    }

}
