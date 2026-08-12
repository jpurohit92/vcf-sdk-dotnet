# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemFilesFileAttributesUpdateSpec
File attributes used for updating an existing file with *POST /vcenter/vm/{vm}/guest/filesystem/files?action=update*  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastModified** | **DateTime** | The date and time the file was last modified.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; the value will not be changed. | [optional] 
**LastAccessed** | **DateTime** | The date and time the file was last accessed.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; the value will not be changed. | [optional] 
**Windows** | [**VcenterVmGuestFilesystemFilesWindowsFileAttributesUpdateSpec**](VcenterVmGuestFilesystemFilesWindowsFileAttributesUpdateSpec.md) | Windows-specific file update information.  This property was added in __vSphere API 7.0.2.0__.  Set if the guest operating system is Windows. | [optional] 
**Posix** | [**VcenterVmGuestFilesystemFilesPosixFileAttributesUpdateSpec**](VcenterVmGuestFilesystemFilesPosixFileAttributesUpdateSpec.md) | Posix-specific file update information.  This property was added in __vSphere API 7.0.2.0__.  Set if the guest operating system is Posix. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

