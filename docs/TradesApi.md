# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.TradesApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTrade**](TradesApi.md#addtrade) | **POST** /trades | 
[**DeleteTrade**](TradesApi.md#deletetrade) | **DELETE** /trades/{id} | 
[**FindTradeById**](TradesApi.md#findtradebyid) | **GET** /trades/{id} | 
[**FindTrades**](TradesApi.md#findtrades) | **GET** /trades | 


<a name="addtrade"></a>
# **AddTrade**
> Trade AddTrade (Trade trade)



Creates a new trade

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddTradeExample
    {
        public void main()
        {
            var apiInstance = new TradesApi();
            var trade = new Trade(); // Trade | Trade to create

            try
            {
                Trade result = apiInstance.AddTrade(trade);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradesApi.AddTrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trade** | [**Trade**](Trade.md)| Trade to create | 

### Return type

[**Trade**](Trade.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetrade"></a>
# **DeleteTrade**
> void DeleteTrade (long? id)



deletes a single trade based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteTradeExample
    {
        public void main()
        {
            var apiInstance = new TradesApi();
            var id = 789;  // long? | ID of trade to delete

            try
            {
                apiInstance.DeleteTrade(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradesApi.DeleteTrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of trade to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtradebyid"></a>
# **FindTradeById**
> Trade FindTradeById (long? id)



Returns a trade based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindTradeByIdExample
    {
        public void main()
        {
            var apiInstance = new TradesApi();
            var id = 789;  // long? | ID of trade to fetch

            try
            {
                Trade result = apiInstance.FindTradeById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradesApi.FindTradeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of trade to fetch | 

### Return type

[**Trade**](Trade.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtrades"></a>
# **FindTrades**
> List<Trade> FindTrades (List<string> tags = null, int? limit = null)



Returns all trades from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindTradesExample
    {
        public void main()
        {
            var apiInstance = new TradesApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;Trade&gt; result = apiInstance.FindTrades(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradesApi.FindTrades: " + e.Message );
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

[**List<Trade>**](Trade.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

