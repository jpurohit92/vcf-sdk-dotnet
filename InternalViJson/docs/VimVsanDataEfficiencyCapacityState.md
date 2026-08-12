# Vcenter.ViJson.OpenApi.Model.VimVsanDataEfficiencyCapacityState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LogicalCapacity** | **long** | Total logical capacity in bytes.  | [optional] 
**LogicalCapacityUsed** | **long** | Logical capacity used in bytes by aggregating all vSAN disks usage including all kinds of overhead.  | [optional] 
**PhysicalCapacity** | **long** | Total physical capacity in bytes.  | [optional] 
**PhysicalCapacityUsed** | **long** | Physical capacity used in bytes by aggregating all vSAN disks usage including all kinds of overhead.  | [optional] 
**DedupMetadataSize** | **long** | Size of space used for deduplication metadata in bytes.  | [optional] 
**SpaceEfficiencyMetadataSize** | [**VsanSpaceEfficiencyMetadataSize**](VsanSpaceEfficiencyMetadataSize.md) | vSAN space efficiency metadata size in bytes.  | [optional] 
**EsaDedupSpaceSaving** | **long** | Total space saving in bytes by global deduplication when storing regular vSAN objects on vSAN ESA.  Notice it doesn&#39;t include the space saving from RAID efficiency as we may store the deduplicated data with more RAID efficient way. This is only valid since 9.0.  | [optional] 
**EsaCompressionSpaceSaving** | **long** | Total space saving in bytes by compression when storing regular vSAN objects on vSAN ESA.  Notice it doesn&#39;t include the space saving from RAID efficiency as we may store the compressed data with more RAID efficient way. This is only valid since 9.0.  | [optional] 
**TotalSpaceUsedWithoutOverhead** | **long** | Total space used in bytes when storing regular vSAN objects on vSAN ESA after deduplication and compression, including space used by regular objects and dedup store, any other overhead including RAID will be excluded.  This is only valid since 9.0.  | [optional] 
**DedupEnabledObjectSpaceUsed** | **long** | Total space used in bytes of regular vSAN objects with global deduplication policy applied in vSAN ESA.  This space used size is calculated after deduplication but before compression, any other overhead including RAID will be excluded.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

