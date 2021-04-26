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
    /// Additional information about the route.
    /// </summary>
    [DataContract]
    public partial class AirlineTravelRoute : IEquatable<AirlineTravelRoute>, IValidatableObject
    {
        /// <summary>
        /// Indicates whether the route is direct.
        /// </summary>
        /// <value>Indicates whether the route is direct.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StopoverTypeEnum
        {
            /// <summary>
            /// Enum DIRECT for value: DIRECT
            /// </summary>
            [EnumMember(Value = "DIRECT")]
            DIRECT = 1,

            /// <summary>
            /// Enum STOPOVER for value: STOPOVER
            /// </summary>
            [EnumMember(Value = "STOPOVER")]
            STOPOVER = 2

        }

        /// <summary>
        /// Indicates whether the route is direct.
        /// </summary>
        /// <value>Indicates whether the route is direct.</value>
        [DataMember(Name = "stopoverType", EmitDefaultValue = false)]
        public StopoverTypeEnum? StopoverType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineTravelRoute" /> class.
        /// </summary>
        /// <param name="departureDate">Date of departure..</param>
        /// <param name="origin">The IATA code for the departure airport..</param>
        /// <param name="destination">The IATA code for the destination. airport..</param>
        /// <param name="carrierCode">The IATA code for the carrier..</param>
        /// <param name="serviceClass">The airline code for the service class of the ticket..</param>
        /// <param name="stopoverType">Indicates whether the route is direct..</param>
        /// <param name="fareBasisCode">The airline fare basis code..</param>
        /// <param name="departureTax">Fee charged by a country when a person leaves the country..</param>
        /// <param name="flightNumber">The airline flight number associated with the ticket..</param>
        public AirlineTravelRoute(DateTime departureDate = default(DateTime), string origin = default(string), string destination = default(string), string carrierCode = default(string), string serviceClass = default(string), StopoverTypeEnum? stopoverType = null, string fareBasisCode = default(string), decimal departureTax = default(decimal), string flightNumber = default(string))
        {
            this.DepartureDate = departureDate;
            this.Origin = origin;
            this.Destination = destination;
            this.CarrierCode = carrierCode;
            this.ServiceClass = serviceClass;
            this.StopoverType = stopoverType;
            this.FareBasisCode = fareBasisCode;
            this.DepartureTax = departureTax;
            this.FlightNumber = flightNumber;
        }

        /// <summary>
        /// Date of departure.
        /// </summary>
        /// <value>Date of departure.</value>
        [DataMember(Name = "departureDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// The IATA code for the departure airport.
        /// </summary>
        /// <value>The IATA code for the departure airport.</value>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// The IATA code for the destination. airport.
        /// </summary>
        /// <value>The IATA code for the destination. airport.</value>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public string Destination { get; set; }

        /// <summary>
        /// The IATA code for the carrier.
        /// </summary>
        /// <value>The IATA code for the carrier.</value>
        [DataMember(Name = "carrierCode", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// The airline code for the service class of the ticket.
        /// </summary>
        /// <value>The airline code for the service class of the ticket.</value>
        [DataMember(Name = "serviceClass", EmitDefaultValue = false)]
        public string ServiceClass { get; set; }

        /// <summary>
        /// The airline fare basis code.
        /// </summary>
        /// <value>The airline fare basis code.</value>
        [DataMember(Name = "fareBasisCode", EmitDefaultValue = false)]
        public string FareBasisCode { get; set; }

        /// <summary>
        /// Fee charged by a country when a person leaves the country.
        /// </summary>
        /// <value>Fee charged by a country when a person leaves the country.</value>
        [DataMember(Name = "departureTax", EmitDefaultValue = false)]
        public decimal DepartureTax { get; set; }

        /// <summary>
        /// The airline flight number associated with the ticket.
        /// </summary>
        /// <value>The airline flight number associated with the ticket.</value>
        [DataMember(Name = "flightNumber", EmitDefaultValue = false)]
        public string FlightNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AirlineTravelRoute {\n");
            sb.Append("  DepartureDate: ").Append(DepartureDate).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  ServiceClass: ").Append(ServiceClass).Append("\n");
            sb.Append("  StopoverType: ").Append(StopoverType).Append("\n");
            sb.Append("  FareBasisCode: ").Append(FareBasisCode).Append("\n");
            sb.Append("  DepartureTax: ").Append(DepartureTax).Append("\n");
            sb.Append("  FlightNumber: ").Append(FlightNumber).Append("\n");
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
            return this.Equals(input as AirlineTravelRoute);
        }

        /// <summary>
        /// Returns true if AirlineTravelRoute instances are equal
        /// </summary>
        /// <param name="input">Instance of AirlineTravelRoute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirlineTravelRoute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DepartureDate == input.DepartureDate ||
                    (this.DepartureDate != null &&
                    this.DepartureDate.Equals(input.DepartureDate))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.ServiceClass == input.ServiceClass ||
                    (this.ServiceClass != null &&
                    this.ServiceClass.Equals(input.ServiceClass))
                ) && 
                (
                    this.StopoverType == input.StopoverType ||
                    (this.StopoverType != null &&
                    this.StopoverType.Equals(input.StopoverType))
                ) && 
                (
                    this.FareBasisCode == input.FareBasisCode ||
                    (this.FareBasisCode != null &&
                    this.FareBasisCode.Equals(input.FareBasisCode))
                ) && 
                (
                    this.DepartureTax == input.DepartureTax ||
                    (this.DepartureTax != null &&
                    this.DepartureTax.Equals(input.DepartureTax))
                ) && 
                (
                    this.FlightNumber == input.FlightNumber ||
                    (this.FlightNumber != null &&
                    this.FlightNumber.Equals(input.FlightNumber))
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
                if (this.DepartureDate != null)
                    hashCode = hashCode * 59 + this.DepartureDate.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.CarrierCode != null)
                    hashCode = hashCode * 59 + this.CarrierCode.GetHashCode();
                if (this.ServiceClass != null)
                    hashCode = hashCode * 59 + this.ServiceClass.GetHashCode();
                if (this.StopoverType != null)
                    hashCode = hashCode * 59 + this.StopoverType.GetHashCode();
                if (this.FareBasisCode != null)
                    hashCode = hashCode * 59 + this.FareBasisCode.GetHashCode();
                if (this.DepartureTax != null)
                    hashCode = hashCode * 59 + this.DepartureTax.GetHashCode();
                if (this.FlightNumber != null)
                    hashCode = hashCode * 59 + this.FlightNumber.GetHashCode();
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
            // Origin (string) maxLength
            if(this.Origin != null && this.Origin.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Origin, length must be less than 3.", new [] { "Origin" });
            }

            // Destination (string) maxLength
            if(this.Destination != null && this.Destination.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Destination, length must be less than 3.", new [] { "Destination" });
            }

            // CarrierCode (string) maxLength
            if(this.CarrierCode != null && this.CarrierCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CarrierCode, length must be less than 2.", new [] { "CarrierCode" });
            }

            // ServiceClass (string) maxLength
            if(this.ServiceClass != null && this.ServiceClass.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ServiceClass, length must be less than 1.", new [] { "ServiceClass" });
            }

            // FareBasisCode (string) maxLength
            if(this.FareBasisCode != null && this.FareBasisCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FareBasisCode, length must be less than 2.", new [] { "FareBasisCode" });
            }

            // DepartureTax (decimal) maximum
            if(this.DepartureTax > (decimal)999999999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DepartureTax, must be a value less than or equal to 999999999999.", new [] { "DepartureTax" });
            }

            // FlightNumber (string) maxLength
            if(this.FlightNumber != null && this.FlightNumber.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FlightNumber, length must be less than 10.", new [] { "FlightNumber" });
            }

            yield break;
        }
    }
}
