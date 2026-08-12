# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareAdapterScsiCreateSpec
The Vcenter.Vm.Hardware.Adapter.Scsi.CreateSpec schema provides a specification for the configuration of a newly-created virtual SCSI adapter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Adapter type.  Possible values:   - &#x60;BUSLOGIC&#x60;: BusLogic host bus adapter.   - &#x60;LSILOGIC&#x60;: LSI Logic host bus adapter.   - &#x60;LSILOGICSAS&#x60;: LSI Logic SAS 1068 host bus adapter.   - &#x60;PVSCSI&#x60;: Paravirtualized host bus adapter.   For more information see: *Vcenter.Vm.Hardware.Adapter.Scsi.Type*.  If missing or &#x60;null&#x60;, a guest-specific default value will be used. | [optional] 
**Bus** | **long** | SCSI bus number.  If missing or &#x60;null&#x60;, the server will choose an available bus number; if none is available, the request will fail. | [optional] 
**PciSlotNumber** | **long** | Address of the SCSI adapter on the PCI bus. If the PCI address is invalid, the server will change it when the VM is started or as the device is hot added.  If missing or &#x60;null&#x60;, the server will choose an available address when the virtual machine is powered on. | [optional] 
**Sharing** | **string** | Bus sharing mode.  Possible values:   - &#x60;NONE&#x60;: The virtual SCSI bus is not shared.   - &#x60;VIRTUAL&#x60;: The virtual SCSI bus is shared between two or more virtual machines. In this case, no physical machine is involved.   - &#x60;PHYSICAL&#x60;: The virtual SCSI bus is shared between two or more virtual machines residing on different physical hosts.   For more information see: *Vcenter.Vm.Hardware.Adapter.Scsi.Sharing*.  If missing or &#x60;null&#x60;, the adapter will default to *Vcenter.Vm.Hardware.Adapter.Scsi.Sharing.NONE*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

