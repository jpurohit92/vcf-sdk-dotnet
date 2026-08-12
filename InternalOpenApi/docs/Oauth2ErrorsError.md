# Vcenter.Automation.OpenApi.Model.Oauth2ErrorsError
The OAuth2 Oauth2.Errors.Error describes the properties common to standard OAuth 2.0 errors.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | **string** | Discriminator field to help API consumers identify the structure type.  Possible values:   - &#x60;invalid_request&#x60;: Discriminator for the *Oauth2.Errors.InvalidRequest* type.   - &#x60;invalid_scope&#x60;: Discriminator for the *Oauth2.Errors.InvalidScope* type.   - &#x60;invalid_grant&#x60;: Discriminator for the *Oauth2.Errors.InvalidGrant* type.   - &#x60;invalid_client&#x60;: Discriminator for the *Oauth2.Errors.InvalidClient* type.  This constant was added in __vSphere API 8.0.3.0__.   - &#x60;unauthorized_client&#x60;: Discriminator for the *Oauth2.Errors.UnauthorizedClient* type.  This constant was added in __vSphere API 8.0.3.0__.   - &#x60;unsupported_grant_type&#x60;: Discriminator for the *Oauth2.Errors.UnsupportedGrantType* type.  This constant was added in __vSphere API 8.0.3.0__.   - &#x60;invalid_target&#x60;: Discriminator for the *Oauth2.Errors.InvalidTarget* type  This constant was added in __vSphere API 8.0.3.0__.   For more information see: *Oauth2.Errors.Error.Type*.  This property was added in __vSphere API 7.0.2.0__. | 
**ErrorDescription** | **string** | Human-readable ASCII text providing additional information, used to assist the client developer in understanding the error that occurred. Values for the \&quot;error_description\&quot; parameter MUST NOT include characters outside the set %x20-21 / %x23-5B / %x5D-7E.  This property was added in __vSphere API 7.0.2.0__.  if no additional information is available. | [optional] 
**ErrorUri** | **string** | A URI identifying a human-readable web page with information about the error, used to provide the client developer with additional information about the error.  This property was added in __vSphere API 7.0.2.0__.  if no such web-page is available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

