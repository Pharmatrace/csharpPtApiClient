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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Org.OpenAPITools.io.pharmatrace.api.scin.public.api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContainerApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Location History
        /// </summary>
        /// <remarks>
        /// Returns the location history of a container or a individually labeled pharmaceutical
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">container id of the tracked container. (optional)</param>
        /// <param name="offset">Offset the list of returned results by this amount. Default is zero. (optional)</param>
        /// <param name="limit">Number of items to retrieve. Default is 5, maximum is 100. (optional)</param>
        /// <returns>Locations</returns>
        Locations LocationHistoryGet (string containerId = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Location History
        /// </summary>
        /// <remarks>
        /// Returns the location history of a container or a individually labeled pharmaceutical
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">container id of the tracked container. (optional)</param>
        /// <param name="offset">Offset the list of returned results by this amount. Default is zero. (optional)</param>
        /// <param name="limit">Number of items to retrieve. Default is 5, maximum is 100. (optional)</param>
        /// <returns>ApiResponse of Locations</returns>
        ApiResponse<Locations> LocationHistoryGetWithHttpInfo (string containerId = null, int? offset = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Location History
        /// </summary>
        /// <remarks>
        /// Returns the location history of a container or a individually labeled pharmaceutical
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">container id of the tracked container. (optional)</param>
        /// <param name="offset">Offset the list of returned results by this amount. Default is zero. (optional)</param>
        /// <param name="limit">Number of items to retrieve. Default is 5, maximum is 100. (optional)</param>
        /// <returns>Task of Locations</returns>
        System.Threading.Tasks.Task<Locations> LocationHistoryGetAsync (string containerId = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Location History
        /// </summary>
        /// <remarks>
        /// Returns the location history of a container or a individually labeled pharmaceutical
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">container id of the tracked container. (optional)</param>
        /// <param name="offset">Offset the list of returned results by this amount. Default is zero. (optional)</param>
        /// <param name="limit">Number of items to retrieve. Default is 5, maximum is 100. (optional)</param>
        /// <returns>Task of ApiResponse (Locations)</returns>
        System.Threading.Tasks.Task<ApiResponse<Locations>> LocationHistoryGetAsyncWithHttpInfo (string containerId = null, int? offset = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ContainerApi : IContainerApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContainerApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerApi"/> class
        /// </summary>
        /// <returns></returns>
        public ContainerApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContainerApi(Org.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Location History Returns the location history of a container or a individually labeled pharmaceutical
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">container id of the tracked container. (optional)</param>
        /// <param name="offset">Offset the list of returned results by this amount. Default is zero. (optional)</param>
        /// <param name="limit">Number of items to retrieve. Default is 5, maximum is 100. (optional)</param>
        /// <returns>Locations</returns>
        public Locations LocationHistoryGet (string containerId = null, int? offset = null, int? limit = null)
        {
             ApiResponse<Locations> localVarResponse = LocationHistoryGetWithHttpInfo(containerId, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Location History Returns the location history of a container or a individually labeled pharmaceutical
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">container id of the tracked container. (optional)</param>
        /// <param name="offset">Offset the list of returned results by this amount. Default is zero. (optional)</param>
        /// <param name="limit">Number of items to retrieve. Default is 5, maximum is 100. (optional)</param>
        /// <returns>ApiResponse of Locations</returns>
        public ApiResponse< Locations > LocationHistoryGetWithHttpInfo (string containerId = null, int? offset = null, int? limit = null)
        {

            var localVarPath = "/locationHistory";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (containerId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "container_id", containerId)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LocationHistoryGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Locations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Locations) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Locations)));
        }

        /// <summary>
        /// Location History Returns the location history of a container or a individually labeled pharmaceutical
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">container id of the tracked container. (optional)</param>
        /// <param name="offset">Offset the list of returned results by this amount. Default is zero. (optional)</param>
        /// <param name="limit">Number of items to retrieve. Default is 5, maximum is 100. (optional)</param>
        /// <returns>Task of Locations</returns>
        public async System.Threading.Tasks.Task<Locations> LocationHistoryGetAsync (string containerId = null, int? offset = null, int? limit = null)
        {
             ApiResponse<Locations> localVarResponse = await LocationHistoryGetAsyncWithHttpInfo(containerId, offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Location History Returns the location history of a container or a individually labeled pharmaceutical
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">container id of the tracked container. (optional)</param>
        /// <param name="offset">Offset the list of returned results by this amount. Default is zero. (optional)</param>
        /// <param name="limit">Number of items to retrieve. Default is 5, maximum is 100. (optional)</param>
        /// <returns>Task of ApiResponse (Locations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Locations>> LocationHistoryGetAsyncWithHttpInfo (string containerId = null, int? offset = null, int? limit = null)
        {

            var localVarPath = "/locationHistory";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (containerId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "container_id", containerId)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LocationHistoryGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Locations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Locations) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Locations)));
        }

    }
}
