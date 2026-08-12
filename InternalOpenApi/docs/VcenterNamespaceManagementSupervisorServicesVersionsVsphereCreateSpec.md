# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesVersionsVsphereCreateSpec
The Vcenter.NamespaceManagement.SupervisorServices.Versions.VsphereCreateSpec schema provides a specification required to create a Supervisor Service version from vSphere application service format, which shall contain the Supervisor Service identifier, version identifier, display name and description information.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | Inline content that contains all service definition of the version in vSphere application service format, which shall be base64 encoded.  This property was added in __vSphere API 7.0.3.0__. | 
**TrustedProvider** | **bool** | Whether or not the Supervisor Service version is from a trusted provider, this field must be set to false if the service version is not from a trusted provider. If it is set to be true, but the content is not signed or the signature is invalid, an &#x60;InvalidArgument&#x60; will be thrown.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the default value is true. In this case, the content must be signed and will be verified. | [optional] 
**AcceptEula** | **bool** | Whether or not the End User License Agreement (EULA) that is specified in the content is accepted. If a EULA is specified, this property must be set to be true so that the Supervisor Service version can be created.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the default value is false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

