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
    /// The device where this transaction originated.
    /// </summary>
    [DataContract]
    public partial class Device : IEquatable<Device>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of this object.
        /// </summary>
        /// <value>Defines the type of this object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            /// <summary>
            /// Enum Pos for value: device/pos
            /// </summary>
            [EnumMember(Value = "device/pos")]
            Pos = 1,

            /// <summary>
            /// Enum Mobile for value: device/mobile
            /// </summary>
            [EnumMember(Value = "device/mobile")]
            Mobile = 2

        }

        /// <summary>
        /// Defines the type of this object.
        /// </summary>
        /// <value>Defines the type of this object.</value>
        [DataMember(Name = "deviceType", EmitDefaultValue = false)]
        public DeviceTypeEnum DeviceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Device() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        /// <param name="deviceType">Defines the type of this object. (required).</param>
        /// <param name="deviceId">The unique ID of the device. Must be unique for the entire system (not just within a specific merchant or industry). (required).</param>
        /// <param name="networks">Information about the networks associated with the device..</param>
        /// <param name="latitude">The GPS decimal latitude, ranging from (-90.0 to 90.0) where positive numbers indicate locations North of the equator..</param>
        /// <param name="longitude">The GPS decimal longitude, ranging from (-180.0 to 180.0) where positive numbers indicate locations East of the IERS Reference Meridian..</param>
        /// <param name="imei">The device&#39;s International Mobile Equipment Identity (IMEI) as described in IETF RFC7254..</param>
        /// <param name="model">The device&#39;s model name..</param>
        /// <param name="manufacturer">The device&#39;s manufacturer..</param>
        /// <param name="timezoneOffset">The timezone offset from UTC to the devices timezone configuration, specified in the format +hh:mm..</param>
        /// <param name="rooted">A flag indicating that the device has been altered to allow privileged access to users. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise..</param>
        /// <param name="malwareDetected">A flag indicating that malware was detected on the mobile phone. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise..</param>
        /// <param name="userDefined">A JSON object that can carry any additional information about the device that might be helpful for fraud detection..</param>
        public Device(DeviceTypeEnum deviceType = default(DeviceTypeEnum), string deviceId = default(string), List<Items> networks = default(List<Items>), decimal latitude = default(decimal), decimal longitude = default(decimal), string imei = default(string), string model = default(string), string manufacturer = default(string), string timezoneOffset = default(string), bool rooted = default(bool), bool malwareDetected = default(bool), Object userDefined = default(Object))
        {
            // to ensure "deviceType" is required (not null)
            this.DeviceType = deviceType;
            // to ensure "deviceId" is required (not null)
            this.DeviceId = deviceId ?? throw new ArgumentNullException("deviceId is a required property for Device and cannot be null");
            this.Networks = networks;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Imei = imei;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.TimezoneOffset = timezoneOffset;
            this.Rooted = rooted;
            this.MalwareDetected = malwareDetected;
            this.UserDefined = userDefined;
        }

        /// <summary>
        /// The unique ID of the device. Must be unique for the entire system (not just within a specific merchant or industry).
        /// </summary>
        /// <value>The unique ID of the device. Must be unique for the entire system (not just within a specific merchant or industry).</value>
        [DataMember(Name = "deviceId", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Information about the networks associated with the device.
        /// </summary>
        /// <value>Information about the networks associated with the device.</value>
        [DataMember(Name = "networks", EmitDefaultValue = false)]
        public List<Items> Networks { get; set; }

        /// <summary>
        /// The GPS decimal latitude, ranging from (-90.0 to 90.0) where positive numbers indicate locations North of the equator.
        /// </summary>
        /// <value>The GPS decimal latitude, ranging from (-90.0 to 90.0) where positive numbers indicate locations North of the equator.</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public decimal Latitude { get; set; }

        /// <summary>
        /// The GPS decimal longitude, ranging from (-180.0 to 180.0) where positive numbers indicate locations East of the IERS Reference Meridian.
        /// </summary>
        /// <value>The GPS decimal longitude, ranging from (-180.0 to 180.0) where positive numbers indicate locations East of the IERS Reference Meridian.</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public decimal Longitude { get; set; }

        /// <summary>
        /// The device&#39;s International Mobile Equipment Identity (IMEI) as described in IETF RFC7254.
        /// </summary>
        /// <value>The device&#39;s International Mobile Equipment Identity (IMEI) as described in IETF RFC7254.</value>
        [DataMember(Name = "imei", EmitDefaultValue = false)]
        public string Imei { get; set; }

        /// <summary>
        /// The device&#39;s model name.
        /// </summary>
        /// <value>The device&#39;s model name.</value>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public string Model { get; set; }

        /// <summary>
        /// The device&#39;s manufacturer.
        /// </summary>
        /// <value>The device&#39;s manufacturer.</value>
        [DataMember(Name = "manufacturer", EmitDefaultValue = false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The timezone offset from UTC to the devices timezone configuration, specified in the format +hh:mm.
        /// </summary>
        /// <value>The timezone offset from UTC to the devices timezone configuration, specified in the format +hh:mm.</value>
        [DataMember(Name = "timezoneOffset", EmitDefaultValue = false)]
        public string TimezoneOffset { get; set; }

        /// <summary>
        /// A flag indicating that the device has been altered to allow privileged access to users. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise.
        /// </summary>
        /// <value>A flag indicating that the device has been altered to allow privileged access to users. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise.</value>
        [DataMember(Name = "rooted", EmitDefaultValue = false)]
        public bool? Rooted { get; set; }

        /// <summary>
        /// A flag indicating that malware was detected on the mobile phone. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise.
        /// </summary>
        /// <value>A flag indicating that malware was detected on the mobile phone. This flag should only be set to false if a test was performed and the result was negative. Leave unset otherwise.</value>
        [DataMember(Name = "malwareDetected", EmitDefaultValue = false)]
        public bool? MalwareDetected { get; set; }

        /// <summary>
        /// A JSON object that can carry any additional information about the device that might be helpful for fraud detection.
        /// </summary>
        /// <value>A JSON object that can carry any additional information about the device that might be helpful for fraud detection.</value>
        [DataMember(Name = "userDefined", EmitDefaultValue = false)]
        public Object UserDefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Device {\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Networks: ").Append(Networks).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Imei: ").Append(Imei).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  TimezoneOffset: ").Append(TimezoneOffset).Append("\n");
            sb.Append("  Rooted: ").Append(Rooted).Append("\n");
            sb.Append("  MalwareDetected: ").Append(MalwareDetected).Append("\n");
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
            return this.Equals(input as Device);
        }

        /// <summary>
        /// Returns true if Device instances are equal
        /// </summary>
        /// <param name="input">Instance of Device to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Device input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.Networks == input.Networks ||
                    this.Networks != null &&
                    input.Networks != null &&
                    this.Networks.SequenceEqual(input.Networks)
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Imei == input.Imei ||
                    (this.Imei != null &&
                    this.Imei.Equals(input.Imei))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.TimezoneOffset == input.TimezoneOffset ||
                    (this.TimezoneOffset != null &&
                    this.TimezoneOffset.Equals(input.TimezoneOffset))
                ) && 
                (
                    this.Rooted == input.Rooted ||
                    (this.Rooted != null &&
                    this.Rooted.Equals(input.Rooted))
                ) && 
                (
                    this.MalwareDetected == input.MalwareDetected ||
                    (this.MalwareDetected != null &&
                    this.MalwareDetected.Equals(input.MalwareDetected))
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
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.Networks != null)
                    hashCode = hashCode * 59 + this.Networks.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Imei != null)
                    hashCode = hashCode * 59 + this.Imei.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.TimezoneOffset != null)
                    hashCode = hashCode * 59 + this.TimezoneOffset.GetHashCode();
                if (this.Rooted != null)
                    hashCode = hashCode * 59 + this.Rooted.GetHashCode();
                if (this.MalwareDetected != null)
                    hashCode = hashCode * 59 + this.MalwareDetected.GetHashCode();
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
            // DeviceId (string) pattern
            Regex regexDeviceId = new Regex(@"^(?!\\s*$).+", RegexOptions.CultureInvariant);
            if (false == regexDeviceId.Match(this.DeviceId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeviceId, must match a pattern of " + regexDeviceId, new [] { "DeviceId" });
            }

            yield break;
        }
    }
}
