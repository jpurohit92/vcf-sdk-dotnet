# Vcenter.ViJson.OpenApi.Model.VimVsanHostVsanScsiDisk

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | [**HostDiskDimensionsLba**](HostDiskDimensionsLba.md) | The size of SCSI disk using the Logical Block Addressing scheme.  | 
**UsedCapacity** | **long** | The used capacity in byte for this disk.  | [optional] 
**DevicePath** | **string** | The device path of the ScsiDisk.  This device path is a file path that can be opened to create partitions on the disk.  | 
**Ssd** | **bool** | Indicates whether the ScsiDisk is SSD backed.  If unset, the information whether the ScsiDisk is SSD backed is unknown.  | [optional] 
**LocalDisk** | **bool** | Indicates whether the ScsiDisk is local.  If unset, the information whether the ScsiDisk is local is unknown.  | [optional] 
**ScsiDiskType** | **string** | The types of disk drives.  | [optional] 
**Uuid** | **string** | Universally unique identifier for the LUN used to identify ScsiLun across multiple servers.  | 
**OperationalState** | **List&lt;string&gt;** | The operational states of the LUN.  When more than one item is present in the array, the first state should be considered the primary state. For example, a LUN may be \&quot;ok\&quot; and \&quot;degraded\&quot; indicating I/O is still possible to the LUN, but it is operating in a degraded mode.  | [optional] 
**CanonicalName** | **string** | Canonical name of the SCSI logical unit.  | [optional] 
**DisplayName** | **string** | User configurable display name of the SCSI logical unit.  | [optional] 
**LunType** | **string** | The type of SCSI device.  Must be one of the values of *ScsiLunType_enum*.  | 
**Vendor** | **string** | The vendor of the SCSI device.  | [optional] 
**Model** | **string** | The model number of the SCSI device.  | [optional] 
**MountInfo** | [**HostMountInfo**](HostMountInfo.md) | The mount info for this disk.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

