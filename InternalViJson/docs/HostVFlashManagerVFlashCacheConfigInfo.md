# Vcenter.ViJson.OpenApi.Model.HostVFlashManagerVFlashCacheConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VFlashModuleConfigOption** | [**List&lt;HostVFlashManagerVFlashCacheConfigInfoVFlashModuleConfigOption&gt;**](HostVFlashManagerVFlashCacheConfigInfoVFlashModuleConfigOption.md) | Cache configuration options for the supported vFlash modules.  | [optional] 
**DefaultVFlashModule** | **string** | Name of the default vFlash module for the read-write cache associated with the VMs of this host.  This setting can be overridden by *VirtualDiskVFlashCacheConfigInfo.vFlashModule* per VMDK.  | [optional] 
**SwapCacheReservationInGB** | **long** | Amount of vFlash resource is allocated to the host swap cache.  As long as set, reservation will be permanent and retain regardless of host power state. The host swap cache will be disabled if reservation is set to zero.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

