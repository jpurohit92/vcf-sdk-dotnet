# Vcenter.Automation.OpenApi.Model.VcenterVmGuestLocalFilesystemInfo
The Vcenter.Vm.Guest.LocalFilesystem.Info schema contains information about a local file system configured in the guest operating system.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **long** | Total capacity of the file system, in bytes.  This property was added in __vSphere API 6.7__. | 
**FreeSpace** | **long** | Free space on the file system, in bytes.  This property was added in __vSphere API 6.7__. | 
**Filesystem** | **string** | Filesystem type, if known. For example, ext3 or NTFS.  This property was added in __vSphere API 7.0.0.0__.  set if VMware Tools reports a value. | [optional] 
**Mappings** | [**List&lt;VcenterVmGuestLocalFilesystemVirtualDiskMapping&gt;**](VcenterVmGuestLocalFilesystemVirtualDiskMapping.md) | VirtualDisks backing the guest partition, if known.  This property was added in __vSphere API 7.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

