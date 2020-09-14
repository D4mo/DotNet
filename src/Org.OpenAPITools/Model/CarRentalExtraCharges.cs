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
    /// CarRentalExtraCharges
    /// </summary>
    [DataContract]
    public partial class CarRentalExtraCharges : IEquatable<CarRentalExtraCharges>, IValidatableObject
    {
        /// <summary>
        /// Additional charge item.
        /// </summary>
        /// <value>Additional charge item.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChargeItemEnum
        {
            /// <summary>
            /// Enum EXTRAMILEAGE for value: EXTRA_MILEAGE
            /// </summary>
            [EnumMember(Value = "EXTRA_MILEAGE")]
            EXTRAMILEAGE = 1,

            /// <summary>
            /// Enum GAS for value: GAS
            /// </summary>
            [EnumMember(Value = "GAS")]
            GAS = 2,

            /// <summary>
            /// Enum LATERETURN for value: LATE_RETURN
            /// </summary>
            [EnumMember(Value = "LATE_RETURN")]
            LATERETURN = 3,

            /// <summary>
            /// Enum ONEWAYSERVICEFEE for value: ONE_WAY_SERVICE_FEE
            /// </summary>
            [EnumMember(Value = "ONE_WAY_SERVICE_FEE")]
            ONEWAYSERVICEFEE = 4,

            /// <summary>
            /// Enum PARKINGVIOLATION for value: PARKING_VIOLATION
            /// </summary>
            [EnumMember(Value = "PARKING_VIOLATION")]
            PARKINGVIOLATION = 5

        }

        /// <summary>
        /// Additional charge item.
        /// </summary>
        /// <value>Additional charge item.</value>
        [DataMember(Name = "chargeItem", EmitDefaultValue = false)]
        public ChargeItemEnum? ChargeItem { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CarRentalExtraCharges" /> class.
        /// </summary>
        /// <param name="chargeItem">Additional charge item..</param>
        public CarRentalExtraCharges(ChargeItemEnum? chargeItem = null)
        {
            this.ChargeItem = chargeItem;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarRentalExtraCharges {\n");
            sb.Append("  ChargeItem: ").Append(ChargeItem).Append("\n");
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
            return this.Equals(input as CarRentalExtraCharges);
        }

        /// <summary>
        /// Returns true if CarRentalExtraCharges instances are equal
        /// </summary>
        /// <param name="input">Instance of CarRentalExtraCharges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarRentalExtraCharges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChargeItem == input.ChargeItem ||
                    this.ChargeItem.Equals(input.ChargeItem)
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
                hashCode = hashCode * 59 + this.ChargeItem.GetHashCode();
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
