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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Provides shared fields for all AuthenticationUpdateRequest types. Abstract class, do not use this class directly, use one of its children.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "AuthenticationType")]
    [JsonSubtypes.KnownSubType(typeof(UnionPayAuthenticationUpdateRequest), "UnionPayAuthenticationUpdateRequest")]
    [JsonSubtypes.KnownSubType(typeof(Secure3D10AuthenticationUpdateRequest), "Secure3D10AuthenticationUpdateRequest")]
    [JsonSubtypes.KnownSubType(typeof(Secure3D21AuthenticationUpdateRequest), "Secure3D21AuthenticationUpdateRequest")]
    [JsonSubtypes.KnownSubType(typeof(Secure3DAuthenticationUpdateRequest), "Secure3DAuthenticationUpdateRequest")]
    public partial class AuthenticationUpdateRequest : IEquatable<AuthenticationUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticationUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationUpdateRequest" /> class.
        /// </summary>
        /// <param name="storeId">An optional Outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="authenticationType">Object name of the authentication update request. (required).</param>
        /// <param name="billingAddress">billingAddress.</param>
        public AuthenticationUpdateRequest(string storeId = default(string), string authenticationType = default(string), Address billingAddress = default(Address))
        {
            // to ensure "authenticationType" is required (not null)
            this.AuthenticationType = authenticationType ?? throw new ArgumentNullException("authenticationType is a required property for AuthenticationUpdateRequest and cannot be null");
            this.StoreId = storeId;
            this.BillingAddress = billingAddress;
        }

        /// <summary>
        /// An optional Outlet ID for clients that support multiple stores in the same developer app.
        /// </summary>
        /// <value>An optional Outlet ID for clients that support multiple stores in the same developer app.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Object name of the authentication update request.
        /// </summary>
        /// <value>Object name of the authentication update request.</value>
        [DataMember(Name = "authenticationType", EmitDefaultValue = false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationUpdateRequest {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
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
            return this.Equals(input as AuthenticationUpdateRequest);
        }

        /// <summary>
        /// Returns true if AuthenticationUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    (this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(input.AuthenticationType))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
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
                if (this.StoreId != null)
                    hashCode = hashCode * 59 + this.StoreId.GetHashCode();
                if (this.AuthenticationType != null)
                    hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            // StoreId (string) maxLength
            if(this.StoreId != null && this.StoreId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoreId, length must be less than 20.", new [] { "StoreId" });
            }

            yield break;
        }
    }
}
