# Vcenter.ViJson.OpenApi.Model.VirtualDiskPartitionedRawDiskVer2BackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DescriptorFileName** | **string** | The name of the raw disk descriptor file.  | 
**Uuid** | **string** | Disk UUID for the virtual disk, if available.  | [optional] 
**ChangeId** | **string** | The change ID of the virtual disk for the corresponding snapshot or virtual machine.  This can be used to track incremental changes to a virtual disk. See *VirtualMachine.QueryChangedDiskAreas*.  | [optional] 
**Sharing** | **string** | The sharing mode of the virtual disk.  See *VirtualDiskSharing_enum*. The default value is no sharing.  | [optional] 
**Partition** | **List&lt;int&gt;** | Array of partition indexes.  This array identifies the partitions that are used on the physical disk drive.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

