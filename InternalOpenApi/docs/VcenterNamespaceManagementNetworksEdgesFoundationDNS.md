# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesFoundationDNS
Vcenter.NamespaceManagement.Networks.Edges.Foundation.DNS describes DNS servers and search domains for a given network.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | **List&lt;string&gt;** | *Vcenter.NamespaceManagement.Networks.Edges.Foundation.DNS.servers* is a list of IP addresses that clients may use for DNS resolution on a given network in priority order.    If missing or &#x60;null&#x60;, and the interface configured with a Management Persona is connected to a DHCP network, it will attempt to obtain its settings from a DHCP server. If the interface configured with a Management Persona is connected to a static IP network, the values will be synced with the Supervisor&#39;s management services *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.Network.services*.  This property was added in __vSphere API 9.0.0.0__. | 
**SearchDomains** | **List&lt;string&gt;** | *Vcenter.NamespaceManagement.Networks.Edges.Foundation.DNS.search_domains* is a list of DNS search domains to be used on this network.   This field is useful for corporate networks or local domains that are not publicly resolvable.    If missing or &#x60;null&#x60;, and the interface configured with a Management Persona is connected to a DHCP network, it will attempt to obtain its settings from a DHCP server. If the interface configured with a Management Persona is connected to a static IP network, the values will be synced with the Supervisor&#39;s management services *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.Network.services*.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

