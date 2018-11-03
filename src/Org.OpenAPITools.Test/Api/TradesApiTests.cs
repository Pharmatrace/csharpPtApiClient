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
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing TradesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TradesApiTests
    {
        private TradesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TradesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TradesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TradesApi
            //Assert.IsInstanceOfType(typeof(TradesApi), instance, "instance is a TradesApi");
        }

        
        /// <summary>
        /// Test AddTrade
        /// </summary>
        [Test]
        public void AddTradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Trade trade = null;
            //var response = instance.AddTrade(trade);
            //Assert.IsInstanceOf<Trade> (response, "response is Trade");
        }
        
        /// <summary>
        /// Test DeleteTrade
        /// </summary>
        [Test]
        public void DeleteTradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteTrade(id);
            
        }
        
        /// <summary>
        /// Test FindTradeById
        /// </summary>
        [Test]
        public void FindTradeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.FindTradeById(id);
            //Assert.IsInstanceOf<Trade> (response, "response is Trade");
        }
        
        /// <summary>
        /// Test FindTrades
        /// </summary>
        [Test]
        public void FindTradesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> tags = null;
            //int? limit = null;
            //var response = instance.FindTrades(tags, limit);
            //Assert.IsInstanceOf<List<Trade>> (response, "response is List<Trade>");
        }
        
    }

}
