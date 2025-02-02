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
    /// Used to generate payment tokens during payment using a payment device.
    /// </summary>
    [DataContract]
    public partial class PaymentDevicePaymentTokenizationRequest : PaymentTokenizationRequest, IEquatable<PaymentDevicePaymentTokenizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDevicePaymentTokenizationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentDevicePaymentTokenizationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDevicePaymentTokenizationRequest" /> class.
        /// </summary>
        /// <param name="paymentDevice">paymentDevice (required).</param>
        /// <param name="requestType">Object name of tokenization request. (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="createToken">createToken (required).</param>
        /// <param name="accountVerification">If the account should be verified prior to token creation. (default to false).</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="additionalDetails">additionalDetails.</param>
        public PaymentDevicePaymentTokenizationRequest(PaymentDevice paymentDevice = default(PaymentDevice), string requestType = default(string), string storeId = default(string), Address billingAddress = default(Address), CreatePaymentToken createToken = default(CreatePaymentToken), bool accountVerification = false, string merchantTransactionId = default(string), AdditionalDetails additionalDetails = default(AdditionalDetails)) : base(requestType, storeId, billingAddress, createToken, accountVerification, merchantTransactionId, additionalDetails)
        {
            // to ensure "paymentDevice" is required (not null)
            this.PaymentDevice = paymentDevice ?? throw new ArgumentNullException("paymentDevice is a required property for PaymentDevicePaymentTokenizationRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PaymentDevice
        /// </summary>
        [DataMember(Name = "paymentDevice", EmitDefaultValue = false)]
        public PaymentDevice PaymentDevice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentDevicePaymentTokenizationRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentDevice: ").Append(PaymentDevice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as PaymentDevicePaymentTokenizationRequest);
        }

        /// <summary>
        /// Returns true if PaymentDevicePaymentTokenizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentDevicePaymentTokenizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDevicePaymentTokenizationRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PaymentDevice == input.PaymentDevice ||
                    (this.PaymentDevice != null &&
                    this.PaymentDevice.Equals(input.PaymentDevice))
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
                int hashCode = base.GetHashCode();
                if (this.PaymentDevice != null)
                    hashCode = hashCode * 59 + this.PaymentDevice.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
