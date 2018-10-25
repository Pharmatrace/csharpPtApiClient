# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.ContainersApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddContainer**](ContainersApi.md#addcontainer) | **POST** /containers | 
[**DeleteContainer**](ContainersApi.md#deletecontainer) | **DELETE** /containers/{id} | 
[**FindContainerById**](ContainersApi.md#findcontainerbyid) | **GET** /containers/{id} | 
[**FindContainers**](ContainersApi.md#findcontainers) | **GET** /containers | 


<a name="addcontainer"></a>
# **AddContainer**
> Container AddContainer (Container container)



Creates a new container

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddContainerExample
    {
        public void main()
        {
            var apiInstance = new ContainersApi();
            var container = new Container(); // Container | Container to create

            try
            {
                Container result = apiInstance.AddContainer(container);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContainersApi.AddContainer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **container** | [**Container**](Container.md)| Container to create | 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontainer"></a>
# **DeleteContainer**
> void DeleteContainer (long? id)



deletes a single container based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteContainerExample
    {
        public void main()
        {
            var apiInstance = new ContainersApi();
            var id = 789;  // long? | ID of container to delete

            try
            {
                apiInstance.DeleteContainer(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContainersApi.DeleteContainer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of container to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcontainerbyid"></a>
# **FindContainerById**
> Container FindContainerById (long? id)



Returns a container based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindContainerByIdExample
    {
        public void main()
        {
            var apiInstance = new ContainersApi();
            var id = 789;  // long? | ID of container to fetch

            try
            {
                Container result = apiInstance.FindContainerById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContainersApi.FindContainerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of container to fetch | 

### Return type

[**Container**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcontainers"></a>
# **FindContainers**
> List<Container> FindContainers (List<string> tags = null, int? limit = null)



Returns all containers from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindContainersExample
    {
        public void main()
        {
            var apiInstance = new ContainersApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;Container&gt; result = apiInstance.FindContainers(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContainersApi.FindContainers: " + e.Message );
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

[**List<Container>**](Container.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

