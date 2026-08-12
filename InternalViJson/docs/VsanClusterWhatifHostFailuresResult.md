# Vcenter.ViJson.OpenApi.Model.VsanClusterWhatifHostFailuresResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumFailures** | **long** | The number of simulated host failures  | 
**TotalUsedCapacityB** | **long** | The total physically used capacity in bytes aggregating from all of disks of all of available hosts.  The physically used capacity for vSAN disk is defined as the maximum value between reserved capacity and data size physically written into the disk  | 
**TotalCapacityB** | **long** | The total vSAN capacity in byte.  It&#39;s the total of physical space which can be used for writing data including any of user data, metadata and the overhead data  | 
**TotalRcReservationB** | **long** | The total read cache reservation in bytes  | 
**TotalRcSizeB** | **long** | The total read cache size in byes  | 
**UsedComponents** | **long** | The number of used components  | 
**TotalComponents** | **long** | The maximum number of components  | 
**ComponentLimitHealth** | **string** | The component usage health status.  The status will be red if the used of component number exceeds 90% of total component number limit, the status will be yellow if it exceeds 80% of total component number and it will be green if it&#39;s less than 80% of total component number  | [optional] 
**DiskFreeSpaceHealth** | **string** | The disk usage health status.  The status will be red if the used disk space is larger than 90% of total space, the status will be yellow if it&#39;s larger than 70% of total space and it will be green if it&#39;s less than 70% of total space  | [optional] 
**RcFreeReservationHealth** | **string** | The read cache reservation health status.  The status will be red if the reserved read cache space is larger than 90% of total space, the status will be yellow if it&#39;s larger than 70% of total space and it will be green if it&#39;s less than 70% of total space  | [optional] 
**SlackSpaceCapRequired** | **long** | The total space required by the vSAN internal operations like policy reconfiguration and we expect user to reserve this in cluster.  | [optional] 
**DiskSpaceThreshold** | [**VsanHealthThreshold**](VsanHealthThreshold.md) | Indicates the yellow or red threshold, in bytes, for the &#39;disk space&#39; health check.  The thresholds are computed based on current cluster&#39;s capacity reservation info.  | [optional] 
**CapacityReservationInfo** | [**VsanCapacityReservationInfo**](VsanCapacityReservationInfo.md) | Indicates the capacity reservation info, *VsanCapacityReservationInfo*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

