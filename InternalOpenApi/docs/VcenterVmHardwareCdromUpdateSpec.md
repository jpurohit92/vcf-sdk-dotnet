# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareCdromUpdateSpec
The Vcenter.Vm.Hardware.Cdrom.UpdateSpec schema describes the updates to be made to the configuration of a virtual CD-ROM device.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Backing** | [**VcenterVmHardwareCdromBackingSpec**](VcenterVmHardwareCdromBackingSpec.md) | Physical resource backing for the virtual CD-ROM device.    This property may only be modified if the virtual machine is not powered on or the virtual CD-ROM device is not connected.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**StartConnected** | **bool** | Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**AllowGuestControl** | **bool** | Flag indicating whether the guest can connect and disconnect the device.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

