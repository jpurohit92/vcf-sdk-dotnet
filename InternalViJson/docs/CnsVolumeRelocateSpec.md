# Vcenter.ViJson.OpenApi.Model.CnsVolumeRelocateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VolumeId** | [**CnsVolumeId**](CnsVolumeId.md) | Unique identifier for the volume.  | 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The destination datastore that the volume is relocated to.  Refers instance of *Datastore*.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Volume relocation profile requirement.     While relocating the volume, the default policy of the destination datastore is applied if this is unset.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

