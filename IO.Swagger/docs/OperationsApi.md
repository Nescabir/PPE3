# IO.Swagger.Api.OperationsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOperationsItem**](OperationsApi.md#deleteoperationsitem) | **DELETE** /operations/{id} | Removes the Operations resource.
[**GetByNumerocompteJoueur**](OperationsApi.md#getbynumerocomptejoueur) | **GET** /operations/byNumerocompte/{numerocompte} | Retrieves the collection of Operations resources.
[**GetOperationsByDate**](OperationsApi.md#getoperationsbydate) | **GET** /operations/byDate/{date} | Retrieves the collection of Operations resources.
[**GetOperationsCollection**](OperationsApi.md#getoperationscollection) | **GET** /operations | Retrieves the collection of Operations resources.
[**GetOperationsItem**](OperationsApi.md#getoperationsitem) | **GET** /operations/{id} | Retrieves a Operations resource.
[**PostOperationsCollection**](OperationsApi.md#postoperationscollection) | **POST** /operations | Creates a Operations resource.
[**PutOperationsItem**](OperationsApi.md#putoperationsitem) | **PUT** /operations/{id} | Replaces the Operations resource.


<a name="deleteoperationsitem"></a>
# **DeleteOperationsItem**
> void DeleteOperationsItem (string id)

Removes the Operations resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOperationsItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Operations resource.
                apiInstance.DeleteOperationsItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.DeleteOperationsItem: " + e.Message );
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

<a name="getbynumerocomptejoueur"></a>
# **GetByNumerocompteJoueur**
> List<Operations> GetByNumerocompteJoueur (string numerocompte, int? page = null)

Retrieves the collection of Operations resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetByNumerocompteJoueurExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var numerocompte = numerocompte_example;  // string | Affiche les opérations par compte
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Operations resources.
                List&lt;Operations&gt; result = apiInstance.GetByNumerocompteJoueur(numerocompte, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.GetByNumerocompteJoueur: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numerocompte** | **string**| Affiche les opérations par compte | 
 **page** | **int?**| The collection page number | [optional] 

### Return type

[**List<Operations>**](Operations.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoperationsbydate"></a>
# **GetOperationsByDate**
> List<Operations> GetOperationsByDate (string date, int? page = null)

Retrieves the collection of Operations resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOperationsByDateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var date = date_example;  // string | Affiche les opérations par date
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Operations resources.
                List&lt;Operations&gt; result = apiInstance.GetOperationsByDate(date, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.GetOperationsByDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**| Affiche les opérations par date | 
 **page** | **int?**| The collection page number | [optional] 

### Return type

[**List<Operations>**](Operations.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoperationscollection"></a>
# **GetOperationsCollection**
> List<Operations> GetOperationsCollection (int? page = null)

Retrieves the collection of Operations resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOperationsCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Operations resources.
                List&lt;Operations&gt; result = apiInstance.GetOperationsCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.GetOperationsCollection: " + e.Message );
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

[**List<Operations>**](Operations.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoperationsitem"></a>
# **GetOperationsItem**
> Operations GetOperationsItem (string id)

Retrieves a Operations resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOperationsItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Operations resource.
                Operations result = apiInstance.GetOperationsItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.GetOperationsItem: " + e.Message );
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

[**Operations**](Operations.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postoperationscollection"></a>
# **PostOperationsCollection**
> Operations PostOperationsCollection (Operations operations = null)

Creates a Operations resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostOperationsCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var operations = new Operations(); // Operations | The new Operations resource (optional) 

            try
            {
                // Creates a Operations resource.
                Operations result = apiInstance.PostOperationsCollection(operations);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.PostOperationsCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **operations** | [**Operations**](Operations.md)| The new Operations resource | [optional] 

### Return type

[**Operations**](Operations.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putoperationsitem"></a>
# **PutOperationsItem**
> Operations PutOperationsItem (string id, Operations operations = null)

Replaces the Operations resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutOperationsItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OperationsApi();
            var id = id_example;  // string | 
            var operations = new Operations(); // Operations | The updated Operations resource (optional) 

            try
            {
                // Replaces the Operations resource.
                Operations result = apiInstance.PutOperationsItem(id, operations);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.PutOperationsItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **operations** | [**Operations**](Operations.md)| The updated Operations resource | [optional] 

### Return type

[**Operations**](Operations.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

