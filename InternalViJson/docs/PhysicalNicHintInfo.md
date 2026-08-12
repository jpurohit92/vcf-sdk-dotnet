# Vcenter.ViJson.OpenApi.Model.PhysicalNicHintInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | **string** | The physical network adapter device to which this hint applies.  | 
**Subnet** | [**List&lt;PhysicalNicIpHint&gt;**](PhysicalNicIpHint.md) | The list of subnets that were detected on this physical network adapter.  | [optional] 
**Network** | [**List&lt;PhysicalNicNameHint&gt;**](PhysicalNicNameHint.md) | The list of network names that were detected on this physical network adapter.  | [optional] 
**ConnectedSwitchPort** | [**PhysicalNicCdpInfo**](PhysicalNicCdpInfo.md) | If the uplink directly connects to a CDP-aware network device and the device&#39;s CDP broadcast is enabled, this property will be set to return the CDP information that vmkernel received on this Physical NIC.  CDP data contains the device information and port ID that the Physical NIC connects to. If the uplink is not connecting to a CDP-aware device or CDP is not enabled on the device, this property will be unset. *PhysicalNicCdpInfo*  | [optional] 
**LldpInfo** | [**LinkLayerDiscoveryProtocolInfo**](LinkLayerDiscoveryProtocolInfo.md) | If the uplink directly connects to an LLDP-aware network device and the device&#39;s LLDP broadcast is enabled, this property will be set to return the LLDP information that is received on this physical network adapter.  If the uplink is not connecting to a LLDP-aware device or LLDP is not enabled on the device, this property will be unset.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

