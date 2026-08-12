# Vcenter.Automation.OpenApi.Model.EsxHclPCIDevice
The Esx.Hcl.PCIDevice schema contains properties describing information about a single PCI device on a host.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PciAddress** | **string** | The device&#39;s address in a given ESXi host. | 
**Vid** | **string** | A unique number assigned to each computer hardware device that helps to identify the chipset manufacturer. For example, Dell, Broadcom, etc. | 
**Did** | **string** | A unique number that identifies the specific device of the Vendor (VID). | 
**Svid** | **string** | A unique number that identifies the card manufacturer. | 
**Ssid** | **string** | A unique number that identifies the specific device of Subsystem Vendor (SVID). | 
**Vendor** | **string** | The name of the vendor. | 
**ModelName** | **string** | The name of the device model. | 
**ClassCode** | **string** | Register that specifies the type of function the device performs. | 
**SubClassCode** | **string** | Register that specifies the specific function the device performs. | 
**Driver** | [**EsxHclDriver**](EsxHclDriver.md) | Currently installed driver used by the device. | 
**Firmware** | [**EsxHclFirmware**](EsxHclFirmware.md) | Currently installed firmware used by the device.  If missing or &#x60;null&#x60; firmware is unknown. | [optional] 
**UsedByVsan** | **bool** | Shows whether the device is part of VSAN cluster or not. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

