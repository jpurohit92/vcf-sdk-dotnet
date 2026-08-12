# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersVpcConfig
The Vcenter.NamespaceManagement.Clusters.VpcConfig schema describes the specification of an NSX VPC for Supervisor Network configuration.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NsxProjectInfo** | [**VcenterNamespaceManagementClustersProjectInfo**](VcenterNamespaceManagementClustersProjectInfo.md) | The default NSX Project for VPCs created in the Supervisor.  This property was added in __vSphere API 9.0.0.0__. | 
**VpcConnectivityProfileInfo** | [**VcenterNamespaceManagementNetworksNsxProjectsVpcConnectivityProfilesInfo**](VcenterNamespaceManagementNetworksNsxProjectsVpcConnectivityProfilesInfo.md) | Default VPC Connectivity Profile used for all VPCs created in the Supervisor.  This property was added in __vSphere API 9.0.0.0__. | 
**DefaultPrivateCidrs** | [**List&lt;VcenterNamespaceManagementIpv4Cidr&gt;**](VcenterNamespaceManagementIpv4Cidr.md) | Default CIDR blocks from which private subnets and private pod IPs are allocated for all VPCs created in the Supervisor.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

