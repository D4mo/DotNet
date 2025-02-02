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
    /// AirlineAncillaryServiceCategory
    /// </summary>
    [DataContract]
    public partial class AirlineAncillaryServiceCategory : IEquatable<AirlineAncillaryServiceCategory>, IValidatableObject
    {
        /// <summary>
        /// Identifies the service purchased in the transaction if not a base ticket
        /// </summary>
        /// <value>Identifies the service purchased in the transaction if not a base ticket</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceCategoryEnum
        {
            /// <summary>
            /// Enum BUNDLEDSERVICE for value: BUNDLED_SERVICE
            /// </summary>
            [EnumMember(Value = "BUNDLED_SERVICE")]
            BUNDLEDSERVICE = 1,

            /// <summary>
            /// Enum BAGGAGEFEE for value: BAGGAGE_FEE
            /// </summary>
            [EnumMember(Value = "BAGGAGE_FEE")]
            BAGGAGEFEE = 2,

            /// <summary>
            /// Enum CHANGEFEE for value: CHANGE_FEE
            /// </summary>
            [EnumMember(Value = "CHANGE_FEE")]
            CHANGEFEE = 3,

            /// <summary>
            /// Enum CARGO for value: CARGO
            /// </summary>
            [EnumMember(Value = "CARGO")]
            CARGO = 4,

            /// <summary>
            /// Enum CARBONOFFSET for value: CARBON_OFFSET
            /// </summary>
            [EnumMember(Value = "CARBON_OFFSET")]
            CARBONOFFSET = 5,

            /// <summary>
            /// Enum FREQUENTFLYER for value: FREQUENT_FLYER
            /// </summary>
            [EnumMember(Value = "FREQUENT_FLYER")]
            FREQUENTFLYER = 6,

            /// <summary>
            /// Enum GIFTCARD for value: GIFT_CARD
            /// </summary>
            [EnumMember(Value = "GIFT_CARD")]
            GIFTCARD = 7,

            /// <summary>
            /// Enum GROUNDTRANSPORT for value: GROUND_TRANSPORT
            /// </summary>
            [EnumMember(Value = "GROUND_TRANSPORT")]
            GROUNDTRANSPORT = 8,

            /// <summary>
            /// Enum INFLIGHTENTERTAINMENT for value: IN_FLIGHT_ENTERTAINMENT
            /// </summary>
            [EnumMember(Value = "IN_FLIGHT_ENTERTAINMENT")]
            INFLIGHTENTERTAINMENT = 9,

            /// <summary>
            /// Enum LOUNGE for value: LOUNGE
            /// </summary>
            [EnumMember(Value = "LOUNGE")]
            LOUNGE = 10,

            /// <summary>
            /// Enum MEDICAL for value: MEDICAL
            /// </summary>
            [EnumMember(Value = "MEDICAL")]
            MEDICAL = 11,

            /// <summary>
            /// Enum MEALBEVERAGE for value: MEAL_BEVERAGE
            /// </summary>
            [EnumMember(Value = "MEAL_BEVERAGE")]
            MEALBEVERAGE = 12,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 13,

            /// <summary>
            /// Enum PASSENGERASSISTFEE for value: PASSENGER_ASSIST_FEE
            /// </summary>
            [EnumMember(Value = "PASSENGER_ASSIST_FEE")]
            PASSENGERASSISTFEE = 14,

            /// <summary>
            /// Enum PETS for value: PETS
            /// </summary>
            [EnumMember(Value = "PETS")]
            PETS = 15,

            /// <summary>
            /// Enum SEATFEES for value: SEAT_FEES
            /// </summary>
            [EnumMember(Value = "SEAT_FEES")]
            SEATFEES = 16,

            /// <summary>
            /// Enum STANDBY for value: STANDBY
            /// </summary>
            [EnumMember(Value = "STANDBY")]
            STANDBY = 17,

            /// <summary>
            /// Enum SERVICEFEE for value: SERVICE_FEE
            /// </summary>
            [EnumMember(Value = "SERVICE_FEE")]
            SERVICEFEE = 18,

            /// <summary>
            /// Enum STORE for value: STORE
            /// </summary>
            [EnumMember(Value = "STORE")]
            STORE = 19,

            /// <summary>
            /// Enum TRAVELSERVICE for value: TRAVEL_SERVICE
            /// </summary>
            [EnumMember(Value = "TRAVEL_SERVICE")]
            TRAVELSERVICE = 20,

            /// <summary>
            /// Enum UNACCOMPANIEDTRAVEL for value: UNACCOMPANIED_TRAVEL
            /// </summary>
            [EnumMember(Value = "UNACCOMPANIED_TRAVEL")]
            UNACCOMPANIEDTRAVEL = 21,

            /// <summary>
            /// Enum UPGRADES for value: UPGRADES
            /// </summary>
            [EnumMember(Value = "UPGRADES")]
            UPGRADES = 22,

            /// <summary>
            /// Enum WIFI for value: WI_FI
            /// </summary>
            [EnumMember(Value = "WI_FI")]
            WIFI = 23

        }

        /// <summary>
        /// Identifies the service purchased in the transaction if not a base ticket
        /// </summary>
        /// <value>Identifies the service purchased in the transaction if not a base ticket</value>
        [DataMember(Name = "serviceCategory", EmitDefaultValue = false)]
        public ServiceCategoryEnum ServiceCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineAncillaryServiceCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AirlineAncillaryServiceCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineAncillaryServiceCategory" /> class.
        /// </summary>
        /// <param name="serviceCategory">Identifies the service purchased in the transaction if not a base ticket (required).</param>
        public AirlineAncillaryServiceCategory(ServiceCategoryEnum serviceCategory = default(ServiceCategoryEnum))
        {
            // to ensure "serviceCategory" is required (not null)
            this.ServiceCategory = serviceCategory;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AirlineAncillaryServiceCategory {\n");
            sb.Append("  ServiceCategory: ").Append(ServiceCategory).Append("\n");
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
            return this.Equals(input as AirlineAncillaryServiceCategory);
        }

        /// <summary>
        /// Returns true if AirlineAncillaryServiceCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of AirlineAncillaryServiceCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirlineAncillaryServiceCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceCategory == input.ServiceCategory ||
                    (this.ServiceCategory != null &&
                    this.ServiceCategory.Equals(input.ServiceCategory))
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
                if (this.ServiceCategory != null)
                    hashCode = hashCode * 59 + this.ServiceCategory.GetHashCode();
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
