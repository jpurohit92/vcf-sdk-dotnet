# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneSettingsSizeUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Settings.SizeUpdateSpec schema contains updates for the control plane VM size for the given Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | Update the control plane VM size for this Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the control plane VM size is unchanged.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.software.supervisors.versions.control_plane.Size&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.software.supervisors.versions.control_plane.Size&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

