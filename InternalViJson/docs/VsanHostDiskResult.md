# Vcenter.ViJson.OpenApi.Model.VsanHostDiskResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disk** | [**HostScsiDisk**](HostScsiDisk.md) | Disk for this result.  | 
**State** | **string** | State of the disk for this result.  See also *VsanHostDiskResultState_enum*.  | 
**VsanUuid** | **string** | VSAN disk UUID in case this disk is a VSAN disk.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | Error information for this result: may be populated with additional information about the disk at hand, regardless of the disk&#39;s state.  See also *VsanDiskFault*, *VsanHostDiskResult.state*.  | [optional] 
**Degraded** | **bool** | Indicates whether the disk is degraded in VSAN performance.  If set, indicates the disk performance is degraded in VSAN If unset, it is unknown whether the disk performance is degraded in VSAN.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

