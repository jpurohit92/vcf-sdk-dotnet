# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemFilesFileAttributesInfo
The Vcenter.Vm.Guest.Filesystem.Files.FileAttributesInfo schema describes the attributes of a file in a guest operating system.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastModified** | **DateTime** | The date and time the file was last modified.  This property was added in __vSphere API 7.0.2.0__. | 
**LastAccessed** | **DateTime** | The date and time the file was last accessed.  This property was added in __vSphere API 7.0.2.0__. | 
**SymlinkTarget** | **string** | The target for the file if it&#39;s a symbolic link. This is currently only set for Posix guest operating systems, but may be supported in the future on Windows guest operating systems that support symbolic links.  This property was added in __vSphere API 7.0.2.0__.  Set if the file is a symbolic link. | [optional] 
**FilesystemFamily** | **string** | The type of guest filesystem.  Possible values:   - &#x60;WINDOWS&#x60;: The guest OS is a Windows variant.   - &#x60;POSIX&#x60;: Linux, Solaris, etc.   For more information see: *Vcenter.Vm.Guest.Filesystem.Files.FilesystemFamily*.  This property was added in __vSphere API 7.0.2.0__. | 
**WinAttributes** | [**VcenterVmGuestFilesystemFilesWindowsFileAttributesInfo**](VcenterVmGuestFilesystemFilesWindowsFileAttributesInfo.md) | Windows-specific file information.  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of filesystem_family is *Vcenter.Vm.Guest.Filesystem.Files.FilesystemFamily.WINDOWS*. | [optional] 
**PosixAttributes** | [**VcenterVmGuestFilesystemFilesPosixFileAttributesInfo**](VcenterVmGuestFilesystemFilesPosixFileAttributesInfo.md) | Posix-specific file information.  This property was added in __vSphere API 7.0.2.0__.  This property is optional and it is only relevant when the value of filesystem_family is *Vcenter.Vm.Guest.Filesystem.Files.FilesystemFamily.POSIX*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

