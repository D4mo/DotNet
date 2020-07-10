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
    /// Request to create sale transaction using payment token.
    /// </summary>
    [DataContract]
    public partial class PaymentTokenSaleTransaction : PrimaryTransaction,  IEquatable<PaymentTokenSaleTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenSaleTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTokenSaleTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTokenSaleTransaction" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="storedCredentials">storedCredentials.</param>
        /// <param name="settlementSplit">Settle with multiple sub-merchants, sale and preAuth only..</param>
        /// <param name="currencyConversion">currencyConversion.</param>
        /// <param name="authenticationRequest">authenticationRequest.</param>
        /// <param name="authenticationResult">authenticationResult.</param>
        public PaymentTokenSaleTransaction(PaymentTokenPaymentMethod paymentMethod = default(PaymentTokenPaymentMethod), StoredCredential storedCredentials = default(StoredCredential), List<SubMerchantSplit> settlementSplit = default(List<SubMerchantSplit>), CurrencyConversion currencyConversion = default(CurrencyConversion), AuthenticationRequest authenticationRequest = default(AuthenticationRequest), AuthenticationResult authenticationResult = default(AuthenticationResult), string requestType = default(string), Amount transactionAmount = default(Amount), string storeId = default(string), string merchantTransactionId = default(string), TransactionOrigin? transactionOrigin = default(TransactionOrigin?), Order order = default(Order)) : base(requestType, transactionAmount, storeId, merchantTransactionId, transactionOrigin, order)
        {
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for PaymentTokenSaleTransaction and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }
            
            this.StoredCredentials = storedCredentials;
            this.SettlementSplit = settlementSplit;
            this.CurrencyConversion = currencyConversion;
            this.AuthenticationRequest = authenticationRequest;
            this.AuthenticationResult = authenticationResult;
        }
        
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=true)]
        public PaymentTokenPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets StoredCredentials
        /// </summary>
        [DataMember(Name="storedCredentials", EmitDefaultValue=false)]
        public StoredCredential StoredCredentials { get; set; }

        /// <summary>
        /// Settle with multiple sub-merchants, sale and preAuth only.
        /// </summary>
        /// <value>Settle with multiple sub-merchants, sale and preAuth only.</value>
        [DataMember(Name="settlementSplit", EmitDefaultValue=false)]
        public List<SubMerchantSplit> SettlementSplit { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyConversion
        /// </summary>
        [DataMember(Name="currencyConversion", EmitDefaultValue=false)]
        public CurrencyConversion CurrencyConversion { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationRequest
        /// </summary>
        [DataMember(Name="authenticationRequest", EmitDefaultValue=false)]
        public AuthenticationRequest AuthenticationRequest { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationResult
        /// </summary>
        [DataMember(Name="authenticationResult", EmitDefaultValue=false)]
        public AuthenticationResult AuthenticationResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentTokenSaleTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
            sb.Append("  SettlementSplit: ").Append(SettlementSplit).Append("\n");
            sb.Append("  CurrencyConversion: ").Append(CurrencyConversion).Append("\n");
            sb.Append("  AuthenticationRequest: ").Append(AuthenticationRequest).Append("\n");
            sb.Append("  AuthenticationResult: ").Append(AuthenticationResult).Append("\n");
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
            return this.Equals(input as PaymentTokenSaleTransaction);
        }

        /// <summary>
        /// Returns true if PaymentTokenSaleTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentTokenSaleTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentTokenSaleTransaction input)
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
                    this.StoredCredentials == input.StoredCredentials ||
                    (this.StoredCredentials != null &&
                    this.StoredCredentials.Equals(input.StoredCredentials))
                ) && base.Equals(input) && 
                (
                    this.SettlementSplit == input.SettlementSplit ||
                    this.SettlementSplit != null &&
                    input.SettlementSplit != null &&
                    this.SettlementSplit.SequenceEqual(input.SettlementSplit)
                ) && base.Equals(input) && 
                (
                    this.CurrencyConversion == input.CurrencyConversion ||
                    (this.CurrencyConversion != null &&
                    this.CurrencyConversion.Equals(input.CurrencyConversion))
                ) && base.Equals(input) && 
                (
                    this.AuthenticationRequest == input.AuthenticationRequest ||
                    (this.AuthenticationRequest != null &&
                    this.AuthenticationRequest.Equals(input.AuthenticationRequest))
                ) && base.Equals(input) && 
                (
                    this.AuthenticationResult == input.AuthenticationResult ||
                    (this.AuthenticationResult != null &&
                    this.AuthenticationResult.Equals(input.AuthenticationResult))
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
                if (this.StoredCredentials != null)
                    hashCode = hashCode * 59 + this.StoredCredentials.GetHashCode();
                if (this.SettlementSplit != null)
                    hashCode = hashCode * 59 + this.SettlementSplit.GetHashCode();
                if (this.CurrencyConversion != null)
                    hashCode = hashCode * 59 + this.CurrencyConversion.GetHashCode();
                if (this.AuthenticationRequest != null)
                    hashCode = hashCode * 59 + this.AuthenticationRequest.GetHashCode();
                if (this.AuthenticationResult != null)
                    hashCode = hashCode * 59 + this.AuthenticationResult.GetHashCode();
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
