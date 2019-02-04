# IO.Swagger.Api.PartiesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePartiesItem**](PartiesApi.md#deletepartiesitem) | **DELETE** /parties/{id} | Removes the Parties resource.
[**GetByDate**](PartiesApi.md#getbydate) | **GET** /parties/byDate/{date} | Retrieves the collection of Parties resources.
[**GetPartiesCollection**](PartiesApi.md#getpartiescollection) | **GET** /parties | Retrieves the collection of Parties resources.
[**GetPartiesItem**](PartiesApi.md#getpartiesitem) | **GET** /parties/{id} | Retrieves a Parties resource.
[**PostPartiesCollection**](PartiesApi.md#postpartiescollection) | **POST** /parties | Creates a Parties resource.
[**PutPartiesItem**](PartiesApi.md#putpartiesitem) | **PUT** /parties/{id} | Replaces the Parties resource.


<a name="deletepartiesitem"></a>
# **DeletePartiesItem**
> void DeletePartiesItem (string id)

Removes the Parties resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePartiesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartiesApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Parties resource.
                apiInstance.DeletePartiesItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartiesApi.DeletePartiesItem: " + e.Message );
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

<a name="getbydate"></a>
# **GetByDate**
> List<Parties> GetByDate (string date, int? page = null)

Retrieves the collection of Parties resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetByDateExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartiesApi();
            var date = date_example;  // string | Affiche les parties en fonction de la date
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Parties resources.
                List&lt;Parties&gt; result = apiInstance.GetByDate(date, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartiesApi.GetByDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **string**| Affiche les parties en fonction de la date | 
 **page** | **int?**| The collection page number | [optional] 

### Return type

[**List<Parties>**](Parties.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpartiescollection"></a>
# **GetPartiesCollection**
> List<Parties> GetPartiesCollection (int? page = null)

Retrieves the collection of Parties resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPartiesCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartiesApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Parties resources.
                List&lt;Parties&gt; result = apiInstance.GetPartiesCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartiesApi.GetPartiesCollection: " + e.Message );
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

[**List<Parties>**](Parties.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpartiesitem"></a>
# **GetPartiesItem**
> Parties GetPartiesItem (string id)

Retrieves a Parties resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPartiesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartiesApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Parties resource.
                Parties result = apiInstance.GetPartiesItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartiesApi.GetPartiesItem: " + e.Message );
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

[**Parties**](Parties.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpartiescollection"></a>
# **PostPartiesCollection**
> Parties PostPartiesCollection (Parties parties = null)

Creates a Parties resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPartiesCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartiesApi();
            var parties = new Parties(); // Parties | The new Parties resource (optional) 

            try
            {
                // Creates a Parties resource.
                Parties result = apiInstance.PostPartiesCollection(parties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartiesApi.PostPartiesCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parties** | [**Parties**](Parties.md)| The new Parties resource | [optional] 

### Return type

[**Parties**](Parties.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpartiesitem"></a>
# **PutPartiesItem**
> Parties PutPartiesItem (string id, Parties parties = null)

Replaces the Parties resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutPartiesItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PartiesApi();
            var id = id_example;  // string | 
            var parties = new Parties(); // Parties | The updated Parties resource (optional) 

            try
            {
                // Replaces the Parties resource.
                Parties result = apiInstance.PutPartiesItem(id, parties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PartiesApi.PutPartiesItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **parties** | [**Parties**](Parties.md)| The updated Parties resource | [optional] 

### Return type

[**Parties**](Parties.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

