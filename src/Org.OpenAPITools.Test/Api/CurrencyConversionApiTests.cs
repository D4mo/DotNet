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
    ///  Class for testing CurrencyConversionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CurrencyConversionApiTests : IDisposable
    {
        private CurrencyConversionApi instance;

        public CurrencyConversionApiTests()
        {
            instance = new CurrencyConversionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CurrencyConversionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CurrencyConversionApi
            //Assert.IsType(typeof(CurrencyConversionApi), instance, "instance is a CurrencyConversionApi");
        }

        
        /// <summary>
        /// Test GetExchangeRate
        /// </summary>
        [Fact]
        public void GetExchangeRateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //ExchangeRateRequest exchangeRateRequest = null;
            //string messageSignature = null;
            //string region = null;
            //var response = instance.GetExchangeRate(contentType, clientRequestId, apiKey, timestamp, exchangeRateRequest, messageSignature, region);
            //Assert.IsType<ExchangeRateResponse> (response, "response is ExchangeRateResponse");
        }
        
    }

}
