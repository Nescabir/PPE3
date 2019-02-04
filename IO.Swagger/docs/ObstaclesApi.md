# IO.Swagger.Api.ObstaclesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteObstaclesItem**](ObstaclesApi.md#deleteobstaclesitem) | **DELETE** /obstacles/{id} | Removes the Obstacles resource.
[**GetObstaclesCollection**](ObstaclesApi.md#getobstaclescollection) | **GET** /obstacles | Retrieves the collection of Obstacles resources.
[**GetObstaclesItem**](ObstaclesApi.md#getobstaclesitem) | **GET** /obstacles/{id} | Retrieves a Obstacles resource.
[**GetbyPartie**](ObstaclesApi.md#getbypartie) | **GET** /obstacles/byPartie/{idPartie} | Retrieves the collection of Obstacles resources.
[**PostObstaclesCollection**](ObstaclesApi.md#postobstaclescollection) | **POST** /obstacles | Creates a Obstacles resource.
[**PutObstaclesItem**](ObstaclesApi.md#putobstaclesitem) | **PUT** /obstacles/{id} | Replaces the Obstacles resource.


<a name="deleteobstaclesitem"></a>
# **DeleteObstaclesItem**
> void DeleteObstaclesItem (string id)

Removes the Obstacles resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteObstaclesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ObstaclesApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Obstacles resource.
                apiInstance.DeleteObstaclesItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObstaclesApi.DeleteObstaclesItem: " + e.Message );
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

<a name="getobstaclescollection"></a>
# **GetObstaclesCollection**
> List<Obstacles> GetObstaclesCollection (int? page = null)

Retrieves the collection of Obstacles resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetObstaclesCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ObstaclesApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Obstacles resources.
                List&lt;Obstacles&gt; result = apiInstance.GetObstaclesCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObstaclesApi.GetObstaclesCollection: " + e.Message );
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

[**List<Obstacles>**](Obstacles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getobstaclesitem"></a>
# **GetObstaclesItem**
> Obstacles GetObstaclesItem (string id)

Retrieves a Obstacles resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetObstaclesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ObstaclesApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Obstacles resource.
                Obstacles result = apiInstance.GetObstaclesItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObstaclesApi.GetObstaclesItem: " + e.Message );
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

[**Obstacles**](Obstacles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbypartie"></a>
# **GetbyPartie**
> List<Obstacles> GetbyPartie (int? idPartie, int? page = null)

Retrieves the collection of Obstacles resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetbyPartieExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ObstaclesApi();
            var idPartie = 56;  // int? | Affiche les obstacles en fonction de la partie
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Obstacles resources.
                List&lt;Obstacles&gt; result = apiInstance.GetbyPartie(idPartie, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObstaclesApi.GetbyPartie: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idPartie** | **int?**| Affiche les obstacles en fonction de la partie | 
 **page** | **int?**| The collection page number | [optional] 

### Return type

[**List<Obstacles>**](Obstacles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postobstaclescollection"></a>
# **PostObstaclesCollection**
> Obstacles PostObstaclesCollection (Obstacles obstacles = null)

Creates a Obstacles resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostObstaclesCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ObstaclesApi();
            var obstacles = new Obstacles(); // Obstacles | The new Obstacles resource (optional) 

            try
            {
                // Creates a Obstacles resource.
                Obstacles result = apiInstance.PostObstaclesCollection(obstacles);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObstaclesApi.PostObstaclesCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **obstacles** | [**Obstacles**](Obstacles.md)| The new Obstacles resource | [optional] 

### Return type

[**Obstacles**](Obstacles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putobstaclesitem"></a>
# **PutObstaclesItem**
> Obstacles PutObstaclesItem (string id, Obstacles obstacles = null)

Replaces the Obstacles resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutObstaclesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ObstaclesApi();
            var id = id_example;  // string | 
            var obstacles = new Obstacles(); // Obstacles | The updated Obstacles resource (optional) 

            try
            {
                // Replaces the Obstacles resource.
                Obstacles result = apiInstance.PutObstaclesItem(id, obstacles);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObstaclesApi.PutObstaclesItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **obstacles** | [**Obstacles**](Obstacles.md)| The updated Obstacles resource | [optional] 

### Return type

[**Obstacles**](Obstacles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

