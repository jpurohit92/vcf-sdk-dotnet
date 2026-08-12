# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemTransfersCreateSpec
The Vcenter.Vm.Guest.Filesystem.Transfers.CreateSpec schema describes the details of a file transfer operation.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The complete destination path in the guest to transfer the file to or from the client. It cannot be a path to a directory or a symbolic link.  This property was added in __vSphere API 7.0.2.0__. | 
**Attributes** | [**VcenterVmGuestFilesystemTransfersFileCreationAttributes**](VcenterVmGuestFilesystemTransfersFileCreationAttributes.md) | Details about the file to be transferred into the guest.  This property was added in __vSphere API 7.0.2.0__.  Must be set if the file is being transferred to the guest. Must not be set if the file is being transferred from the guest. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

