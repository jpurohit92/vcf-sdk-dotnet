# Vcenter.Automation.OpenApi.Model.VcenterVmGuestCredentialsType
Types of guest credentials  Possible values:   - `USERNAME_PASSWORD`: USERNAME_PASSWORD credentials contains the information necessary to authenticate within a guest using a username and password. This method of authentication is stateless.    To use USERNAME_PASSWORD, populate userName and password with the appropriate login information.    Once populated, you can use USERNAME_PASSWORD in any guest operations operation.   - `SAML_BEARER_TOKEN`: SAML_BEARER_TOKEN contains the information necessary to authenticate within a guest using a SAML token. SAML Bearer token credentials relies on a guest alias that associates a guest account with the subject and certificate encoded in a SAML Bearer token obtained from the VMware SSO Server.   This enumeration was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

