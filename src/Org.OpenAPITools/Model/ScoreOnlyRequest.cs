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
    /// Fraud detect request payload.
    /// </summary>
    [DataContract]
    public partial class ScoreOnlyRequest : IEquatable<ScoreOnlyRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of the original transaction that is being evaluated for the Fraud Score.
        /// </summary>
        /// <value>Defines the type of the original transaction that is being evaluated for the Fraud Score.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OriginalTransactionTypeEnum
        {
            /// <summary>
            /// Enum Authorization for value: transaction/authorization
            /// </summary>
            [EnumMember(Value = "transaction/authorization")]
            Authorization = 1,

            /// <summary>
            /// Enum AuthorizationReversal for value: transaction/authorization-reversal
            /// </summary>
            [EnumMember(Value = "transaction/authorization-reversal")]
            AuthorizationReversal = 2,

            /// <summary>
            /// Enum Deposit for value: transaction/deposit
            /// </summary>
            [EnumMember(Value = "transaction/deposit")]
            Deposit = 3,

            /// <summary>
            /// Enum DepositReversal for value: transaction/deposit-reversal
            /// </summary>
            [EnumMember(Value = "transaction/deposit-reversal")]
            DepositReversal = 4,

            /// <summary>
            /// Enum Purchase for value: transaction/purchase
            /// </summary>
            [EnumMember(Value = "transaction/purchase")]
            Purchase = 5,

            /// <summary>
            /// Enum PurchaseReversal for value: transaction/purchase-reversal
            /// </summary>
            [EnumMember(Value = "transaction/purchase-reversal")]
            PurchaseReversal = 6,

            /// <summary>
            /// Enum RefundAuthorization for value: transaction/refund-authorization
            /// </summary>
            [EnumMember(Value = "transaction/refund-authorization")]
            RefundAuthorization = 7,

            /// <summary>
            /// Enum RefundDeposit for value: transaction/refund-deposit
            /// </summary>
            [EnumMember(Value = "transaction/refund-deposit")]
            RefundDeposit = 8,

            /// <summary>
            /// Enum Verification for value: transaction/verification
            /// </summary>
            [EnumMember(Value = "transaction/verification")]
            Verification = 9,

            /// <summary>
            /// Enum BalanceInquiry for value: transaction/balance-inquiry
            /// </summary>
            [EnumMember(Value = "transaction/balance-inquiry")]
            BalanceInquiry = 10

        }

        /// <summary>
        /// Defines the type of the original transaction that is being evaluated for the Fraud Score.
        /// </summary>
        /// <value>Defines the type of the original transaction that is being evaluated for the Fraud Score.</value>
        [DataMember(Name = "originalTransactionType", EmitDefaultValue = false)]
        public OriginalTransactionTypeEnum OriginalTransactionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreOnlyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScoreOnlyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreOnlyRequest" /> class.
        /// </summary>
        /// <param name="merchantRef">Merchant reference code. Used by FirstAPI and reflected in settlement records and Webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction..</param>
        /// <param name="transactionType">Type of transaction merchant wants to process. (required).</param>
        /// <param name="originalTransactionType">Defines the type of the original transaction that is being evaluated for the Fraud Score. (required).</param>
        /// <param name="originalTransactionId">The unique ID of this transaction. Must be unique for the entire system (not just within a specific merchant or industry). Subsequent requests related to the same transaction must have the same transactionId (e.g. transaction/deposit or transaction/authorization-reversal). This field is used for matching transactions with settlement and chargeback information. If there is no such ID available you may wish to compose one from fields available in both systems. Consider including backend, issuer, merchant id, date and time, amount, etc. as necessary. (required).</param>
        /// <param name="amount">The amount processed for the original transaction. (required).</param>
        /// <param name="currencyCode">The currency of the original transaction. (required).</param>
        /// <param name="customer">customer.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="device">device.</param>
        /// <param name="loyalty">loyalty.</param>
        /// <param name="payment">payment (required).</param>
        /// <param name="merchant">merchant (required).</param>
        /// <param name="order">order.</param>
        /// <param name="userDefined">A JSON object that can carry any additional information that might be helpful for fraud detection..</param>
        public ScoreOnlyRequest(string merchantRef = default(string), string transactionType = default(string), OriginalTransactionTypeEnum originalTransactionType = default(OriginalTransactionTypeEnum), string originalTransactionId = default(string), string amount = default(string), string currencyCode = default(string), Customer customer = default(Customer), BillingAddress billingAddress = default(BillingAddress), Device device = default(Device), Loyalty loyalty = default(Loyalty), Payment payment = default(Payment), Merchant merchant = default(Merchant), FraudOrder order = default(FraudOrder), Object userDefined = default(Object))
        {
            // to ensure "transactionType" is required (not null)
            this.TransactionType = transactionType ?? throw new ArgumentNullException("transactionType is a required property for ScoreOnlyRequest and cannot be null");
            // to ensure "originalTransactionType" is required (not null)
            this.OriginalTransactionType = originalTransactionType;
            // to ensure "originalTransactionId" is required (not null)
            this.OriginalTransactionId = originalTransactionId ?? throw new ArgumentNullException("originalTransactionId is a required property for ScoreOnlyRequest and cannot be null");
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount is a required property for ScoreOnlyRequest and cannot be null");
            // to ensure "currencyCode" is required (not null)
            this.CurrencyCode = currencyCode ?? throw new ArgumentNullException("currencyCode is a required property for ScoreOnlyRequest and cannot be null");
            // to ensure "payment" is required (not null)
            this.Payment = payment ?? throw new ArgumentNullException("payment is a required property for ScoreOnlyRequest and cannot be null");
            // to ensure "merchant" is required (not null)
            this.Merchant = merchant ?? throw new ArgumentNullException("merchant is a required property for ScoreOnlyRequest and cannot be null");
            this.MerchantRef = merchantRef;
            this.Customer = customer;
            this.BillingAddress = billingAddress;
            this.Device = device;
            this.Loyalty = loyalty;
            this.Order = order;
            this.UserDefined = userDefined;
        }

        /// <summary>
        /// Merchant reference code. Used by FirstAPI and reflected in settlement records and Webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction.
        /// </summary>
        /// <value>Merchant reference code. Used by FirstAPI and reflected in settlement records and Webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction.</value>
        [DataMember(Name = "merchantRef", EmitDefaultValue = false)]
        public string MerchantRef { get; set; }

        /// <summary>
        /// Type of transaction merchant wants to process.
        /// </summary>
        /// <value>Type of transaction merchant wants to process.</value>
        [DataMember(Name = "transactionType", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// The unique ID of this transaction. Must be unique for the entire system (not just within a specific merchant or industry). Subsequent requests related to the same transaction must have the same transactionId (e.g. transaction/deposit or transaction/authorization-reversal). This field is used for matching transactions with settlement and chargeback information. If there is no such ID available you may wish to compose one from fields available in both systems. Consider including backend, issuer, merchant id, date and time, amount, etc. as necessary.
        /// </summary>
        /// <value>The unique ID of this transaction. Must be unique for the entire system (not just within a specific merchant or industry). Subsequent requests related to the same transaction must have the same transactionId (e.g. transaction/deposit or transaction/authorization-reversal). This field is used for matching transactions with settlement and chargeback information. If there is no such ID available you may wish to compose one from fields available in both systems. Consider including backend, issuer, merchant id, date and time, amount, etc. as necessary.</value>
        [DataMember(Name = "originalTransactionId", EmitDefaultValue = false)]
        public string OriginalTransactionId { get; set; }

        /// <summary>
        /// The amount processed for the original transaction.
        /// </summary>
        /// <value>The amount processed for the original transaction.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The currency of the original transaction.
        /// </summary>
        /// <value>The currency of the original transaction.</value>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public Device Device { get; set; }

        /// <summary>
        /// Gets or Sets Loyalty
        /// </summary>
        [DataMember(Name = "loyalty", EmitDefaultValue = false)]
        public Loyalty Loyalty { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        public Payment Payment { get; set; }

        /// <summary>
        /// Gets or Sets Merchant
        /// </summary>
        [DataMember(Name = "merchant", EmitDefaultValue = false)]
        public Merchant Merchant { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public FraudOrder Order { get; set; }

        /// <summary>
        /// A JSON object that can carry any additional information that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that can carry any additional information that might be helpful for fraud detection.</value>
        [DataMember(Name = "userDefined", EmitDefaultValue = false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScoreOnlyRequest {\n");
            sb.Append("  MerchantRef: ").Append(MerchantRef).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  OriginalTransactionType: ").Append(OriginalTransactionType).Append("\n");
            sb.Append("  OriginalTransactionId: ").Append(OriginalTransactionId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Loyalty: ").Append(Loyalty).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Merchant: ").Append(Merchant).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
            return this.Equals(input as ScoreOnlyRequest);
        }

        /// <summary>
        /// Returns true if ScoreOnlyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScoreOnlyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScoreOnlyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantRef == input.MerchantRef ||
                    (this.MerchantRef != null &&
                    this.MerchantRef.Equals(input.MerchantRef))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.OriginalTransactionType == input.OriginalTransactionType ||
                    (this.OriginalTransactionType != null &&
                    this.OriginalTransactionType.Equals(input.OriginalTransactionType))
                ) && 
                (
                    this.OriginalTransactionId == input.OriginalTransactionId ||
                    (this.OriginalTransactionId != null &&
                    this.OriginalTransactionId.Equals(input.OriginalTransactionId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.Loyalty == input.Loyalty ||
                    (this.Loyalty != null &&
                    this.Loyalty.Equals(input.Loyalty))
                ) && 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.Merchant == input.Merchant ||
                    (this.Merchant != null &&
                    this.Merchant.Equals(input.Merchant))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.UserDefined == input.UserDefined ||
                    (this.UserDefined != null &&
                    this.UserDefined.Equals(input.UserDefined))
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
                if (this.MerchantRef != null)
                    hashCode = hashCode * 59 + this.MerchantRef.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.OriginalTransactionType != null)
                    hashCode = hashCode * 59 + this.OriginalTransactionType.GetHashCode();
                if (this.OriginalTransactionId != null)
                    hashCode = hashCode * 59 + this.OriginalTransactionId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.Loyalty != null)
                    hashCode = hashCode * 59 + this.Loyalty.GetHashCode();
                if (this.Payment != null)
                    hashCode = hashCode * 59 + this.Payment.GetHashCode();
                if (this.Merchant != null)
                    hashCode = hashCode * 59 + this.Merchant.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.UserDefined != null)
                    hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
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
            // OriginalTransactionId (string) pattern
            Regex regexOriginalTransactionId = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexOriginalTransactionId.Match(this.OriginalTransactionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OriginalTransactionId, must match a pattern of " + regexOriginalTransactionId, new [] { "OriginalTransactionId" });
            }

            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
            }

            // CurrencyCode (string) pattern
            Regex regexCurrencyCode = new Regex(@"([A-Z]{3})|([0-9]{3})", RegexOptions.CultureInvariant);
            if (false == regexCurrencyCode.Match(this.CurrencyCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrencyCode, must match a pattern of " + regexCurrencyCode, new [] { "CurrencyCode" });
            }

            yield break;
        }
    }
}
