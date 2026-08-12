# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsContainerImageRegistriesInfo
The Vcenter.NamespaceManagement.Supervisors.ContainerImageRegistries.Info schema contains the detailed information about the container image registry.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier of the container image registry.  This property was added in __vSphere API 8.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.ContainerImageRegistry&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.ContainerImageRegistry&#x60;. | 
**Name** | **string** | Name of the container image registry.  This property was added in __vSphere API 8.0.3.0__. | 
**ImageRegistry** | [**VcenterNamespaceManagementSupervisorsImageRegistry**](VcenterNamespaceManagementSupervisorsImageRegistry.md) | The *Vcenter.NamespaceManagement.Supervisors.ContainerImageRegistries.Info.image_registry* schema contains the specification of the container image registry endpoint.  This property was added in __vSphere API 8.0.3.0__. | 
**DefaultRegistry** | **bool** | Indicates if this registry is used as default.  If set true, the image registry is used to host container images from Supervisor system components and services.   This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

