# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersIpv4Range
The Vcenter.NamespaceManagement.Clusters.Ipv4Range contains specification to configure multiple interfaces in IPv4. The range of IPv4 addresses is derived by incrementing the startingAddress to the specified addressCount. To use the object for a single IPv4 address specification, set addressCount to 1.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartingAddress** | **string** | The IPv4 address denoting the start of the range.  This property was added in __vSphere API 7.0.0.0__. | 
**AddressCount** | **long** | The number of IP addresses in the range. Addresses are derived by incrementing *Vcenter.NamespaceManagement.Clusters.Ipv4Range.starting_address*.  This property was added in __vSphere API 7.0.0.0__. | 
**SubnetMask** | **string** | Subnet mask to be set.  This property was added in __vSphere API 7.0.0.0__. | 
**Gateway** | **string** | The IPv4 address of the gateway associated with the range indicated by *Vcenter.NamespaceManagement.Clusters.Ipv4Range.starting_address* and *Vcenter.NamespaceManagement.Clusters.Ipv4Range.address_count*.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

