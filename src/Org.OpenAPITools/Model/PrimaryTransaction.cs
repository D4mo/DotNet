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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Provides shared fields for all PrimaryTransaction request types. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    [JsonSubtypes.KnownSubType(typeof(PaymentCardForcedTicketTransaction), "PaymentCardForcedTicketTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentCardPayerAuthTransaction), "PaymentCardPayerAuthTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaypalCreditTransaction), "PaypalCreditTransaction")]
    [JsonSubtypes.KnownSubType(typeof(ApmSaleTransaction), "ApmSaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(ChinaPnRSaleTransaction), "ChinaPnRSaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(AliPaySaleTransaction), "AliPaySaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(SepaSaleTransaction), "SepaSaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(WalletSaleTransaction), "WalletSaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(WalletPreAuthTransaction), "WalletPreAuthTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentTokenCreditTransaction), "PaymentTokenCreditTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentTokenPreAuthTransaction), "PaymentTokenPreAuthTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentTokenSaleTransaction), "PaymentTokenSaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentCardPreAuthTransaction), "PaymentCardPreAuthTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentCardSaleTransaction), "PaymentCardSaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentCardCreditTransaction), "PaymentCardCreditTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentCardDisbursementTransaction), "PaymentCardDisbursementTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentTokenDisbursementTransaction), "PaymentTokenDisbursementTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentDevicePreAuthTransaction), "PaymentDevicePreAuthTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentDeviceSaleTransaction), "PaymentDeviceSaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentDeviceCreditTransaction), "PaymentDeviceCreditTransaction")]
    [JsonSubtypes.KnownSubType(typeof(PaymentDeviceDisbursementTransaction), "PaymentDeviceDisbursementTransaction")]
    [JsonSubtypes.KnownSubType(typeof(AchPreAuthTransaction), "AchPreAuthTransaction")]
    [JsonSubtypes.KnownSubType(typeof(AchSaleTransaction), "AchSaleTransaction")]
    [JsonSubtypes.KnownSubType(typeof(AchCreditTransaction), "AchCreditTransaction")]
    public partial class PrimaryTransaction : IEquatable<PrimaryTransaction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TransactionOrigin
        /// </summary>
        [DataMember(Name = "transactionOrigin", EmitDefaultValue = false)]
        public TransactionOrigin? TransactionOrigin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrimaryTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimaryTransaction" /> class.
        /// </summary>
        /// <param name="requestType">Object name of the primary transaction request. (required).</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request header, if supplied..</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="order">order.</param>
        public PrimaryTransaction(string requestType = default(string), Amount transactionAmount = default(Amount), string storeId = default(string), string merchantTransactionId = default(string), TransactionOrigin transactionOrigin = default(TransactionOrigin), Order order = default(Order))
        {
            // to ensure "requestType" is required (not null)
            this.RequestType = requestType ?? throw new ArgumentNullException("requestType is a required property for PrimaryTransaction and cannot be null");
            // to ensure "transactionAmount" is required (not null)
            this.TransactionAmount = transactionAmount ?? throw new ArgumentNullException("transactionAmount is a required property for PrimaryTransaction and cannot be null");
            this.StoreId = storeId;
            this.MerchantTransactionId = merchantTransactionId;
            this.TransactionOrigin = transactionOrigin;
            this.Order = order;
        }

        /// <summary>
        /// Object name of the primary transaction request.
        /// </summary>
        /// <value>Object name of the primary transaction request.</value>
        [DataMember(Name = "requestType", EmitDefaultValue = false)]
        public string RequestType { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transactionAmount", EmitDefaultValue = false)]
        public Amount TransactionAmount { get; set; }

        /// <summary>
        /// An optional outlet ID for clients that support multiple stores in the same app.
        /// </summary>
        /// <value>An optional outlet ID for clients that support multiple stores in the same app.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// The unique merchant transaction ID from the request header, if supplied.
        /// </summary>
        /// <value>The unique merchant transaction ID from the request header, if supplied.</value>
        [DataMember(Name = "merchantTransactionId", EmitDefaultValue = false)]
        public string MerchantTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public Order Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrimaryTransaction {\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  MerchantTransactionId: ").Append(MerchantTransactionId).Append("\n");
            sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as PrimaryTransaction);
        }

        /// <summary>
        /// Returns true if PrimaryTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of PrimaryTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrimaryTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestType == input.RequestType ||
                    (this.RequestType != null &&
                    this.RequestType.Equals(input.RequestType))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.MerchantTransactionId == input.MerchantTransactionId ||
                    (this.MerchantTransactionId != null &&
                    this.MerchantTransactionId.Equals(input.MerchantTransactionId))
                ) && 
                (
                    this.TransactionOrigin == input.TransactionOrigin ||
                    (this.TransactionOrigin != null &&
                    this.TransactionOrigin.Equals(input.TransactionOrigin))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.RequestType != null)
                    hashCode = hashCode * 59 + this.RequestType.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.MerchantTransactionId != null)
                    hashCode = hashCode * 59 + this.MerchantTransactionId.GetHashCode();
                if (this.TransactionOrigin != null)
                    hashCode = hashCode * 59 + this.TransactionOrigin.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            // StoreId (string) maxLength
            if(this.StoreId != null && this.StoreId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreId, length must be less than 20.", new [] { "StoreId" });
            }

            // MerchantTransactionId (string) maxLength
            if(this.MerchantTransactionId != null && this.MerchantTransactionId.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantTransactionId, length must be less than 40.", new [] { "MerchantTransactionId" });
            }

            yield break;
        }
    }
}
