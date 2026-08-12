# Vcenter.Automation.OpenApi.Model.VapiMetadataAuthenticationAuthenticationInfoSchemeType
The Vapi.Metadata.Authentication.AuthenticationInfo.SchemeType enumerated type provides enumeration values for the set of valid authentication scheme types.  Possible values:   - `SESSIONLESS`: Indicates that the scheme is a session less authentication scheme, the user is authenticated on every operation. There is no explicit session establishment.   - `SESSION_AWARE`: Indicates that the scheme is a session aware authentication scheme. It requires an explicit login before executing a operation and logout when a session terminates. A resource might choose to have a session aware scheme if it wants to associate some state corresponding to the user until the user logs out or if it wants to mitigate the cost of authenticating the user on every operation. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

