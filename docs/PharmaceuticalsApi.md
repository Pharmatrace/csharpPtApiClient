# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.PharmaceuticalsApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPharmaceutical**](PharmaceuticalsApi.md#addpharmaceutical) | **POST** /pharmaceuticals | 
[**DeletePharmaceutical**](PharmaceuticalsApi.md#deletepharmaceutical) | **DELETE** /pharmaceuticals/{id} | 
[**FindPharmaceuticalById**](PharmaceuticalsApi.md#findpharmaceuticalbyid) | **GET** /pharmaceuticals/{id} | 
[**FindPharmaceuticals**](PharmaceuticalsApi.md#findpharmaceuticals) | **GET** /pharmaceuticals | 


<a name="addpharmaceutical"></a>
# **AddPharmaceutical**
> Pharmaceutical AddPharmaceutical (Pharmaceutical pharmaceutical)



Creates a new pharmaceutical

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddPharmaceuticalExample
    {
        public void main()
        {
            var apiInstance = new PharmaceuticalsApi();
            var pharmaceutical = new Pharmaceutical(); // Pharmaceutical | Pharmaceutical to create

            try
            {
                Pharmaceutical result = apiInstance.AddPharmaceutical(pharmaceutical);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PharmaceuticalsApi.AddPharmaceutical: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pharmaceutical** | [**Pharmaceutical**](Pharmaceutical.md)| Pharmaceutical to create | 

### Return type

[**Pharmaceutical**](Pharmaceutical.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepharmaceutical"></a>
# **DeletePharmaceutical**
> void DeletePharmaceutical (long? id)



deletes a single pharmaceutical based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeletePharmaceuticalExample
    {
        public void main()
        {
            var apiInstance = new PharmaceuticalsApi();
            var id = 789;  // long? | ID of pharmaceutical to delete

            try
            {
                apiInstance.DeletePharmaceutical(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PharmaceuticalsApi.DeletePharmaceutical: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of pharmaceutical to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findpharmaceuticalbyid"></a>
# **FindPharmaceuticalById**
> Pharmaceutical FindPharmaceuticalById (long? id)



Returns a pharmaceutical based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindPharmaceuticalByIdExample
    {
        public void main()
        {
            var apiInstance = new PharmaceuticalsApi();
            var id = 789;  // long? | ID of pharmaceutical to fetch

            try
            {
                Pharmaceutical result = apiInstance.FindPharmaceuticalById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PharmaceuticalsApi.FindPharmaceuticalById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of pharmaceutical to fetch | 

### Return type

[**Pharmaceutical**](Pharmaceutical.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findpharmaceuticals"></a>
# **FindPharmaceuticals**
> List<Pharmaceutical> FindPharmaceuticals (List<string> tags = null, int? limit = null)



Returns all pharmaceuticals from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindPharmaceuticalsExample
    {
        public void main()
        {
            var apiInstance = new PharmaceuticalsApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;Pharmaceutical&gt; result = apiInstance.FindPharmaceuticals(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PharmaceuticalsApi.FindPharmaceuticals: " + e.Message );
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

[**List<Pharmaceutical>**](Pharmaceutical.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

