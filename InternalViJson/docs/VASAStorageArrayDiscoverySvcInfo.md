# Vcenter.ViJson.OpenApi.Model.VASAStorageArrayDiscoverySvcInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortType** | **string** | Port type, string as defined in *VASAStorageArrayBlockEnum_enum*.  | 
**SvcNqn** | **string** | Well-known NQN of discovery service.  | 
**IpInfo** | [**VASAStorageArrayDiscoveryIpTransport**](VASAStorageArrayDiscoveryIpTransport.md) | IP transport discovery information.  Must be specified if the discovery service is IP-based.  | [optional] 
**FcInfo** | [**VASAStorageArrayDiscoveryFcTransport**](VASAStorageArrayDiscoveryFcTransport.md) | FC transport discovery information.  Must be specified if the discovery service is FC-based.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

