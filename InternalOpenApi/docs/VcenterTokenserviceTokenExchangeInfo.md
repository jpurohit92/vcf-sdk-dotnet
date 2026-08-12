# Vcenter.Automation.OpenApi.Model.VcenterTokenserviceTokenExchangeInfo
This schema is deprecated as of __vSphere API 7.0.2.0__.  The Vcenter.Tokenservice.TokenExchange.Info schema contains data that represents successful token exchange response.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | This property is deprecated as of __vSphere API 7.0.2.0__.  The security token issued by the server in response to the token exchange request. Token is base64-encoded.  This property was added in __vSphere API 7.0.0.0__. | 
**IssuedTokenType** | **string** | This property is deprecated as of __vSphere API 7.0.2.0__.  An identifier, that indicates the type of the security token in the *Vcenter.Tokenservice.TokenExchange.Info.access_token* parameter.  This property was added in __vSphere API 7.0.0.0__. | 
**TokenType** | **string** | This property is deprecated as of __vSphere API 7.0.2.0__.  A case-insensitive value specifying the method of using the access token issued.  This property was added in __vSphere API 7.0.0.0__. | 
**ExpiresIn** | **long** | This property is deprecated as of __vSphere API 7.0.2.0__.  The validity lifetime, in seconds, of the token issued by the server.  This property was added in __vSphere API 7.0.0.0__.  if not applicable for issued token. | [optional] 
**Scope** | **string** | This property is deprecated as of __vSphere API 7.0.2.0__.  Scope of the issued security token.  This property was added in __vSphere API 7.0.0.0__.  if the scope of the issued security token is identical to the scope requested by the client. | [optional] 
**RefreshToken** | **string** | This property is deprecated as of __vSphere API 7.0.2.0__.  A refresh token can be issued in cases where the client of the token exchange needs the ability to access a resource even when the original credential is no longer valid.  This property was added in __vSphere API 7.0.0.0__.  if not needed for specific case of exchange. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

