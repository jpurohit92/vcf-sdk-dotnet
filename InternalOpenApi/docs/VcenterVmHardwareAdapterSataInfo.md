# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareAdapterSataInfo
The Vcenter.Vm.Hardware.Adapter.Sata.Info schema contains information about a virtual SATA adapter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Device label. | 
**Type** | **string** | Adapter type.  Possible values:   - &#x60;AHCI&#x60;: AHCI host bus adapter.   For more information see: *Vcenter.Vm.Hardware.Adapter.Sata.Type*. | 
**Bus** | **long** | SATA bus number. | 
**PciSlotNumber** | **long** | Address of the SATA adapter on the PCI bus.  May be missing or &#x60;null&#x60; if the virtual machine has never been powered on since the adapter was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

