# Vcenter.ViJson.OpenApi.Api.SessionManagerApi

All URIs are relative to *https://localhost/sdk/vim25/9.1.0.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SessionManagerAcquireCloneTicket**](SessionManagerApi.md#sessionmanageracquirecloneticket) | **POST** /SessionManager/{moId}/AcquireCloneTicket | Acquire a session-specific ticket string which can be used to clone the current session.  |
| [**SessionManagerAcquireGenericServiceTicket**](SessionManagerApi.md#sessionmanageracquiregenericserviceticket) | **POST** /SessionManager/{moId}/AcquireGenericServiceTicket | Creates and returns a one-time credential that may be used to make the specified request.  |
| [**SessionManagerAcquireLocalTicket**](SessionManagerApi.md#sessionmanageracquirelocalticket) | **POST** /SessionManager/{moId}/AcquireLocalTicket | Acquires a one-time ticket for mutual authentication between a server and client.  |
| [**SessionManagerCloneSession**](SessionManagerApi.md#sessionmanagerclonesession) | **POST** /SessionManager/{moId}/CloneSession | Clone the session specified by the clone ticket and associate it with the current connection.  |
| [**SessionManagerGetCurrentSession**](SessionManagerApi.md#sessionmanagergetcurrentsession) | **GET** /SessionManager/{moId}/currentSession | This property contains information about the client&#39;s current session.  |
| [**SessionManagerGetDefaultLocale**](SessionManagerApi.md#sessionmanagergetdefaultlocale) | **GET** /SessionManager/{moId}/defaultLocale | This is the default server locale.  |
| [**SessionManagerGetMessage**](SessionManagerApi.md#sessionmanagergetmessage) | **GET** /SessionManager/{moId}/message | The system global message from the server.  |
| [**SessionManagerGetMessageLocaleList**](SessionManagerApi.md#sessionmanagergetmessagelocalelist) | **GET** /SessionManager/{moId}/messageLocaleList | Provides the list of locales for which the server has localized messages.  |
| [**SessionManagerGetSessionList**](SessionManagerApi.md#sessionmanagergetsessionlist) | **GET** /SessionManager/{moId}/sessionList | The list of currently active sessions.  |
| [**SessionManagerGetSupportedLocaleList**](SessionManagerApi.md#sessionmanagergetsupportedlocalelist) | **GET** /SessionManager/{moId}/supportedLocaleList | Provides the list of locales that the server supports.  |
| [**SessionManagerImpersonateUser**](SessionManagerApi.md#sessionmanagerimpersonateuser) | **POST** /SessionManager/{moId}/ImpersonateUser | Converts current session to impersonate the specified user.  |
| [**SessionManagerLogin**](SessionManagerApi.md#sessionmanagerlogin) | **POST** /SessionManager/{moId}/Login | Log on to the server.  |
| [**SessionManagerLoginBySSPI**](SessionManagerApi.md#sessionmanagerloginbysspi) | **POST** /SessionManager/{moId}/LoginBySSPI | Log on to the server using SSPI pass-through authentication.  |
| [**SessionManagerLoginByToken**](SessionManagerApi.md#sessionmanagerloginbytoken) | **POST** /SessionManager/{moId}/LoginByToken | Log on to the server through token representing principal identity.  |
| [**SessionManagerLoginExtension**](SessionManagerApi.md#sessionmanagerloginextension) | **POST** /SessionManager/{moId}/LoginExtension | Creates a special privileged session that includes the Sessions.ImpersonateUser privilege.  |
| [**SessionManagerLoginExtensionByCertificate**](SessionManagerApi.md#sessionmanagerloginextensionbycertificate) | **POST** /SessionManager/{moId}/LoginExtensionByCertificate | Creates a special privileged session that includes the Sessions.ImpersonateUser privilege.  |
| [**SessionManagerLoginExtensionBySubjectName**](SessionManagerApi.md#sessionmanagerloginextensionbysubjectname) | **POST** /SessionManager/{moId}/LoginExtensionBySubjectName | Creates a special privileged session that includes the Sessions.ImpersonateUser privilege.  |
| [**SessionManagerLogout**](SessionManagerApi.md#sessionmanagerlogout) | **POST** /SessionManager/{moId}/Logout | Log out and terminate the current session.  |
| [**SessionManagerSessionIsActive**](SessionManagerApi.md#sessionmanagersessionisactive) | **POST** /SessionManager/{moId}/SessionIsActive | Validates that a currently-active session exists with the specified sessionID and userName associated with it.  |
| [**SessionManagerSetLocale**](SessionManagerApi.md#sessionmanagersetlocale) | **POST** /SessionManager/{moId}/SetLocale | Sets the session locale.  |
| [**SessionManagerTerminateSession**](SessionManagerApi.md#sessionmanagerterminatesession) | **POST** /SessionManager/{moId}/TerminateSession | Log off and terminate the provided list of sessions.  |
| [**SessionManagerUpdateServiceMessage**](SessionManagerApi.md#sessionmanagerupdateservicemessage) | **POST** /SessionManager/{moId}/UpdateServiceMessage | Updates the system global message.  |

<a id="sessionmanageracquirecloneticket"></a>
# **SessionManagerAcquireCloneTicket**
> string SessionManagerAcquireCloneTicket (string moId)

Acquire a session-specific ticket string which can be used to clone the current session. 

Acquire a session-specific ticket string which can be used to clone the current session.  The caller of this operation can pass the ticket value to another entity on the client. The recipient can then call *SessionManager.CloneSession* with the ticket string on an unauthenticated session and avoid having to re-enter credentials.  The ticket may only be used once and becomes invalid after use. The ticket is also invalidated when the corresponding session is closed or expires. The ticket is only valid on the server which issued it.  This sequence of operations is conceptually similar to the functionality provided by *SessionManager.AcquireLocalTicket*, however the methods can be used by remote clients and do not require a shared filesystem for transport.  See also *SessionManager.CloneSession*.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerAcquireCloneTicketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Acquire a session-specific ticket string which can be used to clone the current session. 
                string result = apiInstance.SessionManagerAcquireCloneTicket(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerAcquireCloneTicket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerAcquireCloneTicketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Acquire a session-specific ticket string which can be used to clone the current session. 
    ApiResponse<string> response = apiInstance.SessionManagerAcquireCloneTicketWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerAcquireCloneTicketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**string**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | one-time secret ticket string.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanageracquiregenericserviceticket"></a>
# **SessionManagerAcquireGenericServiceTicket**
> SessionManagerGenericServiceTicket SessionManagerAcquireGenericServiceTicket (string moId, AcquireGenericServiceTicketRequestType acquireGenericServiceTicketRequestType)

Creates and returns a one-time credential that may be used to make the specified request. 

Creates and returns a one-time credential that may be used to make the specified request.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerAcquireGenericServiceTicketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var acquireGenericServiceTicketRequestType = new AcquireGenericServiceTicketRequestType(); // AcquireGenericServiceTicketRequestType | 

            try
            {
                // Creates and returns a one-time credential that may be used to make the specified request. 
                SessionManagerGenericServiceTicket result = apiInstance.SessionManagerAcquireGenericServiceTicket(moId, acquireGenericServiceTicketRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerAcquireGenericServiceTicket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerAcquireGenericServiceTicketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates and returns a one-time credential that may be used to make the specified request. 
    ApiResponse<SessionManagerGenericServiceTicket> response = apiInstance.SessionManagerAcquireGenericServiceTicketWithHttpInfo(moId, acquireGenericServiceTicketRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerAcquireGenericServiceTicketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **acquireGenericServiceTicketRequestType** | [**AcquireGenericServiceTicketRequestType**](AcquireGenericServiceTicketRequestType.md) |  |  |

### Return type

[**SessionManagerGenericServiceTicket**](SessionManagerGenericServiceTicket.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | a ticket that may be used to invoke the specified request. The first choice for authenticating the host is *SessionManagerGenericServiceTicket.sslCertificate*. If *SessionManagerGenericServiceTicket.sslCertificate* is unset, the following logic is used to authenticate the host: 1\\. If the VC system supports the crypto hash algorithm of the *SessionManagerGenericServiceTicket.sslThumbprint* or *SessionManagerGenericServiceTicket.certThumbprintList* (if set), they will be verified against that of the server certificate. If they doesn&#39;t match, the CA certificates will be used to authenticate the host. 2\\. If the VC system does not support the crypto hash algorithm of *SessionManagerGenericServiceTicket.sslThumbprint* or *SessionManagerGenericServiceTicket.certThumbprintList*, only the CA certificates will be used to authenticate the host.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanageracquirelocalticket"></a>
# **SessionManagerAcquireLocalTicket**
> SessionManagerLocalTicket SessionManagerAcquireLocalTicket (string moId, AcquireLocalTicketRequestType acquireLocalTicketRequestType)

Acquires a one-time ticket for mutual authentication between a server and client. 

Acquires a one-time ticket for mutual authentication between a server and client.  The caller of this operation can use the user name and file content of the returned object as the userName and password arguments for login operation. The local ticket that is returned becomes invalid either after it is used or after a server-determined ticket expiration time passes. This operation can be used by servers and clients to avoid re-entering user credentials after authentication by the operating system has already happened.  For example, service console utilities that connect to a host agent should not require users to re-enter their passwords every time the utilities run. Since the one-time password file is readable only by the given user, the identity of the one-time password user is protected by the operating system file permission.  Only local clients are allowed to call this operation. Remote clients receive an InvalidRequest fault upon calling this operation.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerAcquireLocalTicketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var acquireLocalTicketRequestType = new AcquireLocalTicketRequestType(); // AcquireLocalTicketRequestType | 

            try
            {
                // Acquires a one-time ticket for mutual authentication between a server and client. 
                SessionManagerLocalTicket result = apiInstance.SessionManagerAcquireLocalTicket(moId, acquireLocalTicketRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerAcquireLocalTicket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerAcquireLocalTicketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Acquires a one-time ticket for mutual authentication between a server and client. 
    ApiResponse<SessionManagerLocalTicket> response = apiInstance.SessionManagerAcquireLocalTicketWithHttpInfo(moId, acquireLocalTicketRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerAcquireLocalTicketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **acquireLocalTicketRequestType** | [**AcquireLocalTicketRequestType**](AcquireLocalTicketRequestType.md) |  |  |

### Return type

[**SessionManagerLocalTicket**](SessionManagerLocalTicket.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LocalTicket object containing userName and path to file containing one-time password for use in login operation.  |  -  |
| **500** | ***InvalidLogin***: if the userName is invalid.  ***NoPermission***: if the user and password are valid, but the user has no access granted.  ***NotSupported***: if the server does not support this operation.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerclonesession"></a>
# **SessionManagerCloneSession**
> UserSession SessionManagerCloneSession (string moId, CloneSessionRequestType cloneSessionRequestType)

Clone the session specified by the clone ticket and associate it with the current connection. 

Clone the session specified by the clone ticket and associate it with the current connection.  The current session will take on the identity and authorization level of the UserSession associated with the specified cloning ticket.  See also *SessionManager.AcquireCloneTicket*, *SessionManager.AcquireGenericServiceTicket*.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerCloneSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var cloneSessionRequestType = new CloneSessionRequestType(); // CloneSessionRequestType | 

            try
            {
                // Clone the session specified by the clone ticket and associate it with the current connection. 
                UserSession result = apiInstance.SessionManagerCloneSession(moId, cloneSessionRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerCloneSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerCloneSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clone the session specified by the clone ticket and associate it with the current connection. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerCloneSessionWithHttpInfo(moId, cloneSessionRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerCloneSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **cloneSessionRequestType** | [**CloneSessionRequestType**](CloneSessionRequestType.md) |  |  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The new/cloned UserSession object.  |  -  |
| **500** | ***InvalidLogin***: if the specified ticket value is not valid.  ***NotSupported***: if the server does not support this operation.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagergetcurrentsession"></a>
# **SessionManagerGetCurrentSession**
> UserSession SessionManagerGetCurrentSession (string moId)

This property contains information about the client's current session. 

This property contains information about the client's current session.  If the client is not logged on, the value is null.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerGetCurrentSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // This property contains information about the client's current session. 
                UserSession result = apiInstance.SessionManagerGetCurrentSession(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetCurrentSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerGetCurrentSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This property contains information about the client's current session. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerGetCurrentSessionWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetCurrentSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagergetdefaultlocale"></a>
# **SessionManagerGetDefaultLocale**
> string SessionManagerGetDefaultLocale (string moId)

This is the default server locale. 

This is the default server locale.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerGetDefaultLocaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // This is the default server locale. 
                string result = apiInstance.SessionManagerGetDefaultLocale(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetDefaultLocale: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerGetDefaultLocaleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This is the default server locale. 
    ApiResponse<string> response = apiInstance.SessionManagerGetDefaultLocaleWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetDefaultLocaleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**string**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagergetmessage"></a>
# **SessionManagerGetMessage**
> string SessionManagerGetMessage (string moId)

The system global message from the server. 

The system global message from the server.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerGetMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The system global message from the server. 
                string result = apiInstance.SessionManagerGetMessage(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerGetMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The system global message from the server. 
    ApiResponse<string> response = apiInstance.SessionManagerGetMessageWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**string**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagergetmessagelocalelist"></a>
# **SessionManagerGetMessageLocaleList**
> List&lt;string&gt; SessionManagerGetMessageLocaleList (string moId)

Provides the list of locales for which the server has localized messages. 

Provides the list of locales for which the server has localized messages.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerGetMessageLocaleListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Provides the list of locales for which the server has localized messages. 
                List<string> result = apiInstance.SessionManagerGetMessageLocaleList(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetMessageLocaleList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerGetMessageLocaleListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provides the list of locales for which the server has localized messages. 
    ApiResponse<List<string>> response = apiInstance.SessionManagerGetMessageLocaleListWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetMessageLocaleListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**List<string>**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagergetsessionlist"></a>
# **SessionManagerGetSessionList**
> List&lt;UserSession&gt; SessionManagerGetSessionList (string moId)

The list of currently active sessions. 

The list of currently active sessions.  ***Required privileges:*** Sessions.TerminateSession 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerGetSessionListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // The list of currently active sessions. 
                List<UserSession> result = apiInstance.SessionManagerGetSessionList(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetSessionList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerGetSessionListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The list of currently active sessions. 
    ApiResponse<List<UserSession>> response = apiInstance.SessionManagerGetSessionListWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetSessionListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

[**List&lt;UserSession&gt;**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagergetsupportedlocalelist"></a>
# **SessionManagerGetSupportedLocaleList**
> List&lt;string&gt; SessionManagerGetSupportedLocaleList (string moId)

Provides the list of locales that the server supports. 

Provides the list of locales that the server supports.  Listing a locale ensures that some standardized information such as dates appear in the appropriate format. Other localized information, such as error messages, are displayed, if available. If localized information is not available, the message is returned using the system locale.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerGetSupportedLocaleListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Provides the list of locales that the server supports. 
                List<string> result = apiInstance.SessionManagerGetSupportedLocaleList(moId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetSupportedLocaleList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerGetSupportedLocaleListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provides the list of locales that the server supports. 
    ApiResponse<List<string>> response = apiInstance.SessionManagerGetSupportedLocaleListWithHttpInfo(moId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerGetSupportedLocaleListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

**List<string>**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerimpersonateuser"></a>
# **SessionManagerImpersonateUser**
> UserSession SessionManagerImpersonateUser (string moId, ImpersonateUserRequestType impersonateUserRequestType)

Converts current session to impersonate the specified user. 

Converts current session to impersonate the specified user.  The current session will take on the identity and authorization level of the user. That user must have a currently-active session. If the given userName is an extension key and this key does not overlap with a user name of any currently-active session, it will take on the identity and authorization level of that extension provided the current session has the same authorization level of that extension.  ***Required privileges:*** Sessions.ImpersonateUser 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerImpersonateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var impersonateUserRequestType = new ImpersonateUserRequestType(); // ImpersonateUserRequestType | 

            try
            {
                // Converts current session to impersonate the specified user. 
                UserSession result = apiInstance.SessionManagerImpersonateUser(moId, impersonateUserRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerImpersonateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerImpersonateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Converts current session to impersonate the specified user. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerImpersonateUserWithHttpInfo(moId, impersonateUserRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerImpersonateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **impersonateUserRequestType** | [**ImpersonateUserRequestType**](ImpersonateUserRequestType.md) |  |  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |
| **500** | Failure  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerlogin"></a>
# **SessionManagerLogin**
> UserSession SessionManagerLogin (string moId, LoginRequestType loginRequestType)

Log on to the server. 

Log on to the server.  This method fails if the user name and password are incorrect, or if the user is valid but has no permissions granted.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var loginRequestType = new LoginRequestType(); // LoginRequestType | 

            try
            {
                // Log on to the server. 
                UserSession result = apiInstance.SessionManagerLogin(moId, loginRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log on to the server. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerLoginWithHttpInfo(moId, loginRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **loginRequestType** | [**LoginRequestType**](LoginRequestType.md) |  |  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The UserSession object.  As of vSphere API 5.1 for VirtualCenter login use SSO style *SessionManager.LoginByToken*  |  -  |
| **500** | ***InvalidLogin***: if the user and password combination is invalid.  ***NoPermission***: if the user is valid, but has no access granted.  ***InvalidLocale***: if the locale is invalid or unknown to the server.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerloginbysspi"></a>
# **SessionManagerLoginBySSPI**
> UserSession SessionManagerLoginBySSPI (string moId, LoginBySSPIRequestType loginBySSPIRequestType)

Log on to the server using SSPI pass-through authentication. 

Deprecated as of vSphere API 5.1 for VirtualCenter login use SSO style *SessionManager.LoginByToken*.  Log on to the server using SSPI pass-through authentication.  This method provides support for passing credentials of the calling process to the server without using a password, by leveraging the Windows Security Support Provider Interface (SSPI) library.  If the function is not supported, this throws a NotSupported fault.  The client first calls AcquireCredentialsHandle(). If Kerberos is used, this should include the desired credential to pass. The client then calls InitializeSecurityContext(). The resulting partially-formed context is passed in Base-64 encoded form to this method.  If the context has been successfully formed, the server proceeds with login and behaves like *SessionManager.Login*. If further negotiation is needed, the server throws an SSPIChallenge fault with a challenge token, which the client should again pass to InitializeSecurityContext(), followed by calling this method again.  For more information, see the MSDN documentation on SSPI.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerLoginBySSPIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var loginBySSPIRequestType = new LoginBySSPIRequestType(); // LoginBySSPIRequestType | 

            try
            {
                // Log on to the server using SSPI pass-through authentication. 
                UserSession result = apiInstance.SessionManagerLoginBySSPI(moId, loginBySSPIRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginBySSPI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerLoginBySSPIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log on to the server using SSPI pass-through authentication. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerLoginBySSPIWithHttpInfo(moId, loginBySSPIRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginBySSPIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **loginBySSPIRequestType** | [**LoginBySSPIRequestType**](LoginBySSPIRequestType.md) |  |  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The UserSession object.  |  -  |
| **500** | ***SSPIChallenge***: if further negotiation is required.  ***InvalidLogin***: if the user context could not be passed successfully, or the context is not valid on the server.  ***NoPermission***: if the user is valid, but has no access granted.  ***InvalidLocale***: if the locale is invalid or unknown to the server.  ***NotSupported***: if the service does not support SSPI authentication.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerloginbytoken"></a>
# **SessionManagerLoginByToken**
> UserSession SessionManagerLoginByToken (string moId, LoginByTokenRequestType? loginByTokenRequestType = null)

Log on to the server through token representing principal identity. 

Log on to the server through token representing principal identity.  The token is obtained from SSO (single sign-on) service. This method fails if the token is not valid, or the principal has no permissions granted. Two type of sso tokens are supported by this method: Bearer and Holder-of-Key (HoK). If the token type obliges the method caller to prove his rights to present this token (HoK), then a signature is supplied as well. The token and the security signature if available are provided in a transport specific way.  If the communication with the VirtualCenter is SOAP based read the WS-Security specification (SAML Token profile) to understand how to transport the SSO token and signature.  Usual login scenario: 1. Acquire HoK token from the SSO service. Different authentication    mechanisms are available for acquiring token (user/password,    certificate, SSPI and so on). For more details consult the SSO    documentation. To find the location of your SSO service consult the    Virtual Infrastructure documentation. 2. Once SSO token is acquired successfully *SessionManager.LoginByToken* could be    invoked.     ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerLoginByTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var loginByTokenRequestType = new LoginByTokenRequestType?(); // LoginByTokenRequestType? |  (optional) 

            try
            {
                // Log on to the server through token representing principal identity. 
                UserSession result = apiInstance.SessionManagerLoginByToken(moId, loginByTokenRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginByToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerLoginByTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log on to the server through token representing principal identity. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerLoginByTokenWithHttpInfo(moId, loginByTokenRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginByTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **loginByTokenRequestType** | [**LoginByTokenRequestType?**](LoginByTokenRequestType?.md) |  | [optional]  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The UserSession object.  |  -  |
| **500** | ***InvalidLogin***: if there is no token provided or the token could not be validated or trying to login with an already authenticated session. In the case of an already authenticated session the fault message key will be set to \&quot;vim.fault.InvalidLoginWithReason\&quot; with value: 1\\. \&quot;vim.fault.InvalidLoginReasonRegisterFailed\&quot; if client tries to login to an already authenticated session. 2\\. \&quot;vim.fault.InvalidLoginReasonTerminating\&quot; if current session is being terminated. 3\\. \&quot;vim.fault.InvalidLoginReasonAlreadyClosed\&quot; if current session is already closed.  ***NoPermission***: if the principal is valid, but has no access granted.  ***InvalidLocale***: if the locale is invalid or unknown to the server.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerloginextension"></a>
# **SessionManagerLoginExtension**
> UserSession SessionManagerLoginExtension (string moId, LoginExtensionRequestType loginExtensionRequestType)

Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 

Deprecated as of vSphere API 4.0, use SSO style of login instead *SessionManager.LoginByToken*.  Creates a special privileged session that includes the Sessions.ImpersonateUser privilege.  Requires exchange of a message signed with the extension's registered public key and base-64 encoded.  As of vSphere API 4.0, the NotFound fault is no longer thrown. Instead, InvalidLogin is thrown if the specified extension is not registered.  As of vSphere API 5.0, this method always throws a NotSupported exception.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerLoginExtensionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var loginExtensionRequestType = new LoginExtensionRequestType(); // LoginExtensionRequestType | 

            try
            {
                // Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 
                UserSession result = apiInstance.SessionManagerLoginExtension(moId, loginExtensionRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginExtension: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerLoginExtensionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerLoginExtensionWithHttpInfo(moId, loginExtensionRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginExtensionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **loginExtensionRequestType** | [**LoginExtensionRequestType**](LoginExtensionRequestType.md) |  |  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |
| **500** | Failure  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerloginextensionbycertificate"></a>
# **SessionManagerLoginExtensionByCertificate**
> UserSession SessionManagerLoginExtensionByCertificate (string moId, LoginExtensionByCertificateRequestType loginExtensionByCertificateRequestType)

Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 

Deprecated as of vSphere API 6.0, use SSO style of login instead *SessionManager.LoginByToken*.  Creates a special privileged session that includes the Sessions.ImpersonateUser privilege.  Requires that the client connect over SSL and provide an X.509 certificate for which they hold the private key. The certificate must match the certificate used in an earlier call to *ExtensionManager.SetExtensionCertificate*.  NOTE: Verification of the received certificate (such as expiry, revocation, and trust chain) is not required for successful authentication using this method. If certificate verification is desired, use the *SessionManager.LoginExtensionBySubjectName* method instead.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerLoginExtensionByCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var loginExtensionByCertificateRequestType = new LoginExtensionByCertificateRequestType(); // LoginExtensionByCertificateRequestType | 

            try
            {
                // Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 
                UserSession result = apiInstance.SessionManagerLoginExtensionByCertificate(moId, loginExtensionByCertificateRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginExtensionByCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerLoginExtensionByCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerLoginExtensionByCertificateWithHttpInfo(moId, loginExtensionByCertificateRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginExtensionByCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **loginExtensionByCertificateRequestType** | [**LoginExtensionByCertificateRequestType**](LoginExtensionByCertificateRequestType.md) |  |  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |
| **500** | ***InvalidLogin***: if the extension is not registered, or the certificate does not match the expected value.  ***InvalidLocale***: if the supplied locale is not valid  ***NoClientCertificate***: if no certificate was used by the client to connect  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerloginextensionbysubjectname"></a>
# **SessionManagerLoginExtensionBySubjectName**
> UserSession SessionManagerLoginExtensionBySubjectName (string moId, LoginExtensionBySubjectNameRequestType loginExtensionBySubjectNameRequestType)

Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 

Deprecated as of vSphere API 6.0, use SSO style of login instead *SessionManager.LoginByToken*.  Creates a special privileged session that includes the Sessions.ImpersonateUser privilege.  Requires that the extension connected using SSL, with a certificate that has a subject name that matches the subject name registered for the extension.  As of vSphere API 4.0, the NotFound fault is no longer thrown. Instead, InvalidLogin is thrown if the specified extension is not registered.  ***Required privileges:*** System.Anonymous 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerLoginExtensionBySubjectNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var loginExtensionBySubjectNameRequestType = new LoginExtensionBySubjectNameRequestType(); // LoginExtensionBySubjectNameRequestType | 

            try
            {
                // Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 
                UserSession result = apiInstance.SessionManagerLoginExtensionBySubjectName(moId, loginExtensionBySubjectNameRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginExtensionBySubjectName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerLoginExtensionBySubjectNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a special privileged session that includes the Sessions.ImpersonateUser privilege. 
    ApiResponse<UserSession> response = apiInstance.SessionManagerLoginExtensionBySubjectNameWithHttpInfo(moId, loginExtensionBySubjectNameRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerLoginExtensionBySubjectNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **loginExtensionBySubjectNameRequestType** | [**LoginExtensionBySubjectNameRequestType**](LoginExtensionBySubjectNameRequestType.md) |  |  |

### Return type

[**UserSession**](UserSession.md)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |
| **500** | ***InvalidLogin***: if the extension is not registered, or the subject name doesn&#39;t match the subject name of the extension.  ***InvalidLocale***: if the supplied locale is not valid  ***NotFound***: if no extension is associated with the given key  ***NoClientCertificate***: if no certificate was used by the client to connect  ***NoSubjectName***: if the extension was registered without a subject name  ***InvalidClientCertificate***: if the client certificate fails the verification at the server  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerlogout"></a>
# **SessionManagerLogout**
> void SessionManagerLogout (string moId)

Log out and terminate the current session. 

Log out and terminate the current session.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerLogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.

            try
            {
                // Log out and terminate the current session. 
                apiInstance.SessionManagerLogout(moId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerLogout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerLogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log out and terminate the current session. 
    apiInstance.SessionManagerLogoutWithHttpInfo(moId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerLogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagersessionisactive"></a>
# **SessionManagerSessionIsActive**
> bool SessionManagerSessionIsActive (string moId, SessionIsActiveRequestType sessionIsActiveRequestType)

Validates that a currently-active session exists with the specified sessionID and userName associated with it. 

Validates that a currently-active session exists with the specified sessionID and userName associated with it.  Returns true if session exists.  ***Required privileges:*** Sessions.ValidateSession 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerSessionIsActiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var sessionIsActiveRequestType = new SessionIsActiveRequestType(); // SessionIsActiveRequestType | 

            try
            {
                // Validates that a currently-active session exists with the specified sessionID and userName associated with it. 
                bool result = apiInstance.SessionManagerSessionIsActive(moId, sessionIsActiveRequestType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerSessionIsActive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerSessionIsActiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validates that a currently-active session exists with the specified sessionID and userName associated with it. 
    ApiResponse<bool> response = apiInstance.SessionManagerSessionIsActiveWithHttpInfo(moId, sessionIsActiveRequestType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerSessionIsActiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **sessionIsActiveRequestType** | [**SessionIsActiveRequestType**](SessionIsActiveRequestType.md) |  |  |

### Return type

**bool**

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagersetlocale"></a>
# **SessionManagerSetLocale**
> void SessionManagerSetLocale (string moId, SetLocaleRequestType setLocaleRequestType)

Sets the session locale. 

Sets the session locale.  ***Required privileges:*** System.View 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerSetLocaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var setLocaleRequestType = new SetLocaleRequestType(); // SetLocaleRequestType | 

            try
            {
                // Sets the session locale. 
                apiInstance.SessionManagerSetLocale(moId, setLocaleRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerSetLocale: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerSetLocaleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets the session locale. 
    apiInstance.SessionManagerSetLocaleWithHttpInfo(moId, setLocaleRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerSetLocaleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **setLocaleRequestType** | [**SetLocaleRequestType**](SetLocaleRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***InvalidLocale***: if the locale is invalid or unknown to the server.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerterminatesession"></a>
# **SessionManagerTerminateSession**
> void SessionManagerTerminateSession (string moId, TerminateSessionRequestType terminateSessionRequestType)

Log off and terminate the provided list of sessions. 

Log off and terminate the provided list of sessions.  This method is only transactional for each session ID. The set of sessions are terminated sequentially, as specified in the list. If a failure occurs, for example, because of an unknown sessionID, the method aborts with an exception. When the method aborts, any sessions that have not yet been terminated are left in their unterminated state.  ***Required privileges:*** Sessions.TerminateSession 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerTerminateSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var terminateSessionRequestType = new TerminateSessionRequestType(); // TerminateSessionRequestType | 

            try
            {
                // Log off and terminate the provided list of sessions. 
                apiInstance.SessionManagerTerminateSession(moId, terminateSessionRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerTerminateSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerTerminateSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log off and terminate the provided list of sessions. 
    apiInstance.SessionManagerTerminateSessionWithHttpInfo(moId, terminateSessionRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerTerminateSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **terminateSessionRequestType** | [**TerminateSessionRequestType**](TerminateSessionRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |
| **500** | ***NotFound***: if a sessionId could not be found as a valid logged-on session.  ***InvalidArgument***: if a sessionId matches the current session. Use the logout method to terminate the current session.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sessionmanagerupdateservicemessage"></a>
# **SessionManagerUpdateServiceMessage**
> void SessionManagerUpdateServiceMessage (string moId, UpdateServiceMessageRequestType updateServiceMessageRequestType)

Updates the system global message. 

Updates the system global message.  If not blank, the message is immediately displayed to currently logged-on users. When set, the message is shown by new clients upon logging in.  ***Required privileges:*** Sessions.GlobalMessage 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Vcenter.ViJson.OpenApi.Api;
using Vcenter.ViJson.OpenApi.Client;
using Vcenter.ViJson.OpenApi.Model;

namespace Example
{
    public class SessionManagerUpdateServiceMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost/sdk/vim25/9.1.0.0";
            // Configure API key authorization: Session
            config.AddApiKey("vmware-api-session-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("vmware-api-session-id", "Bearer");

            var apiInstance = new SessionManagerApi(config);
            var moId = "moId_example";  // string | A unique identifier (within this vCenter Server instance) for a specific managed object such as `group-d1` or `vm-015` or `ServiceInstance`.
            var updateServiceMessageRequestType = new UpdateServiceMessageRequestType(); // UpdateServiceMessageRequestType | 

            try
            {
                // Updates the system global message. 
                apiInstance.SessionManagerUpdateServiceMessage(moId, updateServiceMessageRequestType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionManagerApi.SessionManagerUpdateServiceMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SessionManagerUpdateServiceMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the system global message. 
    apiInstance.SessionManagerUpdateServiceMessageWithHttpInfo(moId, updateServiceMessageRequestType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionManagerApi.SessionManagerUpdateServiceMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moId** | **string** | A unique identifier (within this vCenter Server instance) for a specific managed object such as &#x60;group-d1&#x60; or &#x60;vm-015&#x60; or &#x60;ServiceInstance&#x60;. |  |
| **updateServiceMessageRequestType** | [**UpdateServiceMessageRequestType**](UpdateServiceMessageRequestType.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Session](../README.md#Session)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

