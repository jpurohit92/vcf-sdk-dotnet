# Vcenter.ViJson.OpenApi.Model.CnsDeleteVolumeRequestType
The parameters of *CnsVolumeManager.CnsDeleteVolume*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeIds** | [**List&lt;CnsVolumeId&gt;**](CnsVolumeId.md) | List of *CnsVolumeId* for the volumes to be deleted.  | 
**DeleteDisk** | **bool** | Disk is the backing object for each container volume specified in volumeIds list. If set to true, the backing objects specified in volumeIds list will be deleted. If set to false, the backing objects specified in volumeIds list will not be deleted but will no longer be a container volume.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

