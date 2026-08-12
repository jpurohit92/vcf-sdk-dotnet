# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsContainerImageRegistriesCreateSpec
The Vcenter.NamespaceManagement.Supervisors.ContainerImageRegistries.CreateSpec schema provides a specification required to create a container image registry.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the container image registry. This name is unique across all container image registries in one Supervisor.  This property was added in __vSphere API 8.0.3.0__. | 
**ImageRegistry** | [**VcenterNamespaceManagementSupervisorsImageRegistry**](VcenterNamespaceManagementSupervisorsImageRegistry.md) | The *Vcenter.NamespaceManagement.Supervisors.ContainerImageRegistries.CreateSpec.image_registry* schema contains the specification required to configure a container image registry endpoint.  This property was added in __vSphere API 8.0.3.0__. | 
**DefaultRegistry** | **bool** | Indicates if this container image registry serves as the default option when multiple registries exist, and no specific registry is specified. If there is already a default image registry, the new registry set to default will overwrite the original default setting.  When set true, the image registry will be used to host container images from Supervisor system components and services.  If there are one or more container image registries associated with the Supervisor, but none of them is set as the default, Docker Hub will be treated as the default.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60;, this registry is not used as the default option. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

