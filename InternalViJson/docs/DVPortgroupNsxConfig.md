# Vcenter.ViJson.OpenApi.Model.DVPortgroupNsxConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VlanIdExtended** | **int** | The VLAN ID this NSX port group extends to.  If unset, this NSX port group doesn&#39;t extend to any VLAN.  | [optional] 
**SubnetAddresses** | [**DVPortgroupNsxSubnetAddressInfo**](DVPortgroupNsxSubnetAddressInfo.md) | The subnet address(es) assigned to this NSX port group.  If unset, no subnet address is configured.  | [optional] 
**SpanIds** | **List&lt;string&gt;** | The span IDs of the subnet.  It can only be set when the *DVPortgroupConfigSpec.subnetId* is set. If unset, all the hosts join the corresponding transport zone can access the subnet.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

