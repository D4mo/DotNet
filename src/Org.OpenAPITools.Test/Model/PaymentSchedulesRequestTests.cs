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
    ///  Class for testing PaymentSchedulesRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PaymentSchedulesRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PaymentSchedulesRequest
        //private PaymentSchedulesRequest instance;

        public PaymentSchedulesRequestTests()
        {
            // TODO uncomment below to create an instance of PaymentSchedulesRequest
            //instance = new PaymentSchedulesRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaymentSchedulesRequest
        /// </summary>
        [Fact]
        public void PaymentSchedulesRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PaymentSchedulesRequest
            //Assert.IsInstanceOfType<PaymentSchedulesRequest> (instance, "variable 'instance' is a PaymentSchedulesRequest");
        }

        /// <summary>
        /// Test deserialize a ReferencedOrderPaymentSchedulesRequest from type PaymentSchedulesRequest
        /// </summary>
        [Fact]
        public void ReferencedOrderPaymentSchedulesRequestDeserializeFromPaymentSchedulesRequestTest()
        {
            // TODO uncomment below to test deserialize a ReferencedOrderPaymentSchedulesRequest from type PaymentSchedulesRequest
            //Assert.IsInstanceOf<PaymentSchedulesRequest>(JsonConvert.DeserializeObject<PaymentSchedulesRequest>(new ReferencedOrderPaymentSchedulesRequest().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentMethodPaymentSchedulesRequest from type PaymentSchedulesRequest
        /// </summary>
        [Fact]
        public void PaymentMethodPaymentSchedulesRequestDeserializeFromPaymentSchedulesRequestTest()
        {
            // TODO uncomment below to test deserialize a PaymentMethodPaymentSchedulesRequest from type PaymentSchedulesRequest
            //Assert.IsInstanceOf<PaymentSchedulesRequest>(JsonConvert.DeserializeObject<PaymentSchedulesRequest>(new PaymentMethodPaymentSchedulesRequest().ToJson()));
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
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'NumberOfPayments'
        /// </summary>
        [Fact]
        public void NumberOfPaymentsTest()
        {
            // TODO unit test for the property 'NumberOfPayments'
        }
        /// <summary>
        /// Test the property 'MaximumFailures'
        /// </summary>
        [Fact]
        public void MaximumFailuresTest()
        {
            // TODO unit test for the property 'MaximumFailures'
        }
        /// <summary>
        /// Test the property 'InvoiceNumber'
        /// </summary>
        [Fact]
        public void InvoiceNumberTest()
        {
            // TODO unit test for the property 'InvoiceNumber'
        }
        /// <summary>
        /// Test the property 'PurchaseOrderNumber'
        /// </summary>
        [Fact]
        public void PurchaseOrderNumberTest()
        {
            // TODO unit test for the property 'PurchaseOrderNumber'
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
        /// Test the property 'DynamicMerchantName'
        /// </summary>
        [Fact]
        public void DynamicMerchantNameTest()
        {
            // TODO unit test for the property 'DynamicMerchantName'
        }
        /// <summary>
        /// Test the property 'Frequency'
        /// </summary>
        [Fact]
        public void FrequencyTest()
        {
            // TODO unit test for the property 'Frequency'
        }
        /// <summary>
        /// Test the property 'TransactionAmount'
        /// </summary>
        [Fact]
        public void TransactionAmountTest()
        {
            // TODO unit test for the property 'TransactionAmount'
        }
        /// <summary>
        /// Test the property 'ClientLocale'
        /// </summary>
        [Fact]
        public void ClientLocaleTest()
        {
            // TODO unit test for the property 'ClientLocale'
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
        /// Test the property 'Billing'
        /// </summary>
        [Fact]
        public void BillingTest()
        {
            // TODO unit test for the property 'Billing'
        }
        /// <summary>
        /// Test the property 'Shipping'
        /// </summary>
        [Fact]
        public void ShippingTest()
        {
            // TODO unit test for the property 'Shipping'
        }
        /// <summary>
        /// Test the property 'Comments'
        /// </summary>
        [Fact]
        public void CommentsTest()
        {
            // TODO unit test for the property 'Comments'
        }

    }

}
