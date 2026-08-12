# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksServiceDNS
Vcenter.NamespaceManagement.Networks.Service.DNS describes DNS servers and search domains for a given network.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | **List&lt;string&gt;** |   *Vcenter.NamespaceManagement.Networks.Service.DNS.servers* is a list of IP addresses that clients may use for DNS resolution on a given network in priority order.   If empty, no DNS servers will be configured.  This property was added in __vSphere API 8.0.0.1__. | 
**SearchDomains** | **List&lt;string&gt;** |   *Vcenter.NamespaceManagement.Networks.Service.DNS.search_domains* is a list of DNS search domains to be used on this network.   This field is useful for corporate networks or local domains that are not publicly resolvable.   If empty, no search domains will be configured.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

