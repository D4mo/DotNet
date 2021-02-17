/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.1.0.20210122.001
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
    /// Amount component details, used in responses.
    /// </summary>
    [DataContract]
    public partial class ResponseAmountComponents : IEquatable<ResponseAmountComponents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAmountComponents" /> class.
        /// </summary>
        /// <param name="subtotal">Subtotal amount..</param>
        /// <param name="vatAmount">Value-added tax amount..</param>
        /// <param name="localTax">Local tax amount..</param>
        /// <param name="shipping">Shipping amount..</param>
        /// <param name="cashback">Cashback amount..</param>
        /// <param name="tip">Tip amount..</param>
        /// <param name="convenienceFee">Amount added for proccessing or handling fees..</param>
        public ResponseAmountComponents(decimal subtotal = default(decimal), decimal vatAmount = default(decimal), decimal localTax = default(decimal), decimal shipping = default(decimal), decimal cashback = default(decimal), decimal tip = default(decimal), decimal convenienceFee = default(decimal))
        {
            this.Subtotal = subtotal;
            this.VatAmount = vatAmount;
            this.LocalTax = localTax;
            this.Shipping = shipping;
            this.Cashback = cashback;
            this.Tip = tip;
            this.ConvenienceFee = convenienceFee;
        }

        /// <summary>
        /// Subtotal amount.
        /// </summary>
        /// <value>Subtotal amount.</value>
        [DataMember(Name = "subtotal", EmitDefaultValue = false)]
        public decimal Subtotal { get; set; }

        /// <summary>
        /// Value-added tax amount.
        /// </summary>
        /// <value>Value-added tax amount.</value>
        [DataMember(Name = "vatAmount", EmitDefaultValue = false)]
        public decimal VatAmount { get; set; }

        /// <summary>
        /// Local tax amount.
        /// </summary>
        /// <value>Local tax amount.</value>
        [DataMember(Name = "localTax", EmitDefaultValue = false)]
        public decimal LocalTax { get; set; }

        /// <summary>
        /// Shipping amount.
        /// </summary>
        /// <value>Shipping amount.</value>
        [DataMember(Name = "shipping", EmitDefaultValue = false)]
        public decimal Shipping { get; set; }

        /// <summary>
        /// Cashback amount.
        /// </summary>
        /// <value>Cashback amount.</value>
        [DataMember(Name = "cashback", EmitDefaultValue = false)]
        public decimal Cashback { get; set; }

        /// <summary>
        /// Tip amount.
        /// </summary>
        /// <value>Tip amount.</value>
        [DataMember(Name = "tip", EmitDefaultValue = false)]
        public decimal Tip { get; set; }

        /// <summary>
        /// Amount added for proccessing or handling fees.
        /// </summary>
        /// <value>Amount added for proccessing or handling fees.</value>
        [DataMember(Name = "convenienceFee", EmitDefaultValue = false)]
        public decimal ConvenienceFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAmountComponents {\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  VatAmount: ").Append(VatAmount).Append("\n");
            sb.Append("  LocalTax: ").Append(LocalTax).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Cashback: ").Append(Cashback).Append("\n");
            sb.Append("  Tip: ").Append(Tip).Append("\n");
            sb.Append("  ConvenienceFee: ").Append(ConvenienceFee).Append("\n");
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
            return this.Equals(input as ResponseAmountComponents);
        }

        /// <summary>
        /// Returns true if ResponseAmountComponents instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAmountComponents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAmountComponents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subtotal == input.Subtotal ||
                    (this.Subtotal != null &&
                    this.Subtotal.Equals(input.Subtotal))
                ) && 
                (
                    this.VatAmount == input.VatAmount ||
                    (this.VatAmount != null &&
                    this.VatAmount.Equals(input.VatAmount))
                ) && 
                (
                    this.LocalTax == input.LocalTax ||
                    (this.LocalTax != null &&
                    this.LocalTax.Equals(input.LocalTax))
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) && 
                (
                    this.Cashback == input.Cashback ||
                    (this.Cashback != null &&
                    this.Cashback.Equals(input.Cashback))
                ) && 
                (
                    this.Tip == input.Tip ||
                    (this.Tip != null &&
                    this.Tip.Equals(input.Tip))
                ) && 
                (
                    this.ConvenienceFee == input.ConvenienceFee ||
                    (this.ConvenienceFee != null &&
                    this.ConvenienceFee.Equals(input.ConvenienceFee))
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
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.VatAmount != null)
                    hashCode = hashCode * 59 + this.VatAmount.GetHashCode();
                if (this.LocalTax != null)
                    hashCode = hashCode * 59 + this.LocalTax.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.Cashback != null)
                    hashCode = hashCode * 59 + this.Cashback.GetHashCode();
                if (this.Tip != null)
                    hashCode = hashCode * 59 + this.Tip.GetHashCode();
                if (this.ConvenienceFee != null)
                    hashCode = hashCode * 59 + this.ConvenienceFee.GetHashCode();
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
