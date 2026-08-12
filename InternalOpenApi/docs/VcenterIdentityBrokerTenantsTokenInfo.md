# Vcenter.Automation.OpenApi.Model.VcenterIdentityBrokerTenantsTokenInfo
The Vcenter.Identity.Broker.Tenants.TokenInfo schema contains detailed information about the tenant token.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenType** | **string** | The type of the token issued. The access token type provides the client with the information required to successfully utilize the access token to make a protected resource request (along with type-specific attributes). The client MUST NOT use an access token if it does not understand the token type.    \&quot;Bearer\&quot; token type as defined in RFC 6750 is supported.  This property was added in __vSphere API 8.0.1.0__. | 
**AccessToken** | **string** | Tenant client access token issued by the authorization server.  This property was added in __vSphere API 8.0.1.0__. | 
**ExpiresIn** | **long** | The lifetime in seconds of the access token. For example, the value \&quot;3600\&quot; denotes that the access token will expire in one hour from the time the response was generated.  This property was added in __vSphere API 8.0.1.0__.  missing or &#x60;null&#x60; if not applicable for issued token. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

