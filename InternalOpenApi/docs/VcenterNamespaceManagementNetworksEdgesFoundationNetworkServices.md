# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesFoundationNetworkServices
Vcenter.NamespaceManagement.Networks.Edges.Foundation.NetworkServices contains external services on a network that the load balancer is eligible to interact with.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dns** | [**VcenterNamespaceManagementNetworksEdgesFoundationDNS**](VcenterNamespaceManagementNetworksEdgesFoundationDNS.md) | Domain Name Service configuration.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, and the interface configured with a Management Persona is connected to a DHCP network, it will attempt to obtain its settings from a DHCP server. If the interface configured with a Management Persona is connected to a static IP network, the values will be synced with the Supervisor&#39;s management services *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.Network.services*. | [optional] 
**Ntp** | [**VcenterNamespaceManagementNetworksEdgesFoundationNTP**](VcenterNamespaceManagementNetworksEdgesFoundationNTP.md) | Network Time Protocol configuration.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, and the interface configured with a Management Persona is connected to a DHCP network, it will attempt to obtain its settings from a DHCP server. If the interface configured with a Management Persona is connected to a static IP network, the values will be synced with the Supervisor&#39;s management services *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.Network.services*. | [optional] 
**Syslog** | [**VcenterNamespaceManagementNetworksEdgesFoundationSyslog**](VcenterNamespaceManagementNetworksEdgesFoundationSyslog.md) | Configure remote log forwarding for all load balancer nodes.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; logs will be persisted locally and can be retrieved through the Supervisor support bundle collection APIs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

