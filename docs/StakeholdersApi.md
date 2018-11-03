# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.StakeholdersApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddStakeholder**](StakeholdersApi.md#addstakeholder) | **POST** /stakeholders | 
[**DeleteStakeholder**](StakeholdersApi.md#deletestakeholder) | **DELETE** /stakeholders/{id} | 
[**FindStakeholderById**](StakeholdersApi.md#findstakeholderbyid) | **GET** /stakeholders/{id} | 
[**FindStakeholders**](StakeholdersApi.md#findstakeholders) | **GET** /stakeholders | 


<a name="addstakeholder"></a>
# **AddStakeholder**
> Stakeholder AddStakeholder (Stakeholder stakeholder)



Creates a new stakeholder

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddStakeholderExample
    {
        public void main()
        {
            var apiInstance = new StakeholdersApi();
            var stakeholder = new Stakeholder(); // Stakeholder | Stakeholder to create

            try
            {
                Stakeholder result = apiInstance.AddStakeholder(stakeholder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StakeholdersApi.AddStakeholder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeholder** | [**Stakeholder**](Stakeholder.md)| Stakeholder to create | 

### Return type

[**Stakeholder**](Stakeholder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestakeholder"></a>
# **DeleteStakeholder**
> void DeleteStakeholder (long? id)



deletes a single stakeholder based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteStakeholderExample
    {
        public void main()
        {
            var apiInstance = new StakeholdersApi();
            var id = 789;  // long? | ID of stakeholder to delete

            try
            {
                apiInstance.DeleteStakeholder(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StakeholdersApi.DeleteStakeholder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of stakeholder to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findstakeholderbyid"></a>
# **FindStakeholderById**
> Stakeholder FindStakeholderById (long? id)



Returns a stakeholder based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindStakeholderByIdExample
    {
        public void main()
        {
            var apiInstance = new StakeholdersApi();
            var id = 789;  // long? | ID of stakeholder to fetch

            try
            {
                Stakeholder result = apiInstance.FindStakeholderById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StakeholdersApi.FindStakeholderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of stakeholder to fetch | 

### Return type

[**Stakeholder**](Stakeholder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findstakeholders"></a>
# **FindStakeholders**
> List<Stakeholder> FindStakeholders (List<string> tags = null, int? limit = null)



Returns all stakeholders from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindStakeholdersExample
    {
        public void main()
        {
            var apiInstance = new StakeholdersApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;Stakeholder&gt; result = apiInstance.FindStakeholders(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StakeholdersApi.FindStakeholders: " + e.Message );
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

[**List<Stakeholder>**](Stakeholder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

