# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemFileErrorDetails
The Vcenter.Vm.Guest.Filesystem.FileErrorDetails schema describes additional error information for file and directory operations.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | The reason for the error.  Possible values:   - &#x60;NOT_A_FILE&#x60;: An argument is not a file.   - &#x60;NOT_A_DIRECTORY&#x60;: The argument is not a directory.   - &#x60;PATH_TOO_LONG&#x60;: The file path is too long.   - &#x60;FILE_NOT_FOUND&#x60;: The file is not found.   - &#x60;FILE_TOO_LARGE&#x60;: The file is too large.   - &#x60;NO_DISK_SPACE&#x60;: There is insufficient disk space.   - &#x60;DIRECTORY_NOT_EMPTY&#x60;: Directory not empty.   For more information see: *Vcenter.Vm.Guest.Filesystem.ErrorReason*.  This property was added in __vSphere API 7.0.2.0__. | 
**FilePath** | **string** | The file path associated with the error.  This property was added in __vSphere API 7.0.2.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

