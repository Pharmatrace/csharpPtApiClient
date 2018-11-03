# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.LegalTxTermssApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLegalTxTerms**](LegalTxTermssApi.md#addlegaltxterms) | **POST** /legaltxtermss | 
[**DeleteLegalTxTerms**](LegalTxTermssApi.md#deletelegaltxterms) | **DELETE** /legaltxtermss/{id} | 
[**FindLegalTxTermss**](LegalTxTermssApi.md#findlegaltxtermss) | **GET** /legaltxtermss | 
[**FindLegaltxtermsById**](LegalTxTermssApi.md#findlegaltxtermsbyid) | **GET** /legaltxtermss/{id} | 


<a name="addlegaltxterms"></a>
# **AddLegalTxTerms**
> LegalTxTerms AddLegalTxTerms (LegalTxTerms legalTxTerms)



Creates a new legaltxterms

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddLegalTxTermsExample
    {
        public void main()
        {
            var apiInstance = new LegalTxTermssApi();
            var legalTxTerms = new LegalTxTerms(); // LegalTxTerms | LegalTxTerms to create

            try
            {
                LegalTxTerms result = apiInstance.AddLegalTxTerms(legalTxTerms);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalTxTermssApi.AddLegalTxTerms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **legalTxTerms** | [**LegalTxTerms**](LegalTxTerms.md)| LegalTxTerms to create | 

### Return type

[**LegalTxTerms**](LegalTxTerms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelegaltxterms"></a>
# **DeleteLegalTxTerms**
> void DeleteLegalTxTerms (long? id)



deletes a single legaltxterms based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteLegalTxTermsExample
    {
        public void main()
        {
            var apiInstance = new LegalTxTermssApi();
            var id = 789;  // long? | ID of legaltxterms to delete

            try
            {
                apiInstance.DeleteLegalTxTerms(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalTxTermssApi.DeleteLegalTxTerms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of legaltxterms to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlegaltxtermss"></a>
# **FindLegalTxTermss**
> List<LegalTxTerms> FindLegalTxTermss (List<string> tags = null, int? limit = null)



Returns all legaltxtermss from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindLegalTxTermssExample
    {
        public void main()
        {
            var apiInstance = new LegalTxTermssApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;LegalTxTerms&gt; result = apiInstance.FindLegalTxTermss(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalTxTermssApi.FindLegalTxTermss: " + e.Message );
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

[**List<LegalTxTerms>**](LegalTxTerms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlegaltxtermsbyid"></a>
# **FindLegaltxtermsById**
> LegalTxTerms FindLegaltxtermsById (long? id)



Returns a legaltxterms based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindLegaltxtermsByIdExample
    {
        public void main()
        {
            var apiInstance = new LegalTxTermssApi();
            var id = 789;  // long? | ID of legaltxterms to fetch

            try
            {
                LegalTxTerms result = apiInstance.FindLegaltxtermsById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalTxTermssApi.FindLegaltxtermsById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of legaltxterms to fetch | 

### Return type

[**LegalTxTerms**](LegalTxTerms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

