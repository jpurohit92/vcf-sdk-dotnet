# Vcenter.Automation.OpenApi.Model.VcenterIdentityProvidersOidcSummary
The Vcenter.Identity.Providers.OidcSummary schema contains commonly used information about an OIDC identity provider. OIDC is a discovery protocol for OAuth2 configuration metadata, so Vcenter.Identity.Providers.OidcSummary contains discovered OAuth2 metadata.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscoveryEndpoint** | **string** | Endpoint to retrieve the provider metadata  This property was added in __vSphere API 7.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**LogoutEndpoint** | **string** | The endpoint to use for terminating the user&#39;s session at the identity provider. This value is automatically derived from the metadata information provided by the OIDC discovery endpoint.  This property was added in __vSphere API 7.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**AuthEndpoint** | **string** | Authentication/authorization endpoint of the provider  This property was added in __vSphere API 7.0.0.0__. | 
**TokenEndpoint** | **string** | Token endpoint of the provider  This property was added in __vSphere API 7.0.0.0__. | 
**ClientId** | **string** | Client identifier to connect to the provider  This property was added in __vSphere API 7.0.0.0__. | 
**AuthenticationHeader** | **string** | The authentication data used as part of request header to acquire or refresh an OAuth2 token. The data format depends on the authentication method used. Example of basic authentication format: Authorization: Basic [base64Encode(clientId + \&quot;:\&quot; + secret)]  This property was added in __vSphere API 7.0.0.0__. | 
**AuthQueryParams** | **Dictionary&lt;string, List&lt;string&gt;&gt;** |   key/value pairs that are to be appended to the authEndpoint request.   How to append to authEndpoint request: If the map is not empty, a \&quot;?\&quot; is added to the endpoint URL, and combination of each k and each string in the v is added with an \&quot;&amp;\&quot; delimiter. Details:    - If the value contains only one string, then the key is added with \&quot;k&#x3D;v\&quot;.    - If the value is an empty list, then the key is added without a \&quot;&#x3D;v\&quot;.    - If the value contains multiple strings, then the key is repeated in the query-string for each string in the value.   This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

