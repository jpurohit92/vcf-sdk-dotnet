# Vcenter.ViJson.OpenApi.Model.VimVsanHostVsanDirectStorage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScsiDisks** | [**List&lt;VimVsanHostVsanScsiDisk&gt;**](VimVsanHostVsanScsiDisk.md) | vSAN direct SCSI disks information, which are claimed from the vSAN API *VimClusterVsanVcDiskManagementSystem.InitializeDiskMappings* with the disk creation type as vmfs.  | [optional] 
**Tier** | **string** | vSAN direct storage tier.  It&#39;s specified by user and different tier of storage has different performance characteristic, which can be used to support deploying workload with various performance requirement.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

