# Vcenter.ViJson.OpenApi.Model.VirtualMachineDynamicPassthroughInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**VendorName** | **string** | The vendor name of this PCI device.  | 
**DeviceName** | **string** | The device name of this PCI device.  | 
**CustomLabel** | **string** | The custom label attached to this PCI device.  | [optional] 
**VendorId** | **int** | PCI vendor ID for this device.  | 
**DeviceId** | **int** | PCI device ID for this device.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

