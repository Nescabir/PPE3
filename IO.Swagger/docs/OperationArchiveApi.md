# IO.Swagger.Api.OperationArchiveApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOperationArchiveItem**](OperationArchiveApi.md#deleteoperationarchiveitem) | **DELETE** /operation_archives/{id} | Removes the OperationArchive resource.
[**GetOperationArchiveCollection**](OperationArchiveApi.md#getoperationarchivecollection) | **GET** /operation_archives | Retrieves the collection of OperationArchive resources.
[**GetOperationArchiveItem**](OperationArchiveApi.md#getoperationarchiveitem) | **GET** /operation_archives/{id} | Retrieves a OperationArchive resource.
[**PostOperationArchiveCollection**](OperationArchiveApi.md#postoperationarchivecollection) | **POST** /operation_archives | Creates a OperationArchive resource.
[**PutOperationArchiveItem**](OperationArchiveApi.md#putoperationarchiveitem) | **PUT** /operation_archives/{id} | Replaces the OperationArchive resource.


<a name="deleteoperationarchiveitem"></a>
# **DeleteOperationArchiveItem**
> void DeleteOperationArchiveItem (string id)

Removes the OperationArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOperationArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationArchiveApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the OperationArchive resource.
                apiInstance.DeleteOperationArchiveItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationArchiveApi.DeleteOperationArchiveItem: " + e.Message );
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

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoperationarchivecollection"></a>
# **GetOperationArchiveCollection**
> List<OperationArchive> GetOperationArchiveCollection (int? page = null)

Retrieves the collection of OperationArchive resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOperationArchiveCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationArchiveApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of OperationArchive resources.
                List&lt;OperationArchive&gt; result = apiInstance.GetOperationArchiveCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationArchiveApi.GetOperationArchiveCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The collection page number | [optional] 

### Return type

[**List<OperationArchive>**](OperationArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoperationarchiveitem"></a>
# **GetOperationArchiveItem**
> OperationArchive GetOperationArchiveItem (string id)

Retrieves a OperationArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOperationArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationArchiveApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a OperationArchive resource.
                OperationArchive result = apiInstance.GetOperationArchiveItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationArchiveApi.GetOperationArchiveItem: " + e.Message );
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

[**OperationArchive**](OperationArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postoperationarchivecollection"></a>
# **PostOperationArchiveCollection**
> OperationArchive PostOperationArchiveCollection (OperationArchive operationArchive = null)

Creates a OperationArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostOperationArchiveCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationArchiveApi();
            var operationArchive = new OperationArchive(); // OperationArchive | The new OperationArchive resource (optional) 

            try
            {
                // Creates a OperationArchive resource.
                OperationArchive result = apiInstance.PostOperationArchiveCollection(operationArchive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationArchiveApi.PostOperationArchiveCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **operationArchive** | [**OperationArchive**](OperationArchive.md)| The new OperationArchive resource | [optional] 

### Return type

[**OperationArchive**](OperationArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putoperationarchiveitem"></a>
# **PutOperationArchiveItem**
> OperationArchive PutOperationArchiveItem (string id, OperationArchive operationArchive = null)

Replaces the OperationArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutOperationArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationArchiveApi();
            var id = id_example;  // string | 
            var operationArchive = new OperationArchive(); // OperationArchive | The updated OperationArchive resource (optional) 

            try
            {
                // Replaces the OperationArchive resource.
                OperationArchive result = apiInstance.PutOperationArchiveItem(id, operationArchive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationArchiveApi.PutOperationArchiveItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **operationArchive** | [**OperationArchive**](OperationArchive.md)| The updated OperationArchive resource | [optional] 

### Return type

[**OperationArchive**](OperationArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

