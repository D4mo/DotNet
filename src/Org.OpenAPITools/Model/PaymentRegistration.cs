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
    /// PaymentRegistration
    /// </summary>
    [DataContract]
    public partial class PaymentRegistration : IEquatable<PaymentRegistration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRegistration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentRegistration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRegistration" /> class.
        /// </summary>
        /// <param name="merchantRef">Merchant reference code. Used by FirstAPI and reflected in settlement records and webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction..</param>
        /// <param name="transactionType">Type of transaction merchant wants to process. (required).</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="merchant">merchant (required).</param>
        /// <param name="device">device.</param>
        /// <param name="userDefined">A JSON object that can carry any additional information that might be helpful for fraud detection..</param>
        /// <param name="originalTransactionType">Defines the type of the original transaction that is being evaluated for the Fraud Score. (required).</param>
        /// <param name="issuerResponse">issuerResponse.</param>
        /// <param name="verificationAvs">verificationAvs.</param>
        /// <param name="verification3ds">verification3ds.</param>
        /// <param name="verificationCvv">verificationCvv.</param>
        /// <param name="registrationMethod">registrationMethod (required).</param>
        public PaymentRegistration(string merchantRef = default(string), string transactionType = default(string), Customer customer = default(Customer), Merchant merchant = default(Merchant), FraudRegistrationDevice device = default(FraudRegistrationDevice), Object userDefined = default(Object), string originalTransactionType = default(string), IssuerResponse issuerResponse = default(IssuerResponse), VerificationAvs verificationAvs = default(VerificationAvs), Verification3ds verification3ds = default(Verification3ds), VerificationCvv verificationCvv = default(VerificationCvv), RegistrationMethod registrationMethod = default(RegistrationMethod))
        {
            // to ensure "transactionType" is required (not null)
            this.TransactionType = transactionType ?? throw new ArgumentNullException("transactionType is a required property for PaymentRegistration and cannot be null");
            // to ensure "customer" is required (not null)
            this.Customer = customer ?? throw new ArgumentNullException("customer is a required property for PaymentRegistration and cannot be null");
            // to ensure "merchant" is required (not null)
            this.Merchant = merchant ?? throw new ArgumentNullException("merchant is a required property for PaymentRegistration and cannot be null");
            // to ensure "originalTransactionType" is required (not null)
            this.OriginalTransactionType = originalTransactionType ?? throw new ArgumentNullException("originalTransactionType is a required property for PaymentRegistration and cannot be null");
            // to ensure "registrationMethod" is required (not null)
            this.RegistrationMethod = registrationMethod ?? throw new ArgumentNullException("registrationMethod is a required property for PaymentRegistration and cannot be null");
            this.MerchantRef = merchantRef;
            this.Device = device;
            this.UserDefined = userDefined;
            this.IssuerResponse = issuerResponse;
            this.VerificationAvs = verificationAvs;
            this.Verification3ds = verification3ds;
            this.VerificationCvv = verificationCvv;
        }

        /// <summary>
        /// Merchant reference code. Used by FirstAPI and reflected in settlement records and webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction.
        /// </summary>
        /// <value>Merchant reference code. Used by FirstAPI and reflected in settlement records and webhook notifications. Typically, the merchantRef field is the purchase order number or unique sequence value associated to a given transaction.</value>
        [DataMember(Name = "merchantRef", EmitDefaultValue = false)]
        public string MerchantRef { get; set; }

        /// <summary>
        /// Type of transaction merchant wants to process.
        /// </summary>
        /// <value>Type of transaction merchant wants to process.</value>
        [DataMember(Name = "transactionType", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or Sets Merchant
        /// </summary>
        [DataMember(Name = "merchant", EmitDefaultValue = false)]
        public Merchant Merchant { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public FraudRegistrationDevice Device { get; set; }

        /// <summary>
        /// A JSON object that can carry any additional information that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that can carry any additional information that might be helpful for fraud detection.</value>
        [DataMember(Name = "userDefined", EmitDefaultValue = false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// Defines the type of the original transaction that is being evaluated for the Fraud Score.
        /// </summary>
        /// <value>Defines the type of the original transaction that is being evaluated for the Fraud Score.</value>
        [DataMember(Name = "originalTransactionType", EmitDefaultValue = false)]
        public string OriginalTransactionType { get; set; }

        /// <summary>
        /// Gets or Sets IssuerResponse
        /// </summary>
        [DataMember(Name = "issuerResponse", EmitDefaultValue = false)]
        public IssuerResponse IssuerResponse { get; set; }

        /// <summary>
        /// Gets or Sets VerificationAvs
        /// </summary>
        [DataMember(Name = "verificationAvs", EmitDefaultValue = false)]
        public VerificationAvs VerificationAvs { get; set; }

        /// <summary>
        /// Gets or Sets Verification3ds
        /// </summary>
        [DataMember(Name = "verification3ds", EmitDefaultValue = false)]
        public Verification3ds Verification3ds { get; set; }

        /// <summary>
        /// Gets or Sets VerificationCvv
        /// </summary>
        [DataMember(Name = "verificationCvv", EmitDefaultValue = false)]
        public VerificationCvv VerificationCvv { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationMethod
        /// </summary>
        [DataMember(Name = "registrationMethod", EmitDefaultValue = false)]
        public RegistrationMethod RegistrationMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRegistration {\n");
            sb.Append("  MerchantRef: ").Append(MerchantRef).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Merchant: ").Append(Merchant).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
            sb.Append("  OriginalTransactionType: ").Append(OriginalTransactionType).Append("\n");
            sb.Append("  IssuerResponse: ").Append(IssuerResponse).Append("\n");
            sb.Append("  VerificationAvs: ").Append(VerificationAvs).Append("\n");
            sb.Append("  Verification3ds: ").Append(Verification3ds).Append("\n");
            sb.Append("  VerificationCvv: ").Append(VerificationCvv).Append("\n");
            sb.Append("  RegistrationMethod: ").Append(RegistrationMethod).Append("\n");
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
            return this.Equals(input as PaymentRegistration);
        }

        /// <summary>
        /// Returns true if PaymentRegistration instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentRegistration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRegistration input)
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
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.Merchant == input.Merchant ||
                    (this.Merchant != null &&
                    this.Merchant.Equals(input.Merchant))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.UserDefined == input.UserDefined ||
                    (this.UserDefined != null &&
                    this.UserDefined.Equals(input.UserDefined))
                ) && 
                (
                    this.OriginalTransactionType == input.OriginalTransactionType ||
                    (this.OriginalTransactionType != null &&
                    this.OriginalTransactionType.Equals(input.OriginalTransactionType))
                ) && 
                (
                    this.IssuerResponse == input.IssuerResponse ||
                    (this.IssuerResponse != null &&
                    this.IssuerResponse.Equals(input.IssuerResponse))
                ) && 
                (
                    this.VerificationAvs == input.VerificationAvs ||
                    (this.VerificationAvs != null &&
                    this.VerificationAvs.Equals(input.VerificationAvs))
                ) && 
                (
                    this.Verification3ds == input.Verification3ds ||
                    (this.Verification3ds != null &&
                    this.Verification3ds.Equals(input.Verification3ds))
                ) && 
                (
                    this.VerificationCvv == input.VerificationCvv ||
                    (this.VerificationCvv != null &&
                    this.VerificationCvv.Equals(input.VerificationCvv))
                ) && 
                (
                    this.RegistrationMethod == input.RegistrationMethod ||
                    (this.RegistrationMethod != null &&
                    this.RegistrationMethod.Equals(input.RegistrationMethod))
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
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Merchant != null)
                    hashCode = hashCode * 59 + this.Merchant.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.UserDefined != null)
                    hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
                if (this.OriginalTransactionType != null)
                    hashCode = hashCode * 59 + this.OriginalTransactionType.GetHashCode();
                if (this.IssuerResponse != null)
                    hashCode = hashCode * 59 + this.IssuerResponse.GetHashCode();
                if (this.VerificationAvs != null)
                    hashCode = hashCode * 59 + this.VerificationAvs.GetHashCode();
                if (this.Verification3ds != null)
                    hashCode = hashCode * 59 + this.Verification3ds.GetHashCode();
                if (this.VerificationCvv != null)
                    hashCode = hashCode * 59 + this.VerificationCvv.GetHashCode();
                if (this.RegistrationMethod != null)
                    hashCode = hashCode * 59 + this.RegistrationMethod.GetHashCode();
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
            yield break;
        }
    }
}
