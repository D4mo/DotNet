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
    ///  Class for testing Disbursement
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DisbursementTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Disbursement
        //private Disbursement instance;

        public DisbursementTests()
        {
            // TODO uncomment below to create an instance of Disbursement
            //instance = new Disbursement();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Disbursement
        /// </summary>
        [Fact]
        public void DisbursementInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Disbursement
            //Assert.IsInstanceOfType<Disbursement> (instance, "variable 'instance' is a Disbursement");
        }

        /// <summary>
        /// Test deserialize a FundingTransactionType from type Disbursement
        /// </summary>
        [Fact]
        public void FundingTransactionTypeDeserializeFromDisbursementTest()
        {
            // TODO uncomment below to test deserialize a FundingTransactionType from type Disbursement
            //Assert.IsInstanceOf<Disbursement>(JsonConvert.DeserializeObject<Disbursement>(new FundingTransactionType().ToJson()));
        }
        /// <summary>
        /// Test deserialize a DisbursementTransactionType from type Disbursement
        /// </summary>
        [Fact]
        public void DisbursementTransactionTypeDeserializeFromDisbursementTest()
        {
            // TODO uncomment below to test deserialize a DisbursementTransactionType from type Disbursement
            //Assert.IsInstanceOf<Disbursement>(JsonConvert.DeserializeObject<Disbursement>(new DisbursementTransactionType().ToJson()));
        }

        /// <summary>
        /// Test the property 'DisbursementType'
        /// </summary>
        [Fact]
        public void DisbursementTypeTest()
        {
            // TODO unit test for the property 'DisbursementType'
        }
        /// <summary>
        /// Test the property 'SenderInfo'
        /// </summary>
        [Fact]
        public void SenderInfoTest()
        {
            // TODO unit test for the property 'SenderInfo'
        }
        /// <summary>
        /// Test the property 'ReceiverInfo'
        /// </summary>
        [Fact]
        public void ReceiverInfoTest()
        {
            // TODO unit test for the property 'ReceiverInfo'
        }

    }

}
