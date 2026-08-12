# Vcenter.ViJson.OpenApi.Model.BaseConfigInfoFileBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore managed object where this backing is located.  Refers instance of *Datastore*.  | 
**FilePath** | **string** | Full file path for the host file used in this backing.  | 
**BackingObjectId** | **string** | Id refers to the backed storage object where the virtual storage object is backed on.  | [optional] 
**Parent** | [**BaseConfigInfoFileBackingInfo**](BaseConfigInfoFileBackingInfo.md) | The parent of this virtual disk file, if this is a delta disk backing.  This will be unset if this is the root disk backing.  Note that the type of the backing is consistent throughout the chain; any new delta disk backing which is added is of the same type as the original disk. Also note that since the parent backing is not being written to, it is possible that the parent backing may be shared among multiple disks.  Only raw disk mappings in *virtual compatibility mode* can have parents.  | [optional] 
**DeltaSizeInMB** | **long** | Size allocated by the FS for this file/chain/link/extent only.  This property is used only for a delta disk whose *BaseConfigInfoFileBackingInfo.parent* is set.  | [optional] 
**KeyId** | [**CryptoKeyId**](CryptoKeyId.md) | key id used to encrypt the backing disk.  | [optional] 
**SharedFileBacking** | **bool** | Flag indicates whether the file backing is shared across multiple fcd disk chains.  This flag is intended for internal use only and is primarily used in the relocation and deletion workflow.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

