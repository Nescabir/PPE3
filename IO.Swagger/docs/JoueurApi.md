# IO.Swagger.Api.JoueurApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteJoueurItem**](JoueurApi.md#deletejoueuritem) | **DELETE** /joueurs/{id} | Removes the Joueur resource.
[**GetByIdjoueur**](JoueurApi.md#getbyidjoueur) | **GET** /joueurs/byIdjoueur/{idjoueur} | Retrieves a Joueur resource.
[**GetByPseudo**](JoueurApi.md#getbypseudo) | **GET** /joueurs/byPseudo/{pseudo} | Retrieves a Joueur resource.
[**GetJoueurCollection**](JoueurApi.md#getjoueurcollection) | **GET** /joueurs | Retrieves the collection of Joueur resources.
[**GetJoueurItem**](JoueurApi.md#getjoueuritem) | **GET** /joueurs/{id} | Retrieves a Joueur resource.
[**PostJoueurCollection**](JoueurApi.md#postjoueurcollection) | **POST** /joueurs | Creates a Joueur resource.
[**PutJoueurItem**](JoueurApi.md#putjoueuritem) | **PUT** /joueurs/{id} | Replaces the Joueur resource.


<a name="deletejoueuritem"></a>
# **DeleteJoueurItem**
> void DeleteJoueurItem (string id)

Removes the Joueur resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteJoueurItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Joueur resource.
                apiInstance.DeleteJoueurItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurApi.DeleteJoueurItem: " + e.Message );
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

<a name="getbyidjoueur"></a>
# **GetByIdjoueur**
> Joueur GetByIdjoueur (string idjoueur)

Retrieves a Joueur resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetByIdjoueurExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurApi();
            var idjoueur = idjoueur_example;  // string | Id du joueur

            try
            {
                // Retrieves a Joueur resource.
                Joueur result = apiInstance.GetByIdjoueur(idjoueur);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurApi.GetByIdjoueur: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idjoueur** | **string**| Id du joueur | 

### Return type

[**Joueur**](Joueur.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbypseudo"></a>
# **GetByPseudo**
> Joueur GetByPseudo (string pseudo)

Retrieves a Joueur resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetByPseudoExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurApi();
            var pseudo = pseudo_example;  // string | Pseudo du joueur

            try
            {
                // Retrieves a Joueur resource.
                Joueur result = apiInstance.GetByPseudo(pseudo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurApi.GetByPseudo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pseudo** | **string**| Pseudo du joueur | 

### Return type

[**Joueur**](Joueur.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjoueurcollection"></a>
# **GetJoueurCollection**
> List<Joueur> GetJoueurCollection (int? page = null)

Retrieves the collection of Joueur resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJoueurCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Joueur resources.
                List&lt;Joueur&gt; result = apiInstance.GetJoueurCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurApi.GetJoueurCollection: " + e.Message );
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

[**List<Joueur>**](Joueur.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjoueuritem"></a>
# **GetJoueurItem**
> Joueur GetJoueurItem (string id)

Retrieves a Joueur resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJoueurItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Joueur resource.
                Joueur result = apiInstance.GetJoueurItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurApi.GetJoueurItem: " + e.Message );
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

[**Joueur**](Joueur.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postjoueurcollection"></a>
# **PostJoueurCollection**
> Joueur PostJoueurCollection (Joueur joueur = null)

Creates a Joueur resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostJoueurCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurApi();
            var joueur = new Joueur(); // Joueur | The new Joueur resource (optional) 

            try
            {
                // Creates a Joueur resource.
                Joueur result = apiInstance.PostJoueurCollection(joueur);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurApi.PostJoueurCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **joueur** | [**Joueur**](Joueur.md)| The new Joueur resource | [optional] 

### Return type

[**Joueur**](Joueur.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putjoueuritem"></a>
# **PutJoueurItem**
> Joueur PutJoueurItem (string id, Joueur joueur = null)

Replaces the Joueur resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutJoueurItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JoueurApi();
            var id = id_example;  // string | 
            var joueur = new Joueur(); // Joueur | The updated Joueur resource (optional) 

            try
            {
                // Replaces the Joueur resource.
                Joueur result = apiInstance.PutJoueurItem(id, joueur);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JoueurApi.PutJoueurItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **joueur** | [**Joueur**](Joueur.md)| The updated Joueur resource | [optional] 

### Return type

[**Joueur**](Joueur.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

