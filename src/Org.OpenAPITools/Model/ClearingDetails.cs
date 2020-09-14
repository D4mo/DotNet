/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.13.0.20200810.001
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
    /// Contains clearing related response information.
    /// </summary>
    [DataContract]
    public partial class ClearingDetails : IEquatable<ClearingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClearingDetails" /> class.
        /// </summary>
        /// <param name="clearingElements">The array contains information about the clearing elements..</param>
        /// <param name="batchTimeStamp">Timestamp when the clearing has been processed. The used format is \&quot;YYYYMMDDhhmmss\&quot;..</param>
        /// <param name="receiptNumberFrom">Start receipt number for the clearing process..</param>
        /// <param name="receiptNumberTo">End receipt number for the clearing process..</param>
        /// <param name="traceNumber">Trace number for the clearing process..</param>
        public ClearingDetails(List<ClearingElement> clearingElements = default(List<ClearingElement>), string batchTimeStamp = default(string), int receiptNumberFrom = default(int), int receiptNumberTo = default(int), int traceNumber = default(int))
        {
            this.ClearingElements = clearingElements;
            this.BatchTimeStamp = batchTimeStamp;
            this.ReceiptNumberFrom = receiptNumberFrom;
            this.ReceiptNumberTo = receiptNumberTo;
            this.TraceNumber = traceNumber;
        }

        /// <summary>
        /// The array contains information about the clearing elements.
        /// </summary>
        /// <value>The array contains information about the clearing elements.</value>
        [DataMember(Name = "clearingElements", EmitDefaultValue = false)]
        public List<ClearingElement> ClearingElements { get; set; }

        /// <summary>
        /// Timestamp when the clearing has been processed. The used format is \&quot;YYYYMMDDhhmmss\&quot;.
        /// </summary>
        /// <value>Timestamp when the clearing has been processed. The used format is \&quot;YYYYMMDDhhmmss\&quot;.</value>
        [DataMember(Name = "batchTimeStamp", EmitDefaultValue = false)]
        public string BatchTimeStamp { get; set; }

        /// <summary>
        /// Start receipt number for the clearing process.
        /// </summary>
        /// <value>Start receipt number for the clearing process.</value>
        [DataMember(Name = "receiptNumberFrom", EmitDefaultValue = false)]
        public int ReceiptNumberFrom { get; set; }

        /// <summary>
        /// End receipt number for the clearing process.
        /// </summary>
        /// <value>End receipt number for the clearing process.</value>
        [DataMember(Name = "receiptNumberTo", EmitDefaultValue = false)]
        public int ReceiptNumberTo { get; set; }

        /// <summary>
        /// Trace number for the clearing process.
        /// </summary>
        /// <value>Trace number for the clearing process.</value>
        [DataMember(Name = "traceNumber", EmitDefaultValue = false)]
        public int TraceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClearingDetails {\n");
            sb.Append("  ClearingElements: ").Append(ClearingElements).Append("\n");
            sb.Append("  BatchTimeStamp: ").Append(BatchTimeStamp).Append("\n");
            sb.Append("  ReceiptNumberFrom: ").Append(ReceiptNumberFrom).Append("\n");
            sb.Append("  ReceiptNumberTo: ").Append(ReceiptNumberTo).Append("\n");
            sb.Append("  TraceNumber: ").Append(TraceNumber).Append("\n");
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
            return this.Equals(input as ClearingDetails);
        }

        /// <summary>
        /// Returns true if ClearingDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ClearingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClearingDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClearingElements == input.ClearingElements ||
                    this.ClearingElements != null &&
                    input.ClearingElements != null &&
                    this.ClearingElements.SequenceEqual(input.ClearingElements)
                ) && 
                (
                    this.BatchTimeStamp == input.BatchTimeStamp ||
                    (this.BatchTimeStamp != null &&
                    this.BatchTimeStamp.Equals(input.BatchTimeStamp))
                ) && 
                (
                    this.ReceiptNumberFrom == input.ReceiptNumberFrom ||
                    this.ReceiptNumberFrom.Equals(input.ReceiptNumberFrom)
                ) && 
                (
                    this.ReceiptNumberTo == input.ReceiptNumberTo ||
                    this.ReceiptNumberTo.Equals(input.ReceiptNumberTo)
                ) && 
                (
                    this.TraceNumber == input.TraceNumber ||
                    this.TraceNumber.Equals(input.TraceNumber)
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
                if (this.ClearingElements != null)
                    hashCode = hashCode * 59 + this.ClearingElements.GetHashCode();
                if (this.BatchTimeStamp != null)
                    hashCode = hashCode * 59 + this.BatchTimeStamp.GetHashCode();
                hashCode = hashCode * 59 + this.ReceiptNumberFrom.GetHashCode();
                hashCode = hashCode * 59 + this.ReceiptNumberTo.GetHashCode();
                hashCode = hashCode * 59 + this.TraceNumber.GetHashCode();
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
            // BatchTimeStamp (string) pattern
            Regex regexBatchTimeStamp = new Regex(@"[0-9]{14}", RegexOptions.CultureInvariant);
            if (false == regexBatchTimeStamp.Match(this.BatchTimeStamp).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BatchTimeStamp, must match a pattern of " + regexBatchTimeStamp, new [] { "BatchTimeStamp" });
            }

            // ReceiptNumberFrom (int) maximum
            if(this.ReceiptNumberFrom > (int)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReceiptNumberFrom, must be a value less than or equal to 9999.", new [] { "ReceiptNumberFrom" });
            }

            // ReceiptNumberFrom (int) minimum
            if(this.ReceiptNumberFrom < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReceiptNumberFrom, must be a value greater than or equal to 1.", new [] { "ReceiptNumberFrom" });
            }

            // ReceiptNumberTo (int) maximum
            if(this.ReceiptNumberTo > (int)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReceiptNumberTo, must be a value less than or equal to 9999.", new [] { "ReceiptNumberTo" });
            }

            // ReceiptNumberTo (int) minimum
            if(this.ReceiptNumberTo < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReceiptNumberTo, must be a value greater than or equal to 1.", new [] { "ReceiptNumberTo" });
            }

            // TraceNumber (int) maximum
            if(this.TraceNumber > (int)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TraceNumber, must be a value less than or equal to 999999.", new [] { "TraceNumber" });
            }

            // TraceNumber (int) minimum
            if(this.TraceNumber < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TraceNumber, must be a value greater than or equal to 0.", new [] { "TraceNumber" });
            }

            yield break;
        }
    }
}
