# Vcenter.ViJson.OpenApi.Model.VimVsanHostDiskResultEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disk** | [**HostScsiDisk**](HostScsiDisk.md) | Disk for this result.  | 
**State** | **string** | State of the disk for this result.  See also *VsanHostDiskResultState_enum*.  | 
**VsanUuid** | **string** | VSAN disk UUID in case this disk is a VSAN disk.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | Error information for this result: may be populated with additional information about the disk at hand, regardless of the disk&#39;s state.  See also *VsanDiskFault*, *VsanHostDiskResult.state*.  | [optional] 
**Degraded** | **bool** | Indicates whether the disk is degraded in VSAN performance.  If set, indicates the disk performance is degraded in VSAN If unset, it is unknown whether the disk performance is degraded in VSAN.  | [optional] 
**VsanDirectTagged** | **bool** | Indicates whether the disk is tagged to be claimed as vSAN Direct disk.  If set to true, it indicates users prefer to use this disk to be claimed as vSAN Direct disk. If set to false or unset, it indicates users do not have such preference. Currently only eligible disks can be tagged as vSAN Direct. It acts as a hint to the upper management suites like VCF, tagging it does not automatically claim the disk as vSAN Direct.  | 
**StoragePoolDiskState** | **string** | Indicates state of the storage pool disk.  Represents if the disk is In-use/Eligible/Ineligible for storage pool. See *VsanHostDiskResultState_enum*.  | [optional] 
**StoragePoolDiskError** | [**MethodFault**](MethodFault.md) | Error information corresponding to the storagePoolDiskState.  For eg: If storagePoolDiskState is Ineligible, storagePoolDiskError will give the corresponding reason for ineligiblility like &#39;Disk is in use by DiskGroup&#39;. This may also be populated with additional information about the disk at hand.  | [optional] 
**IsCapacityFlash** | **bool** | Check if given disk is capacity flash or not.  For eg: If setup is all flash setup, for capacity tier SSDs, this flag will be true.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

