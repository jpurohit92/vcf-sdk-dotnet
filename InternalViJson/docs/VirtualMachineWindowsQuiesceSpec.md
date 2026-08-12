# Vcenter.ViJson.OpenApi.Model.VirtualMachineWindowsQuiesceSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timeout** | **int** | The property to indicate maximum time in minutes for snapshot operation to be performed on the virtual machine.  The timeout can not be less than 5 minutes or more than 240 minutes.  | [optional] 
**VssBackupType** | **int** | The property to indicate what type of VSS backup operation is going to be performed on the virtual machine.  See VSS\\_BACKUP\\_TYPE on MSDN: https://msdn.microsoft.com/en-us/library/aa384679(v&#x3D;vs.85).aspx  | [optional] 
**VssBootableSystemState** | **bool** | The property to indicate if a bootable system state during VSS backup to be performed on the virtual machine.  | [optional] 
**VssPartialFileSupport** | **bool** | The property to indicate if partial file support is enabled during VSS backup to be performed on the virtual machine.  | [optional] 
**VssBackupContext** | **string** | The property to indicate what context of VSS backup operation to be performed on the virtual machine.  For the list of supported values, see *VirtualMachineWindowsQuiesceSpecVssBackupContext_enum*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

