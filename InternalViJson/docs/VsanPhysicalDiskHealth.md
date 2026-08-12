# Vcenter.ViJson.OpenApi.Model.VsanPhysicalDiskHealth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The physical disk name with the format like \&quot;mpx.vmhba1:C0:T2:L0\&quot;.  | 
**Uuid** | **string** | The disk device UUID.  | 
**InCmmds** | **bool** | True indicate this disk can be found in the CMMDS.  | 
**InVsi** | **bool** | True indicates this disk can be found through VSI.  | 
**DedupScope** | **long** | The dedup scope configuration.  The value 0 indicate there is no dedup enabled, 1 indicates the dedup scope is in disk wide and 2 indicates the dedup scope is in disk group wide.  | [optional] 
**FormatVersion** | **int** | The disk format version in vSAN.  | [optional] 
**IsAllFlash** | **int** | Flag to indicate if it&#39;s all flash configuration.  The value is 1 if the disk group are all flash disk.  | [optional] 
**CongestionValue** | **int** | The maximum congestion value among the area of log, SSD, slab, and memory.  The IO congestion may happen in this four areas in vSAN, it will choose the maximum value among them.  | [optional] 
**CongestionArea** | **string** | The IO congestion area including log, SSD, slab and memory.  If there is no congestion happen for all of these areas, this value will be &#39;none&#39;.  | [optional] 
**CongestionHealth** | **string** | The congestion health status.  The status will be red if the congestion value is larger than 220 and it&#39;s yellow if the congestion value is between 200 and 220 and it&#39;s green if the congestion value is less than 200.  | [optional] 
**MetadataHealth** | **string** | The vSAN metadata health status.  All of possible values are \&quot;green\&quot;, \&quot;yellow\&quot; and \&quot;red\&quot;  | [optional] 
**OperationalHealthDescription** | **string** | The disk operational health description.  It gives the reason why the disk is not in operational. All the possible values are: - \&quot;OK\&quot;: Healthy - \&quot;UNKNOWN\&quot;: Disk health is unknown - \&quot;FAILED\&quot;: Permanent disk failure - \&quot;OFFLINE\&quot;: Permanent disk loss - \&quot;OFFLINE,PROPAGATED\&quot;: Propagated permanent disk failure   in disk group - \&quot;DECOMMISSIONED\&quot;: Disk dicommissioned - \&quot;EVACUATING,LATENCY\&quot;: Impending permanent disk failure,   data is being evacuated - \&quot;EVACUATE\\_FAILED,LATENCY\&quot;: Impending permanent disk failure,   evacuation failed due to insufficient resources - \&quot;EVACUATE\\_INACCESSIBLE,LATENCY\&quot;: Impending permanent disk failure,   evacuation failed due to inaccessible objects - \&quot;EVACUATED,LATENCY\&quot;: Impending permanent disk failure, data   evacuation complete - \&quot;EVACUATING,LOG\\_CONGESTION\&quot;: Observed excessive log congestion,   data is being evacuated - \&quot;EVACUATE\\_FAILED,LOG\\_CONGESTION\&quot;: Observed excessive log congestion,   evacuation failed due to insufficient resources - \&quot;EVACUATE\\_INACCESSIBLE,LOG\\_CONGESTION\&quot;: Observed excessive log   congestion, evacuation failed due to inaccessible objects - \&quot;EVACUATED,LOG\\_CONGESTION\&quot;: Observed excessive log congestion, data   evacuation is complete - \&quot;EVACUATING,PROPAGATED\&quot;: Propagated impending permanent disk failure   in the diskgroup, data is being evacuated - \&quot;EVACUATE\\_FAILED,PROPAGATED\&quot;: Propagated impending permanent disk   failure in the diskgroup, evacuation failed due to insufficient   resources - \&quot;EVACUATE\\_INACCESSIBLE,PROPAGATED\&quot;: Propagated impending permanent   disk failure in the diskgroup, evacuation failed due to inaccessible   objects - \&quot;EVACUATED,PROPAGATED\&quot;: Propagated impending permanent disk failure in   the diskgroup, data evacuation is complete - \&quot;TRANSIENT\\_ERROR\&quot;: Disk is being repaired due to I/O failures - \&quot;TRANSIENT\\_ERROR\\_IMPACT\&quot;: Propagated disk issue in the diskgroup - \&quot;TRANSIENT\\_ERROR\\_REPAIR\\_FAILED\&quot;: Disk recovery failed - \&quot;READONLY\&quot;: Disk is in readonly mode, which should only be set for   testing purpose - \&quot;UNKNOWN\&quot;: Unknown disk state  | [optional] 
**OperationalHealth** | **string** | The disk operational health status.  All of possible value are \&quot;green\&quot;, \&quot;yellow\&quot; and \&quot;red\&quot;  | [optional] 
**DedupUsageHealth** | **string** | The dedup usage health status.  The status will be red if the dedup is enabled on a hybrid diskgroup, the status will be yellow if dedup is not enabled on an all flash diskgroup and it&#39;s green in any other situation  | [optional] 
**CapacityHealth** | **string** | The disk capacity health status  | [optional] 
**SummaryHealth** | **string** | The overall disk health status.  It&#39;s the aggregation for the disk operational health, the disk congestion health, disk metadata health, disk capacity health, disk component limit health and disk dedup usage health. All of possible value are \&quot;green\&quot;, \&quot;yellow\&quot;, and \&quot;red\&quot;.  | 
**Capacity** | **long** | The total disk capacity for written data  | [optional] 
**UsedCapacity** | **long** | The total used disk capacity in byte, which is the larger value between reserved capacity and the data physically written into the disk.  | [optional] 
**ReservedCapacity** | **long** | The total reserved capacity in the disk  | [optional] 
**TotalBytes** | **long** | Ignore this value  | [optional] 
**FreeBytes** | **long** | Ignore this value  | [optional] 
**HashedBytes** | **long** | Ignore this value  | [optional] 
**DedupedBytes** | **long** | Ignore this value  | [optional] 
**ScsiDisk** | [**HostScsiDisk**](HostScsiDisk.md) | The SCSI disk information  | [optional] 
**UsedComponents** | **long** | The number of used components on the disk.  When vSAN ESA is not enabled, it represents total used components on the disk. Otherwise it represents used data components only on the disk.  | [optional] 
**MaxComponents** | **long** | The maximum component limit on the disk.  When vSAN ESA is not enabled, it represents the maximum component limit on the disk. Otherwise it represents maximum data components on the disk.  | [optional] 
**CompLimitHealth** | **string** | The component usage health status.  The status will be red if the used of component number exceeds 95% of total component number limit, the status will be yellow if it exceeds 75% of total component number and it will be green if it&#39;s less than 75% of total component number. When vSAN ESA is not enabled, it will check total component usage for this disks. Otherwise, it will check component usage of data and metadata components and then generate overall health status for this disk.  | [optional] 
**EncryptionEnabled** | **bool** | Encryption state in disk metadata.  | [optional] 
**KmsProviderId** | **string** | The Id of the KMS cluster to use for vSAN Encryption.  Keys will be created on and used from this KMS.  | [optional] 
**KekId** | **string** | Key Encryption Key ID in disk metadata.  | [optional] 
**DekGenerationId** | **long** | Data Encryption Key generation number in disk metadata.  | [optional] 
**EncryptedUnlocked** | **bool** | Whether encryption keys for this disk are loaded.  If encryption is on and the encryption keys are not loaded for the disk, the disk cannot be used for vSAN I/O on this host.  | [optional] 
**RebalanceResult** | [**VsanDiskRebalanceResult**](VsanDiskRebalanceResult.md) | The vSAN disk rebalance status  | [optional] 
**DekId** | **string** | Data Key Encryption Key ID in disk metadata.  | [optional] 
**KekVerifierHealth** | **bool** | The disk KEK verifier health state.  &#39;True&#39; means the disk KEK verifier has not changed and the disk KEK is healthy, and &#39;False&#39; means the disk KEK verifier has changed and the disk KEK is unhealthy.  | [optional] 
**DekVerifierHealth** | **bool** | The disk DEK verifier health state.  &#39;True&#39; means the disk DEK verifier has not changed and the disk DEK is healthy, and &#39;False&#39; means the disk DEK verifier has changed and the disk DEK is unhealthy.  | [optional] 
**LogicalCapacity** | **long** | The logical disk capacity for written data.  It will be nonzero only when cluster deduplication and compression or compression only is enabled. Otherwise, the value is unset(None).  | [optional] 
**LogicalCapacityUsed** | **long** | The total used disk logical capacity in byte.  It will be nonzero only when cluster deduplication and compression or compression only is enabled. Otherwise, the value is unset(None).  | [optional] 
**LogicalCapacityHealth** | **string** | The health status of disk logical space usage.  The value will be one of \&quot;green\&quot;, \&quot;yellow\&quot;, \&quot;red\&quot;.  | [optional] 
**VsanDiskGroupUuid** | **string** | The vSAN disk group UUID.  | [optional] 
**DgLayoutIssue** | **bool** | True indicates the disk is a large capacity drive and the vSAN disk group layout need to be converted to 64 bit to support such disk.  The value is unset(None) if there is no issue found.  | [optional] 
**UsedMetadataComponents** | **long** | The number of used metadata components on the disk.  This is only set when vSAN ESA is enabled.  | [optional] 
**MaxMetadataComponents** | **long** | The maximum metadata component limit on the disk.  This is only set when vSAN ESA is enabled.  | [optional] 
**PendingClusterDekId** | **string** | vSAN ESA adds a pending cluster data encryption key into disk metadata to record the new key to encrypt disk metadata in the comming deep rekey.  This is the pending cluster data encryption key id.  | [optional] 
**DmekVerifierHealth** | **bool** | The disk DMEK verifier health state.  &#39;True&#39; means the disk DMEK verifier has not changed and the disk DMEK is healthy, and &#39;False&#39; means the disk DMEK verifier has changed and the disk DMEK is unhealthy.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

