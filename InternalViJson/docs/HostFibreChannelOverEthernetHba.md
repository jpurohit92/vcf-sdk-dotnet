# Vcenter.ViJson.OpenApi.Model.HostFibreChannelOverEthernetHba

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortWorldWideName** | **long** | The world wide port name for the adapter.  | 
**NodeWorldWideName** | **long** | The world wide node name for the adapter.  | 
**PortType** | **FibreChannelPortTypeEnum** | The type of the fiber channel port.  | 
**Speed** | **long** | The current operating speed of the adapter in bits per second.  | 
**UnderlyingNic** | **string** | The name associated with this FCoE HBA&#39;s underlying FcoeNic.  | 
**LinkInfo** | [**HostFibreChannelOverEthernetHbaLinkInfo**](HostFibreChannelOverEthernetHbaLinkInfo.md) | Link information that can be used to uniquely identify this FCoE HBA.  | 
**IsSoftwareFcoe** | **bool** | True if this host bus adapter is a software based FCoE initiator.  | 
**MarkedForRemoval** | **bool** | Deprecated as of vSphere API 8.0. Software FCoE not supported.  True if this host bus adapter has been marked for removal.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

