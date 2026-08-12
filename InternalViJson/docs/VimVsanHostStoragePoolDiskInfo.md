# Vcenter.ViJson.OpenApi.Model.VimVsanHostStoragePoolDiskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disk** | [**HostScsiDisk**](HostScsiDisk.md) | Disk for the info.  | 
**VsanUuid** | **string** | VSAN disk UUID.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | Error information for this disk info: may be populated with additional information about the disk at hand, regardless of the disk&#39;s state.  | [optional] 
**IsMounted** | **bool** | Indicates whether the storage pool disk is mounted.  | [optional] 
**IsEncrypted** | **bool** | Indicates whether encryption is enabled.  | [optional] 
**DekId** | **string** | Data Encryption Key (DEK) cluster wide uuid.  | [optional] 
**DiskType** | **string** | Represents storage pool disk type.  Refer to *StoragePoolDiskType_enum*  See also *StoragePoolDiskType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

