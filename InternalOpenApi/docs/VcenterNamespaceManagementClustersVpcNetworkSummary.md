# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersVpcNetworkSummary
The Vcenter.NamespaceManagement.Clusters.VpcNetworkSummary schema describes the the VPC settings for a Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NsxProject** | **string** | NsxProject is the NSX path of an NSX Project.  This property was added in __vSphere API 9.0.0.0__. | 
**VpcConnectivityProfile** | **string** | VpcConnectivityProfile is the path of a VpcConnectivityProfile.  This property was added in __vSphere API 9.0.0.0__. | 
**DefaultPrivateCidrs** | [**List&lt;VcenterNamespaceManagementIpv4Cidr&gt;**](VcenterNamespaceManagementIpv4Cidr.md) | Default CIDR blocks from which private subnets and private pod IPs are allocated.  This property was added in __vSphere API 9.0.0.0__. | 
**AutoCreated** | **bool** | Whether the VPC has been automatically created for the namespace.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

