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
    /// Product details.
    /// </summary>
    [DataContract]
    public partial class FraudOrderItems : IEquatable<FraudOrderItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudOrderItems" /> class.
        /// </summary>
        /// <param name="id">A unique ID associated with the product. Must be unique within the merchant&#39;s system..</param>
        /// <param name="name">A name or short description of the product..</param>
        /// <param name="quantity">The unit in which the product is sold (e.g. litre, kilogram, etc). Leave empty if the product is sold as a complete unit..</param>
        /// <param name="unit">The number of units sold. Set to 1 if there is only one unit of the item. Leave empty if the quantity is unknown at the time of the request..</param>
        /// <param name="unitPrice">The price per unit..</param>
        /// <param name="categories">The categories that this product belongs to..</param>
        /// <param name="detailsUrl">The URL to the merchant&#39;s management system, for reporting and analysis..</param>
        /// <param name="userDefined">A JSON object that can carry any additional information about the order that might be helpful for fraud detection..</param>
        public FraudOrderItems(string id = default(string), string name = default(string), string quantity = default(string), string unit = default(string), string unitPrice = default(string), List<List<string>> categories = default(List<List<string>>), string detailsUrl = default(string), Object userDefined = default(Object))
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Unit = unit;
            this.UnitPrice = unitPrice;
            this.Categories = categories;
            this.DetailsUrl = detailsUrl;
            this.UserDefined = userDefined;
        }

        /// <summary>
        /// A unique ID associated with the product. Must be unique within the merchant&#39;s system.
        /// </summary>
        /// <value>A unique ID associated with the product. Must be unique within the merchant&#39;s system.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A name or short description of the product.
        /// </summary>
        /// <value>A name or short description of the product.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The unit in which the product is sold (e.g. litre, kilogram, etc). Leave empty if the product is sold as a complete unit.
        /// </summary>
        /// <value>The unit in which the product is sold (e.g. litre, kilogram, etc). Leave empty if the product is sold as a complete unit.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// The number of units sold. Set to 1 if there is only one unit of the item. Leave empty if the quantity is unknown at the time of the request.
        /// </summary>
        /// <value>The number of units sold. Set to 1 if there is only one unit of the item. Leave empty if the quantity is unknown at the time of the request.</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// The price per unit.
        /// </summary>
        /// <value>The price per unit.</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// The categories that this product belongs to.
        /// </summary>
        /// <value>The categories that this product belongs to.</value>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<List<string>> Categories { get; set; }

        /// <summary>
        /// The URL to the merchant&#39;s management system, for reporting and analysis.
        /// </summary>
        /// <value>The URL to the merchant&#39;s management system, for reporting and analysis.</value>
        [DataMember(Name = "detailsUrl", EmitDefaultValue = false)]
        public string DetailsUrl { get; set; }

        /// <summary>
        /// A JSON object that can carry any additional information about the order that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that can carry any additional information about the order that might be helpful for fraud detection.</value>
        [DataMember(Name = "userDefined", EmitDefaultValue = false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudOrderItems {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  DetailsUrl: ").Append(DetailsUrl).Append("\n");
            sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
            return this.Equals(input as FraudOrderItems);
        }

        /// <summary>
        /// Returns true if FraudOrderItems instances are equal
        /// </summary>
        /// <param name="input">Instance of FraudOrderItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudOrderItems input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.DetailsUrl == input.DetailsUrl ||
                    (this.DetailsUrl != null &&
                    this.DetailsUrl.Equals(input.DetailsUrl))
                ) && 
                (
                    this.UserDefined == input.UserDefined ||
                    (this.UserDefined != null &&
                    this.UserDefined.Equals(input.UserDefined))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.DetailsUrl != null)
                    hashCode = hashCode * 59 + this.DetailsUrl.GetHashCode();
                if (this.UserDefined != null)
                    hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
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
