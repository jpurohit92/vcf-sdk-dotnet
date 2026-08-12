# Vcenter.ViJson.OpenApi.Model.VmfsDatastoreCreateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskUuid** | **string** | The UUID of the SCSI disk on which the VMFS datastore is located.  See also *HostScsiDisk*, *ScsiLun.uuid*.  | 
**Partition** | [**HostDiskPartitionSpec**](HostDiskPartitionSpec.md) | Partitioning specification.  | 
**Vmfs** | [**HostVmfsSpec**](HostVmfsSpec.md) | The VMFS creation specification.  | 
**Extent** | [**List&lt;HostScsiDiskPartition&gt;**](HostScsiDiskPartition.md) | Extents to append to VMFS.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

