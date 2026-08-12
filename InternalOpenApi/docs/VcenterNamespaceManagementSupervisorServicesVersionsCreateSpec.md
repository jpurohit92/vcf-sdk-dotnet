# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesVersionsCreateSpec
The Vcenter.NamespaceManagement.SupervisorServices.Versions.CreateSpec schema provides a specification required to create a Supervisor Service version.    Exactly one of *Vcenter.NamespaceManagement.SupervisorServices.Versions.CreateSpec.custom_spec* or *Vcenter.NamespaceManagement.SupervisorServices.Versions.CreateSpec.vsphere_spec* must be set.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomSpec** | [**VcenterNamespaceManagementSupervisorServicesVersionsCustomCreateSpec**](VcenterNamespaceManagementSupervisorServicesVersionsCustomCreateSpec.md) | The specification required to create a Supervisor Service version from inline content that is based on a plain Kubernetes YAML format.     This property was added in __vSphere API 7.0.3.0__.  If set, the service version will be created from inline content based on a plain Kubernetes YAML format. | [optional] 
**VsphereSpec** | [**VcenterNamespaceManagementSupervisorServicesVersionsVsphereCreateSpec**](VcenterNamespaceManagementSupervisorServicesVersionsVsphereCreateSpec.md) | The specification required to create a Supervisor Service version from inline content that is based on the vSphere application service format.     This property was added in __vSphere API 7.0.3.0__.  If set, the service version will be created from inline content based on the vSphere application service format. | [optional] 
**CarvelSpec** | [**VcenterNamespaceManagementSupervisorServicesVersionsCarvelCreateSpec**](VcenterNamespaceManagementSupervisorServicesVersionsCarvelCreateSpec.md) | The specification required to create a Supervisor Service version from inline content that is based on the Carvel application package format.     This property was added in __vSphere API 8.0.0.1__.  If set, the service version will be created from inline content based on the Carvel application package format (Package and PackageMetadata resources should be declared). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

