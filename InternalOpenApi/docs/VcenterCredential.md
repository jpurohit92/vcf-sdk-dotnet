# Vcenter.Automation.OpenApi.Model.VcenterCredential
The Vcenter.Credential provides credential for authentication such as username/password or SAML token.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of credential to use for connecting to a VC.  Possible values:   - &#x60;USERNAME_PASSWORD&#x60;: Username-password based authentication is being used.   - &#x60;SAML_TOKEN&#x60;: SAML based authentication is being used.   For more information see: *Vcenter.Credential.Type*.  This property was added in __vSphere API 9.0.0.0__. | 
**UsernamePassword** | [**VcenterUsernamePassword**](VcenterUsernamePassword.md) | Username-password details.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Credential.Type.USERNAME_PASSWORD*. | [optional] 
**SamlToken** | **string** | SAML token details, when using SAML based authentication.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Credential.Type.SAML_TOKEN*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

