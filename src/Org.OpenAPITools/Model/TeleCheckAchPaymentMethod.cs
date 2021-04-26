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
    /// ACH means automated clearing house. Contains properties common across TeleCheck message types. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "AchType")]
    [JsonSubtypes.KnownSubType(typeof(TeleCheckICAPaymentMethod), "TeleCheckICAPaymentMethod")]
    [JsonSubtypes.KnownSubType(typeof(TeleCheckCBPPaymentMethod), "TeleCheckCBPPaymentMethod")]
    public partial class TeleCheckAchPaymentMethod : IEquatable<TeleCheckAchPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Identifies if the account type is checking or savings.
        /// </summary>
        /// <value>Identifies if the account type is checking or savings.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 1,

            /// <summary>
            /// Enum S for value: S
            /// </summary>
            [EnumMember(Value = "S")]
            S = 2

        }

        /// <summary>
        /// Identifies if the account type is checking or savings.
        /// </summary>
        /// <value>Identifies if the account type is checking or savings.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public AccountTypeEnum AccountType { get; set; }
        /// <summary>
        /// Identifies if the check type is personal or company.
        /// </summary>
        /// <value>Identifies if the check type is personal or company.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CheckTypeEnum
        {
            /// <summary>
            /// Enum P for value: P
            /// </summary>
            [EnumMember(Value = "P")]
            P = 1,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 2

        }

        /// <summary>
        /// Identifies if the check type is personal or company.
        /// </summary>
        /// <value>Identifies if the check type is personal or company.</value>
        [DataMember(Name = "checkType", EmitDefaultValue = false)]
        public CheckTypeEnum CheckType { get; set; }
        /// <summary>
        /// Release type is used as a risk variable to gauge risk level when the merchant is releasing the purchased merchandise.
        /// </summary>
        /// <value>Release type is used as a risk variable to gauge risk level when the merchant is releasing the purchased merchandise.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReleaseTypeEnum
        {
            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 1,

            /// <summary>
            /// Enum D for value: D
            /// </summary>
            [EnumMember(Value = "D")]
            D = 2,

            /// <summary>
            /// Enum P for value: P
            /// </summary>
            [EnumMember(Value = "P")]
            P = 3,

            /// <summary>
            /// Enum T for value: T
            /// </summary>
            [EnumMember(Value = "T")]
            T = 4

        }

        /// <summary>
        /// Release type is used as a risk variable to gauge risk level when the merchant is releasing the purchased merchandise.
        /// </summary>
        /// <value>Release type is used as a risk variable to gauge risk level when the merchant is releasing the purchased merchandise.</value>
        [DataMember(Name = "releaseType", EmitDefaultValue = false)]
        public ReleaseTypeEnum? ReleaseType { get; set; }
        /// <summary>
        /// Flags a transaction as a VIP order (based on merchant criteria). This field should not be sent for non-VIP orders.
        /// </summary>
        /// <value>Flags a transaction as a VIP order (based on merchant criteria). This field should not be sent for non-VIP orders.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VipCustomerEnum
        {
            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 1,

            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 2

        }

        /// <summary>
        /// Flags a transaction as a VIP order (based on merchant criteria). This field should not be sent for non-VIP orders.
        /// </summary>
        /// <value>Flags a transaction as a VIP order (based on merchant criteria). This field should not be sent for non-VIP orders.</value>
        [DataMember(Name = "vipCustomer", EmitDefaultValue = false)]
        public VipCustomerEnum? VipCustomer { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckAchPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeleCheckAchPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckAchPaymentMethod" /> class.
        /// </summary>
        /// <param name="achType">ACH application type values will be one of either TeleCheckICAPaymentMethod or TeleCheckCBPPaymentMethod. (required).</param>
        /// <param name="routingNumber">Bank routing number. (required).</param>
        /// <param name="accountNumber">Bank account number. (required).</param>
        /// <param name="accountType">Identifies if the account type is checking or savings. (required).</param>
        /// <param name="checkNumber">Check number..</param>
        /// <param name="checkType">Identifies if the check type is personal or company. (required).</param>
        /// <param name="productCode">Identifies the product code in the transaction..</param>
        /// <param name="manualIdInfo">manualIdInfo.</param>
        /// <param name="supplementIdInfo">supplementIdInfo.</param>
        /// <param name="agentId">Used to track the agent transaction activity..</param>
        /// <param name="terminalId">Identifies the register or lane number where the original sale transaction occurred..</param>
        /// <param name="registrationId">Unique ID assigned by the merchant for the consumer (never recycled). It is an additional level of authentication. To use this feature, the merchant must work with TeleCheck Risk to discuss. Registration IDs must not be generated for an existing or returning consumer returns. The single registration ID must be unique per consumer..</param>
        /// <param name="registrationDate">Date the consumer originally registered in format MMDDYYYY..</param>
        /// <param name="releaseType">Release type is used as a risk variable to gauge risk level when the merchant is releasing the purchased merchandise..</param>
        /// <param name="vipCustomer">Flags a transaction as a VIP order (based on merchant criteria). This field should not be sent for non-VIP orders..</param>
        /// <param name="sessionId">Session identifier. (required).</param>
        /// <param name="terminalState">Identifies the US state or territory where the original sale transaction occurred..</param>
        /// <param name="terminalCity">Identifies the city where the original sale transaction occurred..</param>
        /// <param name="achBillTo">achBillTo (required).</param>
        public TeleCheckAchPaymentMethod(string achType = default(string), string routingNumber = default(string), string accountNumber = default(string), AccountTypeEnum accountType = default(AccountTypeEnum), string checkNumber = default(string), CheckTypeEnum checkType = default(CheckTypeEnum), string productCode = default(string), IdInfo manualIdInfo = default(IdInfo), IdInfo supplementIdInfo = default(IdInfo), string agentId = default(string), string terminalId = default(string), string registrationId = default(string), DateTime registrationDate = default(DateTime), ReleaseTypeEnum? releaseType = null, VipCustomerEnum? vipCustomer = null, string sessionId = default(string), string terminalState = default(string), string terminalCity = default(string), TeleCheckAchPaymentMethodAchBillTo achBillTo = default(TeleCheckAchPaymentMethodAchBillTo))
        {
            // to ensure "achType" is required (not null)
            this.AchType = achType ?? throw new ArgumentNullException("achType is a required property for TeleCheckAchPaymentMethod and cannot be null");
            // to ensure "routingNumber" is required (not null)
            this.RoutingNumber = routingNumber ?? throw new ArgumentNullException("routingNumber is a required property for TeleCheckAchPaymentMethod and cannot be null");
            // to ensure "accountNumber" is required (not null)
            this.AccountNumber = accountNumber ?? throw new ArgumentNullException("accountNumber is a required property for TeleCheckAchPaymentMethod and cannot be null");
            // to ensure "accountType" is required (not null)
            this.AccountType = accountType;
            // to ensure "checkType" is required (not null)
            this.CheckType = checkType;
            // to ensure "sessionId" is required (not null)
            this.SessionId = sessionId ?? throw new ArgumentNullException("sessionId is a required property for TeleCheckAchPaymentMethod and cannot be null");
            // to ensure "achBillTo" is required (not null)
            this.AchBillTo = achBillTo ?? throw new ArgumentNullException("achBillTo is a required property for TeleCheckAchPaymentMethod and cannot be null");
            this.CheckNumber = checkNumber;
            this.ProductCode = productCode;
            this.ManualIdInfo = manualIdInfo;
            this.SupplementIdInfo = supplementIdInfo;
            this.AgentId = agentId;
            this.TerminalId = terminalId;
            this.RegistrationId = registrationId;
            this.RegistrationDate = registrationDate;
            this.ReleaseType = releaseType;
            this.VipCustomer = vipCustomer;
            this.TerminalState = terminalState;
            this.TerminalCity = terminalCity;
        }

        /// <summary>
        /// ACH application type values will be one of either TeleCheckICAPaymentMethod or TeleCheckCBPPaymentMethod.
        /// </summary>
        /// <value>ACH application type values will be one of either TeleCheckICAPaymentMethod or TeleCheckCBPPaymentMethod.</value>
        [DataMember(Name = "achType", EmitDefaultValue = false)]
        public string AchType { get; set; }

        /// <summary>
        /// Bank routing number.
        /// </summary>
        /// <value>Bank routing number.</value>
        [DataMember(Name = "routingNumber", EmitDefaultValue = false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Bank account number.
        /// </summary>
        /// <value>Bank account number.</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Check number.
        /// </summary>
        /// <value>Check number.</value>
        [DataMember(Name = "checkNumber", EmitDefaultValue = false)]
        public string CheckNumber { get; set; }

        /// <summary>
        /// Identifies the product code in the transaction.
        /// </summary>
        /// <value>Identifies the product code in the transaction.</value>
        [DataMember(Name = "productCode", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ManualIdInfo
        /// </summary>
        [DataMember(Name = "manualIdInfo", EmitDefaultValue = false)]
        public IdInfo ManualIdInfo { get; set; }

        /// <summary>
        /// Gets or Sets SupplementIdInfo
        /// </summary>
        [DataMember(Name = "supplementIdInfo", EmitDefaultValue = false)]
        public IdInfo SupplementIdInfo { get; set; }

        /// <summary>
        /// Used to track the agent transaction activity.
        /// </summary>
        /// <value>Used to track the agent transaction activity.</value>
        [DataMember(Name = "agentId", EmitDefaultValue = false)]
        public string AgentId { get; set; }

        /// <summary>
        /// Identifies the register or lane number where the original sale transaction occurred.
        /// </summary>
        /// <value>Identifies the register or lane number where the original sale transaction occurred.</value>
        [DataMember(Name = "terminalId", EmitDefaultValue = false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// Unique ID assigned by the merchant for the consumer (never recycled). It is an additional level of authentication. To use this feature, the merchant must work with TeleCheck Risk to discuss. Registration IDs must not be generated for an existing or returning consumer returns. The single registration ID must be unique per consumer.
        /// </summary>
        /// <value>Unique ID assigned by the merchant for the consumer (never recycled). It is an additional level of authentication. To use this feature, the merchant must work with TeleCheck Risk to discuss. Registration IDs must not be generated for an existing or returning consumer returns. The single registration ID must be unique per consumer.</value>
        [DataMember(Name = "registrationId", EmitDefaultValue = false)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Date the consumer originally registered in format MMDDYYYY.
        /// </summary>
        /// <value>Date the consumer originally registered in format MMDDYYYY.</value>
        [DataMember(Name = "registrationDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Session identifier.
        /// </summary>
        /// <value>Session identifier.</value>
        [DataMember(Name = "sessionId", EmitDefaultValue = false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Identifies the US state or territory where the original sale transaction occurred.
        /// </summary>
        /// <value>Identifies the US state or territory where the original sale transaction occurred.</value>
        [DataMember(Name = "terminalState", EmitDefaultValue = false)]
        public string TerminalState { get; set; }

        /// <summary>
        /// Identifies the city where the original sale transaction occurred.
        /// </summary>
        /// <value>Identifies the city where the original sale transaction occurred.</value>
        [DataMember(Name = "terminalCity", EmitDefaultValue = false)]
        public string TerminalCity { get; set; }

        /// <summary>
        /// Gets or Sets AchBillTo
        /// </summary>
        [DataMember(Name = "achBillTo", EmitDefaultValue = false)]
        public TeleCheckAchPaymentMethodAchBillTo AchBillTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeleCheckAchPaymentMethod {\n");
            sb.Append("  AchType: ").Append(AchType).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  CheckNumber: ").Append(CheckNumber).Append("\n");
            sb.Append("  CheckType: ").Append(CheckType).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ManualIdInfo: ").Append(ManualIdInfo).Append("\n");
            sb.Append("  SupplementIdInfo: ").Append(SupplementIdInfo).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  ReleaseType: ").Append(ReleaseType).Append("\n");
            sb.Append("  VipCustomer: ").Append(VipCustomer).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  TerminalState: ").Append(TerminalState).Append("\n");
            sb.Append("  TerminalCity: ").Append(TerminalCity).Append("\n");
            sb.Append("  AchBillTo: ").Append(AchBillTo).Append("\n");
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
            return this.Equals(input as TeleCheckAchPaymentMethod);
        }

        /// <summary>
        /// Returns true if TeleCheckAchPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of TeleCheckAchPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeleCheckAchPaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AchType == input.AchType ||
                    (this.AchType != null &&
                    this.AchType.Equals(input.AchType))
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.CheckNumber == input.CheckNumber ||
                    (this.CheckNumber != null &&
                    this.CheckNumber.Equals(input.CheckNumber))
                ) && 
                (
                    this.CheckType == input.CheckType ||
                    (this.CheckType != null &&
                    this.CheckType.Equals(input.CheckType))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.ManualIdInfo == input.ManualIdInfo ||
                    (this.ManualIdInfo != null &&
                    this.ManualIdInfo.Equals(input.ManualIdInfo))
                ) && 
                (
                    this.SupplementIdInfo == input.SupplementIdInfo ||
                    (this.SupplementIdInfo != null &&
                    this.SupplementIdInfo.Equals(input.SupplementIdInfo))
                ) && 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
                ) && 
                (
                    this.RegistrationId == input.RegistrationId ||
                    (this.RegistrationId != null &&
                    this.RegistrationId.Equals(input.RegistrationId))
                ) && 
                (
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.ReleaseType == input.ReleaseType ||
                    (this.ReleaseType != null &&
                    this.ReleaseType.Equals(input.ReleaseType))
                ) && 
                (
                    this.VipCustomer == input.VipCustomer ||
                    (this.VipCustomer != null &&
                    this.VipCustomer.Equals(input.VipCustomer))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.TerminalState == input.TerminalState ||
                    (this.TerminalState != null &&
                    this.TerminalState.Equals(input.TerminalState))
                ) && 
                (
                    this.TerminalCity == input.TerminalCity ||
                    (this.TerminalCity != null &&
                    this.TerminalCity.Equals(input.TerminalCity))
                ) && 
                (
                    this.AchBillTo == input.AchBillTo ||
                    (this.AchBillTo != null &&
                    this.AchBillTo.Equals(input.AchBillTo))
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
                if (this.AchType != null)
                    hashCode = hashCode * 59 + this.AchType.GetHashCode();
                if (this.RoutingNumber != null)
                    hashCode = hashCode * 59 + this.RoutingNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.CheckNumber != null)
                    hashCode = hashCode * 59 + this.CheckNumber.GetHashCode();
                if (this.CheckType != null)
                    hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.ManualIdInfo != null)
                    hashCode = hashCode * 59 + this.ManualIdInfo.GetHashCode();
                if (this.SupplementIdInfo != null)
                    hashCode = hashCode * 59 + this.SupplementIdInfo.GetHashCode();
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.TerminalId != null)
                    hashCode = hashCode * 59 + this.TerminalId.GetHashCode();
                if (this.RegistrationId != null)
                    hashCode = hashCode * 59 + this.RegistrationId.GetHashCode();
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.ReleaseType != null)
                    hashCode = hashCode * 59 + this.ReleaseType.GetHashCode();
                if (this.VipCustomer != null)
                    hashCode = hashCode * 59 + this.VipCustomer.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.TerminalState != null)
                    hashCode = hashCode * 59 + this.TerminalState.GetHashCode();
                if (this.TerminalCity != null)
                    hashCode = hashCode * 59 + this.TerminalCity.GetHashCode();
                if (this.AchBillTo != null)
                    hashCode = hashCode * 59 + this.AchBillTo.GetHashCode();
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
            // RoutingNumber (string) maxLength
            if(this.RoutingNumber != null && this.RoutingNumber.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoutingNumber, length must be less than 9.", new [] { "RoutingNumber" });
            }

            // RoutingNumber (string) minLength
            if(this.RoutingNumber != null && this.RoutingNumber.Length < 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoutingNumber, length must be greater than 9.", new [] { "RoutingNumber" });
            }

            // RoutingNumber (string) pattern
            Regex regexRoutingNumber = new Regex(@"^[0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexRoutingNumber.Match(this.RoutingNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoutingNumber, must match a pattern of " + regexRoutingNumber, new [] { "RoutingNumber" });
            }

            // AccountNumber (string) maxLength
            if(this.AccountNumber != null && this.AccountNumber.Length > 56)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 56.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if(this.AccountNumber != null && this.AccountNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 1.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) pattern
            Regex regexAccountNumber = new Regex(@"^[0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexAccountNumber.Match(this.AccountNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, must match a pattern of " + regexAccountNumber, new [] { "AccountNumber" });
            }

            // CheckNumber (string) maxLength
            if(this.CheckNumber != null && this.CheckNumber.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckNumber, length must be less than 10.", new [] { "CheckNumber" });
            }

            // CheckNumber (string) pattern
            Regex regexCheckNumber = new Regex(@"^[0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexCheckNumber.Match(this.CheckNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckNumber, must match a pattern of " + regexCheckNumber, new [] { "CheckNumber" });
            }

            // ProductCode (string) maxLength
            if(this.ProductCode != null && this.ProductCode.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductCode, length must be less than 6.", new [] { "ProductCode" });
            }

            // ProductCode (string) pattern
            Regex regexProductCode = new Regex(@"^[0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexProductCode.Match(this.ProductCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductCode, must match a pattern of " + regexProductCode, new [] { "ProductCode" });
            }

            // AgentId (string) maxLength
            if(this.AgentId != null && this.AgentId.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AgentId, length must be less than 6.", new [] { "AgentId" });
            }

            // AgentId (string) pattern
            Regex regexAgentId = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexAgentId.Match(this.AgentId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AgentId, must match a pattern of " + regexAgentId, new [] { "AgentId" });
            }

            // TerminalId (string) maxLength
            if(this.TerminalId != null && this.TerminalId.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalId, length must be less than 10.", new [] { "TerminalId" });
            }

            // TerminalId (string) pattern
            Regex regexTerminalId = new Regex(@"^[0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexTerminalId.Match(this.TerminalId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalId, must match a pattern of " + regexTerminalId, new [] { "TerminalId" });
            }

            // RegistrationId (string) maxLength
            if(this.RegistrationId != null && this.RegistrationId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RegistrationId, length must be less than 50.", new [] { "RegistrationId" });
            }

            // RegistrationId (string) pattern
            Regex regexRegistrationId = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexRegistrationId.Match(this.RegistrationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RegistrationId, must match a pattern of " + regexRegistrationId, new [] { "RegistrationId" });
            }

            // SessionId (string) maxLength
            if(this.SessionId != null && this.SessionId.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionId, length must be less than 128.", new [] { "SessionId" });
            }

            // SessionId (string) pattern
            Regex regexSessionId = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexSessionId.Match(this.SessionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionId, must match a pattern of " + regexSessionId, new [] { "SessionId" });
            }

            // TerminalState (string) maxLength
            if(this.TerminalState != null && this.TerminalState.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalState, length must be less than 2.", new [] { "TerminalState" });
            }

            // TerminalState (string) pattern
            Regex regexTerminalState = new Regex(@"^[A-Z]{2}$", RegexOptions.CultureInvariant);
            if (false == regexTerminalState.Match(this.TerminalState).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalState, must match a pattern of " + regexTerminalState, new [] { "TerminalState" });
            }

            // TerminalCity (string) maxLength
            if(this.TerminalCity != null && this.TerminalCity.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalCity, length must be less than 16.", new [] { "TerminalCity" });
            }

            // TerminalCity (string) pattern
            Regex regexTerminalCity = new Regex(@"(?=.*[^\\s])^[^|]+$", RegexOptions.CultureInvariant);
            if (false == regexTerminalCity.Match(this.TerminalCity).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalCity, must match a pattern of " + regexTerminalCity, new [] { "TerminalCity" });
            }

            yield break;
        }
    }
}
