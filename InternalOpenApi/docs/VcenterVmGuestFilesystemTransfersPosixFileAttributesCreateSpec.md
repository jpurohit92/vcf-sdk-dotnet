# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemTransfersPosixFileAttributesCreateSpec
The Vcenter.Vm.Guest.Filesystem.Transfers.PosixFileAttributesCreateSpec schema describes creation information about file attributes specific to Posix guest operating systems.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OwnerId** | **long** | The owner ID. If this property is not specified when passing a *Vcenter.Vm.Guest.Filesystem.Transfers.PosixFileAttributesCreateSpec* object to *POST /vcenter/vm/{vm}/guest/filesystem?action&#x3D;create*, the default value will be the owner Id of the user who invoked the file transfer operation.  This property was added in __vSphere API 7.0.2.0__.  Defaults to uid of user invoking the operation. | [optional] 
**GroupId** | **long** | The group ID. If this property is not specified when passing a *Vcenter.Vm.Guest.Filesystem.Transfers.PosixFileAttributesCreateSpec* object to *POST /vcenter/vm/{vm}/guest/filesystem?action&#x3D;create*, the default value will be the group Id of the user who invoked the file transfer operation.  This property was added in __vSphere API 7.0.2.0__.  Defaults to gid of user invoking the operation. | [optional] 
**Permissions** | **string** | The file permissions in chmod(2) format. If this property is not specified when passing a *Vcenter.Vm.Guest.Filesystem.Transfers.PosixFileAttributesCreateSpec* object to *POST /vcenter/vm/{vm}/guest/filesystem?action&#x3D;create*, the file will be created with 0644 permissions. This property is interpreted as octal.  This property was added in __vSphere API 7.0.2.0__.  Defaults to 0644. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

