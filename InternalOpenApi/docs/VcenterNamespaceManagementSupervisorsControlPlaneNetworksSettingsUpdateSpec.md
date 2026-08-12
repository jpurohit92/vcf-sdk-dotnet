# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Networks.Settings.UpdateSpec schema contains updates to management network settings.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Backing** | **string** | Backing determines the type of network deployed.  Possible values:   - &#x60;NETWORK_SEGMENTS&#x60;: Management network is configured using network segments. A set of network segments provides L2 management network connectivity.   For more information see: *Vcenter.NamespaceManagement.Supervisors.ControlPlane.Networks.Settings.Backing*.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no change will able to be made to network settings requiring a specific backing. | [optional] 
**NetworkSegmentsUpdateSpec** | [**VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNetworkSegmentsUpdateSpec**](VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsNetworkSegmentsUpdateSpec.md) | Network segments configuration updates.  This property was added in __vSphere API 9.1.0.0__.  This property is optional and it is only relevant when the value of backing is *Vcenter.NamespaceManagement.Supervisors.ControlPlane.Networks.Settings.Backing.NETWORK_SEGMENTS*. | [optional] 
**FloatingIpAddress** | **string** | Floating IP address for the control plane management endpoint.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no change will be made to the floating IP address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

