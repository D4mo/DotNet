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
    /// Model for processor data.
    /// </summary>
    [DataContract]
    public partial class ProcessorData : IEquatable<ProcessorData>, IValidatableObject
    {
        /// <summary>
        /// Code returned for CVV.
        /// </summary>
        /// <value>Code returned for CVV.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecurityCodeResponseEnum
        {
            /// <summary>
            /// Enum MATCHED for value: MATCHED
            /// </summary>
            [EnumMember(Value = "MATCHED")]
            MATCHED = 1,

            /// <summary>
            /// Enum NOTMATCHED for value: NOT_MATCHED
            /// </summary>
            [EnumMember(Value = "NOT_MATCHED")]
            NOTMATCHED = 2,

            /// <summary>
            /// Enum NOTPROCESSED for value: NOT_PROCESSED
            /// </summary>
            [EnumMember(Value = "NOT_PROCESSED")]
            NOTPROCESSED = 3,

            /// <summary>
            /// Enum NOTPRESENT for value: NOT_PRESENT
            /// </summary>
            [EnumMember(Value = "NOT_PRESENT")]
            NOTPRESENT = 4,

            /// <summary>
            /// Enum NOTCERTIFIED for value: NOT_CERTIFIED
            /// </summary>
            [EnumMember(Value = "NOT_CERTIFIED")]
            NOTCERTIFIED = 5,

            /// <summary>
            /// Enum NOTCHECKED for value: NOT_CHECKED
            /// </summary>
            [EnumMember(Value = "NOT_CHECKED")]
            NOTCHECKED = 6

        }

        /// <summary>
        /// Code returned for CVV.
        /// </summary>
        /// <value>Code returned for CVV.</value>
        [DataMember(Name = "securityCodeResponse", EmitDefaultValue = false)]
        public SecurityCodeResponseEnum? SecurityCodeResponse { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessorData" /> class.
        /// </summary>
        /// <param name="referenceNumber">Reference transaction ID..</param>
        /// <param name="authorizationCode">Code returned to confirm transaction..</param>
        /// <param name="responseCode">Response code from endpoints..</param>
        /// <param name="network">Network used for transaction..</param>
        /// <param name="associationResponseCode">Raw response code from issuer..</param>
        /// <param name="responseMessage">Message returned from endpoints..</param>
        /// <param name="avsResponse">avsResponse.</param>
        /// <param name="cardholderInfoResponse">cardholderInfoResponse.</param>
        /// <param name="securityCodeResponse">Code returned for CVV..</param>
        /// <param name="merchantAdviceCodeIndicator">Code to map merchant advice code to ISO specification..</param>
        /// <param name="responseIndicator">Indicates whether the transaction was routed through the payment card&#39;s own network or through a different network..</param>
        /// <param name="debitReceiptNumber">Receipt number from debit network provider..</param>
        /// <param name="transactionIntegrityClass">MasterCard provided Transaction Integrity Class for Point of Sale (POS) Purchase and Purchase with Cash Back transactions initiated on the Authorization Platform..</param>
        public ProcessorData(string referenceNumber = default(string), string authorizationCode = default(string), string responseCode = default(string), string network = default(string), string associationResponseCode = default(string), string responseMessage = default(string), AVSResponse avsResponse = default(AVSResponse), CardholderInfoResponse cardholderInfoResponse = default(CardholderInfoResponse), SecurityCodeResponseEnum? securityCodeResponse = null, string merchantAdviceCodeIndicator = default(string), string responseIndicator = default(string), string debitReceiptNumber = default(string), string transactionIntegrityClass = default(string))
        {
            this.ReferenceNumber = referenceNumber;
            this.AuthorizationCode = authorizationCode;
            this.ResponseCode = responseCode;
            this.Network = network;
            this.AssociationResponseCode = associationResponseCode;
            this.ResponseMessage = responseMessage;
            this.AvsResponse = avsResponse;
            this.CardholderInfoResponse = cardholderInfoResponse;
            this.SecurityCodeResponse = securityCodeResponse;
            this.MerchantAdviceCodeIndicator = merchantAdviceCodeIndicator;
            this.ResponseIndicator = responseIndicator;
            this.DebitReceiptNumber = debitReceiptNumber;
            this.TransactionIntegrityClass = transactionIntegrityClass;
        }

        /// <summary>
        /// Reference transaction ID.
        /// </summary>
        /// <value>Reference transaction ID.</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Code returned to confirm transaction.
        /// </summary>
        /// <value>Code returned to confirm transaction.</value>
        [DataMember(Name = "authorizationCode", EmitDefaultValue = false)]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Response code from endpoints.
        /// </summary>
        /// <value>Response code from endpoints.</value>
        [DataMember(Name = "responseCode", EmitDefaultValue = false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Network used for transaction.
        /// </summary>
        /// <value>Network used for transaction.</value>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Raw response code from issuer.
        /// </summary>
        /// <value>Raw response code from issuer.</value>
        [DataMember(Name = "associationResponseCode", EmitDefaultValue = false)]
        public string AssociationResponseCode { get; set; }

        /// <summary>
        /// Message returned from endpoints.
        /// </summary>
        /// <value>Message returned from endpoints.</value>
        [DataMember(Name = "responseMessage", EmitDefaultValue = false)]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Gets or Sets AvsResponse
        /// </summary>
        [DataMember(Name = "avsResponse", EmitDefaultValue = false)]
        public AVSResponse AvsResponse { get; set; }

        /// <summary>
        /// Gets or Sets CardholderInfoResponse
        /// </summary>
        [DataMember(Name = "cardholderInfoResponse", EmitDefaultValue = false)]
        public CardholderInfoResponse CardholderInfoResponse { get; set; }

        /// <summary>
        /// Code to map merchant advice code to ISO specification.
        /// </summary>
        /// <value>Code to map merchant advice code to ISO specification.</value>
        [DataMember(Name = "merchantAdviceCodeIndicator", EmitDefaultValue = false)]
        public string MerchantAdviceCodeIndicator { get; set; }

        /// <summary>
        /// Indicates whether the transaction was routed through the payment card&#39;s own network or through a different network.
        /// </summary>
        /// <value>Indicates whether the transaction was routed through the payment card&#39;s own network or through a different network.</value>
        [DataMember(Name = "responseIndicator", EmitDefaultValue = false)]
        public string ResponseIndicator { get; set; }

        /// <summary>
        /// Receipt number from debit network provider.
        /// </summary>
        /// <value>Receipt number from debit network provider.</value>
        [DataMember(Name = "debitReceiptNumber", EmitDefaultValue = false)]
        public string DebitReceiptNumber { get; set; }

        /// <summary>
        /// MasterCard provided Transaction Integrity Class for Point of Sale (POS) Purchase and Purchase with Cash Back transactions initiated on the Authorization Platform.
        /// </summary>
        /// <value>MasterCard provided Transaction Integrity Class for Point of Sale (POS) Purchase and Purchase with Cash Back transactions initiated on the Authorization Platform.</value>
        [DataMember(Name = "transactionIntegrityClass", EmitDefaultValue = false)]
        public string TransactionIntegrityClass { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessorData {\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  AuthorizationCode: ").Append(AuthorizationCode).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  AssociationResponseCode: ").Append(AssociationResponseCode).Append("\n");
            sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
            sb.Append("  AvsResponse: ").Append(AvsResponse).Append("\n");
            sb.Append("  CardholderInfoResponse: ").Append(CardholderInfoResponse).Append("\n");
            sb.Append("  SecurityCodeResponse: ").Append(SecurityCodeResponse).Append("\n");
            sb.Append("  MerchantAdviceCodeIndicator: ").Append(MerchantAdviceCodeIndicator).Append("\n");
            sb.Append("  ResponseIndicator: ").Append(ResponseIndicator).Append("\n");
            sb.Append("  DebitReceiptNumber: ").Append(DebitReceiptNumber).Append("\n");
            sb.Append("  TransactionIntegrityClass: ").Append(TransactionIntegrityClass).Append("\n");
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
            return this.Equals(input as ProcessorData);
        }

        /// <summary>
        /// Returns true if ProcessorData instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessorData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessorData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.AuthorizationCode == input.AuthorizationCode ||
                    (this.AuthorizationCode != null &&
                    this.AuthorizationCode.Equals(input.AuthorizationCode))
                ) && 
                (
                    this.ResponseCode == input.ResponseCode ||
                    (this.ResponseCode != null &&
                    this.ResponseCode.Equals(input.ResponseCode))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.AssociationResponseCode == input.AssociationResponseCode ||
                    (this.AssociationResponseCode != null &&
                    this.AssociationResponseCode.Equals(input.AssociationResponseCode))
                ) && 
                (
                    this.ResponseMessage == input.ResponseMessage ||
                    (this.ResponseMessage != null &&
                    this.ResponseMessage.Equals(input.ResponseMessage))
                ) && 
                (
                    this.AvsResponse == input.AvsResponse ||
                    (this.AvsResponse != null &&
                    this.AvsResponse.Equals(input.AvsResponse))
                ) && 
                (
                    this.CardholderInfoResponse == input.CardholderInfoResponse ||
                    (this.CardholderInfoResponse != null &&
                    this.CardholderInfoResponse.Equals(input.CardholderInfoResponse))
                ) && 
                (
                    this.SecurityCodeResponse == input.SecurityCodeResponse ||
                    (this.SecurityCodeResponse != null &&
                    this.SecurityCodeResponse.Equals(input.SecurityCodeResponse))
                ) && 
                (
                    this.MerchantAdviceCodeIndicator == input.MerchantAdviceCodeIndicator ||
                    (this.MerchantAdviceCodeIndicator != null &&
                    this.MerchantAdviceCodeIndicator.Equals(input.MerchantAdviceCodeIndicator))
                ) && 
                (
                    this.ResponseIndicator == input.ResponseIndicator ||
                    (this.ResponseIndicator != null &&
                    this.ResponseIndicator.Equals(input.ResponseIndicator))
                ) && 
                (
                    this.DebitReceiptNumber == input.DebitReceiptNumber ||
                    (this.DebitReceiptNumber != null &&
                    this.DebitReceiptNumber.Equals(input.DebitReceiptNumber))
                ) && 
                (
                    this.TransactionIntegrityClass == input.TransactionIntegrityClass ||
                    (this.TransactionIntegrityClass != null &&
                    this.TransactionIntegrityClass.Equals(input.TransactionIntegrityClass))
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
                if (this.ReferenceNumber != null)
                    hashCode = hashCode * 59 + this.ReferenceNumber.GetHashCode();
                if (this.AuthorizationCode != null)
                    hashCode = hashCode * 59 + this.AuthorizationCode.GetHashCode();
                if (this.ResponseCode != null)
                    hashCode = hashCode * 59 + this.ResponseCode.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.AssociationResponseCode != null)
                    hashCode = hashCode * 59 + this.AssociationResponseCode.GetHashCode();
                if (this.ResponseMessage != null)
                    hashCode = hashCode * 59 + this.ResponseMessage.GetHashCode();
                if (this.AvsResponse != null)
                    hashCode = hashCode * 59 + this.AvsResponse.GetHashCode();
                if (this.CardholderInfoResponse != null)
                    hashCode = hashCode * 59 + this.CardholderInfoResponse.GetHashCode();
                if (this.SecurityCodeResponse != null)
                    hashCode = hashCode * 59 + this.SecurityCodeResponse.GetHashCode();
                if (this.MerchantAdviceCodeIndicator != null)
                    hashCode = hashCode * 59 + this.MerchantAdviceCodeIndicator.GetHashCode();
                if (this.ResponseIndicator != null)
                    hashCode = hashCode * 59 + this.ResponseIndicator.GetHashCode();
                if (this.DebitReceiptNumber != null)
                    hashCode = hashCode * 59 + this.DebitReceiptNumber.GetHashCode();
                if (this.TransactionIntegrityClass != null)
                    hashCode = hashCode * 59 + this.TransactionIntegrityClass.GetHashCode();
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
            // MerchantAdviceCodeIndicator (string) pattern
            Regex regexMerchantAdviceCodeIndicator = new Regex(@"[0-9]{2}", RegexOptions.CultureInvariant);
            if (false == regexMerchantAdviceCodeIndicator.Match(this.MerchantAdviceCodeIndicator).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantAdviceCodeIndicator, must match a pattern of " + regexMerchantAdviceCodeIndicator, new [] { "MerchantAdviceCodeIndicator" });
            }

            yield break;
        }
    }
}
