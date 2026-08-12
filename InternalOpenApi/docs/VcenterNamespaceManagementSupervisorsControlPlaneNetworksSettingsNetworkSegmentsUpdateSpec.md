# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNetworkSegmentsUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Networks.Settings.NetworkSegmentsUpdateSpec schema contains updates to network segments configuration.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortGroupsToAdd** | **List&lt;string&gt;** | List of Standard Port Groups or Distributed Virtual Port Groups that are part of the same layer 2 broadcast domain.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no port groups will be added.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Network&#x60;. | [optional] 
**PortGroupsToRemove** | **List&lt;string&gt;** | List of existing Standard Port Groups or Distributed Virtual Port Groups that are part of the same layer 2 broadcast domain.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no port groups will be removed.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Network&#x60;. | [optional] 
**Dns** | [**VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsDNSUpdateSpec**](VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsDNSUpdateSpec.md) | DNS configuration updates.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no DNS configuration changes will be made. | [optional] 
**Ntp** | [**VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNTPUpdateSpec**](VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNTPUpdateSpec.md) | NTP configuration updates.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no NTP configuration changes will be made. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

