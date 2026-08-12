# Vcenter.ViJson.OpenApi.Model.PhysicalNicCdpDeviceCapability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Router** | **bool** | The CDP-aware device has the capability of a routing for at least one network layer protocol  | 
**TransparentBridge** | **bool** | The CDP-aware device has the capability of transparent bridging  | 
**SourceRouteBridge** | **bool** | The CDP-aware device has the capability of source-route bridging  | 
**NetworkSwitch** | **bool** | The CDP-aware device has the capability of switching.  The difference between this capability and transparentBridge is that a switch does not run the Spanning-Tree Protocol. This device is assumed to be deployed in a physical loop-free topology.  | 
**Host** | **bool** | The CDP-aware device has the capability of a host, which Sends and receives packets for at least one network layer protocol.  | 
**IgmpEnabled** | **bool** | The CDP-aware device is IGMP-enabled, which does not forward IGMP Report packets on nonrouter ports.  | 
**Repeater** | **bool** | The CDP-aware device has the capability of a repeater  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

