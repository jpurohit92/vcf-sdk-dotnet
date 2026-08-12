# Vcenter.Automation.OpenApi.Api.CisSessionApi

All URIs are relative to *https://localhost/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CisSessionCreate**](CisSessionApi.md#cissessioncreate) | **POST** /session |  |
| [**CisSessionDelete**](CisSessionApi.md#cissessiondelete) | **DELETE** /session |  |
| [**CisSessionGet**](CisSessionApi.md#cissessionget) | **GET** /session |  |

<a id="cissessioncreate"></a>
# **CisSessionCreate**
> string CisSessionCreate ()



Creates a session with the API. This is the equivalent of login. This operation exchanges user credentials supplied in the security context for a session token that is to be used for authenticating subsequent calls.   To authenticate subsequent calls clients are expected to include the session token. For REST API calls the HTTP `vmware-api-session-id` header field should be used for this.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class CisSessionCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure HTTP basic authorization: basic_auth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CisSessionApi(config);

            try
            {
                string result = apiInstance.CisSessionCreate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CisSessionApi.CisSessionCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CisSessionCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.CisSessionCreateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CisSessionApi.CisSessionCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[basic_auth](../README.md#basic_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** |  if the session creation fails due to request specific issues. Due to the security nature of the API the details of the error are not disclosed.    Please check the following preconditions if using a SAML token to authenticate:     - the supplied token is delegate-able.    - the time of client and server system are synchronized.    - the token supplied is valid.    - if bearer tokens are used check that system configuration allows the API endpoint to accept such tokens.   |  -  |
| **503** |  if session creation fails due to server specific issues, for example connection to a back end component is failing. Due to the security nature of this API further details will not be disclosed in the error. Please refer to component health information, administrative logs and product specific documentation for possible causes. |  -  |
| **201** | Newly created session token to be used for authenticating further requests. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cissessiondelete"></a>
# **CisSessionDelete**
> void CisSessionDelete ()



Terminates the validity of a session token. This is the equivalent of log out.    A session token is expected as part of the request.   

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class CisSessionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new CisSessionApi(config);

            try
            {
                apiInstance.CisSessionDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CisSessionApi.CisSessionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CisSessionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CisSessionDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CisSessionApi.CisSessionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** |  if the session id is missing from the request or the corresponding session object cannot be found. |  -  |
| **503** |  if session deletion fails due to server specific issues, for example connection to a back end component is failing. Due to the security nature of this API further details will not be disclosed in the error. Please refer to component health information, administrative logs and product specific documentation for possible causes. |  -  |
| **204** | Success! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cissessionget"></a>
# **CisSessionGet**
> CisSessionInfo CisSessionGet ()



Returns information about the current session. This operation expects a valid session token to be supplied.    A side effect of invoking this operation may be a change to the session's last accessed time to the current time if this is supported by the session implementation. Invoking any other operation in the API will also update the session's last accessed time.    This API is meant to serve the needs of various front end projects that may want to display the name of the user. Examples of this include various web based user interfaces and logging facilities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.Automation.OpenApi.Api;
using Vcenter.Automation.OpenApi.Client;
using Vcenter.Automation.OpenApi.Model;

namespace Example
{
    public class CisSessionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/api";
            // Configure API key authorization: api_key_auth
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new CisSessionApi(config);

            try
            {
                CisSessionInfo result = apiInstance.CisSessionGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CisSessionApi.CisSessionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CisSessionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CisSessionInfo> response = apiInstance.CisSessionGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CisSessionApi.CisSessionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CisSessionInfo**](CisSessionInfo.md)

### Authorization

[api_key_auth](../README.md#api_key_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** |  if the session id is missing from the request or the corresponding session object cannot be found. |  -  |
| **503** |  if session retrieval fails due to server specific issues e.g. connection to back end component is failing. Due to the security nature of this API further details will not be disclosed in the error. Please refer to component health information, administrative logs and product specific documentation for possible causes. |  -  |
| **200** | Information about the session. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

