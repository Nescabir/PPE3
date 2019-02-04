# IO.Swagger.Api.AvisApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAvisItem**](AvisApi.md#deleteavisitem) | **DELETE** /avis/{id} | Removes the Avis resource.
[**GetAvisCollection**](AvisApi.md#getaviscollection) | **GET** /avis | Retrieves the collection of Avis resources.
[**GetAvisItem**](AvisApi.md#getavisitem) | **GET** /avis/{id} | Retrieves a Avis resource.
[**GetByPseudojoueurAvis**](AvisApi.md#getbypseudojoueuravis) | **GET** /avis/byPseudojoueur/{pseudojoueur} | Retrieves the collection of Avis resources.
[**GetBySalleAvis**](AvisApi.md#getbysalleavis) | **GET** /avis/BySalle/{idsalle} | Retrieves the collection of Avis resources.
[**PostAvisCollection**](AvisApi.md#postaviscollection) | **POST** /avis | Creates a Avis resource.
[**PutAvisItem**](AvisApi.md#putavisitem) | **PUT** /avis/{id} | Replaces the Avis resource.


<a name="deleteavisitem"></a>
# **DeleteAvisItem**
> void DeleteAvisItem (string id)

Removes the Avis resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAvisItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvisApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Avis resource.
                apiInstance.DeleteAvisItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisApi.DeleteAvisItem: " + e.Message );
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

<a name="getaviscollection"></a>
# **GetAvisCollection**
> List<Avis> GetAvisCollection (int? page = null)

Retrieves the collection of Avis resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAvisCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvisApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Avis resources.
                List&lt;Avis&gt; result = apiInstance.GetAvisCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisApi.GetAvisCollection: " + e.Message );
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

[**List<Avis>**](Avis.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavisitem"></a>
# **GetAvisItem**
> Avis GetAvisItem (string id)

Retrieves a Avis resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAvisItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvisApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Avis resource.
                Avis result = apiInstance.GetAvisItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisApi.GetAvisItem: " + e.Message );
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

[**Avis**](Avis.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbypseudojoueuravis"></a>
# **GetByPseudojoueurAvis**
> List<Avis> GetByPseudojoueurAvis (string pseudojoueur, int? page = null)

Retrieves the collection of Avis resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetByPseudojoueurAvisExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvisApi();
            var pseudojoueur = pseudojoueur_example;  // string | Affiche les avis du joueur via son pseudo
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Avis resources.
                List&lt;Avis&gt; result = apiInstance.GetByPseudojoueurAvis(pseudojoueur, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisApi.GetByPseudojoueurAvis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pseudojoueur** | **string**| Affiche les avis du joueur via son pseudo | 
 **page** | **int?**| The collection page number | [optional] 

### Return type

[**List<Avis>**](Avis.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbysalleavis"></a>
# **GetBySalleAvis**
> List<Avis> GetBySalleAvis (int? idsalle, int? page = null)

Retrieves the collection of Avis resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBySalleAvisExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvisApi();
            var idsalle = 56;  // int? | Affiche les avis via l'id de la salle
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Avis resources.
                List&lt;Avis&gt; result = apiInstance.GetBySalleAvis(idsalle, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisApi.GetBySalleAvis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idsalle** | **int?**| Affiche les avis via l&#39;id de la salle | 
 **page** | **int?**| The collection page number | [optional] 

### Return type

[**List<Avis>**](Avis.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaviscollection"></a>
# **PostAvisCollection**
> Avis PostAvisCollection (Avis avis = null)

Creates a Avis resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAvisCollectionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvisApi();
            var avis = new Avis(); // Avis | The new Avis resource (optional) 

            try
            {
                // Creates a Avis resource.
                Avis result = apiInstance.PostAvisCollection(avis);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisApi.PostAvisCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **avis** | [**Avis**](Avis.md)| The new Avis resource | [optional] 

### Return type

[**Avis**](Avis.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putavisitem"></a>
# **PutAvisItem**
> Avis PutAvisItem (string id, Avis avis = null)

Replaces the Avis resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAvisItemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AvisApi();
            var id = id_example;  // string | 
            var avis = new Avis(); // Avis | The updated Avis resource (optional) 

            try
            {
                // Replaces the Avis resource.
                Avis result = apiInstance.PutAvisItem(id, avis);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AvisApi.PutAvisItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **avis** | [**Avis**](Avis.md)| The updated Avis resource | [optional] 

### Return type

[**Avis**](Avis.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/html
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

