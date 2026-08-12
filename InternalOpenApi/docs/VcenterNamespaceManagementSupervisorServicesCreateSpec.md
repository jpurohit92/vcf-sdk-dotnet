# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesCreateSpec
The Vcenter.NamespaceManagement.SupervisorServices.CreateSpec schema provides a specification required to create a Supervisor Service. Exactly one of *Vcenter.NamespaceManagement.SupervisorServices.CreateSpec.custom_spec* or *Vcenter.NamespaceManagement.SupervisorServices.CreateSpec.vsphere_spec* must be set.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomSpec** | [**VcenterNamespaceManagementSupervisorServicesCustomCreateSpec**](VcenterNamespaceManagementSupervisorServicesCustomCreateSpec.md) | The specification required to create a Supervisor Service with a version from inline content that is based on a plain Kubernetes YAML format.     This property was added in __vSphere API 7.0.3.0__.  If set, the service will be created from a version based on a plain Kubernetes YAML format. | [optional] 
**VsphereSpec** | [**VcenterNamespaceManagementSupervisorServicesVsphereCreateSpec**](VcenterNamespaceManagementSupervisorServicesVsphereCreateSpec.md) | The specification required to create a Supervisor Service with a version from inline content that is based on the vSphere application service format.     This property was added in __vSphere API 7.0.3.0__.  If set, the service will be created from a version based on the vSphere application service format. | [optional] 
**CarvelSpec** | [**VcenterNamespaceManagementSupervisorServicesCarvelCreateSpec**](VcenterNamespaceManagementSupervisorServicesCarvelCreateSpec.md) | The specification required to create a Supervisor Service with a version from inline content that is based on the Carvel application package format.     This property was added in __vSphere API 8.0.0.1__.  If set, the service will be created from a version based on the Carvel application package format (Package and PackageMetadata resources should be declared). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

