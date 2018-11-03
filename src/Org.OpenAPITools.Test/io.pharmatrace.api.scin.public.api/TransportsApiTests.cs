/* 
 * PharmaTrace Supply Chain Information Network API
 *
 * The PharmaTrace SCIN API provides network members a resource and process oriented access to the blockchain backed market and inventory information. It represents a layer of abstraction above the Hyperledger network to facilitate a business focused development of clients and integration systems without the need to directly connect to Hyperledger nodes.
 *
 * OpenAPI spec version: 0.0.1
 * Contact: api@pharmatrace.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing TransportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransportsApiTests
    {
        private TransportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransportsApi
            //Assert.IsInstanceOfType(typeof(TransportsApi), instance, "instance is a TransportsApi");
        }

        
        /// <summary>
        /// Test AddTransport
        /// </summary>
        [Test]
        public void AddTransportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Transport transport = null;
            //var response = instance.AddTransport(transport);
            //Assert.IsInstanceOf<Transport> (response, "response is Transport");
        }
        
        /// <summary>
        /// Test DeleteTransport
        /// </summary>
        [Test]
        public void DeleteTransportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteTransport(id);
            
        }
        
        /// <summary>
        /// Test FindTransportById
        /// </summary>
        [Test]
        public void FindTransportByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.FindTransportById(id);
            //Assert.IsInstanceOf<Transport> (response, "response is Transport");
        }
        
        /// <summary>
        /// Test FindTransports
        /// </summary>
        [Test]
        public void FindTransportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> tags = null;
            //int? limit = null;
            //var response = instance.FindTransports(tags, limit);
            //Assert.IsInstanceOf<List<Transport>> (response, "response is List<Transport>");
        }
        
    }

}
