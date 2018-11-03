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
    ///  Class for testing RepackagesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RepackagesApiTests
    {
        private RepackagesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RepackagesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RepackagesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RepackagesApi
            //Assert.IsInstanceOfType(typeof(RepackagesApi), instance, "instance is a RepackagesApi");
        }

        
        /// <summary>
        /// Test AddRepackage
        /// </summary>
        [Test]
        public void AddRepackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Repackage repackage = null;
            //var response = instance.AddRepackage(repackage);
            //Assert.IsInstanceOf<Repackage> (response, "response is Repackage");
        }
        
        /// <summary>
        /// Test DeleteRepackage
        /// </summary>
        [Test]
        public void DeleteRepackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteRepackage(id);
            
        }
        
        /// <summary>
        /// Test FindRepackageById
        /// </summary>
        [Test]
        public void FindRepackageByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.FindRepackageById(id);
            //Assert.IsInstanceOf<Repackage> (response, "response is Repackage");
        }
        
        /// <summary>
        /// Test FindRepackages
        /// </summary>
        [Test]
        public void FindRepackagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> tags = null;
            //int? limit = null;
            //var response = instance.FindRepackages(tags, limit);
            //Assert.IsInstanceOf<List<Repackage>> (response, "response is List<Repackage>");
        }
        
    }

}
