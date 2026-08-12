# Vcenter.ViJson.OpenApi.Model.HostNvmeDiscoverSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HbaName** | **string** | The device name of the NVME over Fabrics host bus adapter.  | 
**TransportParameters** | [**HostNvmeTransportParameters**](HostNvmeTransportParameters.md) | Transport specific information necessary to connect to the controller.  | 
**AutoConnect** | **bool** | Indicates whether the specified adapter should automatically be connected to all the discovered controllers.  It is possible to automatically connect to all discovered controllers. This will only be attempted if this flag is set to true. Whether the connection attempt for an entry succeeded can then be determined via the corresponding *HostNvmeDiscoveryLogEntry.connected* field.  | [optional] 
**RootDiscoveryController** | **bool** | If set to true, this flag indicates we are connecting to a root/central discovery controller (RDC/CDC).  This will create a persistent connection between the host and the root discovery controller, thus enabling some advanced features.  ***Since:*** vSphere API Release 7.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

