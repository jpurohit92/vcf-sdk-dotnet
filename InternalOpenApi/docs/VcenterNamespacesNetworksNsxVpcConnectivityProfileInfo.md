# Vcenter.Automation.OpenApi.Model.VcenterNamespacesNetworksNsxVpcConnectivityProfileInfo
The Vcenter.Namespaces.Networks.Nsx.VpcConnectivityProfileInfo provides information of NSX VPC Connectivity Profile.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | **string** | Identifier of the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.networks.nsx.VpcConnectivityProfile&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.networks.nsx.VpcConnectivityProfile&#x60;. | 
**Name** | **string** | Name of the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__. | 
**NsxPath** | **string** | NSX path of the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__. | 
**Description** | **string** | Description of the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no description is added to the VPC Connectivity Profile. | [optional] 
**DefaultProfile** | **bool** | &#x60;true&#x60; if this profile is the default connectivity profile in NSX project, &#x60;false&#x60; otherwise.  This property was added in __vSphere API 9.0.0.0__. | 
**ExternalIpBlocks** | [**List&lt;VcenterNamespacesNetworksNsxIPBlockInfo&gt;**](VcenterNamespacesNetworksNsxIPBlockInfo.md) | List of NSX External IP Blocks currently configured with the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no external IP blocks are defined in the VPC Connectivity Profile. | [optional] 
**PrivatetgwIpBlocks** | [**List&lt;VcenterNamespacesNetworksNsxIPBlockInfo&gt;**](VcenterNamespacesNetworksNsxIPBlockInfo.md) | List of NSX Private (Transit Gateway) IP Blocks currently configured with the VPC Connectivity Profile.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no private TGW IP blocks are defined in the VPC Connectivity Profile. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

