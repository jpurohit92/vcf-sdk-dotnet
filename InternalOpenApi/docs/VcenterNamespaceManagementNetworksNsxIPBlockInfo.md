# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxIPBlockInfo
The Vcenter.NamespaceManagement.Networks.Nsx.IPBlockInfo schema contains information about IP blocks.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | NSX policy path of the IP block.  This property was added in __vSphere API 9.0.0.0__. | 
**Name** | **string** | IP block name.  This property was added in __vSphere API 9.0.0.0__. | 
**Cidr** | [**VcenterNamespaceManagementNetworksIpv4Cidr**](VcenterNamespaceManagementNetworksIpv4Cidr.md) | IP block CIDR.  This property was added in __vSphere API 9.0.0.0__. | 
**Cidrs** | [**List&lt;VcenterNamespaceManagementNetworksIpv4Cidr&gt;**](VcenterNamespaceManagementNetworksIpv4Cidr.md) | A list of IP block CIDRs used to create the IP block. The IP block can be created with both CIDRs and ranges. CIDRs should not overlap with *Vcenter.NamespaceManagement.Networks.Nsx.IPBlockInfo.ranges*.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**Ranges** | [**List&lt;VcenterNamespaceManagementNetworksIPRange&gt;**](VcenterNamespaceManagementNetworksIPRange.md) | A list of IP block ranges used to create the IP block. The IP block can be created with both CIDRs and ranges. Ranges should not overlap with *Vcenter.NamespaceManagement.Networks.Nsx.IPBlockInfo.cidrs*  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**AvailableIpRanges** | [**List&lt;VcenterNamespaceManagementNetworksIPRange&gt;**](VcenterNamespaceManagementNetworksIPRange.md) | Free IP ranges from CIDRs and ranges of the IP block.  This property was added in __vSphere API 9.0.0.0__. | 
**CidrUsages** | [**List&lt;VcenterNamespaceManagementNetworksNsxCidrUsageDetails&gt;**](VcenterNamespaceManagementNetworksNsxCidrUsageDetails.md) | Usage details for each CIDR of the IP block.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**RangeUsages** | [**List&lt;VcenterNamespaceManagementNetworksNsxRangeUsageDetails&gt;**](VcenterNamespaceManagementNetworksNsxRangeUsageDetails.md) | Usage details for each range of the IP block.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**UsedIpCount** | **long** | The count of used IP addresses in the IPBlock.  This property was added in __vSphere API 9.0.0.0__. | 
**AvailableIpCount** | **long** | The count of available IP addresses in the IPBlock.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

