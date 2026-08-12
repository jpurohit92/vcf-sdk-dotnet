# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesVersionsCustomCreateSpec
The Vcenter.NamespaceManagement.SupervisorServices.Versions.CustomCreateSpec schema provides a specification required to create a Supervisor Service version from a plain Kubernetes YAML format.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | The identifier of the Supervisor Service version. This must be a semantic version.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. | 
**DisplayName** | **string** | A human readable name of the Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | A human readable description of the Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the description for the service version will be empty. | [optional] 
**Content** | **string** | Inline content that contains all service definition of the version, which shall be base64 encoded. The service definition here follows a plain Kubernetes YAML format.  This property was added in __vSphere API 7.0.3.0__. | 
**TrustedProvider** | **bool** | Whether or not the Supervisor Service version is from a trusted provider, this field must be set to false if the service version is not from a trusted provider. If it is set to be true, but the content is not signed or the signature is invalid, an &#x60;InvalidArgument&#x60; will be thrown.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, the default value is true. In this case, the content must be signed and will be verified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

