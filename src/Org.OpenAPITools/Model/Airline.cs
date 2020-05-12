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
    /// Additional data specific to the airline industry.
    /// </summary>
    [DataContract]
    public partial class Airline :  IEquatable<Airline>, IValidatableObject
    {
        /// <summary>
        /// The reservation system used to create the ticket.
        /// </summary>
        /// <value>The reservation system used to create the ticket.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReservationSystemEnum
        {
            /// <summary>
            /// Enum START for value: START
            /// </summary>
            [EnumMember(Value = "START")]
            START = 1,

            /// <summary>
            /// Enum TWA for value: TWA
            /// </summary>
            [EnumMember(Value = "TWA")]
            TWA = 2,

            /// <summary>
            /// Enum DELTA for value: DELTA
            /// </summary>
            [EnumMember(Value = "DELTA")]
            DELTA = 3,

            /// <summary>
            /// Enum SABRE for value: SABRE
            /// </summary>
            [EnumMember(Value = "SABRE")]
            SABRE = 4,

            /// <summary>
            /// Enum COVIAAPOLLO for value: COVIA_APOLLO
            /// </summary>
            [EnumMember(Value = "COVIA_APOLLO")]
            COVIAAPOLLO = 5,

            /// <summary>
            /// Enum DRBLANK for value: DR_BLANK
            /// </summary>
            [EnumMember(Value = "DR_BLANK")]
            DRBLANK = 6,

            /// <summary>
            /// Enum DER for value: DER
            /// </summary>
            [EnumMember(Value = "DER")]
            DER = 7,

            /// <summary>
            /// Enum TUI for value: TUI
            /// </summary>
            [EnumMember(Value = "TUI")]
            TUI = 8

        }

        /// <summary>
        /// The reservation system used to create the ticket.
        /// </summary>
        /// <value>The reservation system used to create the ticket.</value>
        [DataMember(Name="reservationSystem", EmitDefaultValue=false)]
        public ReservationSystemEnum? ReservationSystem { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Airline" /> class.
        /// </summary>
        /// <param name="passengerName">The passenger name associated with the transaction..</param>
        /// <param name="ticketNumber">The airline ticket number associated with the transaction..</param>
        /// <param name="issuingCarrier">The carrier that issued the ticket..</param>
        /// <param name="carrierName">The carrier associated with the transaction..</param>
        /// <param name="travelAgencyIataCode">The IATA code associated with the travel agency..</param>
        /// <param name="travelAgencyName">The business name of the travel agency..</param>
        /// <param name="airlinePlanNumber">The airline plan number associated with the transaction..</param>
        /// <param name="airlineInvoiceNumber">The invoice number used by the airline..</param>
        /// <param name="reservationSystem">The reservation system used to create the ticket..</param>
        /// <param name="restricted">If the transaction is associated with a restricted class fare..</param>
        /// <param name="travelRoute">Array containing up to 4 items that describe the route associated with the transaction..</param>
        /// <param name="relatedTicketNumber">The number of any other tickets associated with the transaction ticket..</param>
        /// <param name="ancillaryServiceCategory">Identify the purchase of ancillary goods or services with a false value. If this element is not provided, the transaction is assumed to be a purchase of an airline ticket..</param>
        /// <param name="ticketPurchase">Identifies if the transaction is a ticket purchase..</param>
        public Airline(string passengerName = default(string), string ticketNumber = default(string), string issuingCarrier = default(string), string carrierName = default(string), string travelAgencyIataCode = default(string), string travelAgencyName = default(string), string airlinePlanNumber = default(string), string airlineInvoiceNumber = default(string), ReservationSystemEnum? reservationSystem = default(ReservationSystemEnum?), bool restricted = default(bool), List<AirlineTravelRoute> travelRoute = default(List<AirlineTravelRoute>), string relatedTicketNumber = default(string), List<AirlineAncillaryServiceCategory> ancillaryServiceCategory = default(List<AirlineAncillaryServiceCategory>), bool ticketPurchase = default(bool))
        {
            this.PassengerName = passengerName;
            this.TicketNumber = ticketNumber;
            this.IssuingCarrier = issuingCarrier;
            this.CarrierName = carrierName;
            this.TravelAgencyIataCode = travelAgencyIataCode;
            this.TravelAgencyName = travelAgencyName;
            this.AirlinePlanNumber = airlinePlanNumber;
            this.AirlineInvoiceNumber = airlineInvoiceNumber;
            this.ReservationSystem = reservationSystem;
            this.Restricted = restricted;
            this.TravelRoute = travelRoute;
            this.RelatedTicketNumber = relatedTicketNumber;
            this.AncillaryServiceCategory = ancillaryServiceCategory;
            this.TicketPurchase = ticketPurchase;
        }
        
        /// <summary>
        /// The passenger name associated with the transaction.
        /// </summary>
        /// <value>The passenger name associated with the transaction.</value>
        [DataMember(Name="passengerName", EmitDefaultValue=false)]
        public string PassengerName { get; set; }

        /// <summary>
        /// The airline ticket number associated with the transaction.
        /// </summary>
        /// <value>The airline ticket number associated with the transaction.</value>
        [DataMember(Name="ticketNumber", EmitDefaultValue=false)]
        public string TicketNumber { get; set; }

        /// <summary>
        /// The carrier that issued the ticket.
        /// </summary>
        /// <value>The carrier that issued the ticket.</value>
        [DataMember(Name="issuingCarrier", EmitDefaultValue=false)]
        public string IssuingCarrier { get; set; }

        /// <summary>
        /// The carrier associated with the transaction.
        /// </summary>
        /// <value>The carrier associated with the transaction.</value>
        [DataMember(Name="carrierName", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// The IATA code associated with the travel agency.
        /// </summary>
        /// <value>The IATA code associated with the travel agency.</value>
        [DataMember(Name="travelAgencyIataCode", EmitDefaultValue=false)]
        public string TravelAgencyIataCode { get; set; }

        /// <summary>
        /// The business name of the travel agency.
        /// </summary>
        /// <value>The business name of the travel agency.</value>
        [DataMember(Name="travelAgencyName", EmitDefaultValue=false)]
        public string TravelAgencyName { get; set; }

        /// <summary>
        /// The airline plan number associated with the transaction.
        /// </summary>
        /// <value>The airline plan number associated with the transaction.</value>
        [DataMember(Name="airlinePlanNumber", EmitDefaultValue=false)]
        public string AirlinePlanNumber { get; set; }

        /// <summary>
        /// The invoice number used by the airline.
        /// </summary>
        /// <value>The invoice number used by the airline.</value>
        [DataMember(Name="airlineInvoiceNumber", EmitDefaultValue=false)]
        public string AirlineInvoiceNumber { get; set; }

        /// <summary>
        /// If the transaction is associated with a restricted class fare.
        /// </summary>
        /// <value>If the transaction is associated with a restricted class fare.</value>
        [DataMember(Name="restricted", EmitDefaultValue=false)]
        public bool? Restricted { get; set; }

        /// <summary>
        /// Array containing up to 4 items that describe the route associated with the transaction.
        /// </summary>
        /// <value>Array containing up to 4 items that describe the route associated with the transaction.</value>
        [DataMember(Name="travelRoute", EmitDefaultValue=false)]
        public List<AirlineTravelRoute> TravelRoute { get; set; }

        /// <summary>
        /// The number of any other tickets associated with the transaction ticket.
        /// </summary>
        /// <value>The number of any other tickets associated with the transaction ticket.</value>
        [DataMember(Name="relatedTicketNumber", EmitDefaultValue=false)]
        public string RelatedTicketNumber { get; set; }

        /// <summary>
        /// Identify the purchase of ancillary goods or services with a false value. If this element is not provided, the transaction is assumed to be a purchase of an airline ticket.
        /// </summary>
        /// <value>Identify the purchase of ancillary goods or services with a false value. If this element is not provided, the transaction is assumed to be a purchase of an airline ticket.</value>
        [DataMember(Name="ancillaryServiceCategory", EmitDefaultValue=false)]
        public List<AirlineAncillaryServiceCategory> AncillaryServiceCategory { get; set; }

        /// <summary>
        /// Identifies if the transaction is a ticket purchase.
        /// </summary>
        /// <value>Identifies if the transaction is a ticket purchase.</value>
        [DataMember(Name="ticketPurchase", EmitDefaultValue=false)]
        public bool? TicketPurchase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Airline {\n");
            sb.Append("  PassengerName: ").Append(PassengerName).Append("\n");
            sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
            sb.Append("  IssuingCarrier: ").Append(IssuingCarrier).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  TravelAgencyIataCode: ").Append(TravelAgencyIataCode).Append("\n");
            sb.Append("  TravelAgencyName: ").Append(TravelAgencyName).Append("\n");
            sb.Append("  AirlinePlanNumber: ").Append(AirlinePlanNumber).Append("\n");
            sb.Append("  AirlineInvoiceNumber: ").Append(AirlineInvoiceNumber).Append("\n");
            sb.Append("  ReservationSystem: ").Append(ReservationSystem).Append("\n");
            sb.Append("  Restricted: ").Append(Restricted).Append("\n");
            sb.Append("  TravelRoute: ").Append(TravelRoute).Append("\n");
            sb.Append("  RelatedTicketNumber: ").Append(RelatedTicketNumber).Append("\n");
            sb.Append("  AncillaryServiceCategory: ").Append(AncillaryServiceCategory).Append("\n");
            sb.Append("  TicketPurchase: ").Append(TicketPurchase).Append("\n");
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
            return this.Equals(input as Airline);
        }

        /// <summary>
        /// Returns true if Airline instances are equal
        /// </summary>
        /// <param name="input">Instance of Airline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Airline input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PassengerName == input.PassengerName ||
                    (this.PassengerName != null &&
                    this.PassengerName.Equals(input.PassengerName))
                ) && 
                (
                    this.TicketNumber == input.TicketNumber ||
                    (this.TicketNumber != null &&
                    this.TicketNumber.Equals(input.TicketNumber))
                ) && 
                (
                    this.IssuingCarrier == input.IssuingCarrier ||
                    (this.IssuingCarrier != null &&
                    this.IssuingCarrier.Equals(input.IssuingCarrier))
                ) && 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.TravelAgencyIataCode == input.TravelAgencyIataCode ||
                    (this.TravelAgencyIataCode != null &&
                    this.TravelAgencyIataCode.Equals(input.TravelAgencyIataCode))
                ) && 
                (
                    this.TravelAgencyName == input.TravelAgencyName ||
                    (this.TravelAgencyName != null &&
                    this.TravelAgencyName.Equals(input.TravelAgencyName))
                ) && 
                (
                    this.AirlinePlanNumber == input.AirlinePlanNumber ||
                    (this.AirlinePlanNumber != null &&
                    this.AirlinePlanNumber.Equals(input.AirlinePlanNumber))
                ) && 
                (
                    this.AirlineInvoiceNumber == input.AirlineInvoiceNumber ||
                    (this.AirlineInvoiceNumber != null &&
                    this.AirlineInvoiceNumber.Equals(input.AirlineInvoiceNumber))
                ) && 
                (
                    this.ReservationSystem == input.ReservationSystem ||
                    this.ReservationSystem.Equals(input.ReservationSystem)
                ) && 
                (
                    this.Restricted == input.Restricted ||
                    this.Restricted.Equals(input.Restricted)
                ) && 
                (
                    this.TravelRoute == input.TravelRoute ||
                    this.TravelRoute != null &&
                    input.TravelRoute != null &&
                    this.TravelRoute.SequenceEqual(input.TravelRoute)
                ) && 
                (
                    this.RelatedTicketNumber == input.RelatedTicketNumber ||
                    (this.RelatedTicketNumber != null &&
                    this.RelatedTicketNumber.Equals(input.RelatedTicketNumber))
                ) && 
                (
                    this.AncillaryServiceCategory == input.AncillaryServiceCategory ||
                    this.AncillaryServiceCategory != null &&
                    input.AncillaryServiceCategory != null &&
                    this.AncillaryServiceCategory.SequenceEqual(input.AncillaryServiceCategory)
                ) && 
                (
                    this.TicketPurchase == input.TicketPurchase ||
                    this.TicketPurchase.Equals(input.TicketPurchase)
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
                if (this.PassengerName != null)
                    hashCode = hashCode * 59 + this.PassengerName.GetHashCode();
                if (this.TicketNumber != null)
                    hashCode = hashCode * 59 + this.TicketNumber.GetHashCode();
                if (this.IssuingCarrier != null)
                    hashCode = hashCode * 59 + this.IssuingCarrier.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.TravelAgencyIataCode != null)
                    hashCode = hashCode * 59 + this.TravelAgencyIataCode.GetHashCode();
                if (this.TravelAgencyName != null)
                    hashCode = hashCode * 59 + this.TravelAgencyName.GetHashCode();
                if (this.AirlinePlanNumber != null)
                    hashCode = hashCode * 59 + this.AirlinePlanNumber.GetHashCode();
                if (this.AirlineInvoiceNumber != null)
                    hashCode = hashCode * 59 + this.AirlineInvoiceNumber.GetHashCode();
                hashCode = hashCode * 59 + this.ReservationSystem.GetHashCode();
                hashCode = hashCode * 59 + this.Restricted.GetHashCode();
                if (this.TravelRoute != null)
                    hashCode = hashCode * 59 + this.TravelRoute.GetHashCode();
                if (this.RelatedTicketNumber != null)
                    hashCode = hashCode * 59 + this.RelatedTicketNumber.GetHashCode();
                if (this.AncillaryServiceCategory != null)
                    hashCode = hashCode * 59 + this.AncillaryServiceCategory.GetHashCode();
                hashCode = hashCode * 59 + this.TicketPurchase.GetHashCode();
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
            // PassengerName (string) maxLength
            if(this.PassengerName != null && this.PassengerName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PassengerName, length must be less than 30.", new [] { "PassengerName" });
            }

            // TicketNumber (string) maxLength
            if(this.TicketNumber != null && this.TicketNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TicketNumber, length must be less than 20.", new [] { "TicketNumber" });
            }

            // IssuingCarrier (string) maxLength
            if(this.IssuingCarrier != null && this.IssuingCarrier.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuingCarrier, length must be less than 20.", new [] { "IssuingCarrier" });
            }

            // CarrierName (string) maxLength
            if(this.CarrierName != null && this.CarrierName.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CarrierName, length must be less than 20.", new [] { "CarrierName" });
            }

            // TravelAgencyIataCode (string) maxLength
            if(this.TravelAgencyIataCode != null && this.TravelAgencyIataCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TravelAgencyIataCode, length must be less than 20.", new [] { "TravelAgencyIataCode" });
            }

            // TravelAgencyName (string) maxLength
            if(this.TravelAgencyName != null && this.TravelAgencyName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TravelAgencyName, length must be less than 30.", new [] { "TravelAgencyName" });
            }

            // AirlinePlanNumber (string) maxLength
            if(this.AirlinePlanNumber != null && this.AirlinePlanNumber.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirlinePlanNumber, length must be less than 2.", new [] { "AirlinePlanNumber" });
            }

            // AirlineInvoiceNumber (string) maxLength
            if(this.AirlineInvoiceNumber != null && this.AirlineInvoiceNumber.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirlineInvoiceNumber, length must be less than 6.", new [] { "AirlineInvoiceNumber" });
            }

            // RelatedTicketNumber (string) maxLength
            if(this.RelatedTicketNumber != null && this.RelatedTicketNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RelatedTicketNumber, length must be less than 20.", new [] { "RelatedTicketNumber" });
            }

            yield break;
        }
    }

}
