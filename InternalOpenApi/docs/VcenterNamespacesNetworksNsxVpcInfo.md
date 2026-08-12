# Vcenter.Automation.OpenApi.Model.VcenterNamespacesNetworksNsxVpcInfo
The Vcenter.Namespaces.Networks.Nsx.VpcInfo schema contains information about a VPC.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vpc** | **string** | Identifier of the VPC.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.networks.nsx.Vpc&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.networks.nsx.Vpc&#x60;. | 
**Name** | **string** | Name of the VPC.  This property was added in __vSphere API 9.0.0.0__. | 
**NsxPath** | **string** | NSX path of the VPC.  This property was added in __vSphere API 9.0.0.0__. | 
**NsxProjectInfo** | [**VcenterNamespacesNetworksNsxProjectInfo**](VcenterNamespacesNetworksNsxProjectInfo.md) | NSX Project used for this namespace.  This property was added in __vSphere API 9.0.0.0__. | 
**VpcConnectivityProfileInfo** | [**VcenterNamespacesNetworksNsxVpcConnectivityProfileInfo**](VcenterNamespacesNetworksNsxVpcConnectivityProfileInfo.md) | VpcConnectivityProfile used for this namespace.  This property was added in __vSphere API 9.0.0.0__. | 
**PrivateCidrs** | [**List&lt;VcenterNamespacesNetworksNsxIpv4Cidr&gt;**](VcenterNamespacesNetworksNsxIpv4Cidr.md) | CIDR blocks from which private subnets and private pod IPs are allocated.  This property was added in __vSphere API 9.0.0.0__.  missing or &#x60;null&#x60; if no private CIDRs configured. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

