# IO.Swagger.Api.AssociationpartieobstaclespositionApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAssociationpartieobstaclespositionItem**](AssociationpartieobstaclespositionApi.md#deleteassociationpartieobstaclespositionitem) | **DELETE** /associationpartieobstaclespositions/{id} | Removes the Associationpartieobstaclesposition resource.
[**GetAssociationpartieobstaclespositionCollection**](AssociationpartieobstaclespositionApi.md#getassociationpartieobstaclespositioncollection) | **GET** /associationpartieobstaclespositions | Retrieves the collection of Associationpartieobstaclesposition resources.
[**GetAssociationpartieobstaclespositionItem**](AssociationpartieobstaclespositionApi.md#getassociationpartieobstaclespositionitem) | **GET** /associationpartieobstaclespositions/{id} | Retrieves a Associationpartieobstaclesposition resource.
[**PostAssociationpartieobstaclespositionCollection**](AssociationpartieobstaclespositionApi.md#postassociationpartieobstaclespositioncollection) | **POST** /associationpartieobstaclespositions | Creates a Associationpartieobstaclesposition resource.
[**PutAssociationpartieobstaclespositionItem**](AssociationpartieobstaclespositionApi.md#putassociationpartieobstaclespositionitem) | **PUT** /associationpartieobstaclespositions/{id} | Replaces the Associationpartieobstaclesposition resource.


<a name="deleteassociationpartieobstaclespositionitem"></a>
# **DeleteAssociationpartieobstaclespositionItem**
> void DeleteAssociationpartieobstaclespositionItem (string id)

Removes the Associationpartieobstaclesposition resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAssociationpartieobstaclespositionItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssociationpartieobstaclespositionApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Associationpartieobstaclesposition resource.
                apiInstance.DeleteAssociationpartieobstaclespositionItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationpartieobstaclespositionApi.DeleteAssociationpartieobstaclespositionItem: " + e.Message );
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

<a name="getassociationpartieobstaclespositioncollection"></a>
# **GetAssociationpartieobstaclespositionCollection**
> List<Associationpartieobstaclesposition> GetAssociationpartieobstaclespositionCollection (int? page = null)

Retrieves the collection of Associationpartieobstaclesposition resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssociationpartieobstaclespositionCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssociationpartieobstaclespositionApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Associationpartieobstaclesposition resources.
                List&lt;Associationpartieobstaclesposition&gt; result = apiInstance.GetAssociationpartieobstaclespositionCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationpartieobstaclespositionApi.GetAssociationpartieobstaclespositionCollection: " + e.Message );
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

[**List<Associationpartieobstaclesposition>**](Associationpartieobstaclesposition.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassociationpartieobstaclespositionitem"></a>
# **GetAssociationpartieobstaclespositionItem**
> Associationpartieobstaclesposition GetAssociationpartieobstaclespositionItem (string id)

Retrieves a Associationpartieobstaclesposition resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssociationpartieobstaclespositionItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssociationpartieobstaclespositionApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Associationpartieobstaclesposition resource.
                Associationpartieobstaclesposition result = apiInstance.GetAssociationpartieobstaclespositionItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationpartieobstaclespositionApi.GetAssociationpartieobstaclespositionItem: " + e.Message );
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

[**Associationpartieobstaclesposition**](Associationpartieobstaclesposition.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postassociationpartieobstaclespositioncollection"></a>
# **PostAssociationpartieobstaclespositionCollection**
> Associationpartieobstaclesposition PostAssociationpartieobstaclespositionCollection (Associationpartieobstaclesposition associationpartieobstaclesposition = null)

Creates a Associationpartieobstaclesposition resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAssociationpartieobstaclespositionCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssociationpartieobstaclespositionApi();
            var associationpartieobstaclesposition = new Associationpartieobstaclesposition(); // Associationpartieobstaclesposition | The new Associationpartieobstaclesposition resource (optional) 

            try
            {
                // Creates a Associationpartieobstaclesposition resource.
                Associationpartieobstaclesposition result = apiInstance.PostAssociationpartieobstaclespositionCollection(associationpartieobstaclesposition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationpartieobstaclespositionApi.PostAssociationpartieobstaclespositionCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **associationpartieobstaclesposition** | [**Associationpartieobstaclesposition**](Associationpartieobstaclesposition.md)| The new Associationpartieobstaclesposition resource | [optional] 

### Return type

[**Associationpartieobstaclesposition**](Associationpartieobstaclesposition.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putassociationpartieobstaclespositionitem"></a>
# **PutAssociationpartieobstaclespositionItem**
> Associationpartieobstaclesposition PutAssociationpartieobstaclespositionItem (string id, Associationpartieobstaclesposition associationpartieobstaclesposition = null)

Replaces the Associationpartieobstaclesposition resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAssociationpartieobstaclespositionItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AssociationpartieobstaclespositionApi();
            var id = id_example;  // string | 
            var associationpartieobstaclesposition = new Associationpartieobstaclesposition(); // Associationpartieobstaclesposition | The updated Associationpartieobstaclesposition resource (optional) 

            try
            {
                // Replaces the Associationpartieobstaclesposition resource.
                Associationpartieobstaclesposition result = apiInstance.PutAssociationpartieobstaclespositionItem(id, associationpartieobstaclesposition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssociationpartieobstaclespositionApi.PutAssociationpartieobstaclespositionItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **associationpartieobstaclesposition** | [**Associationpartieobstaclesposition**](Associationpartieobstaclesposition.md)| The updated Associationpartieobstaclesposition resource | [optional] 

### Return type

[**Associationpartieobstaclesposition**](Associationpartieobstaclesposition.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

