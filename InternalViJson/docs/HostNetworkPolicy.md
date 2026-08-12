# Vcenter.ViJson.OpenApi.Model.HostNetworkPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Security** | [**HostNetworkSecurityPolicy**](HostNetworkSecurityPolicy.md) | The security policy governing ports on this virtual switch.  | [optional] 
**NicTeaming** | [**HostNicTeamingPolicy**](HostNicTeamingPolicy.md) | The network adapter teaming policy.  The bridge must be BondBridge for this property to be valid.  | [optional] 
**OffloadPolicy** | [**HostNetOffloadCapabilities**](HostNetOffloadCapabilities.md) | Deprecated as of VI API 4.0, the system defaults will be used.  Offload capabilities are used to optimize virtual machine network performance.  When a virtual machine is transmitting on a network, some operations can be offloaded to either the host or the physical hardware. This policy indicates what networking related operations should be offloaded.  All virtual machines using this PortGroup are subject to this policy. There is no setting for an individual virtual machine to determine if an operation should be offloaded.  | [optional] 
**ShapingPolicy** | [**HostNetworkTrafficShapingPolicy**](HostNetworkTrafficShapingPolicy.md) | The traffic shaping policy.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

