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
    /// Customer address fields associated with billing.
    /// </summary>
    [DataContract]
    public partial class BillingAddress : IEquatable<BillingAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress" /> class.
        /// </summary>
        /// <param name="firstName">First name..</param>
        /// <param name="lastName">Last name..</param>
        /// <param name="middleName">Middle name..</param>
        /// <param name="street">First line of street address. (required).</param>
        /// <param name="street2">Second line of street address..</param>
        /// <param name="stateProvince">State or province..</param>
        /// <param name="city">City..</param>
        /// <param name="country">Country..</param>
        /// <param name="phone">phone.</param>
        /// <param name="zipPostalCode">Postal code..</param>
        public BillingAddress(string firstName = default(string), string lastName = default(string), string middleName = default(string), string street = default(string), string street2 = default(string), string stateProvince = default(string), string city = default(string), string country = default(string), Phone phone = default(Phone), string zipPostalCode = default(string))
        {
            // to ensure "street" is required (not null)
            this.Street = street ?? throw new ArgumentNullException("street is a required property for BillingAddress and cannot be null");
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Street2 = street2;
            this.StateProvince = stateProvince;
            this.City = city;
            this.Country = country;
            this.Phone = phone;
            this.ZipPostalCode = zipPostalCode;
        }

        /// <summary>
        /// First name.
        /// </summary>
        /// <value>First name.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        /// <value>Last name.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Middle name.
        /// </summary>
        /// <value>Middle name.</value>
        [DataMember(Name = "middleName", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// First line of street address.
        /// </summary>
        /// <value>First line of street address.</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// Second line of street address.
        /// </summary>
        /// <value>Second line of street address.</value>
        [DataMember(Name = "street2", EmitDefaultValue = false)]
        public string Street2 { get; set; }

        /// <summary>
        /// State or province.
        /// </summary>
        /// <value>State or province.</value>
        [DataMember(Name = "stateProvince", EmitDefaultValue = false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        /// <value>City.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        /// <value>Country.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public Phone Phone { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        /// <value>Postal code.</value>
        [DataMember(Name = "zipPostalCode", EmitDefaultValue = false)]
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingAddress {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  ZipPostalCode: ").Append(ZipPostalCode).Append("\n");
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
            return this.Equals(input as BillingAddress);
        }

        /// <summary>
        /// Returns true if BillingAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Street2 == input.Street2 ||
                    (this.Street2 != null &&
                    this.Street2.Equals(input.Street2))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.ZipPostalCode == input.ZipPostalCode ||
                    (this.ZipPostalCode != null &&
                    this.ZipPostalCode.Equals(input.ZipPostalCode))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Street2 != null)
                    hashCode = hashCode * 59 + this.Street2.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.ZipPostalCode != null)
                    hashCode = hashCode * 59 + this.ZipPostalCode.GetHashCode();
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
            // Street (string) pattern
            Regex regexStreet = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexStreet.Match(this.Street).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Street, must match a pattern of " + regexStreet, new [] { "Street" });
            }

            yield break;
        }
    }
}
