# IO.Swagger.Api.CompteArchiveApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCompteArchiveItem**](CompteArchiveApi.md#deletecomptearchiveitem) | **DELETE** /compte_archives/{id} | Removes the CompteArchive resource.
[**GetCompteArchiveCollection**](CompteArchiveApi.md#getcomptearchivecollection) | **GET** /compte_archives | Retrieves the collection of CompteArchive resources.
[**GetCompteArchiveItem**](CompteArchiveApi.md#getcomptearchiveitem) | **GET** /compte_archives/{id} | Retrieves a CompteArchive resource.
[**PostCompteArchiveCollection**](CompteArchiveApi.md#postcomptearchivecollection) | **POST** /compte_archives | Creates a CompteArchive resource.
[**PutCompteArchiveItem**](CompteArchiveApi.md#putcomptearchiveitem) | **PUT** /compte_archives/{id} | Replaces the CompteArchive resource.


<a name="deletecomptearchiveitem"></a>
# **DeleteCompteArchiveItem**
> void DeleteCompteArchiveItem (string id)

Removes the CompteArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCompteArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteArchiveApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the CompteArchive resource.
                apiInstance.DeleteCompteArchiveItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteArchiveApi.DeleteCompteArchiveItem: " + e.Message );
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

<a name="getcomptearchivecollection"></a>
# **GetCompteArchiveCollection**
> List<CompteArchive> GetCompteArchiveCollection (int? page = null)

Retrieves the collection of CompteArchive resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompteArchiveCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteArchiveApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of CompteArchive resources.
                List&lt;CompteArchive&gt; result = apiInstance.GetCompteArchiveCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteArchiveApi.GetCompteArchiveCollection: " + e.Message );
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

[**List<CompteArchive>**](CompteArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomptearchiveitem"></a>
# **GetCompteArchiveItem**
> CompteArchive GetCompteArchiveItem (string id)

Retrieves a CompteArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompteArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteArchiveApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a CompteArchive resource.
                CompteArchive result = apiInstance.GetCompteArchiveItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteArchiveApi.GetCompteArchiveItem: " + e.Message );
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

[**CompteArchive**](CompteArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcomptearchivecollection"></a>
# **PostCompteArchiveCollection**
> CompteArchive PostCompteArchiveCollection (CompteArchive compteArchive = null)

Creates a CompteArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCompteArchiveCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteArchiveApi();
            var compteArchive = new CompteArchive(); // CompteArchive | The new CompteArchive resource (optional) 

            try
            {
                // Creates a CompteArchive resource.
                CompteArchive result = apiInstance.PostCompteArchiveCollection(compteArchive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteArchiveApi.PostCompteArchiveCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **compteArchive** | [**CompteArchive**](CompteArchive.md)| The new CompteArchive resource | [optional] 

### Return type

[**CompteArchive**](CompteArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcomptearchiveitem"></a>
# **PutCompteArchiveItem**
> CompteArchive PutCompteArchiveItem (string id, CompteArchive compteArchive = null)

Replaces the CompteArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutCompteArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteArchiveApi();
            var id = id_example;  // string | 
            var compteArchive = new CompteArchive(); // CompteArchive | The updated CompteArchive resource (optional) 

            try
            {
                // Replaces the CompteArchive resource.
                CompteArchive result = apiInstance.PutCompteArchiveItem(id, compteArchive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteArchiveApi.PutCompteArchiveItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **compteArchive** | [**CompteArchive**](CompteArchive.md)| The updated CompteArchive resource | [optional] 

### Return type

[**CompteArchive**](CompteArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

