# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneSettingsUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Settings.UpdateSpec schema contains updates for control plane settings for the given Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | [**VcenterNamespaceManagementSupervisorsControlPlaneSettingsSizeUpdateSpec**](VcenterNamespaceManagementSupervisorsControlPlaneSettingsSizeUpdateSpec.md) | Update the control plane VM size for this Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the control plane VM size is unchanged. | [optional] 
**LoginBanner** | **string** | Updates for the login banner disclaimer displayed prior to login for the given Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the login banner is unchanged. | [optional] 
**Count** | **long** | Updates for the number of control plane VMs for the given Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the number of control plane VMs is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

