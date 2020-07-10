/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.12.0.20200605.001
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
    /// Object contains background style properties.
    /// </summary>
    [DataContract]
    public partial class Background :  IEquatable<Background>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Background" /> class.
        /// </summary>
        /// <param name="topBar">topBar.</param>
        /// <param name="body">body.</param>
        /// <param name="content">content.</param>
        /// <param name="borders">borders.</param>
        public Background(TopBar topBar = default(TopBar), Body body = default(Body), Content content = default(Content), Borders borders = default(Borders))
        {
            this.TopBar = topBar;
            this.Body = body;
            this.Content = content;
            this.Borders = borders;
        }
        
        /// <summary>
        /// Gets or Sets TopBar
        /// </summary>
        [DataMember(Name="topBar", EmitDefaultValue=false)]
        public TopBar TopBar { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public Body Body { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Content Content { get; set; }

        /// <summary>
        /// Gets or Sets Borders
        /// </summary>
        [DataMember(Name="borders", EmitDefaultValue=false)]
        public Borders Borders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Background {\n");
            sb.Append("  TopBar: ").Append(TopBar).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Borders: ").Append(Borders).Append("\n");
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
            return this.Equals(input as Background);
        }

        /// <summary>
        /// Returns true if Background instances are equal
        /// </summary>
        /// <param name="input">Instance of Background to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Background input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopBar == input.TopBar ||
                    (this.TopBar != null &&
                    this.TopBar.Equals(input.TopBar))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Borders == input.Borders ||
                    (this.Borders != null &&
                    this.Borders.Equals(input.Borders))
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
                if (this.TopBar != null)
                    hashCode = hashCode * 59 + this.TopBar.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Borders != null)
                    hashCode = hashCode * 59 + this.Borders.GetHashCode();
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
