# IO.Swagger.Api.CompteApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCompteItem**](CompteApi.md#deletecompteitem) | **DELETE** /comptes/{id} | Removes the Compte resource.
[**GetByPseudojoueur**](CompteApi.md#getbypseudojoueur) | **GET** /comptes/byPseudojoueur/{pseudojoueur} | Retrieves a Compte resource.
[**GetCompteCollection**](CompteApi.md#getcomptecollection) | **GET** /comptes | Retrieves the collection of Compte resources.
[**GetCompteItem**](CompteApi.md#getcompteitem) | **GET** /comptes/{id} | Retrieves a Compte resource.
[**PostCompteCollection**](CompteApi.md#postcomptecollection) | **POST** /comptes | Creates a Compte resource.
[**PutCompteItem**](CompteApi.md#putcompteitem) | **PUT** /comptes/{id} | Replaces the Compte resource.


<a name="deletecompteitem"></a>
# **DeleteCompteItem**
> void DeleteCompteItem (string id)

Removes the Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCompteItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Compte resource.
                apiInstance.DeleteCompteItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.DeleteCompteItem: " + e.Message );
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

<a name="getbypseudojoueur"></a>
# **GetByPseudojoueur**
> Compte GetByPseudojoueur (string pseudojoueur)

Retrieves a Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetByPseudojoueurExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteApi();
            var pseudojoueur = pseudojoueur_example;  // string | Affiche le compte du joueur via son pseudo

            try
            {
                // Retrieves a Compte resource.
                Compte result = apiInstance.GetByPseudojoueur(pseudojoueur);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.GetByPseudojoueur: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pseudojoueur** | **string**| Affiche le compte du joueur via son pseudo | 

### Return type

[**Compte**](Compte.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomptecollection"></a>
# **GetCompteCollection**
> List<Compte> GetCompteCollection (int? page = null)

Retrieves the collection of Compte resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompteCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Compte resources.
                List&lt;Compte&gt; result = apiInstance.GetCompteCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.GetCompteCollection: " + e.Message );
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

[**List<Compte>**](Compte.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcompteitem"></a>
# **GetCompteItem**
> Compte GetCompteItem (string id)

Retrieves a Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompteItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Compte resource.
                Compte result = apiInstance.GetCompteItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.GetCompteItem: " + e.Message );
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

[**Compte**](Compte.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcomptecollection"></a>
# **PostCompteCollection**
> Compte PostCompteCollection (Compte compte = null)

Creates a Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCompteCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteApi();
            var compte = new Compte(); // Compte | The new Compte resource (optional) 

            try
            {
                // Creates a Compte resource.
                Compte result = apiInstance.PostCompteCollection(compte);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.PostCompteCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **compte** | [**Compte**](Compte.md)| The new Compte resource | [optional] 

### Return type

[**Compte**](Compte.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcompteitem"></a>
# **PutCompteItem**
> Compte PutCompteItem (string id, Compte compte = null)

Replaces the Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutCompteItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new CompteApi();
            var id = id_example;  // string | 
            var compte = new Compte(); // Compte | The updated Compte resource (optional) 

            try
            {
                // Replaces the Compte resource.
                Compte result = apiInstance.PutCompteItem(id, compte);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.PutCompteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **compte** | [**Compte**](Compte.md)| The updated Compte resource | [optional] 

### Return type

[**Compte**](Compte.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

