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
    /// Request to create disbursement transaction using decrypted card details from payment device. The transaction origin will be fixed as PHONE when data is manually entered into the device and as RETAIL when data is entered into the device via swipe.
    /// </summary>
    [DataContract]
    public partial class PaymentDeviceDisbursementTransaction : PrimaryTransaction,  IEquatable<PaymentDeviceDisbursementTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDeviceDisbursementTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentDeviceDisbursementTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDeviceDisbursementTransaction" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="disbursement">disbursement (required).</param>
        public PaymentDeviceDisbursementTransaction(PaymentDevicePaymentMethod paymentMethod = default(PaymentDevicePaymentMethod), Disbursement disbursement = default(Disbursement), string requestType = default(string), Amount transactionAmount = default(Amount), string storeId = default(string), string merchantTransactionId = default(string), TransactionOrigin? transactionOrigin = default(TransactionOrigin?), Order order = default(Order)) : base(requestType, transactionAmount, storeId, merchantTransactionId, transactionOrigin, order)
        {
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for PaymentDeviceDisbursementTransaction and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }
            
            // to ensure "disbursement" is required (not null)
            if (disbursement == null)
            {
                throw new InvalidDataException("disbursement is a required property for PaymentDeviceDisbursementTransaction and cannot be null");
            }
            else
            {
                this.Disbursement = disbursement;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=true)]
        public PaymentDevicePaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Disbursement
        /// </summary>
        [DataMember(Name="disbursement", EmitDefaultValue=true)]
        public Disbursement Disbursement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentDeviceDisbursementTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Disbursement: ").Append(Disbursement).Append("\n");
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
            return this.Equals(input as PaymentDeviceDisbursementTransaction);
        }

        /// <summary>
        /// Returns true if PaymentDeviceDisbursementTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentDeviceDisbursementTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDeviceDisbursementTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && base.Equals(input) && 
                (
                    this.Disbursement == input.Disbursement ||
                    (this.Disbursement != null &&
                    this.Disbursement.Equals(input.Disbursement))
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
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.Disbursement != null)
                    hashCode = hashCode * 59 + this.Disbursement.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
