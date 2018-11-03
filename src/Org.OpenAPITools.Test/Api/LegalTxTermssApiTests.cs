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
    ///  Class for testing LegalTxTermssApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LegalTxTermssApiTests
    {
        private LegalTxTermssApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LegalTxTermssApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LegalTxTermssApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LegalTxTermssApi
            //Assert.IsInstanceOfType(typeof(LegalTxTermssApi), instance, "instance is a LegalTxTermssApi");
        }

        
        /// <summary>
        /// Test AddLegalTxTerms
        /// </summary>
        [Test]
        public void AddLegalTxTermsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LegalTxTerms legalTxTerms = null;
            //var response = instance.AddLegalTxTerms(legalTxTerms);
            //Assert.IsInstanceOf<LegalTxTerms> (response, "response is LegalTxTerms");
        }
        
        /// <summary>
        /// Test DeleteLegalTxTerms
        /// </summary>
        [Test]
        public void DeleteLegalTxTermsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteLegalTxTerms(id);
            
        }
        
        /// <summary>
        /// Test FindLegalTxTermss
        /// </summary>
        [Test]
        public void FindLegalTxTermssTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> tags = null;
            //int? limit = null;
            //var response = instance.FindLegalTxTermss(tags, limit);
            //Assert.IsInstanceOf<List<LegalTxTerms>> (response, "response is List<LegalTxTerms>");
        }
        
        /// <summary>
        /// Test FindLegaltxtermsById
        /// </summary>
        [Test]
        public void FindLegaltxtermsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.FindLegaltxtermsById(id);
            //Assert.IsInstanceOf<LegalTxTerms> (response, "response is LegalTxTerms");
        }
        
    }

}