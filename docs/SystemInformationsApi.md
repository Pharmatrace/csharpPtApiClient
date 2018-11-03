# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.SystemInformationsApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSystemInformation**](SystemInformationsApi.md#addsysteminformation) | **POST** /systeminformations | 
[**DeleteSystemInformation**](SystemInformationsApi.md#deletesysteminformation) | **DELETE** /systeminformations/{id} | 
[**FindSystemInformations**](SystemInformationsApi.md#findsysteminformations) | **GET** /systeminformations | 
[**FindSysteminformationById**](SystemInformationsApi.md#findsysteminformationbyid) | **GET** /systeminformations/{id} | 


<a name="addsysteminformation"></a>
# **AddSystemInformation**
> SystemInformation AddSystemInformation (SystemInformation systemInformation)



Creates a new systeminformation

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddSystemInformationExample
    {
        public void main()
        {
            var apiInstance = new SystemInformationsApi();
            var systemInformation = new SystemInformation(); // SystemInformation | SystemInformation to create

            try
            {
                SystemInformation result = apiInstance.AddSystemInformation(systemInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemInformationsApi.AddSystemInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemInformation** | [**SystemInformation**](SystemInformation.md)| SystemInformation to create | 

### Return type

[**SystemInformation**](SystemInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesysteminformation"></a>
# **DeleteSystemInformation**
> void DeleteSystemInformation (long? id)



deletes a single systeminformation based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteSystemInformationExample
    {
        public void main()
        {
            var apiInstance = new SystemInformationsApi();
            var id = 789;  // long? | ID of systeminformation to delete

            try
            {
                apiInstance.DeleteSystemInformation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemInformationsApi.DeleteSystemInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of systeminformation to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findsysteminformations"></a>
# **FindSystemInformations**
> List<SystemInformation> FindSystemInformations (List<string> tags = null, int? limit = null)



Returns all systeminformations from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindSystemInformationsExample
    {
        public void main()
        {
            var apiInstance = new SystemInformationsApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;SystemInformation&gt; result = apiInstance.FindSystemInformations(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemInformationsApi.FindSystemInformations: " + e.Message );
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

[**List<SystemInformation>**](SystemInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findsysteminformationbyid"></a>
# **FindSysteminformationById**
> SystemInformation FindSysteminformationById (long? id)



Returns a systeminformation based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindSysteminformationByIdExample
    {
        public void main()
        {
            var apiInstance = new SystemInformationsApi();
            var id = 789;  // long? | ID of systeminformation to fetch

            try
            {
                SystemInformation result = apiInstance.FindSysteminformationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemInformationsApi.FindSysteminformationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of systeminformation to fetch | 

### Return type

[**SystemInformation**](SystemInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

