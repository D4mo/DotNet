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
    /// The type of connect mode.
    /// </summary>
    /// <value>The type of connect mode.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ConnectMode
    {
        /// <summary>
        /// Enum Classic for value: Classic
        /// </summary>
        [EnumMember(Value = "Classic")]
        Classic = 1,

        /// <summary>
        /// Enum Combined for value: Combined
        /// </summary>
        [EnumMember(Value = "Combined")]
        Combined = 2

    }

}
