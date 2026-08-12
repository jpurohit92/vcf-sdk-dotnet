# Vcenter.ViJson.OpenApi.Model.HostDiskPartitionAttributes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Partition** | **int** | The partition number.  Must be a positive integer.  | 
**StartSector** | **long** | The start sector.  | 
**EndSector** | **long** | The end sector.  | 
**Type** | **string** | Type of data in the partition.  If it is a well-known partition type, it will be one of the defined types. If it is not, then it will be reported as a hexadecimal number. For example, \&quot;none\&quot;, \&quot;vmfs\&quot;, \&quot;linux\&quot;, and \&quot;0x20\&quot; are all valid values.  See also *HostDiskPartitionInfoType_enum*.  | 
**Guid** | **string** | Globally Unique Identifier of the partition, as defined by the GUID Partition Table (GPT) format.  This is available only for GPT formatted disks.  | [optional] 
**Logical** | **bool** | The flag to indicate whether or not the partition is logical.  If true, the partition number should be greater than 4.  | 
**Attributes** | **int** | The attributes on the partition.  | 
**PartitionAlignment** | **long** | Partition alignment in bytes.  If unset, partition alignment value is unknown.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

