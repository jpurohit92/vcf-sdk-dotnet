# Vcenter.ViJson.OpenApi.Model.HostVFlashManagerVFlashCacheConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultVFlashModule** | **string** | Name of the default vFlash module for the read-write caches associated with the VMs of this host.  This setting can be overridden by *VirtualDiskVFlashCacheConfigInfo.vFlashModule* per VMDK.  | 
**SwapCacheReservationInGB** | **long** | Amount of vFlash resource is allocated to the host swap cache.  As long as set, reservation will be permanent and retain regardless of host power state. The host swap cache will be disabled if the reservation is set to zero.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

