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
    /// ACH TeleCheck payment method for check by phone application type.
    /// </summary>
    [DataContract]
    public partial class TeleCheckCBPPaymentMethod : TeleCheckAchPaymentMethod, IEquatable<TeleCheckCBPPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckCBPPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeleCheckCBPPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleCheckCBPPaymentMethod" /> class.
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
        public TeleCheckCBPPaymentMethod(string achType = default(string), string routingNumber = default(string), string accountNumber = default(string), AccountTypeEnum accountType = default(AccountTypeEnum), string checkNumber = default(string), CheckTypeEnum checkType = default(CheckTypeEnum), string productCode = default(string), IdInfo manualIdInfo = default(IdInfo), IdInfo supplementIdInfo = default(IdInfo), string agentId = default(string), string terminalId = default(string), string registrationId = default(string), DateTime registrationDate = default(DateTime), ReleaseTypeEnum? releaseType = null, VipCustomerEnum? vipCustomer = null, string sessionId = default(string), string terminalState = default(string), string terminalCity = default(string), TeleCheckAchPaymentMethodAchBillTo achBillTo = default(TeleCheckAchPaymentMethodAchBillTo)) : base(achType, routingNumber, accountNumber, accountType, checkNumber, checkType, productCode, manualIdInfo, supplementIdInfo, agentId, terminalId, registrationId, registrationDate, releaseType, vipCustomer, sessionId, terminalState, terminalCity, achBillTo)
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeleCheckCBPPaymentMethod {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as TeleCheckCBPPaymentMethod);
        }

        /// <summary>
        /// Returns true if TeleCheckCBPPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of TeleCheckCBPPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeleCheckCBPPaymentMethod input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
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
