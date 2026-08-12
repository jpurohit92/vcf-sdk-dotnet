# Vcenter.ViJson.OpenApi.Model.FcoeConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PriorityClass** | **int** | 802.1p priority class used for FCoE traffic.  | 
**SourceMac** | **string** | Source MAC address used for FCoE traffic.  This MAC address is associated with the logical construct that is a physical NIC&#39;s associated underlying FCoE Controller, as defined in the FC-BB-5 standard. This MAC address should be of the form \&quot;xx:xx:xx:xx:xx:xx\&quot;, where &#39;x&#39; is a hexadecimal digit. Valid MAC addresses are unicast addresses.  | 
**VlanRange** | [**List&lt;FcoeConfigVlanRange&gt;**](FcoeConfigVlanRange.md) | VLAN ranges associated with this FcoeConfig.  | 
**Capabilities** | [**FcoeConfigFcoeCapabilities**](FcoeConfigFcoeCapabilities.md) | Settable capabilities for this FcoeConfig.  | 
**FcoeActive** | **bool** | Indicates whether this FcoeConfig is \&quot;active\&quot; (has been used in conjunction with a parent physical network adapter for FCoE discovery).  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

