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
    /// Wallet payment method containing encrypted Samsung Pay information.
    /// </summary>
    [DataContract]
    public partial class EncryptedSamsungPayWalletPaymentMethod : WalletPaymentMethod, IEquatable<EncryptedSamsungPayWalletPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedSamsungPayWalletPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EncryptedSamsungPayWalletPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedSamsungPayWalletPaymentMethod" /> class.
        /// </summary>
        /// <param name="encryptedSamsungPay">encryptedSamsungPay (required).</param>
        /// <param name="walletType">Type of wallet. (required).</param>
        public EncryptedSamsungPayWalletPaymentMethod(EncryptedSamsungPay encryptedSamsungPay = default(EncryptedSamsungPay), string walletType = default(string)) : base(walletType)
        {
            // to ensure "encryptedSamsungPay" is required (not null)
            this.EncryptedSamsungPay = encryptedSamsungPay ?? throw new ArgumentNullException("encryptedSamsungPay is a required property for EncryptedSamsungPayWalletPaymentMethod and cannot be null");
        }

        /// <summary>
        /// Gets or Sets EncryptedSamsungPay
        /// </summary>
        [DataMember(Name = "encryptedSamsungPay", EmitDefaultValue = false)]
        public EncryptedSamsungPay EncryptedSamsungPay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptedSamsungPayWalletPaymentMethod {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EncryptedSamsungPay: ").Append(EncryptedSamsungPay).Append("\n");
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
            return this.Equals(input as EncryptedSamsungPayWalletPaymentMethod);
        }

        /// <summary>
        /// Returns true if EncryptedSamsungPayWalletPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of EncryptedSamsungPayWalletPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncryptedSamsungPayWalletPaymentMethod input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.EncryptedSamsungPay == input.EncryptedSamsungPay ||
                    (this.EncryptedSamsungPay != null &&
                    this.EncryptedSamsungPay.Equals(input.EncryptedSamsungPay))
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
                if (this.EncryptedSamsungPay != null)
                    hashCode = hashCode * 59 + this.EncryptedSamsungPay.GetHashCode();
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
