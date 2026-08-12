# Vcenter.ViJson.OpenApi.Model.VirtualUSBControllerPciBusSlotInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PciSlotNumber** | **int** | The pci slot number of the virtual device.  The pci slot number assignment should generally be left to the system. If assigned a value, and the value is invalid or duplicated, it will automatically be reassigned. This will not cause an error.  Generally, the PCI slot numbers should never be specified in an Reconfigure operation, and only in a CreateVM operation if i) they are specified for all devices, and ii) the numbers have been determined by looking at an existing VM configuration of similar hardware version. In other words, when the virtual hardware configuration is duplicated.  | 
**EhciPciSlotNumber** | **int** | The pci slot number of eHCI controller.  This property should be used only when the ehciEnabled property is set to true.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

