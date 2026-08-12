# Vcenter.ViJson.OpenApi.Model.HostVvolVolume

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | FileSystemType of this particular file system See *HostFileSystemVolumeFileSystemType_enum*  | 
**Name** | **string** | Name of the file system volume.  | 
**Capacity** | **long** | The capacity of the file system volume, in bytes.  | 
**ScId** | **string** | The universally unique identifier assigned to vvolDS.  | 
**HostPE** | [**List&lt;VVolHostPE&gt;**](VVolHostPE.md) |  | [optional] 
**HostVvolNQN** | [**List&lt;HostVvolVolumeHostVvolNQN&gt;**](HostVvolVolumeHostVvolNQN.md) | Virtual Protocol endpoints for this volume  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 
**VasaProviderInfo** | [**List&lt;VimVasaProviderInfo&gt;**](VimVasaProviderInfo.md) | VASA Providers that manage this volume  | [optional] 
**StorageArray** | [**List&lt;VASAStorageArray&gt;**](VASAStorageArray.md) | List of storage array serving this VVol based storage container  | [optional] 
**ProtocolEndpointType** | **string** | Backing protocol of the datastore  ***Since:*** vSphere API Release 8.0.0.0  | [optional] 
**VvolNQNFieldsAvailable** | **bool** | vVol NQN field availability  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 
**Stretched** | **bool** | if set to true, indicates a stretched container  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

