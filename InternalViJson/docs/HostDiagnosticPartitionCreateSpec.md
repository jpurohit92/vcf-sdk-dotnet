# Vcenter.ViJson.OpenApi.Model.HostDiagnosticPartitionCreateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StorageType** | **string** | Indicates the storage type where the diagnostic partition will be created.  See also *DiagnosticPartitionStorageType_enum*.  | 
**DiagnosticType** | **string** | Indicates the type of the diagnostic partition to be created.  See also *DiagnosticPartitionType_enum*.  | 
**Id** | [**HostScsiDiskPartition**](HostScsiDiskPartition.md) | Diagnostic partition identification information.  | 
**Partition** | [**HostDiskPartitionSpec**](HostDiskPartitionSpec.md) | Partitioning specification.  | 
**Active** | **bool** | Indicates if the created diagnostic partition should be made the active diagnostic partition.  If not supplied, the system will decide whether or not the created specification is active.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

