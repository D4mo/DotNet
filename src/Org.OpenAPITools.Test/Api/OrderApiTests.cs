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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing OrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrderApiTests : IDisposable
    {
        private OrderApi instance;

        public OrderApiTests()
        {
            instance = new OrderApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrderApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderApi
            //Assert.IsType(typeof(OrderApi), instance, "instance is a OrderApi");
        }

        
        /// <summary>
        /// Test OrderInquiry
        /// </summary>
        [Fact]
        public void OrderInquiryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //string orderId = null;
            //string messageSignature = null;
            //string region = null;
            //string storeId = null;
            //var response = instance.OrderInquiry(contentType, clientRequestId, apiKey, timestamp, orderId, messageSignature, region, storeId);
            //Assert.IsType<OrderResponse> (response, "response is OrderResponse");
        }
        
        /// <summary>
        /// Test SubmitSecondaryTransactionFromOrder
        /// </summary>
        [Fact]
        public void SubmitSecondaryTransactionFromOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //string orderId = null;
            //SecondaryTransaction secondaryTransaction = null;
            //string messageSignature = null;
            //string region = null;
            //var response = instance.SubmitSecondaryTransactionFromOrder(contentType, clientRequestId, apiKey, timestamp, orderId, secondaryTransaction, messageSignature, region);
            //Assert.IsType<TransactionResponse> (response, "response is TransactionResponse");
        }
        
    }

}
