# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareAdapterSataCreateSpec
The Vcenter.Vm.Hardware.Adapter.Sata.CreateSpec schema provides a specification for the configuration of a newly-created virtual SATA adapter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Adapter type.  Possible values:   - &#x60;AHCI&#x60;: AHCI host bus adapter.   For more information see: *Vcenter.Vm.Hardware.Adapter.Sata.Type*.  If missing or &#x60;null&#x60;, a guest-specific default value will be used. | [optional] 
**Bus** | **long** | SATA bus number.  If missing or &#x60;null&#x60;, the server will choose an available bus number; if none is available, the request will fail. | [optional] 
**PciSlotNumber** | **long** | Address of the SATA adapter on the PCI bus.  If missing or &#x60;null&#x60;, the server will choose an available address when the virtual machine is powered on. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

