# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemTransfersFileCreationAttributes
The Vcenter.Vm.Guest.Filesystem.Transfers.FileCreationAttributes schema describes file attributes used when transferring a file into the guest.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **long** | The size in bytes of the file to be transferred into the guest.  This property was added in __vSphere API 7.0.2.0__. | 
**Overwrite** | **bool** | Whether an existing file should be overwritten.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; any existing file will not be overwritten. | [optional] 
**LastModified** | **DateTime** | The date and time the file was last modified.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; the value will be the time when the file is transferred into the guest. | [optional] 
**LastAccessed** | **DateTime** | The date and time the file was last accessed.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; the value will be the time when the file is transferred into the guest. | [optional] 
**Windows** | [**VcenterVmGuestFilesystemTransfersWindowsFileAttributesCreateSpec**](VcenterVmGuestFilesystemTransfersWindowsFileAttributesCreateSpec.md) | Windows-specific file creation information.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, the behavior is equivalent to a *Vcenter.Vm.Guest.Filesystem.Transfers.WindowsFileAttributesCreateSpec* with all properties missing or &#x60;null&#x60; which means the defaults are used. May only be set if the guest operating system is Windows. | [optional] 
**Posix** | [**VcenterVmGuestFilesystemTransfersPosixFileAttributesCreateSpec**](VcenterVmGuestFilesystemTransfersPosixFileAttributesCreateSpec.md) | Posix-specific file creation information.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, the behavior is equivalent to a *Vcenter.Vm.Guest.Filesystem.Transfers.PosixFileAttributesCreateSpec* with all properties missing or &#x60;null&#x60; which means the defaults are used. May only be set if the guest operating system is Posix. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

