# ListApiCli.Api.ItemsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ItemsAddItemsPost**](ItemsApi.md#itemsadditemspost) | **POST** /Items/AddItems | 
[**ItemsDeleteitemIdDelete**](ItemsApi.md#itemsdeleteitemiddelete) | **DELETE** /Items/deleteitem/{id} | 
[**ItemsGet**](ItemsApi.md#itemsget) | **GET** /Items | 
[**ItemsIdGetitemGet**](ItemsApi.md#itemsidgetitemget) | **GET** /Items/{id}/getitem | 


<a name="itemsadditemspost"></a>
# **ItemsAddItemsPost**
> void ItemsAddItemsPost (ToDoItems toDoItems = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ListApiCli.Api;
using ListApiCli.Client;
using ListApiCli.Model;

namespace Example
{
    public class ItemsAddItemsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ItemsApi(config);
            var toDoItems = new ToDoItems(); // ToDoItems |  (optional) 

            try
            {
                apiInstance.ItemsAddItemsPost(toDoItems);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsAddItemsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toDoItems** | [**ToDoItems**](ToDoItems.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemsdeleteitemiddelete"></a>
# **ItemsDeleteitemIdDelete**
> void ItemsDeleteitemIdDelete (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ListApiCli.Api;
using ListApiCli.Client;
using ListApiCli.Model;

namespace Example
{
    public class ItemsDeleteitemIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ItemsApi(config);
            var id = "id_example";  // string | 

            try
            {
                apiInstance.ItemsDeleteitemIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsDeleteitemIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemsget"></a>
# **ItemsGet**
> List&lt;ToDoItems&gt; ItemsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ListApiCli.Api;
using ListApiCli.Client;
using ListApiCli.Model;

namespace Example
{
    public class ItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ItemsApi(config);

            try
            {
                List<ToDoItems> result = apiInstance.ItemsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ToDoItems&gt;**](ToDoItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="itemsidgetitemget"></a>
# **ItemsIdGetitemGet**
> ToDoItems ItemsIdGetitemGet (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ListApiCli.Api;
using ListApiCli.Client;
using ListApiCli.Model;

namespace Example
{
    public class ItemsIdGetitemGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ItemsApi(config);
            var id = "id_example";  // string | 

            try
            {
                ToDoItems result = apiInstance.ItemsIdGetitemGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsIdGetitemGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**ToDoItems**](ToDoItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

