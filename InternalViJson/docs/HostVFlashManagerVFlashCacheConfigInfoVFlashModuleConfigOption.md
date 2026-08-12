# Vcenter.ViJson.OpenApi.Model.HostVFlashManagerVFlashCacheConfigInfoVFlashModuleConfigOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VFlashModule** | **string** | Name of the vFlash module  | 
**VFlashModuleVersion** | **string** | Version of the vFlash module  | 
**MinSupportedModuleVersion** | **string** | Minimum supported version  | 
**CacheConsistencyType** | [**ChoiceOption**](ChoiceOption.md) | Cache data consistency types.  See *VirtualDiskVFlashCacheConfigInfoCacheConsistencyType_enum*  | 
**CacheMode** | [**ChoiceOption**](ChoiceOption.md) | Cache modes.  See *VirtualDiskVFlashCacheConfigInfoCacheMode_enum*  | 
**BlockSizeInKBOption** | [**LongOption**](LongOption.md) | blockSizeInKBOption defines a range of virtual disk cache block size.  | 
**ReservationInMBOption** | [**LongOption**](LongOption.md) | reservationInMBOption defines a range of virtual disk cache size.  | 
**MaxDiskSizeInKB** | **long** | Maximal size of virtual disk supported in kilobytes.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

