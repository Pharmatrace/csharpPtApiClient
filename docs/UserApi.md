# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.UserApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MeGet**](UserApi.md#meget) | **GET** /me | User Profile


<a name="meget"></a>
# **MeGet**
> Profile MeGet ()

User Profile

The User Profile endpoint returns information about the PharmaTrace user that has authorized with the application.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class MeGetExample
    {
        public void main()
        {
            var apiInstance = new UserApi();

            try
            {
                // User Profile
                Profile result = apiInstance.MeGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.MeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Profile**](Profile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

