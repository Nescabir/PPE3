# IO.Swagger.Api.JoueurArchiveApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteJoueurArchiveItem**](JoueurArchiveApi.md#deletejoueurarchiveitem) | **DELETE** /joueur_archives/{id} | Removes the JoueurArchive resource.
[**GetJoueurArchiveCollection**](JoueurArchiveApi.md#getjoueurarchivecollection) | **GET** /joueur_archives | Retrieves the collection of JoueurArchive resources.
[**GetJoueurArchiveItem**](JoueurArchiveApi.md#getjoueurarchiveitem) | **GET** /joueur_archives/{id} | Retrieves a JoueurArchive resource.
[**PostJoueurArchiveCollection**](JoueurArchiveApi.md#postjoueurarchivecollection) | **POST** /joueur_archives | Creates a JoueurArchive resource.
[**PutJoueurArchiveItem**](JoueurArchiveApi.md#putjoueurarchiveitem) | **PUT** /joueur_archives/{id} | Replaces the JoueurArchive resource.


<a name="deletejoueurarchiveitem"></a>
# **DeleteJoueurArchiveItem**
> void DeleteJoueurArchiveItem (string id)

Removes the JoueurArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteJoueurArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurArchiveApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the JoueurArchive resource.
                apiInstance.DeleteJoueurArchiveItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurArchiveApi.DeleteJoueurArchiveItem: " + e.Message );
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

<a name="getjoueurarchivecollection"></a>
# **GetJoueurArchiveCollection**
> List<JoueurArchive> GetJoueurArchiveCollection (int? page = null)

Retrieves the collection of JoueurArchive resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJoueurArchiveCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurArchiveApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of JoueurArchive resources.
                List&lt;JoueurArchive&gt; result = apiInstance.GetJoueurArchiveCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurArchiveApi.GetJoueurArchiveCollection: " + e.Message );
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

[**List<JoueurArchive>**](JoueurArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjoueurarchiveitem"></a>
# **GetJoueurArchiveItem**
> JoueurArchive GetJoueurArchiveItem (string id)

Retrieves a JoueurArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJoueurArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurArchiveApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a JoueurArchive resource.
                JoueurArchive result = apiInstance.GetJoueurArchiveItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurArchiveApi.GetJoueurArchiveItem: " + e.Message );
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

[**JoueurArchive**](JoueurArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postjoueurarchivecollection"></a>
# **PostJoueurArchiveCollection**
> JoueurArchive PostJoueurArchiveCollection (JoueurArchive joueurArchive = null)

Creates a JoueurArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostJoueurArchiveCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurArchiveApi();
            var joueurArchive = new JoueurArchive(); // JoueurArchive | The new JoueurArchive resource (optional) 

            try
            {
                // Creates a JoueurArchive resource.
                JoueurArchive result = apiInstance.PostJoueurArchiveCollection(joueurArchive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurArchiveApi.PostJoueurArchiveCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **joueurArchive** | [**JoueurArchive**](JoueurArchive.md)| The new JoueurArchive resource | [optional] 

### Return type

[**JoueurArchive**](JoueurArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putjoueurarchiveitem"></a>
# **PutJoueurArchiveItem**
> JoueurArchive PutJoueurArchiveItem (string id, JoueurArchive joueurArchive = null)

Replaces the JoueurArchive resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutJoueurArchiveItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurArchiveApi();
            var id = id_example;  // string | 
            var joueurArchive = new JoueurArchive(); // JoueurArchive | The updated JoueurArchive resource (optional) 

            try
            {
                // Replaces the JoueurArchive resource.
                JoueurArchive result = apiInstance.PutJoueurArchiveItem(id, joueurArchive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurArchiveApi.PutJoueurArchiveItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **joueurArchive** | [**JoueurArchive**](JoueurArchive.md)| The updated JoueurArchive resource | [optional] 

### Return type

[**JoueurArchive**](JoueurArchive.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

