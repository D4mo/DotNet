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
    /// The loyalty program information associated with this payment.
    /// </summary>
    [DataContract]
    public partial class Loyalty : IEquatable<Loyalty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loyalty" /> class.
        /// </summary>
        /// <param name="id">A unique ID associated with the loyalty program account. Must be unique within the merchants system. Depending on loyalty programs the account might also serve as a credit/bank account. If this is the case the ID must be not be the PAN..</param>
        /// <param name="program">A string that identifies the program in which the customer is enrolled if the merchant supports several programs or levels..</param>
        /// <param name="balance">The balance of the loyalty program account in a program specific currency (e.g. points)..</param>
        public Loyalty(string id = default(string), string program = default(string), decimal balance = default(decimal))
        {
            this.Id = id;
            this.Program = program;
            this.Balance = balance;
        }

        /// <summary>
        /// A unique ID associated with the loyalty program account. Must be unique within the merchants system. Depending on loyalty programs the account might also serve as a credit/bank account. If this is the case the ID must be not be the PAN.
        /// </summary>
        /// <value>A unique ID associated with the loyalty program account. Must be unique within the merchants system. Depending on loyalty programs the account might also serve as a credit/bank account. If this is the case the ID must be not be the PAN.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A string that identifies the program in which the customer is enrolled if the merchant supports several programs or levels.
        /// </summary>
        /// <value>A string that identifies the program in which the customer is enrolled if the merchant supports several programs or levels.</value>
        [DataMember(Name = "program", EmitDefaultValue = false)]
        public string Program { get; set; }

        /// <summary>
        /// The balance of the loyalty program account in a program specific currency (e.g. points).
        /// </summary>
        /// <value>The balance of the loyalty program account in a program specific currency (e.g. points).</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public decimal Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Loyalty {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Program: ").Append(Program).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
            return this.Equals(input as Loyalty);
        }

        /// <summary>
        /// Returns true if Loyalty instances are equal
        /// </summary>
        /// <param name="input">Instance of Loyalty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Loyalty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Program == input.Program ||
                    (this.Program != null &&
                    this.Program.Equals(input.Program))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Program != null)
                    hashCode = hashCode * 59 + this.Program.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
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
