# Vcenter.ViJson.OpenApi.Model.VmfsDatastoreExtendSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskUuid** | **string** | The UUID of the SCSI disk on which the VMFS datastore is located.  See also *HostScsiDisk*, *ScsiLun.uuid*.  | 
**Partition** | [**HostDiskPartitionSpec**](HostDiskPartitionSpec.md) | Partitioning specification.  | 
**Extent** | [**List&lt;HostScsiDiskPartition&gt;**](HostScsiDiskPartition.md) | Extents to append to VMFS.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

