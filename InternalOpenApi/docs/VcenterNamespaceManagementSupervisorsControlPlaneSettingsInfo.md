# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneSettingsInfo
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Settings.Info schema contains information about the control plane settings for the given Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | [**VcenterNamespaceManagementSupervisorsControlPlaneSettingsSizeInfo**](VcenterNamespaceManagementSupervisorsControlPlaneSettingsSizeInfo.md) | Information about the control plane VM size configuration for the given Supervisor.  This property was added in __vSphere API 9.1.0.0__. | 
**LoginBanner** | **string** | Information about the login banner disclaimer displayed prior to login for the given Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If the login banner is missing or &#x60;null&#x60;, no message will be displayed to users. | [optional] 
**Count** | **long** | Information about the number of control plane VMs for the given Supervisor.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, defaults to 3. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

