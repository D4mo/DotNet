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
    /// Information from the payment device including the blob data and its mode of entry.
    /// </summary>
    [DataContract]
    public partial class PaymentDevice : IEquatable<PaymentDevice>, IValidatableObject
    {
        /// <summary>
        /// The data format.
        /// </summary>
        /// <value>The data format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            /// <summary>
            /// Enum SWIPE for value: SWIPE
            /// </summary>
            [EnumMember(Value = "SWIPE")]
            SWIPE = 1

        }

        /// <summary>
        /// The data format.
        /// </summary>
        /// <value>The data format.</value>
        [DataMember(Name = "deviceType", EmitDefaultValue = false)]
        public DeviceTypeEnum DeviceType { get; set; }
        /// <summary>
        /// Gets or Sets CardFunction
        /// </summary>
        [DataMember(Name = "cardFunction", EmitDefaultValue = false)]
        public CardFunction? CardFunction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDevice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentDevice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDevice" /> class.
        /// </summary>
        /// <param name="deviceType">The data format. (required).</param>
        /// <param name="data">Data from device containing, at a minimum, a transaction-unique key serial number (KSN) and track 2 card data. (required).</param>
        /// <param name="securityCode">Card verification value/number..</param>
        /// <param name="cardholderName">Name of cardholder..</param>
        /// <param name="cardFunction">cardFunction.</param>
        /// <param name="brand">The card brand..</param>
        public PaymentDevice(DeviceTypeEnum deviceType = default(DeviceTypeEnum), string data = default(string), string securityCode = default(string), string cardholderName = default(string), CardFunction? cardFunction = null, string brand = default(string))
        {
            this.DeviceType = deviceType;
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for PaymentDevice and cannot be null");
            this.SecurityCode = securityCode;
            this.CardholderName = cardholderName;
            this.CardFunction = cardFunction;
            this.Brand = brand;
        }

        /// <summary>
        /// Data from device containing, at a minimum, a transaction-unique key serial number (KSN) and track 2 card data.
        /// </summary>
        /// <value>Data from device containing, at a minimum, a transaction-unique key serial number (KSN) and track 2 card data.</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Card verification value/number.
        /// </summary>
        /// <value>Card verification value/number.</value>
        [DataMember(Name = "securityCode", EmitDefaultValue = false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Name of cardholder.
        /// </summary>
        /// <value>Name of cardholder.</value>
        [DataMember(Name = "cardholderName", EmitDefaultValue = false)]
        public string CardholderName { get; set; }

        /// <summary>
        /// The card brand.
        /// </summary>
        /// <value>The card brand.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentDevice {\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            sb.Append("  CardFunction: ").Append(CardFunction).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return this.Equals(input as PaymentDevice);
        }

        /// <summary>
        /// Returns true if PaymentDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDevice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceType == input.DeviceType ||
                    this.DeviceType.Equals(input.DeviceType)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.SecurityCode == input.SecurityCode ||
                    (this.SecurityCode != null &&
                    this.SecurityCode.Equals(input.SecurityCode))
                ) && 
                (
                    this.CardholderName == input.CardholderName ||
                    (this.CardholderName != null &&
                    this.CardholderName.Equals(input.CardholderName))
                ) && 
                (
                    this.CardFunction == input.CardFunction ||
                    this.CardFunction.Equals(input.CardFunction)
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
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
                hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.SecurityCode != null)
                    hashCode = hashCode * 59 + this.SecurityCode.GetHashCode();
                if (this.CardholderName != null)
                    hashCode = hashCode * 59 + this.CardholderName.GetHashCode();
                hashCode = hashCode * 59 + this.CardFunction.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
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
            // Data (string) pattern
            Regex regexData = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexData.Match(this.Data).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, must match a pattern of " + regexData, new [] { "Data" });
            }

            // SecurityCode (string) maxLength
            if(this.SecurityCode != null && this.SecurityCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCode, length must be less than 4.", new [] { "SecurityCode" });
            }

            // SecurityCode (string) minLength
            if(this.SecurityCode != null && this.SecurityCode.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCode, length must be greater than 3.", new [] { "SecurityCode" });
            }

            yield break;
        }
    }
}
