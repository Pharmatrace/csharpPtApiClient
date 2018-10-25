# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.ContainerApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LocationHistoryGet**](ContainerApi.md#locationhistoryget) | **GET** /locationHistory | Location History


<a name="locationhistoryget"></a>
# **LocationHistoryGet**
> Locations LocationHistoryGet (string containerId = null, int? offset = null, int? limit = null)

Location History

Returns the location history of a container or a individually labeled pharmaceutical

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class LocationHistoryGetExample
    {
        public void main()
        {
            var apiInstance = new ContainerApi();
            var containerId = containerId_example;  // string | container id of the tracked container. (optional) 
            var offset = 56;  // int? | Offset the list of returned results by this amount. Default is zero. (optional) 
            var limit = 56;  // int? | Number of items to retrieve. Default is 5, maximum is 100. (optional) 

            try
            {
                // Location History
                Locations result = apiInstance.LocationHistoryGet(containerId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContainerApi.LocationHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**| container id of the tracked container. | [optional] 
 **offset** | **int?**| Offset the list of returned results by this amount. Default is zero. | [optional] 
 **limit** | **int?**| Number of items to retrieve. Default is 5, maximum is 100. | [optional] 

### Return type

[**Locations**](Locations.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

