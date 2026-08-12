# Vcenter.Automation.OpenApi.Model.Oauth2TokenInfo
The Oauth2.TokenInfo schema contains data that represents successful access-token response as defined in [RFC 6749](https://tools.ietf.org/html/rfc6749#section-5) and extended in [RFC 8693](https://tools.ietf.org/html/rfc8693#section-2.2.1).  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | The access token issued by the authorization server.  This property was added in __vSphere API 7.0.2.0__. | 
**TokenType** | **string** | A case-insensitive value specifying the method of using the access token issued.  This property was added in __vSphere API 7.0.2.0__. | 
**ExpiresIn** | **long** | The validity lifetime, in seconds, of the token issued by the server.  This property was added in __vSphere API 7.0.2.0__.  missing or &#x60;null&#x60; if not applicable for issued token. | [optional] 
**Scope** | **string** | Scope of the issued access token. The value of the scope parameter is expressed as a list of space- delimited, case-sensitive strings. The strings are defined by the authorization server. If the value contains multiple space-delimited strings, their order does not matter, and each string adds an additional access range to the requested scope.  This property was added in __vSphere API 7.0.2.0__.  missing or &#x60;null&#x60; if the scope of the issued security token is identical to the scope requested by the client. | [optional] 
**RefreshToken** | **string** | The refresh token, which can be used to obtain new access tokens.  This property was added in __vSphere API 7.0.2.0__.  missing or &#x60;null&#x60; if not applicable to the specific request. | [optional] 
**IssuedTokenType** | **string** | An identifier which indicates the type of the access token in the *Oauth2.TokenInfo.access_token* property.  This property was added in __vSphere API 7.0.2.0__.  missing or &#x60;null&#x60; if not the result of a token-exchange invocation; otherwise, required. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

