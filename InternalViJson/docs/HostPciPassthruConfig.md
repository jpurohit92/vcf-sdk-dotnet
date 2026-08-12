# Vcenter.ViJson.OpenApi.Model.HostPciPassthruConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The name ID of this PCI, composed of \&quot;bus:slot.function\&quot;.  | 
**PassthruEnabled** | **bool** | Whether passThru has been configured for this device  | 
**ApplyNow** | **bool** | Whether the passThru config should take effect without rebooting ESX.  When unset, the behavior will be determined automatically based on *HostCapability.deviceRebindWithoutRebootSupported*. If the configuration can be applied immediately, it will be, otherwise the changes will take effect after reboot.  | [optional] 
**HardwareLabel** | **string** | The hardware label of the this PCI device.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

