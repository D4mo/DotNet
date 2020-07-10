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
    /// Industry-specific information.
    /// </summary>
    [DataContract]
    public partial class IndustrySpecificExtensions :  IEquatable<IndustrySpecificExtensions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndustrySpecificExtensions" /> class.
        /// </summary>
        /// <param name="airline">airline.</param>
        /// <param name="lodging">lodging.</param>
        /// <param name="carRental">carRental.</param>
        /// <param name="mcc6012">mcc6012.</param>
        public IndustrySpecificExtensions(Airline airline = default(Airline), Lodging lodging = default(Lodging), CarRental carRental = default(CarRental), Mcc6012 mcc6012 = default(Mcc6012))
        {
            this.Airline = airline;
            this.Lodging = lodging;
            this.CarRental = carRental;
            this.Mcc6012 = mcc6012;
        }
        
        /// <summary>
        /// Gets or Sets Airline
        /// </summary>
        [DataMember(Name="airline", EmitDefaultValue=false)]
        public Airline Airline { get; set; }

        /// <summary>
        /// Gets or Sets Lodging
        /// </summary>
        [DataMember(Name="lodging", EmitDefaultValue=false)]
        public Lodging Lodging { get; set; }

        /// <summary>
        /// Gets or Sets CarRental
        /// </summary>
        [DataMember(Name="carRental", EmitDefaultValue=false)]
        public CarRental CarRental { get; set; }

        /// <summary>
        /// Gets or Sets Mcc6012
        /// </summary>
        [DataMember(Name="mcc6012", EmitDefaultValue=false)]
        public Mcc6012 Mcc6012 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndustrySpecificExtensions {\n");
            sb.Append("  Airline: ").Append(Airline).Append("\n");
            sb.Append("  Lodging: ").Append(Lodging).Append("\n");
            sb.Append("  CarRental: ").Append(CarRental).Append("\n");
            sb.Append("  Mcc6012: ").Append(Mcc6012).Append("\n");
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
            return this.Equals(input as IndustrySpecificExtensions);
        }

        /// <summary>
        /// Returns true if IndustrySpecificExtensions instances are equal
        /// </summary>
        /// <param name="input">Instance of IndustrySpecificExtensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndustrySpecificExtensions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Airline == input.Airline ||
                    (this.Airline != null &&
                    this.Airline.Equals(input.Airline))
                ) && 
                (
                    this.Lodging == input.Lodging ||
                    (this.Lodging != null &&
                    this.Lodging.Equals(input.Lodging))
                ) && 
                (
                    this.CarRental == input.CarRental ||
                    (this.CarRental != null &&
                    this.CarRental.Equals(input.CarRental))
                ) && 
                (
                    this.Mcc6012 == input.Mcc6012 ||
                    (this.Mcc6012 != null &&
                    this.Mcc6012.Equals(input.Mcc6012))
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
                if (this.Airline != null)
                    hashCode = hashCode * 59 + this.Airline.GetHashCode();
                if (this.Lodging != null)
                    hashCode = hashCode * 59 + this.Lodging.GetHashCode();
                if (this.CarRental != null)
                    hashCode = hashCode * 59 + this.CarRental.GetHashCode();
                if (this.Mcc6012 != null)
                    hashCode = hashCode * 59 + this.Mcc6012.GetHashCode();
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
