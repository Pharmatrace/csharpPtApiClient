# Org.OpenAPITools.io.pharmatrace.api.scin.public.api.WalletsApi

All URIs are relative to *https://api.pharmatrace.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWallet**](WalletsApi.md#addwallet) | **POST** /wallets | 
[**DeleteWallet**](WalletsApi.md#deletewallet) | **DELETE** /wallets/{id} | 
[**FindWalletById**](WalletsApi.md#findwalletbyid) | **GET** /wallets/{id} | 
[**FindWallets**](WalletsApi.md#findwallets) | **GET** /wallets | 


<a name="addwallet"></a>
# **AddWallet**
> Wallet AddWallet (Wallet wallet)



Creates a new wallet

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class AddWalletExample
    {
        public void main()
        {
            var apiInstance = new WalletsApi();
            var wallet = new Wallet(); // Wallet | Wallet to create

            try
            {
                Wallet result = apiInstance.AddWallet(wallet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletsApi.AddWallet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wallet** | [**Wallet**](Wallet.md)| Wallet to create | 

### Return type

[**Wallet**](Wallet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewallet"></a>
# **DeleteWallet**
> void DeleteWallet (long? id)



deletes a single wallet based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class DeleteWalletExample
    {
        public void main()
        {
            var apiInstance = new WalletsApi();
            var id = 789;  // long? | ID of wallet to delete

            try
            {
                apiInstance.DeleteWallet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletsApi.DeleteWallet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of wallet to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findwalletbyid"></a>
# **FindWalletById**
> Wallet FindWalletById (long? id)



Returns a wallet based on the ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindWalletByIdExample
    {
        public void main()
        {
            var apiInstance = new WalletsApi();
            var id = 789;  // long? | ID of wallet to fetch

            try
            {
                Wallet result = apiInstance.FindWalletById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletsApi.FindWalletById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of wallet to fetch | 

### Return type

[**Wallet**](Wallet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findwallets"></a>
# **FindWallets**
> List<Wallet> FindWallets (List<string> tags = null, int? limit = null)



Returns all wallets from the system that the user has access to Nam sed condimentum est. Maecenas tempor sagittis sapien, nec rhoncus sem sagittis sit amet. Aenean at gravida augue, ac iaculis sem. Curabitur odio lorem, ornare eget elementum nec, cursus id lectus. Duis mi turpis, pulvinar ac eros ac, tincidunt varius justo. In hac habitasse platea dictumst. Integer at adipiscing ante, a sagittis ligula. Aenean pharetra tempor ante molestie imperdiet. Vivamus id aliquam diam. Cras quis velit non tortor eleifend sagittis. Praesent at enim pharetra urna volutpat venenatis eget eget mauris. In eleifend fermentum facilisis. Praesent enim enim, gravida ac sodales sed, placerat id erat. Suspendisse lacus dolor, consectetur non augue vel, vehicula interdum libero. Morbi euismod sagittis libero sed lacinia.  Sed tempus felis lobortis leo pulvinar rutrum. Nam mattis velit nisl, eu condimentum ligula luctus nec. Phasellus semper velit eget aliquet faucibus. In a mattis elit. Phasellus vel urna viverra, condimentum lorem id, rhoncus nibh. Ut pellentesque posuere elementum. Sed a varius odio. Morbi rhoncus ligula libero, vel eleifend nunc tristique vitae. Fusce et sem dui. Aenean nec scelerisque tortor. Fusce malesuada accumsan magna vel tempus. Quisque mollis felis eu dolor tristique, sit amet auctor felis gravida. Sed libero lorem, molestie sed nisl in, accumsan tempor nisi. Fusce sollicitudin massa ut lacinia mattis. Sed vel eleifend lorem. Pellentesque vitae felis pretium, pulvinar elit eu, euismod sapien. 

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.io.pharmatrace.api.scin.public.model;

namespace Example
{
    public class FindWalletsExample
    {
        public void main()
        {
            var apiInstance = new WalletsApi();
            var tags = new List<string>(); // List<string> | tags to filter by (optional) 
            var limit = 56;  // int? | maximum number of results to return (optional) 

            try
            {
                List&lt;Wallet&gt; result = apiInstance.FindWallets(tags, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletsApi.FindWallets: " + e.Message );
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

[**List<Wallet>**](Wallet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

