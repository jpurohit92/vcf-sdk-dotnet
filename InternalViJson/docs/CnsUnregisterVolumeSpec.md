# Vcenter.ViJson.OpenApi.Model.CnsUnregisterVolumeSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**CnsVolumeId**](CnsVolumeId.md) | The unique identifier of the volume to be unregistered.  | 
**TargetVolumeType** | **string** | Specifies the final desired volume type after the unregistration operation.  This parameter dictates how the underlying storage volume should be treated or converted once its CNS metadata is removed.  Unregistering a block volume might convert it into a legacy VMDK or FCD The possible values for this field are enumerated in *CnsUnregisterTargetVolumeType_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

