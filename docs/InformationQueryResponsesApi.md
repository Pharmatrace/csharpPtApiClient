# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.InformationQueryResponsesApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInformationQueryResponse**](InformationQueryResponsesApi.md#addinformationqueryresponse) | **POST** /informationqueryresponses | 
[**DeleteInformationQueryResponse**](InformationQueryResponsesApi.md#deleteinformationqueryresponse) | **DELETE** /informationqueryresponses/{id} | 
[**FindInformationQueryResponses**](InformationQueryResponsesApi.md#findinformationqueryresponses) | **GET** /informationqueryresponses | 
[**FindInformationqueryresponseById**](InformationQueryResponsesApi.md#findinformationqueryresponsebyid) | **GET** /informationqueryresponses/{id} | 


<a name="addinformationqueryresponse"></a>
# **AddInformationQueryResponse**
> InformationQueryResponse AddInformationQueryResponse (InformationQueryResponse informationQueryResponse)



Creates a new informationqueryresponse

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddInformationQueryResponseExample
    {
        public void main()
        {
            var apiInstance = new InformationQueryResponsesApi();
            var informationQueryResponse = new InformationQueryResponse(); // InformationQueryResponse | InformationQueryResponse to create

            try
            {
                InformationQueryResponse result = apiInstance.AddInformationQueryResponse(informationQueryResponse);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformationQueryResponsesApi.AddInformationQueryResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **informationQueryResponse** | [**InformationQueryResponse**](InformationQueryResponse.md)| InformationQueryResponse to create | 

### Return type

[**InformationQueryResponse**](InformationQueryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinformationqueryresponse"></a>
# **DeleteInformationQueryResponse**
> void DeleteInformationQueryResponse (long? id)



deletes a single informationqueryresponse based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteInformationQueryResponseExample
    {
        public void main()
        {
            var apiInstance = new InformationQueryResponsesApi();
            var id = 789;  // long? | ID of informationqueryresponse to delete

            try
            {
                apiInstance.DeleteInformationQueryResponse(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformationQueryResponsesApi.DeleteInformationQueryResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of informationqueryresponse to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinformationqueryresponses"></a>
# **FindInformationQueryResponses**
> List<InformationQueryResponse> FindInformationQueryResponses (List<string> tags = null, int? limit = null)



Returns all informationqueryresponses from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindInformationQueryResponsesExample
    {
        public void main()
        {
            var apiInstance = new InformationQueryResponsesApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;InformationQueryResponse&gt; result = apiInstance.FindInformationQueryResponses(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformationQueryResponsesApi.FindInformationQueryResponses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tags** | [**List&lt;string&gt;**](string.md)| tags to filter by | [optional] 
 **limit** | **int?**| maximum number of results to return | [optional] 

### Return type

[**List<InformationQueryResponse>**](InformationQueryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinformationqueryresponsebyid"></a>
# **FindInformationqueryresponseById**
> InformationQueryResponse FindInformationqueryresponseById (long? id)



Returns a informationqueryresponse based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindInformationqueryresponseByIdExample
    {
        public void main()
        {
            var apiInstance = new InformationQueryResponsesApi();
            var id = 789;  // long? | ID of informationqueryresponse to fetch

            try
            {
                InformationQueryResponse result = apiInstance.FindInformationqueryresponseById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformationQueryResponsesApi.FindInformationqueryresponseById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of informationqueryresponse to fetch | 

### Return type

[**InformationQueryResponse**](InformationQueryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

