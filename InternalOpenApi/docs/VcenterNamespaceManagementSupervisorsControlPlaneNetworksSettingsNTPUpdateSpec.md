# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNTPUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Networks.Settings.NTPUpdateSpec schema contains updates to NTP configuration.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServersToAdd** | **List&lt;string&gt;** | List of NTP server DNS names or IP addresses to add, specified in order of preference.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no NTP servers will be added. | [optional] 
**ServersToRemove** | **List&lt;string&gt;** | List of NTP server DNS names or IP addresses to remove.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no NTP servers will be removed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

