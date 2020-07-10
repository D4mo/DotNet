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
    /// Request to create a new payment schedule using a referenced order ID.
    /// </summary>
    [DataContract]
    public partial class ReferencedOrderPaymentSchedulesRequest : PaymentSchedulesRequest,  IEquatable<ReferencedOrderPaymentSchedulesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedOrderPaymentSchedulesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReferencedOrderPaymentSchedulesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedOrderPaymentSchedulesRequest" /> class.
        /// </summary>
        /// <param name="referencedOrderId">Order ID used to create recurring payment from existing transaction. (required).</param>
        public ReferencedOrderPaymentSchedulesRequest(string referencedOrderId = default(string), string requestType = default(string), string storeId = default(string), DateTime startDate = default(DateTime), int numberOfPayments = default(int), int maximumFailures = default(int), string invoiceNumber = default(string), string purchaseOrderNumber = default(string), TransactionOrigin? transactionOrigin = default(TransactionOrigin?), string dynamicMerchantName = default(string), Frequency frequency = default(Frequency), Amount transactionAmount = default(Amount), ClientLocale clientLocale = default(ClientLocale), string orderId = default(string), Billing billing = default(Billing), Shipping shipping = default(Shipping), string comments = default(string)) : base(requestType, storeId, startDate, numberOfPayments, maximumFailures, invoiceNumber, purchaseOrderNumber, transactionOrigin, dynamicMerchantName, frequency, transactionAmount, clientLocale, orderId, billing, shipping, comments)
        {
            // to ensure "referencedOrderId" is required (not null)
            if (referencedOrderId == null)
            {
                throw new InvalidDataException("referencedOrderId is a required property for ReferencedOrderPaymentSchedulesRequest and cannot be null");
            }
            else
            {
                this.ReferencedOrderId = referencedOrderId;
            }
            
        }
        
        /// <summary>
        /// Order ID used to create recurring payment from existing transaction.
        /// </summary>
        /// <value>Order ID used to create recurring payment from existing transaction.</value>
        [DataMember(Name="referencedOrderId", EmitDefaultValue=true)]
        public string ReferencedOrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferencedOrderPaymentSchedulesRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ReferencedOrderId: ").Append(ReferencedOrderId).Append("\n");
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
            return this.Equals(input as ReferencedOrderPaymentSchedulesRequest);
        }

        /// <summary>
        /// Returns true if ReferencedOrderPaymentSchedulesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferencedOrderPaymentSchedulesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferencedOrderPaymentSchedulesRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ReferencedOrderId == input.ReferencedOrderId ||
                    (this.ReferencedOrderId != null &&
                    this.ReferencedOrderId.Equals(input.ReferencedOrderId))
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
                if (this.ReferencedOrderId != null)
                    hashCode = hashCode * 59 + this.ReferencedOrderId.GetHashCode();
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

            
            // ReferencedOrderId (string) pattern
            Regex regexReferencedOrderId = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexReferencedOrderId.Match(this.ReferencedOrderId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferencedOrderId, must match a pattern of " + regexReferencedOrderId, new [] { "ReferencedOrderId" });
            }

            yield break;
        }
    }

}
