/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.1.0.20210122.001
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
    /// Request to create a new payment schedule using a payment method.
    /// </summary>
    [DataContract]
    public partial class PaymentMethodPaymentSchedulesRequest : PaymentSchedulesRequest, IEquatable<PaymentMethodPaymentSchedulesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPaymentSchedulesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodPaymentSchedulesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPaymentSchedulesRequest" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="requestType">Object name of the payment schedules request. (required).</param>
        /// <param name="storeId">Store ID number..</param>
        /// <param name="startDate">Date of mandate signature. (required).</param>
        /// <param name="numberOfPayments">Number of times the recurring payment will process..</param>
        /// <param name="maximumFailures">Number of failures that can be encountered before re-tries cease..</param>
        /// <param name="invoiceNumber">Invoice number..</param>
        /// <param name="purchaseOrderNumber">Purchase order number..</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="dynamicMerchantName">Dynamic merchant name for the cardholder&#39;s statement..</param>
        /// <param name="frequency">frequency (required).</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="clientLocale">clientLocale.</param>
        /// <param name="orderId">Client order ID if supplied by client..</param>
        /// <param name="billing">billing.</param>
        /// <param name="shipping">shipping.</param>
        /// <param name="comments">User supplied comments..</param>
        public PaymentMethodPaymentSchedulesRequest(PaymentCardPaymentMethod paymentMethod = default(PaymentCardPaymentMethod), string requestType = default(string), string storeId = default(string), DateTime startDate = default(DateTime), int numberOfPayments = default(int), int maximumFailures = default(int), string invoiceNumber = default(string), string purchaseOrderNumber = default(string), TransactionOrigin transactionOrigin = default(TransactionOrigin), string dynamicMerchantName = default(string), Frequency frequency = default(Frequency), Amount transactionAmount = default(Amount), ClientLocale clientLocale = default(ClientLocale), string orderId = default(string), Billing billing = default(Billing), Shipping shipping = default(Shipping), string comments = default(string)) : base(requestType, storeId, startDate, numberOfPayments, maximumFailures, invoiceNumber, purchaseOrderNumber, transactionOrigin, dynamicMerchantName, frequency, transactionAmount, clientLocale, orderId, billing, shipping, comments)
        {
            // to ensure "paymentMethod" is required (not null)
            this.PaymentMethod = paymentMethod ?? throw new ArgumentNullException("paymentMethod is a required property for PaymentMethodPaymentSchedulesRequest and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public PaymentCardPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodPaymentSchedulesRequest {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
            return this.Equals(input as PaymentMethodPaymentSchedulesRequest);
        }

        /// <summary>
        /// Returns true if PaymentMethodPaymentSchedulesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodPaymentSchedulesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodPaymentSchedulesRequest input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
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
