# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.LocationsApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLocation**](LocationsApi.md#addlocation) | **POST** /locations | 
[**DeleteLocation**](LocationsApi.md#deletelocation) | **DELETE** /locations/{id} | 
[**FindLocationById**](LocationsApi.md#findlocationbyid) | **GET** /locations/{id} | 
[**FindLocations**](LocationsApi.md#findlocations) | **GET** /locations | 


<a name="addlocation"></a>
# **AddLocation**
> Location AddLocation (Location location)



Creates a new location

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddLocationExample
    {
        public void main()
        {
            var apiInstance = new LocationsApi();
            var location = new Location(); // Location | Location to create

            try
            {
                Location result = apiInstance.AddLocation(location);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.AddLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**Location**](Location.md)| Location to create | 

### Return type

[**Location**](Location.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelocation"></a>
# **DeleteLocation**
> void DeleteLocation (long? id)



deletes a single location based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteLocationExample
    {
        public void main()
        {
            var apiInstance = new LocationsApi();
            var id = 789;  // long? | ID of location to delete

            try
            {
                apiInstance.DeleteLocation(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.DeleteLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of location to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlocationbyid"></a>
# **FindLocationById**
> Location FindLocationById (long? id)



Returns a location based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new LocationsApi();
            var id = 789;  // long? | ID of location to fetch

            try
            {
                Location result = apiInstance.FindLocationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.FindLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of location to fetch | 

### Return type

[**Location**](Location.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlocations"></a>
# **FindLocations**
> List<Location> FindLocations (List<string> tags = null, int? limit = null)



Returns all locations from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindLocationsExample
    {
        public void main()
        {
            var apiInstance = new LocationsApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;Location&gt; result = apiInstance.FindLocations(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationsApi.FindLocations: " + e.Message );
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

[**List<Location>**](Location.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

