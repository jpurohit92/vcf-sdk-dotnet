# Vcenter.ViJson.OpenApi.Model.AuthenticationRequiredErrorTypeEnum
Possible reasons why an access request is declined.  Possible values: - `invalid_request`: The request is missing a required parameter, includes an unsupported   parameter or parameter value, repeats the same parameter, uses more   than one method for including an access token, or is otherwise   malformed. - `invalid_token`: The access token is invalid, expired, revoked or is invalid for   other reasons.      The client may request a new access token and   retry the request. - `insufficient_scope`: The request requires higher privileges than provided by the access   token. - `registration_required`: vCenter requires registration of the full user claims to enable the   provided access token use in vCenter.      The client application should   obtain the full claims token from the authorization server on the   \"ovl\" field specified URI and register the full claims token with   vCenter. After registration, the client application should retry   the request. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

