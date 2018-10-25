# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.InformationQuerysApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInformationQuery**](InformationQuerysApi.md#addinformationquery) | **POST** /informationquerys | 
[**DeleteInformationQuery**](InformationQuerysApi.md#deleteinformationquery) | **DELETE** /informationquerys/{id} | 
[**FindInformationQuerys**](InformationQuerysApi.md#findinformationquerys) | **GET** /informationquerys | 
[**FindInformationqueryById**](InformationQuerysApi.md#findinformationquerybyid) | **GET** /informationquerys/{id} | 


<a name="addinformationquery"></a>
# **AddInformationQuery**
> InformationQuery AddInformationQuery (InformationQuery informationQuery)



Creates a new informationquery

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddInformationQueryExample
    {
        public void main()
        {
            var apiInstance = new InformationQuerysApi();
            var informationQuery = new InformationQuery(); // InformationQuery | InformationQuery to create

            try
            {
                InformationQuery result = apiInstance.AddInformationQuery(informationQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformationQuerysApi.AddInformationQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **informationQuery** | [**InformationQuery**](InformationQuery.md)| InformationQuery to create | 

### Return type

[**InformationQuery**](InformationQuery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinformationquery"></a>
# **DeleteInformationQuery**
> void DeleteInformationQuery (long? id)



deletes a single informationquery based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteInformationQueryExample
    {
        public void main()
        {
            var apiInstance = new InformationQuerysApi();
            var id = 789;  // long? | ID of informationquery to delete

            try
            {
                apiInstance.DeleteInformationQuery(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformationQuerysApi.DeleteInformationQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of informationquery to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinformationquerys"></a>
# **FindInformationQuerys**
> List<InformationQuery> FindInformationQuerys (List<string> tags = null, int? limit = null)



Returns all informationquerys from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindInformationQuerysExample
    {
        public void main()
        {
            var apiInstance = new InformationQuerysApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;InformationQuery&gt; result = apiInstance.FindInformationQuerys(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformationQuerysApi.FindInformationQuerys: " + e.Message );
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

[**List<InformationQuery>**](InformationQuery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinformationquerybyid"></a>
# **FindInformationqueryById**
> InformationQuery FindInformationqueryById (long? id)



Returns a informationquery based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindInformationqueryByIdExample
    {
        public void main()
        {
            var apiInstance = new InformationQuerysApi();
            var id = 789;  // long? | ID of informationquery to fetch

            try
            {
                InformationQuery result = apiInstance.FindInformationqueryById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InformationQuerysApi.FindInformationqueryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of informationquery to fetch | 

### Return type

[**InformationQuery**](InformationQuery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

