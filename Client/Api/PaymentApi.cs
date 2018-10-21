/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>InlineResponse201</returns>
        InlineResponse201 CreatePayment (CreatePaymentRequest createPaymentRequest);

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>ApiResponse of InlineResponse201</returns>
        ApiResponse<InlineResponse201> CreatePaymentWithHttpInfo (CreatePaymentRequest createPaymentRequest);
        /// <summary>
        /// Retrieve a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the GET request to retrieve the payment details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request. </param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetPayment (string id);

        /// <summary>
        /// Retrieve a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the GET request to retrieve the payment details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request. </param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> GetPaymentWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of InlineResponse201</returns>
        System.Threading.Tasks.Task<InlineResponse201> CreatePaymentAsync (CreatePaymentRequest createPaymentRequest);

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of ApiResponse (InlineResponse201)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse201>> CreatePaymentAsyncWithHttpInfo (CreatePaymentRequest createPaymentRequest);
        /// <summary>
        /// Retrieve a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the GET request to retrieve the payment details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request. </param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> GetPaymentAsync (string id);

        /// <summary>
        /// Retrieve a Payment
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the GET request to retrieve the payment details.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request. </param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> GetPaymentAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentApi : IPaymentApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Process a Payment Authorize the payment for the transaction. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>InlineResponse201</returns>
        public InlineResponse201 CreatePayment (CreatePaymentRequest createPaymentRequest)
        {
             ApiResponse<InlineResponse201> localVarResponse = CreatePaymentWithHttpInfo(createPaymentRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process a Payment Authorize the payment for the transaction. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>ApiResponse of InlineResponse201</returns>
        public ApiResponse< InlineResponse201 > CreatePaymentWithHttpInfo (CreatePaymentRequest createPaymentRequest)
        {
            // verify the required parameter 'createPaymentRequest' is set
            if (createPaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'createPaymentRequest' when calling PaymentApi->CreatePayment");

            var localVarPath = $"/pts/v2/payments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                ////"application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createPaymentRequest != null && createPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse201>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse201) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse201)));
        }

        /// <summary>
        /// Process a Payment Authorize the payment for the transaction. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of InlineResponse201</returns>
        public async System.Threading.Tasks.Task<InlineResponse201> CreatePaymentAsync (CreatePaymentRequest createPaymentRequest)
        {
             ApiResponse<InlineResponse201> localVarResponse = await CreatePaymentAsyncWithHttpInfo(createPaymentRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Process a Payment Authorize the payment for the transaction. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of ApiResponse (InlineResponse201)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse201>> CreatePaymentAsyncWithHttpInfo (CreatePaymentRequest createPaymentRequest)
        {
            // verify the required parameter 'createPaymentRequest' is set
            if (createPaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'createPaymentRequest' when calling PaymentApi->CreatePayment");

            var localVarPath = $"/pts/v2/payments/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                //"application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createPaymentRequest != null && createPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse201>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse201) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse201)));
        }

        /// <summary>
        /// Retrieve a Payment Include the payment ID in the GET request to retrieve the payment details.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request. </param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 GetPayment (string id)
        {
             ApiResponse<InlineResponse2002> localVarResponse = GetPaymentWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a Payment Include the payment ID in the GET request to retrieve the payment details.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request. </param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > GetPaymentWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PaymentApi->GetPayment");

            var localVarPath = $"/pts/v2/payments/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002)));
        }

        /// <summary>
        /// Retrieve a Payment Include the payment ID in the GET request to retrieve the payment details.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request. </param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> GetPaymentAsync (string id)
        {
             ApiResponse<InlineResponse2002> localVarResponse = await GetPaymentAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a Payment Include the payment ID in the GET request to retrieve the payment details.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request. </param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> GetPaymentAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PaymentApi->GetPayment");

            var localVarPath = $"/pts/v2/payments/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                //"application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002)));
        }

    }
}
