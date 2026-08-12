# Vcenter.ViJson.OpenApi.Model.VsanLimitHealthResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The host name  | [optional] 
**IssueFound** | **bool** | Whether any issue found in the vSAN limit health check.  | 
**MaxComponents** | **int** | The maximum number of supported vSAN components in the host.  | 
**FreeComponents** | **int** | The number of remaining vSAN components can be created in the host.  It equals to the maximum supported components minus the used components.  | 
**ComponentLimitHealth** | **string** | The host component usage health status.  The status will be red if the used components exceeds 90% of total component number, the status will be yellow if it exceeds 75% of total components and it will be green if it&#39;s less than 75% of total component.  | 
**LowestFreeDiskSpacePct** | **int** | The lowest free disk space percentage among all of disks in the host.  This value will be 100 if there is no disk found in the host.  | 
**UsedDiskSpaceB** | **long** | The total used disk space in byte, which is the larger value between reserved capacity and the data physically written into the disk.  | 
**TotalDiskSpaceB** | **long** | The total vSAN capacity in byte.  It&#39;s the total of physical space which can be used for writing data including any of user data, metadata and the overhead data.  | 
**DiskFreeSpaceHealth** | **string** | The disk free space health status.  The status will be red if the used disk space is larger than 90% of total space, the status will be yellow if it&#39;s larger than 70% of total space and it will be green if it&#39;s less than 70% of total space.  | 
**ReservedRcSizeB** | **long** | The reserved read cache size in byte.  | 
**TotalRcSizeB** | **long** | The total read cache size in byte.  | 
**RcFreeReservationHealth** | **string** | The read cache reservation health status.  The status will be red if the reserved read cache space is larger than 90% of total space, the status will be yellow if it&#39;s larger than 80% of total space and it will be green if it&#39;s less than 80% of total space.  | 
**TotalLogicalSpaceB** | **long** | The total logical capacity in byte.  | [optional] 
**LogicalSpaceUsedB** | **long** | The logical capacity used in byte.  | [optional] 
**DedupMetadataSizeB** | **long** | The dedupMetadataSize used in byte.  | [optional] 
**DiskTransientCapacityUsedB** | **long** | The disk transient used in byte.  | [optional] 
**DgTransientCapacityUsedB** | **long** | The disk group transient used in byte.  | [optional] 
**SlackSpaceCapRequired** | **long** | The space required by the vSAN internal operations like policy reconfiguration and we expect user to reserve this in cluster.  | [optional] 
**ResyncPauseThreshold** | **long** | The space threshold to pause vSAN data resync operation, e.g., the reserved space for storage policy related object reconfigurations.  | [optional] 
**SpaceEfficiencyMetadataSizeB** | [**VsanSpaceEfficiencyMetadataSize**](VsanSpaceEfficiencyMetadataSize.md) | vSAN space efficiency metadata size in byte.  | [optional] 
**HostRebuildCapacity** | **long** | The space required for host rebuild if one of the host is down  | [optional] 
**MinSpaceRequiredForVsanOp** | **long** | The space required by the vSAN internal operations like policy reconfiguration at cluster level.  | [optional] 
**EnforceCapResrvSpace** | **long** | The additional space reserved by the vSAN internal operation at cluster level when vSAN operation capacity is enforced.  | [optional] 
**CdReservedSizeB** | **long** | The total reserved capacity size in byte for all the capacity disks on a host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

