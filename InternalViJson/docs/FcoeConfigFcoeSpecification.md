# Vcenter.ViJson.OpenApi.Model.FcoeConfigFcoeSpecification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnderlyingPnic** | **string** | The name of this FcoeSpecification&#39;s underlying PhysicalNic  | 
**PriorityClass** | **int** | 802.1p priority class to use for FCoE traffic.  | [optional] 
**SourceMac** | **string** | Source MAC address to use for FCoE traffic.  This MAC address is associated with the logical construct that is a physical NIC&#39;s associated underlying FCoE Controller, as defined in the FC-BB-5 standard. This MAC address should be of the form \&quot;xx:xx:xx:xx:xx:xx\&quot;, where &#39;x&#39; is a hexadecimal digit. Valid MAC addresses are unicast addresses.  | [optional] 
**VlanRange** | [**List&lt;FcoeConfigVlanRange&gt;**](FcoeConfigVlanRange.md) | VLAN ranges to use for FCoE traffic.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

