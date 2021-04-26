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
    /// Merchant supplied tracking numbers.
    /// </summary>
    [DataContract]
    public partial class AdditionalDetails : IEquatable<AdditionalDetails>, IValidatableObject
    {
        /// <summary>
        /// Strong customer authentication exemption type indicator.
        /// </summary>
        /// <value>Strong customer authentication exemption type indicator.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScaExemptionTypeEnum
        {
            /// <summary>
            /// Enum LowValueExemption for value: Low Value Exemption
            /// </summary>
            [EnumMember(Value = "Low Value Exemption")]
            LowValueExemption = 1,

            /// <summary>
            /// Enum TRAExemption for value: TRA Exemption
            /// </summary>
            [EnumMember(Value = "TRA Exemption")]
            TRAExemption = 2,

            /// <summary>
            /// Enum TrustedMerchantExemption for value: Trusted Merchant Exemption
            /// </summary>
            [EnumMember(Value = "Trusted Merchant Exemption")]
            TrustedMerchantExemption = 3,

            /// <summary>
            /// Enum SCPExemption for value: SCP Exemption
            /// </summary>
            [EnumMember(Value = "SCP Exemption")]
            SCPExemption = 4,

            /// <summary>
            /// Enum DelegatedAuthentication for value: Delegated Authentication
            /// </summary>
            [EnumMember(Value = "Delegated Authentication")]
            DelegatedAuthentication = 5

        }

        /// <summary>
        /// Strong customer authentication exemption type indicator.
        /// </summary>
        /// <value>Strong customer authentication exemption type indicator.</value>
        [DataMember(Name = "scaExemptionType", EmitDefaultValue = false)]
        public ScaExemptionTypeEnum? ScaExemptionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDetails" /> class.
        /// </summary>
        /// <param name="comments">Comments for the payment..</param>
        /// <param name="invoiceNumber">Invoice number..</param>
        /// <param name="purchaseOrderNumber">Purchase order number..</param>
        /// <param name="operatorId">The operator ID..</param>
        /// <param name="salesSystemId">The sales system ID..</param>
        /// <param name="ipgDeferredAuth">Indicates if the particular transaction is a deferred authorization..</param>
        /// <param name="highRiskPurchaseIndicator">this is highRiskPurchaseIndicator..</param>
        /// <param name="receipts">Provides request information that is necessary to generate receipts..</param>
        /// <param name="scaExemptionType">Strong customer authentication exemption type indicator..</param>
        /// <param name="scaVisaMerchantID">Eight-character Visa merchant identifier (VMID) assigned by Visa, required for trusted merchant and delegated authentication..</param>
        public AdditionalDetails(string comments = default(string), string invoiceNumber = default(string), string purchaseOrderNumber = default(string), string operatorId = default(string), string salesSystemId = default(string), bool ipgDeferredAuth = default(bool), bool highRiskPurchaseIndicator = default(bool), List<ReceiptRequestInfo> receipts = default(List<ReceiptRequestInfo>), ScaExemptionTypeEnum? scaExemptionType = null, string scaVisaMerchantID = default(string))
        {
            this.Comments = comments;
            this.InvoiceNumber = invoiceNumber;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.OperatorId = operatorId;
            this.SalesSystemId = salesSystemId;
            this.IpgDeferredAuth = ipgDeferredAuth;
            this.HighRiskPurchaseIndicator = highRiskPurchaseIndicator;
            this.Receipts = receipts;
            this.ScaExemptionType = scaExemptionType;
            this.ScaVisaMerchantID = scaVisaMerchantID;
        }

        /// <summary>
        /// Comments for the payment.
        /// </summary>
        /// <value>Comments for the payment.</value>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        /// <summary>
        /// Invoice number.
        /// </summary>
        /// <value>Invoice number.</value>
        [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Purchase order number.
        /// </summary>
        /// <value>Purchase order number.</value>
        [DataMember(Name = "purchaseOrderNumber", EmitDefaultValue = false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The operator ID.
        /// </summary>
        /// <value>The operator ID.</value>
        [DataMember(Name = "operatorId", EmitDefaultValue = false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// The sales system ID.
        /// </summary>
        /// <value>The sales system ID.</value>
        [DataMember(Name = "salesSystemId", EmitDefaultValue = false)]
        public string SalesSystemId { get; set; }

        /// <summary>
        /// Indicates if the particular transaction is a deferred authorization.
        /// </summary>
        /// <value>Indicates if the particular transaction is a deferred authorization.</value>
        [DataMember(Name = "ipgDeferredAuth", EmitDefaultValue = false)]
        public bool IpgDeferredAuth { get; set; }

        /// <summary>
        /// this is highRiskPurchaseIndicator.
        /// </summary>
        /// <value>this is highRiskPurchaseIndicator.</value>
        [DataMember(Name = "highRiskPurchaseIndicator", EmitDefaultValue = false)]
        public bool HighRiskPurchaseIndicator { get; set; }

        /// <summary>
        /// Provides request information that is necessary to generate receipts.
        /// </summary>
        /// <value>Provides request information that is necessary to generate receipts.</value>
        [DataMember(Name = "receipts", EmitDefaultValue = false)]
        public List<ReceiptRequestInfo> Receipts { get; set; }

        /// <summary>
        /// Eight-character Visa merchant identifier (VMID) assigned by Visa, required for trusted merchant and delegated authentication.
        /// </summary>
        /// <value>Eight-character Visa merchant identifier (VMID) assigned by Visa, required for trusted merchant and delegated authentication.</value>
        [DataMember(Name = "scaVisaMerchantID", EmitDefaultValue = false)]
        public string ScaVisaMerchantID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalDetails {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  OperatorId: ").Append(OperatorId).Append("\n");
            sb.Append("  SalesSystemId: ").Append(SalesSystemId).Append("\n");
            sb.Append("  IpgDeferredAuth: ").Append(IpgDeferredAuth).Append("\n");
            sb.Append("  HighRiskPurchaseIndicator: ").Append(HighRiskPurchaseIndicator).Append("\n");
            sb.Append("  Receipts: ").Append(Receipts).Append("\n");
            sb.Append("  ScaExemptionType: ").Append(ScaExemptionType).Append("\n");
            sb.Append("  ScaVisaMerchantID: ").Append(ScaVisaMerchantID).Append("\n");
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
            return this.Equals(input as AdditionalDetails);
        }

        /// <summary>
        /// Returns true if AdditionalDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.PurchaseOrderNumber == input.PurchaseOrderNumber ||
                    (this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(input.PurchaseOrderNumber))
                ) && 
                (
                    this.OperatorId == input.OperatorId ||
                    (this.OperatorId != null &&
                    this.OperatorId.Equals(input.OperatorId))
                ) && 
                (
                    this.SalesSystemId == input.SalesSystemId ||
                    (this.SalesSystemId != null &&
                    this.SalesSystemId.Equals(input.SalesSystemId))
                ) && 
                (
                    this.IpgDeferredAuth == input.IpgDeferredAuth ||
                    (this.IpgDeferredAuth != null &&
                    this.IpgDeferredAuth.Equals(input.IpgDeferredAuth))
                ) && 
                (
                    this.HighRiskPurchaseIndicator == input.HighRiskPurchaseIndicator ||
                    (this.HighRiskPurchaseIndicator != null &&
                    this.HighRiskPurchaseIndicator.Equals(input.HighRiskPurchaseIndicator))
                ) && 
                (
                    this.Receipts == input.Receipts ||
                    this.Receipts != null &&
                    input.Receipts != null &&
                    this.Receipts.SequenceEqual(input.Receipts)
                ) && 
                (
                    this.ScaExemptionType == input.ScaExemptionType ||
                    (this.ScaExemptionType != null &&
                    this.ScaExemptionType.Equals(input.ScaExemptionType))
                ) && 
                (
                    this.ScaVisaMerchantID == input.ScaVisaMerchantID ||
                    (this.ScaVisaMerchantID != null &&
                    this.ScaVisaMerchantID.Equals(input.ScaVisaMerchantID))
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
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.OperatorId != null)
                    hashCode = hashCode * 59 + this.OperatorId.GetHashCode();
                if (this.SalesSystemId != null)
                    hashCode = hashCode * 59 + this.SalesSystemId.GetHashCode();
                if (this.IpgDeferredAuth != null)
                    hashCode = hashCode * 59 + this.IpgDeferredAuth.GetHashCode();
                if (this.HighRiskPurchaseIndicator != null)
                    hashCode = hashCode * 59 + this.HighRiskPurchaseIndicator.GetHashCode();
                if (this.Receipts != null)
                    hashCode = hashCode * 59 + this.Receipts.GetHashCode();
                if (this.ScaExemptionType != null)
                    hashCode = hashCode * 59 + this.ScaExemptionType.GetHashCode();
                if (this.ScaVisaMerchantID != null)
                    hashCode = hashCode * 59 + this.ScaVisaMerchantID.GetHashCode();
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
            // Comments (string) maxLength
            if(this.Comments != null && this.Comments.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be less than 1024.", new [] { "Comments" });
            }

            // InvoiceNumber (string) maxLength
            if(this.InvoiceNumber != null && this.InvoiceNumber.Length > 48)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InvoiceNumber, length must be less than 48.", new [] { "InvoiceNumber" });
            }

            // PurchaseOrderNumber (string) maxLength
            if(this.PurchaseOrderNumber != null && this.PurchaseOrderNumber.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseOrderNumber, length must be less than 128.", new [] { "PurchaseOrderNumber" });
            }

            // OperatorId (string) maxLength
            if(this.OperatorId != null && this.OperatorId.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperatorId, length must be less than 35.", new [] { "OperatorId" });
            }

            // OperatorId (string) pattern
            Regex regexOperatorId = new Regex(@"^\\S$|^\\S.*\\S$", RegexOptions.CultureInvariant);
            if (false == regexOperatorId.Match(this.OperatorId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperatorId, must match a pattern of " + regexOperatorId, new [] { "OperatorId" });
            }

            // SalesSystemId (string) maxLength
            if(this.SalesSystemId != null && this.SalesSystemId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesSystemId, length must be less than 50.", new [] { "SalesSystemId" });
            }

            // SalesSystemId (string) pattern
            Regex regexSalesSystemId = new Regex(@"^\\S$|^\\S.*\\S$", RegexOptions.CultureInvariant);
            if (false == regexSalesSystemId.Match(this.SalesSystemId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesSystemId, must match a pattern of " + regexSalesSystemId, new [] { "SalesSystemId" });
            }

            // ScaVisaMerchantID (string) maxLength
            if(this.ScaVisaMerchantID != null && this.ScaVisaMerchantID.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScaVisaMerchantID, length must be less than 8.", new [] { "ScaVisaMerchantID" });
            }

            yield break;
        }
    }
}
