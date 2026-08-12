# Vcenter.ViJson.OpenApi.Model.VirtualDiskVFlashCacheConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VFlashModule** | **string** | Deprecated since vSphere 7.0 because vFlash Read Cache end of availability.  Name of vFlash module which manages the cache.  If not specified, default setting *HostVFlashManagerVFlashCacheConfigSpec.defaultVFlashModule* will be used.  | [optional] 
**ReservationInMB** | **long** | Deprecated since vSphere 7.0 because vFlash Read Cache end of availability.  Amount of vFlash resource that is guaranteed available to the cache.  If not specified, default reservation will be used.  | [optional] 
**CacheConsistencyType** | **string** | Deprecated since vSphere 7.0 because vFlash Read Cache end of availability.  Cache data consistency types after a crash.  See *VirtualDiskVFlashCacheConfigInfoCacheConsistencyType_enum* for supported types. If not specified, the default value used is *strong*  | [optional] 
**CacheMode** | **string** | Deprecated since vSphere 7.0 because vFlash Read Cache end of availability.  Cache modes.  See *VirtualDiskVFlashCacheConfigInfoCacheMode_enum* for supported modes. If not specified, the default value used is *write_thru*.  | [optional] 
**BlockSizeInKB** | **long** | Deprecated since vSphere 7.0 because vFlash Read Cache end of availability.  Cache block size.  This parameter allows the user to control how much data gets cached on a single access to the VMDK. Max block size is 1MB. Default is 4KB.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

