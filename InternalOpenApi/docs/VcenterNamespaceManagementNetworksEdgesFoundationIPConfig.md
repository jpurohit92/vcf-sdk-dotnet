# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesFoundationIPConfig
Vcenter.NamespaceManagement.Networks.Edges.Foundation.IPConfig encapsulates configuration required to enable the load balancer on static IP networks.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpRanges** | [**List&lt;VcenterNamespaceManagementNetworksEdgesFoundationFoundationIPRange&gt;**](VcenterNamespaceManagementNetworksEdgesFoundationFoundationIPRange.md) | IP ranges will be used to provision IP addresses for nodes on a network. You must supply at least one IP address per network override per node. The IP addresses must exist within the same subnet as the provided gateway.    If you want to scale up the number of load balancer nodes, you must have enough free IP addresses present in the pool on each respective network. To deploy a load balancer, one IP address is required for each node on each network. For example, if deploying in HA configuration, you must supply two IP addresses for each network for a total of four IP addresses.  This property was added in __vSphere API 9.0.0.0__. | 
**Gateway** | **string** | A gateway is the default gateway on a network specified in CIDR notation. E.g. 192.168.0.1/24. IP addresses specified in *Vcenter.NamespaceManagement.Networks.Edges.Foundation.IPConfig.ip_ranges* must be contained within the same subnet as this gateway.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

