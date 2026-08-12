# Vcenter.Automation.OpenApi.Model.VcenterVmGuestCredentials
The Vcenter.Vm.Guest.Credentials schema defines the guest credentials used for guest operation authentication.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InteractiveSession** | **bool** | If set, the operation will interact with the logged-in desktop session in the guest. This requires that the logged-on user matches the user specified by the *Vcenter.Vm.Guest.Credentials*. This is currently only supported for *Vcenter.Vm.Guest.Credentials.Type.USERNAME_PASSWORD*.  This property was added in __vSphere API 7.0.2.0__. | 
**Type** | **string** | The guest credentials type  Possible values:   - &#x60;USERNAME_PASSWORD&#x60;: USERNAME_PASSWORD credentials contains the information necessary to authenticate within a guest using a username and password. This method of authentication is stateless.    To use USERNAME_PASSWORD, populate userName and password with the appropriate login information.    Once populated, you can use USERNAME_PASSWORD in any guest operations operation.   - &#x60;SAML_BEARER_TOKEN&#x60;: SAML_BEARER_TOKEN contains the information necessary to authenticate within a guest using a SAML token. SAML Bearer token credentials relies on a guest alias that associates a guest account with the subject and certificate encoded in a SAML Bearer token obtained from the VMware SSO Server.   For more information see: *Vcenter.Vm.Guest.Credentials.Type*.  This property was added in __vSphere API 7.0.2.0__. | 
**UserName** | **string** | For *Vcenter.Vm.Guest.Credentials.Type.SAML_BEARER_TOKEN*, this is the guest user to be associated with the credentials. For *Vcenter.Vm.Guest.Credentials.Type.USERNAME_PASSWORD* this is the guest username.  This property was added in __vSphere API 7.0.2.0__.  If no user is specified for *Vcenter.Vm.Guest.Credentials.Type.SAML_BEARER_TOKEN*, a guest dependent mapping will decide what guest user account is applied. | [optional] 
**Password** | **string** | password  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Guest.Credentials.Type.USERNAME_PASSWORD*. | [optional] 
**SamlToken** | **string** | SAML Bearer Token  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Guest.Credentials.Type.SAML_BEARER_TOKEN*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

