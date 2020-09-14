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
    /// Request to perform post auth transaction.
    /// </summary>
    [DataContract]
    public partial class PostAuthTransaction : SecondaryTransaction, IEquatable<PostAuthTransaction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TransactionOrigin
        /// </summary>
        [DataMember(Name = "transactionOrigin", EmitDefaultValue = false)]
        public TransactionOrigin? TransactionOrigin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostAuthTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthTransaction" /> class.
        /// </summary>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="splitShipment">splitShipment.</param>
        /// <param name="softDescriptor">softDescriptor.</param>
        /// <param name="requestType">Object name of the secondary transaction request. (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="comments">Comment for the secondary transaction..</param>
        /// <param name="order">order.</param>
        public PostAuthTransaction(Amount transactionAmount = default(Amount), TransactionOrigin? transactionOrigin = null, SplitShipment splitShipment = default(SplitShipment), SoftDescriptor softDescriptor = default(SoftDescriptor), string requestType = default(string), string storeId = default(string), string merchantTransactionId = default(string), string comments = default(string), Order order = default(Order)) : base(requestType, storeId, merchantTransactionId, comments, order)
        {
            // to ensure "transactionAmount" is required (not null)
            this.TransactionAmount = transactionAmount ?? throw new ArgumentNullException("transactionAmount is a required property for PostAuthTransaction and cannot be null");
            this.TransactionOrigin = transactionOrigin;
            this.SplitShipment = splitShipment;
            this.SoftDescriptor = softDescriptor;
        }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transactionAmount", EmitDefaultValue = false)]
        public Amount TransactionAmount { get; set; }

        /// <summary>
        /// Gets or Sets SplitShipment
        /// </summary>
        [DataMember(Name = "splitShipment", EmitDefaultValue = false)]
        public SplitShipment SplitShipment { get; set; }

        /// <summary>
        /// Gets or Sets SoftDescriptor
        /// </summary>
        [DataMember(Name = "softDescriptor", EmitDefaultValue = false)]
        public SoftDescriptor SoftDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostAuthTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionOrigin: ").Append(TransactionOrigin).Append("\n");
            sb.Append("  SplitShipment: ").Append(SplitShipment).Append("\n");
            sb.Append("  SoftDescriptor: ").Append(SoftDescriptor).Append("\n");
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
            return this.Equals(input as PostAuthTransaction);
        }

        /// <summary>
        /// Returns true if PostAuthTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of PostAuthTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostAuthTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && base.Equals(input) && 
                (
                    this.TransactionOrigin == input.TransactionOrigin ||
                    this.TransactionOrigin.Equals(input.TransactionOrigin)
                ) && base.Equals(input) && 
                (
                    this.SplitShipment == input.SplitShipment ||
                    (this.SplitShipment != null &&
                    this.SplitShipment.Equals(input.SplitShipment))
                ) && base.Equals(input) && 
                (
                    this.SoftDescriptor == input.SoftDescriptor ||
                    (this.SoftDescriptor != null &&
                    this.SoftDescriptor.Equals(input.SoftDescriptor))
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
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionOrigin.GetHashCode();
                if (this.SplitShipment != null)
                    hashCode = hashCode * 59 + this.SplitShipment.GetHashCode();
                if (this.SoftDescriptor != null)
                    hashCode = hashCode * 59 + this.SoftDescriptor.GetHashCode();
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
