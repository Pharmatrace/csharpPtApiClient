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
    ///  Class for testing PharmaceuticalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PharmaceuticalsApiTests
    {
        private PharmaceuticalsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PharmaceuticalsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PharmaceuticalsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PharmaceuticalsApi
            //Assert.IsInstanceOfType(typeof(PharmaceuticalsApi), instance, "instance is a PharmaceuticalsApi");
        }

        
        /// <summary>
        /// Test AddPharmaceutical
        /// </summary>
        [Test]
        public void AddPharmaceuticalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Pharmaceutical pharmaceutical = null;
            //var response = instance.AddPharmaceutical(pharmaceutical);
            //Assert.IsInstanceOf<Pharmaceutical> (response, "response is Pharmaceutical");
        }
        
        /// <summary>
        /// Test DeletePharmaceutical
        /// </summary>
        [Test]
        public void DeletePharmaceuticalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeletePharmaceutical(id);
            
        }
        
        /// <summary>
        /// Test FindPharmaceuticalById
        /// </summary>
        [Test]
        public void FindPharmaceuticalByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.FindPharmaceuticalById(id);
            //Assert.IsInstanceOf<Pharmaceutical> (response, "response is Pharmaceutical");
        }
        
        /// <summary>
        /// Test FindPharmaceuticals
        /// </summary>
        [Test]
        public void FindPharmaceuticalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> tags = null;
            //int? limit = null;
            //var response = instance.FindPharmaceuticals(tags, limit);
            //Assert.IsInstanceOf<List<Pharmaceutical>> (response, "response is List<Pharmaceutical>");
        }
        
    }

}