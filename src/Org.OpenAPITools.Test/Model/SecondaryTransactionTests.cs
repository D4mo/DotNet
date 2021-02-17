/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.1.0.20210122.001
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
    ///  Class for testing SecondaryTransaction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SecondaryTransactionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SecondaryTransaction
        //private SecondaryTransaction instance;

        public SecondaryTransactionTests()
        {
            // TODO uncomment below to create an instance of SecondaryTransaction
            //instance = new SecondaryTransaction();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecondaryTransaction
        /// </summary>
        [Fact]
        public void SecondaryTransactionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" SecondaryTransaction
            //Assert.IsInstanceOfType<SecondaryTransaction> (instance, "variable 'instance' is a SecondaryTransaction");
        }

        /// <summary>
        /// Test deserialize a AchVoidTransaction from type SecondaryTransaction
        /// </summary>
        [Fact]
        public void AchVoidTransactionDeserializeFromSecondaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a AchVoidTransaction from type SecondaryTransaction
            //Assert.IsInstanceOf<SecondaryTransaction>(JsonConvert.DeserializeObject<SecondaryTransaction>(new AchVoidTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a AchPostAuthTransaction from type SecondaryTransaction
        /// </summary>
        [Fact]
        public void AchPostAuthTransactionDeserializeFromSecondaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a AchPostAuthTransaction from type SecondaryTransaction
            //Assert.IsInstanceOf<SecondaryTransaction>(JsonConvert.DeserializeObject<SecondaryTransaction>(new AchPostAuthTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a VoidPreAuthTransactions from type SecondaryTransaction
        /// </summary>
        [Fact]
        public void VoidPreAuthTransactionsDeserializeFromSecondaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a VoidPreAuthTransactions from type SecondaryTransaction
            //Assert.IsInstanceOf<SecondaryTransaction>(JsonConvert.DeserializeObject<SecondaryTransaction>(new VoidPreAuthTransactions().ToJson()));
        }
        /// <summary>
        /// Test deserialize a ReturnTransaction from type SecondaryTransaction
        /// </summary>
        [Fact]
        public void ReturnTransactionDeserializeFromSecondaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a ReturnTransaction from type SecondaryTransaction
            //Assert.IsInstanceOf<SecondaryTransaction>(JsonConvert.DeserializeObject<SecondaryTransaction>(new ReturnTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a AchReturnTransaction from type SecondaryTransaction
        /// </summary>
        [Fact]
        public void AchReturnTransactionDeserializeFromSecondaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a AchReturnTransaction from type SecondaryTransaction
            //Assert.IsInstanceOf<SecondaryTransaction>(JsonConvert.DeserializeObject<SecondaryTransaction>(new AchReturnTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a VoidTransaction from type SecondaryTransaction
        /// </summary>
        [Fact]
        public void VoidTransactionDeserializeFromSecondaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a VoidTransaction from type SecondaryTransaction
            //Assert.IsInstanceOf<SecondaryTransaction>(JsonConvert.DeserializeObject<SecondaryTransaction>(new VoidTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PostAuthTransaction from type SecondaryTransaction
        /// </summary>
        [Fact]
        public void PostAuthTransactionDeserializeFromSecondaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PostAuthTransaction from type SecondaryTransaction
            //Assert.IsInstanceOf<SecondaryTransaction>(JsonConvert.DeserializeObject<SecondaryTransaction>(new PostAuthTransaction().ToJson()));
        }

        /// <summary>
        /// Test the property 'RequestType'
        /// </summary>
        [Fact]
        public void RequestTypeTest()
        {
            // TODO unit test for the property 'RequestType'
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
        /// Test the property 'MerchantTransactionId'
        /// </summary>
        [Fact]
        public void MerchantTransactionIdTest()
        {
            // TODO unit test for the property 'MerchantTransactionId'
        }
        /// <summary>
        /// Test the property 'Comments'
        /// </summary>
        [Fact]
        public void CommentsTest()
        {
            // TODO unit test for the property 'Comments'
        }
        /// <summary>
        /// Test the property 'Order'
        /// </summary>
        [Fact]
        public void OrderTest()
        {
            // TODO unit test for the property 'Order'
        }

    }

}
