# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemFilesSummary
The Vcenter.Vm.Guest.Filesystem.Files.Summary schema describes a file or directory in the guest operating system returned by a *POST /vcenter/vm/{vm}/guest/filesystem/files?action=list* operation.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filename** | **string** | The name of the file or directory with any leading directories removed.  This property was added in __vSphere API 7.0.2.0__. | 
**Type** | **string** | The type of file.  Possible values:   - &#x60;FILE&#x60;: normal file   - &#x60;DIRECTORY&#x60;: directory   - &#x60;SYMLINK&#x60;: symbolic link   For more information see: *Vcenter.Vm.Guest.Filesystem.Files.Type*.  This property was added in __vSphere API 7.0.2.0__. | 
**Size** | **long** | The file size in bytes.  This property was added in __vSphere API 7.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

