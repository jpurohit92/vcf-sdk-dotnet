# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareAdapterScsiInfo
The Vcenter.Vm.Hardware.Adapter.Scsi.Info schema contains information about a virtual SCSI adapter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Device label. | 
**Type** | **string** | Adapter type.  Possible values:   - &#x60;BUSLOGIC&#x60;: BusLogic host bus adapter.   - &#x60;LSILOGIC&#x60;: LSI Logic host bus adapter.   - &#x60;LSILOGICSAS&#x60;: LSI Logic SAS 1068 host bus adapter.   - &#x60;PVSCSI&#x60;: Paravirtualized host bus adapter.   For more information see: *Vcenter.Vm.Hardware.Adapter.Scsi.Type*. | 
**Scsi** | [**VcenterVmHardwareScsiAddressInfo**](VcenterVmHardwareScsiAddressInfo.md) | Address of the SCSI adapter on the SCSI bus. | 
**PciSlotNumber** | **long** | Address of the SCSI adapter on the PCI bus. If the PCI address is invalid, the server will change it when the VM is started or as the device is hot added.  May be missing or &#x60;null&#x60; if the virtual machine has never been powered on since the adapter was created. | [optional] 
**Sharing** | **string** | Bus sharing mode.  Possible values:   - &#x60;NONE&#x60;: The virtual SCSI bus is not shared.   - &#x60;VIRTUAL&#x60;: The virtual SCSI bus is shared between two or more virtual machines. In this case, no physical machine is involved.   - &#x60;PHYSICAL&#x60;: The virtual SCSI bus is shared between two or more virtual machines residing on different physical hosts.   For more information see: *Vcenter.Vm.Hardware.Adapter.Scsi.Sharing*. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

