# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneSettingsSizeInfo
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Settings.SizeInfo schema contains information about the current control plane VM size configuration.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | The current size of the control plane VMs. Use *GET /vcenter/namespace-management/software/supervisors/versions/{version}/control-plane/sizes* to determine the available sizes for a given Supervisor version.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.software.supervisors.versions.control_plane.Size&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.software.supervisors.versions.control_plane.Size&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

