# Vcenter.ViJson.OpenApi.Model.HostDiskPartitionInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The device name of the disk to which this partition information corresponds.  | 
**Spec** | [**HostDiskPartitionSpec**](HostDiskPartitionSpec.md) | The detailed disk partition specification.  Use this specification for manipulating the file system.  See also *HostStorageSystem.RetrieveDiskPartitionInfo*, *HostStorageSystem.UpdateDiskPartitions*.  | 
**Layout** | [**HostDiskPartitionLayout**](HostDiskPartitionLayout.md) | A convenient format for describing disk layout.  This layout specification can be converted to a Specification object.  See also *HostStorageSystem.ComputeDiskPartitionInfo*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

