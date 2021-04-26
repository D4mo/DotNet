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
    /// Push disbursement information.
    /// </summary>
    [DataContract]
    public partial class DisbursementTransactionType : Disbursement, IEquatable<DisbursementTransactionType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisbursementTransactionType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisbursementTransactionType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisbursementTransactionType" /> class.
        /// </summary>
        /// <param name="disbursementType">The type of disbursement. (required).</param>
        /// <param name="senderInfo">senderInfo (required).</param>
        /// <param name="receiverInfo">receiverInfo (required).</param>
        public DisbursementTransactionType(string disbursementType = default(string), SenderInfo senderInfo = default(SenderInfo), ReceiverInfo receiverInfo = default(ReceiverInfo)) : base(disbursementType, senderInfo, receiverInfo)
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisbursementTransactionType {\n");
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
            return this.Equals(input as DisbursementTransactionType);
        }

        /// <summary>
        /// Returns true if DisbursementTransactionType instances are equal
        /// </summary>
        /// <param name="input">Instance of DisbursementTransactionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisbursementTransactionType input)
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
