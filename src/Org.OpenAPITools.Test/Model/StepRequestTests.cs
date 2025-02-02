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
    ///  Class for testing StepRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class StepRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for StepRequest
        //private StepRequest instance;

        public StepRequestTests()
        {
            // TODO uncomment below to create an instance of StepRequest
            //instance = new StepRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StepRequest
        /// </summary>
        [Fact]
        public void StepRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" StepRequest
            //Assert.IsInstanceOfType<StepRequest> (instance, "variable 'instance' is a StepRequest");
        }

        /// <summary>
        /// Test deserialize a PaymentStepRequest from type StepRequest
        /// </summary>
        [Fact]
        public void PaymentStepRequestDeserializeFromStepRequestTest()
        {
            // TODO uncomment below to test deserialize a PaymentStepRequest from type StepRequest
            //Assert.IsInstanceOf<StepRequest>(JsonConvert.DeserializeObject<StepRequest>(new PaymentStepRequest().ToJson()));
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}
