# Vcenter.ViJson.OpenApi.Model.GuestDiskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiskPath** | **string** | Name of the virtual disk in the guest operating system.  For example: C:\\\\  | [optional] 
**Capacity** | **long** | Total capacity of the disk, in bytes.  This is part of the virtual machine configuration.  | [optional] 
**FreeSpace** | **long** | Free space on the disk, in bytes.  This is retrieved by VMware Tools.  | [optional] 
**FilesystemType** | **string** | Filesystem type, if known.  For example NTFS or ext3.  | [optional] 
**Mappings** | [**List&lt;GuestInfoVirtualDiskMapping&gt;**](GuestInfoVirtualDiskMapping.md) | VirtualDisks backing the guest partition, if known.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

