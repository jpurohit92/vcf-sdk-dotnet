# Vcenter.ViJson.OpenApi.Model.HostVffsSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DevicePath** | **string** | The device path of the SSD disk.  See also *HostScsiDisk.devicePath*.  | 
**Partition** | [**HostDiskPartitionSpec**](HostDiskPartitionSpec.md) | Partition specification of the SSD disk.  If this property is not provided, partition information will be computed and generated.  | [optional] 
**MajorVersion** | **int** | Major version number of VFFS.  This can be changed if the VFFS is upgraded, but this is an irreversible change.  | 
**VolumeName** | **string** | Volume name of VFFS.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

