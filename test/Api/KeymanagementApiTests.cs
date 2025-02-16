/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing KeymanagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class KeymanagementApiTests
    {
        private KeymanagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new KeymanagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KeymanagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' KeymanagementApi
            //Assert.IsInstanceOfType(typeof(KeymanagementApi), instance, "instance is a KeymanagementApi");
        }

        
        /// <summary>
        /// Test SearchKeys
        /// </summary>
        [Test]
        public void SearchKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //string sort = null;
            //List<string> organizationIds = null;
            //List<string> keyIds = null;
            //List<string> keyTypes = null;
            //DateTime? expirationStartDate = null;
            //DateTime? expirationEndDate = null;
            //var response = instance.SearchKeys(offset, limit, sort, organizationIds, keyIds, keyTypes, expirationStartDate, expirationEndDate);
            //Assert.IsInstanceOf<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
    }

}
