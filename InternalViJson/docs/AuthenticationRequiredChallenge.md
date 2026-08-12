# Vcenter.ViJson.OpenApi.Model.AuthenticationRequiredChallenge

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scheme** | **string** | Authentication scheme described in the challenge.  The field possible values are described by *AuthenticationRequiredAuthenticationScheme_enum* enum.  | 
**Realm** | **string** | Defines the protection space of the scheme.  The protection space determines the domain over which credentials might be automatically applied. If a prior request has been authorized the application may reuse the same credentials for all other requests within the same protection space for a period of time determined by the authentication scheme, parameters or application preferences.  | [optional] 
**Error** | **string** | The reason why the access request was declined.  The field possible values are described by *AuthenticationRequiredErrorType_enum* enum.  | [optional] 
**ErrorDescription** | **string** | Provides developers human-readable explanation that is not meant to be displayed to end-users.  | [optional] 
**Ovl** | **string** | Full claims token URI.  An application uses this value to obtain Full Claims Token that is then registered with vCenter to enable the provided access token use in vCenter.  | [optional] 
**OidcConfigUrl** | **string** | OpenID Connect Configuration URI.  An application uses this value to obtain OpenID Connect Configuration.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

