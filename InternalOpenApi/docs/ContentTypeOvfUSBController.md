# Vcenter.Automation.OpenApi.Model.ContentTypeOvfUSBController
Provide USB controller information in a template VM.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | USBControllerType.EHCI (USB 2.0), XHCI (USB 3.0)  A template is not required to specify the USB type. | [optional] 
**AutoConnect** | **bool** | True if the USB controller is connected automatically  A template is not required to specify if auto connect. | [optional] 
**EhciPciSlotNumber** | **long** | ehci.pci slot number  A template is not required to specify the ehci.pci slot number. | [optional] 
**PciSlotNumber** | **long** | pci slot number  A template is not required to specify the pci slot number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

