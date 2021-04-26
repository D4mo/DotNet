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
    ///  Class for testing TransactionErrorResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TransactionErrorResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TransactionErrorResponse
        //private TransactionErrorResponse instance;

        public TransactionErrorResponseTests()
        {
            // TODO uncomment below to create an instance of TransactionErrorResponse
            //instance = new TransactionErrorResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransactionErrorResponse
        /// </summary>
        [Fact]
        public void TransactionErrorResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TransactionErrorResponse
            //Assert.IsInstanceOfType<TransactionErrorResponse> (instance, "variable 'instance' is a TransactionErrorResponse");
        }


        /// <summary>
        /// Test the property 'ClientRequestId'
        /// </summary>
        [Fact]
        public void ClientRequestIdTest()
        {
            // TODO unit test for the property 'ClientRequestId'
        }
        /// <summary>
        /// Test the property 'ApiTraceId'
        /// </summary>
        [Fact]
        public void ApiTraceIdTest()
        {
            // TODO unit test for the property 'ApiTraceId'
        }
        /// <summary>
        /// Test the property 'ResponseType'
        /// </summary>
        [Fact]
        public void ResponseTypeTest()
        {
            // TODO unit test for the property 'ResponseType'
        }
        /// <summary>
        /// Test the property 'IpgTransactionId'
        /// </summary>
        [Fact]
        public void IpgTransactionIdTest()
        {
            // TODO unit test for the property 'IpgTransactionId'
        }
        /// <summary>
        /// Test the property 'OrderId'
        /// </summary>
        [Fact]
        public void OrderIdTest()
        {
            // TODO unit test for the property 'OrderId'
        }
        /// <summary>
        /// Test the property 'TransactionType'
        /// </summary>
        [Fact]
        public void TransactionTypeTest()
        {
            // TODO unit test for the property 'TransactionType'
        }
        /// <summary>
        /// Test the property 'PaymentToken'
        /// </summary>
        [Fact]
        public void PaymentTokenTest()
        {
            // TODO unit test for the property 'PaymentToken'
        }
        /// <summary>
        /// Test the property 'TransactionOrigin'
        /// </summary>
        [Fact]
        public void TransactionOriginTest()
        {
            // TODO unit test for the property 'TransactionOrigin'
        }
        /// <summary>
        /// Test the property 'PaymentMethodDetails'
        /// </summary>
        [Fact]
        public void PaymentMethodDetailsTest()
        {
            // TODO unit test for the property 'PaymentMethodDetails'
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'TerminalId'
        /// </summary>
        [Fact]
        public void TerminalIdTest()
        {
            // TODO unit test for the property 'TerminalId'
        }
        /// <summary>
        /// Test the property 'MerchantId'
        /// </summary>
        [Fact]
        public void MerchantIdTest()
        {
            // TODO unit test for the property 'MerchantId'
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
        /// Test the property 'TransactionTime'
        /// </summary>
        [Fact]
        public void TransactionTimeTest()
        {
            // TODO unit test for the property 'TransactionTime'
        }
        /// <summary>
        /// Test the property 'ApprovedAmount'
        /// </summary>
        [Fact]
        public void ApprovedAmountTest()
        {
            // TODO unit test for the property 'ApprovedAmount'
        }
        /// <summary>
        /// Test the property 'TransactionStatus'
        /// </summary>
        [Fact]
        public void TransactionStatusTest()
        {
            // TODO unit test for the property 'TransactionStatus'
        }
        /// <summary>
        /// Test the property 'TransactionState'
        /// </summary>
        [Fact]
        public void TransactionStateTest()
        {
            // TODO unit test for the property 'TransactionState'
        }
        /// <summary>
        /// Test the property 'Secure3dResponse'
        /// </summary>
        [Fact]
        public void Secure3dResponseTest()
        {
            // TODO unit test for the property 'Secure3dResponse'
        }
        /// <summary>
        /// Test the property 'RedirectURL'
        /// </summary>
        [Fact]
        public void RedirectURLTest()
        {
            // TODO unit test for the property 'RedirectURL'
        }
        /// <summary>
        /// Test the property 'AuthenticationResponse'
        /// </summary>
        [Fact]
        public void AuthenticationResponseTest()
        {
            // TODO unit test for the property 'AuthenticationResponse'
        }
        /// <summary>
        /// Test the property 'SchemeTransactionId'
        /// </summary>
        [Fact]
        public void SchemeTransactionIdTest()
        {
            // TODO unit test for the property 'SchemeTransactionId'
        }
        /// <summary>
        /// Test the property 'Processor'
        /// </summary>
        [Fact]
        public void ProcessorTest()
        {
            // TODO unit test for the property 'Processor'
        }
        /// <summary>
        /// Test the property 'AdditionalDetails'
        /// </summary>
        [Fact]
        public void AdditionalDetailsTest()
        {
            // TODO unit test for the property 'AdditionalDetails'
        }
        /// <summary>
        /// Test the property 'AccountUpdaterResponse'
        /// </summary>
        [Fact]
        public void AccountUpdaterResponseTest()
        {
            // TODO unit test for the property 'AccountUpdaterResponse'
        }
        /// <summary>
        /// Test the property 'AchResponse'
        /// </summary>
        [Fact]
        public void AchResponseTest()
        {
            // TODO unit test for the property 'AchResponse'
        }
        /// <summary>
        /// Test the property 'CurrencyConversionResponse'
        /// </summary>
        [Fact]
        public void CurrencyConversionResponseTest()
        {
            // TODO unit test for the property 'CurrencyConversionResponse'
        }
        /// <summary>
        /// Test the property 'Steps'
        /// </summary>
        [Fact]
        public void StepsTest()
        {
            // TODO unit test for the property 'Steps'
        }
        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }

    }

}
