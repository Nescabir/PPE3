# IO.Swagger.Api.SallesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSallesItem**](SallesApi.md#deletesallesitem) | **DELETE** /salles/{id} | Removes the Salles resource.
[**GetSallesCollection**](SallesApi.md#getsallescollection) | **GET** /salles | Retrieves the collection of Salles resources.
[**GetSallesItem**](SallesApi.md#getsallesitem) | **GET** /salles/{id} | Retrieves a Salles resource.
[**PostSallesCollection**](SallesApi.md#postsallescollection) | **POST** /salles | Creates a Salles resource.
[**PutSallesItem**](SallesApi.md#putsallesitem) | **PUT** /salles/{id} | Replaces the Salles resource.


<a name="deletesallesitem"></a>
# **DeleteSallesItem**
> void DeleteSallesItem (string id)

Removes the Salles resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSallesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SallesApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Salles resource.
                apiInstance.DeleteSallesItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SallesApi.DeleteSallesItem: " + e.Message );
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

<a name="getsallescollection"></a>
# **GetSallesCollection**
> List<Salles> GetSallesCollection (int? page = null)

Retrieves the collection of Salles resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSallesCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SallesApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Salles resources.
                List&lt;Salles&gt; result = apiInstance.GetSallesCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SallesApi.GetSallesCollection: " + e.Message );
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

[**List<Salles>**](Salles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsallesitem"></a>
# **GetSallesItem**
> Salles GetSallesItem (string id)

Retrieves a Salles resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSallesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SallesApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Salles resource.
                Salles result = apiInstance.GetSallesItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SallesApi.GetSallesItem: " + e.Message );
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

[**Salles**](Salles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsallescollection"></a>
# **PostSallesCollection**
> Salles PostSallesCollection (Salles salles = null)

Creates a Salles resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSallesCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SallesApi();
            var salles = new Salles(); // Salles | The new Salles resource (optional) 

            try
            {
                // Creates a Salles resource.
                Salles result = apiInstance.PostSallesCollection(salles);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SallesApi.PostSallesCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **salles** | [**Salles**](Salles.md)| The new Salles resource | [optional] 

### Return type

[**Salles**](Salles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsallesitem"></a>
# **PutSallesItem**
> Salles PutSallesItem (string id, Salles salles = null)

Replaces the Salles resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutSallesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SallesApi();
            var id = id_example;  // string | 
            var salles = new Salles(); // Salles | The updated Salles resource (optional) 

            try
            {
                // Replaces the Salles resource.
                Salles result = apiInstance.PutSallesItem(id, salles);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SallesApi.PutSallesItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **salles** | [**Salles**](Salles.md)| The updated Salles resource | [optional] 

### Return type

[**Salles**](Salles.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

