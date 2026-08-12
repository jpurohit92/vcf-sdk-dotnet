# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersVpcClusterNetworkSetSpec
The Vcenter.NamespaceManagement.Clusters.VpcClusterNetworkSetSpec schema encapsulates the NSX VPC cluster networking configuration parameters for the vSphere Namespaces Cluster Set operation.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultPrivateCidrs** | [**List&lt;VcenterNamespaceManagementIpv4Cidr&gt;**](VcenterNamespaceManagementIpv4Cidr.md) | Default CIDR blocks from which private subnets are allocated for new VPCs. Setting does not affect existing VPCs, but rather establishes the default for all new namespaces. This range should not overlap with those in *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.VpcNetwork.vpc_connectivity_profile*, *Vcenter.NamespaceManagement.Supervisors.Networks.Workload.Network.ip_management*, or other services running in the datacenter. Changing to use invalid CIDR e.g. overlapping or broadcast or reserved CIDR will result in the operation failing with a Vapi.Std.Errors.InvalidArgument error.    This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the current value will be retained. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

