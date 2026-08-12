# Vcenter.ViJson.OpenApi.Model.VimVsanHostVsanManagedDisksInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VSANDirectDisks** | [**List&lt;VimVsanHostVsanDirectStorage&gt;**](VimVsanHostVsanDirectStorage.md) | vSAN direct disks, which are claimed from the vSAN API *VimClusterVsanVcDiskManagementSystem.InitializeDiskMappings*  | [optional] 
**VSANDiskMapInfo** | [**List&lt;VimVsanHostDiskMapInfoEx&gt;**](VimVsanHostDiskMapInfoEx.md) | vSAN disk mapping information for vSAN datastore.  | [optional] 
**VSANPMemInfo** | [**VimVsanHostVsanManagedPMemInfo**](VimVsanHostVsanManagedPMemInfo.md) | Deprecated as of vSphere 9.0 APIs with no replacement.  vSAN managed PMem information.  | [optional] 
**StoragePools** | [**List&lt;VimVsanHostStoragePoolInfo&gt;**](VimVsanHostStoragePoolInfo.md) | vSAN storage pool information.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

