# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemFilesInfo
The Vcenter.Vm.Guest.Filesystem.Files.Info schema describes a file or directory in the guest operating system. Returned by *POST /vcenter/vm/{vm}/guest/filesystem/files/{path}?action=get*.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of file.  Possible values:   - &#x60;FILE&#x60;: normal file   - &#x60;DIRECTORY&#x60;: directory   - &#x60;SYMLINK&#x60;: symbolic link   For more information see: *Vcenter.Vm.Guest.Filesystem.Files.Type*.  This property was added in __vSphere API 7.0.2.0__. | 
**Size** | **long** | The file size in bytes.  This property was added in __vSphere API 7.0.2.0__. | 
**Attributes** | [**VcenterVmGuestFilesystemFilesFileAttributesInfo**](VcenterVmGuestFilesystemFilesFileAttributesInfo.md) | Attributes of a file.  This property was added in __vSphere API 7.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

