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
    /// The payment object for China-domestic transactions. Use this to populate all china domestic payment method details.
    /// </summary>
    [DataContract]
    public partial class ChinaDomestic : IEquatable<ChinaDomestic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChinaDomestic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChinaDomestic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChinaDomestic" /> class.
        /// </summary>
        /// <param name="productCode">Use this to indicate the product code according to the product category list. (required).</param>
        /// <param name="productQuantity">The quantity. (required).</param>
        /// <param name="productPrice">Rate amount in 3 decimal 12 bytes total digit. (required).</param>
        /// <param name="productDescription">The product description. (required).</param>
        /// <param name="redirectURL">Use this to indicate the product code according to the product category list. (required).</param>
        /// <param name="limitCardFunctionToDebit">Use this to limit card functions to debit cards..</param>
        /// <param name="customerId">Use this to indicate the CUP customer ID if known..</param>
        /// <param name="bankId">Use this to indicate the CUP bank ID if known..</param>
        /// <param name="openId">Use this as unique identifier of WeChat user which is corresponded to the appid of merchant. The field is only applicable for ChinaDomesticPaymentMethod - brand &#x3D; WECHAT_DOMESTIC.</param>
        public ChinaDomestic(string productCode = default(string), int productQuantity = default(int), decimal productPrice = default(decimal), string productDescription = default(string), string redirectURL = default(string), bool limitCardFunctionToDebit = default(bool), string customerId = default(string), string bankId = default(string), string openId = default(string))
        {
            // to ensure "productCode" is required (not null)
            this.ProductCode = productCode ?? throw new ArgumentNullException("productCode is a required property for ChinaDomestic and cannot be null");
            // to ensure "productQuantity" is required (not null)
            this.ProductQuantity = productQuantity;
            // to ensure "productPrice" is required (not null)
            this.ProductPrice = productPrice;
            // to ensure "productDescription" is required (not null)
            this.ProductDescription = productDescription ?? throw new ArgumentNullException("productDescription is a required property for ChinaDomestic and cannot be null");
            // to ensure "redirectURL" is required (not null)
            this.RedirectURL = redirectURL ?? throw new ArgumentNullException("redirectURL is a required property for ChinaDomestic and cannot be null");
            this.LimitCardFunctionToDebit = limitCardFunctionToDebit;
            this.CustomerId = customerId;
            this.BankId = bankId;
            this.OpenId = openId;
        }

        /// <summary>
        /// Use this to indicate the product code according to the product category list.
        /// </summary>
        /// <value>Use this to indicate the product code according to the product category list.</value>
        [DataMember(Name = "productCode", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [DataMember(Name = "productQuantity", EmitDefaultValue = false)]
        public int ProductQuantity { get; set; }

        /// <summary>
        /// Rate amount in 3 decimal 12 bytes total digit.
        /// </summary>
        /// <value>Rate amount in 3 decimal 12 bytes total digit.</value>
        [DataMember(Name = "productPrice", EmitDefaultValue = false)]
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// The product description.
        /// </summary>
        /// <value>The product description.</value>
        [DataMember(Name = "productDescription", EmitDefaultValue = false)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Use this to indicate the product code according to the product category list.
        /// </summary>
        /// <value>Use this to indicate the product code according to the product category list.</value>
        [DataMember(Name = "redirectURL", EmitDefaultValue = false)]
        public string RedirectURL { get; set; }

        /// <summary>
        /// Use this to limit card functions to debit cards.
        /// </summary>
        /// <value>Use this to limit card functions to debit cards.</value>
        [DataMember(Name = "limitCardFunctionToDebit", EmitDefaultValue = false)]
        public bool? LimitCardFunctionToDebit { get; set; }

        /// <summary>
        /// Use this to indicate the CUP customer ID if known.
        /// </summary>
        /// <value>Use this to indicate the CUP customer ID if known.</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Use this to indicate the CUP bank ID if known.
        /// </summary>
        /// <value>Use this to indicate the CUP bank ID if known.</value>
        [DataMember(Name = "bankId", EmitDefaultValue = false)]
        public string BankId { get; set; }

        /// <summary>
        /// Use this as unique identifier of WeChat user which is corresponded to the appid of merchant. The field is only applicable for ChinaDomesticPaymentMethod - brand &#x3D; WECHAT_DOMESTIC
        /// </summary>
        /// <value>Use this as unique identifier of WeChat user which is corresponded to the appid of merchant. The field is only applicable for ChinaDomesticPaymentMethod - brand &#x3D; WECHAT_DOMESTIC</value>
        [DataMember(Name = "openId", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChinaDomestic {\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ProductQuantity: ").Append(ProductQuantity).Append("\n");
            sb.Append("  ProductPrice: ").Append(ProductPrice).Append("\n");
            sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
            sb.Append("  RedirectURL: ").Append(RedirectURL).Append("\n");
            sb.Append("  LimitCardFunctionToDebit: ").Append(LimitCardFunctionToDebit).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  BankId: ").Append(BankId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
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
            return this.Equals(input as ChinaDomestic);
        }

        /// <summary>
        /// Returns true if ChinaDomestic instances are equal
        /// </summary>
        /// <param name="input">Instance of ChinaDomestic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChinaDomestic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.ProductQuantity == input.ProductQuantity ||
                    (this.ProductQuantity != null &&
                    this.ProductQuantity.Equals(input.ProductQuantity))
                ) && 
                (
                    this.ProductPrice == input.ProductPrice ||
                    (this.ProductPrice != null &&
                    this.ProductPrice.Equals(input.ProductPrice))
                ) && 
                (
                    this.ProductDescription == input.ProductDescription ||
                    (this.ProductDescription != null &&
                    this.ProductDescription.Equals(input.ProductDescription))
                ) && 
                (
                    this.RedirectURL == input.RedirectURL ||
                    (this.RedirectURL != null &&
                    this.RedirectURL.Equals(input.RedirectURL))
                ) && 
                (
                    this.LimitCardFunctionToDebit == input.LimitCardFunctionToDebit ||
                    (this.LimitCardFunctionToDebit != null &&
                    this.LimitCardFunctionToDebit.Equals(input.LimitCardFunctionToDebit))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.BankId == input.BankId ||
                    (this.BankId != null &&
                    this.BankId.Equals(input.BankId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
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
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.ProductQuantity != null)
                    hashCode = hashCode * 59 + this.ProductQuantity.GetHashCode();
                if (this.ProductPrice != null)
                    hashCode = hashCode * 59 + this.ProductPrice.GetHashCode();
                if (this.ProductDescription != null)
                    hashCode = hashCode * 59 + this.ProductDescription.GetHashCode();
                if (this.RedirectURL != null)
                    hashCode = hashCode * 59 + this.RedirectURL.GetHashCode();
                if (this.LimitCardFunctionToDebit != null)
                    hashCode = hashCode * 59 + this.LimitCardFunctionToDebit.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.BankId != null)
                    hashCode = hashCode * 59 + this.BankId.GetHashCode();
                if (this.OpenId != null)
                    hashCode = hashCode * 59 + this.OpenId.GetHashCode();
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
            // ProductCode (string) maxLength
            if(this.ProductCode != null && this.ProductCode.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductCode, length must be less than 32.", new [] { "ProductCode" });
            }

            // ProductCode (string) pattern
            Regex regexProductCode = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexProductCode.Match(this.ProductCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductCode, must match a pattern of " + regexProductCode, new [] { "ProductCode" });
            }

            // ProductQuantity (int) minimum
            if(this.ProductQuantity < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductQuantity, must be a value greater than or equal to 1.", new [] { "ProductQuantity" });
            }

            // ProductDescription (string) maxLength
            if(this.ProductDescription != null && this.ProductDescription.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductDescription, length must be less than 100.", new [] { "ProductDescription" });
            }

            // ProductDescription (string) pattern
            Regex regexProductDescription = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexProductDescription.Match(this.ProductDescription).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductDescription, must match a pattern of " + regexProductDescription, new [] { "ProductDescription" });
            }

            // RedirectURL (string) maxLength
            if(this.RedirectURL != null && this.RedirectURL.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RedirectURL, length must be less than 1024.", new [] { "RedirectURL" });
            }

            // RedirectURL (string) pattern
            Regex regexRedirectURL = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexRedirectURL.Match(this.RedirectURL).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RedirectURL, must match a pattern of " + regexRedirectURL, new [] { "RedirectURL" });
            }

            // CustomerId (string) maxLength
            if(this.CustomerId != null && this.CustomerId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerId, length must be less than 32.", new [] { "CustomerId" });
            }

            // BankId (string) maxLength
            if(this.BankId != null && this.BankId.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankId, length must be less than 8.", new [] { "BankId" });
            }

            // OpenId (string) maxLength
            if(this.OpenId != null && this.OpenId.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OpenId, length must be less than 128.", new [] { "OpenId" });
            }

            yield break;
        }
    }
}
