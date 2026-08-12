# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesFoundationNTP
Vcenter.NamespaceManagement.Networks.Edges.Foundation.NTP describes network time protocol configuration for a network.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | **List&lt;string&gt;** | *Vcenter.NamespaceManagement.Networks.Edges.Foundation.NTP.servers* contains a list of servers in priority order that clients can use for network time protocol.    If missing or &#x60;null&#x60;, and the interface configured with a Management Persona is connected to a DHCP network, it will attempt to obtain its settings from a DHCP server. If the interface configured with a Management Persona is connected to a static IP network, the values will be synced with the Supervisor&#39;s management services *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.Network.services*.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

