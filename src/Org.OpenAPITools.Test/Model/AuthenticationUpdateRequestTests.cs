/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.2.0.20210406.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing AuthenticationUpdateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AuthenticationUpdateRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AuthenticationUpdateRequest
        //private AuthenticationUpdateRequest instance;

        public AuthenticationUpdateRequestTests()
        {
            // TODO uncomment below to create an instance of AuthenticationUpdateRequest
            //instance = new AuthenticationUpdateRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthenticationUpdateRequest
        /// </summary>
        [Fact]
        public void AuthenticationUpdateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AuthenticationUpdateRequest
            //Assert.IsInstanceOfType<AuthenticationUpdateRequest> (instance, "variable 'instance' is a AuthenticationUpdateRequest");
        }

        /// <summary>
        /// Test deserialize a Secure3D10AuthenticationUpdateRequest from type AuthenticationUpdateRequest
        /// </summary>
        [Fact]
        public void Secure3D10AuthenticationUpdateRequestDeserializeFromAuthenticationUpdateRequestTest()
        {
            // TODO uncomment below to test deserialize a Secure3D10AuthenticationUpdateRequest from type AuthenticationUpdateRequest
            //Assert.IsInstanceOf<AuthenticationUpdateRequest>(JsonConvert.DeserializeObject<AuthenticationUpdateRequest>(new Secure3D10AuthenticationUpdateRequest().ToJson()));
        }
        /// <summary>
        /// Test deserialize a Secure3D21AuthenticationUpdateRequest from type AuthenticationUpdateRequest
        /// </summary>
        [Fact]
        public void Secure3D21AuthenticationUpdateRequestDeserializeFromAuthenticationUpdateRequestTest()
        {
            // TODO uncomment below to test deserialize a Secure3D21AuthenticationUpdateRequest from type AuthenticationUpdateRequest
            //Assert.IsInstanceOf<AuthenticationUpdateRequest>(JsonConvert.DeserializeObject<AuthenticationUpdateRequest>(new Secure3D21AuthenticationUpdateRequest().ToJson()));
        }
        /// <summary>
        /// Test deserialize a Secure3DAuthenticationUpdateRequest from type AuthenticationUpdateRequest
        /// </summary>
        [Fact]
        public void Secure3DAuthenticationUpdateRequestDeserializeFromAuthenticationUpdateRequestTest()
        {
            // TODO uncomment below to test deserialize a Secure3DAuthenticationUpdateRequest from type AuthenticationUpdateRequest
            //Assert.IsInstanceOf<AuthenticationUpdateRequest>(JsonConvert.DeserializeObject<AuthenticationUpdateRequest>(new Secure3DAuthenticationUpdateRequest().ToJson()));
        }
        /// <summary>
        /// Test deserialize a UnionPayAuthenticationUpdateRequest from type AuthenticationUpdateRequest
        /// </summary>
        [Fact]
        public void UnionPayAuthenticationUpdateRequestDeserializeFromAuthenticationUpdateRequestTest()
        {
            // TODO uncomment below to test deserialize a UnionPayAuthenticationUpdateRequest from type AuthenticationUpdateRequest
            //Assert.IsInstanceOf<AuthenticationUpdateRequest>(JsonConvert.DeserializeObject<AuthenticationUpdateRequest>(new UnionPayAuthenticationUpdateRequest().ToJson()));
        }

        /// <summary>
        /// Test the property 'StoreId'
        /// </summary>
        [Fact]
        public void StoreIdTest()
        {
            // TODO unit test for the property 'StoreId'
        }
        /// <summary>
        /// Test the property 'AuthenticationType'
        /// </summary>
        [Fact]
        public void AuthenticationTypeTest()
        {
            // TODO unit test for the property 'AuthenticationType'
        }
        /// <summary>
        /// Test the property 'BillingAddress'
        /// </summary>
        [Fact]
        public void BillingAddressTest()
        {
            // TODO unit test for the property 'BillingAddress'
        }

    }

}
