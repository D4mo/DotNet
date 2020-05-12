/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.10.1.20200226.002
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
    /// Object contains combined mode branding style properties.
    /// </summary>
    [DataContract]
    public partial class CombinedMode :  IEquatable<CombinedMode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedMode" /> class.
        /// </summary>
        /// <param name="logo">logo.</param>
        /// <param name="background">background.</param>
        /// <param name="text">text.</param>
        /// <param name="button">button.</param>
        public CombinedMode(Logo logo = default(Logo), Background background = default(Background), Text text = default(Text), Button button = default(Button))
        {
            this.Logo = logo;
            this.Background = background;
            this.Text = text;
            this.Button = button;
        }
        
        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public Logo Logo { get; set; }

        /// <summary>
        /// Gets or Sets Background
        /// </summary>
        [DataMember(Name="background", EmitDefaultValue=false)]
        public Background Background { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public Text Text { get; set; }

        /// <summary>
        /// Gets or Sets Button
        /// </summary>
        [DataMember(Name="button", EmitDefaultValue=false)]
        public Button Button { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombinedMode {\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Background: ").Append(Background).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Button: ").Append(Button).Append("\n");
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
            return this.Equals(input as CombinedMode);
        }

        /// <summary>
        /// Returns true if CombinedMode instances are equal
        /// </summary>
        /// <param name="input">Instance of CombinedMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CombinedMode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.Background == input.Background ||
                    (this.Background != null &&
                    this.Background.Equals(input.Background))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Button == input.Button ||
                    (this.Button != null &&
                    this.Button.Equals(input.Button))
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
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.Background != null)
                    hashCode = hashCode * 59 + this.Background.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Button != null)
                    hashCode = hashCode * 59 + this.Button.GetHashCode();
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
