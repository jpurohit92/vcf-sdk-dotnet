# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNetworkSegmentsInfo
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Networks.Settings.NetworkSegmentsInfo schema contains network segments configuration information.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortGroups** | **List&lt;string&gt;** | List of existing Standard Port Groups or Distributed Virtual Port Groups that are part of the same layer 2 broadcast domain.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Network&#x60;. | 
**Dns** | [**VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsDNSInfo**](VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsDNSInfo.md) | DNS configuration information.  This property was added in __vSphere API 9.1.0.0__. | 
**Ntp** | [**VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNTPInfo**](VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNTPInfo.md) | NTP configuration information.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

