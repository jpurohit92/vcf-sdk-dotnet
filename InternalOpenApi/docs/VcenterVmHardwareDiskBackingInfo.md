# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareDiskBackingInfo
The Vcenter.Vm.Hardware.Disk.BackingInfo schema contains information about the physical resource backing a virtual disk.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Backing type for the virtual disk.  Possible values:   - &#x60;VMDK_FILE&#x60;: Virtual disk is backed by a VMDK file.   For more information see: *Vcenter.Vm.Hardware.Disk.BackingType*. | 
**VmdkFile** | **string** | Path of the VMDK file backing the virtual disk.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Disk.BackingType.VMDK_FILE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

