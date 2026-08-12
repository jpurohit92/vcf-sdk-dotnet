# Vcenter.Automation.OpenApi.Model.VcenterHostHardwareDirectPathDevicesConfigureSpec
The Vcenter.Host.Hardware.DirectPathDevices.ConfigureSpec schema provides options to configure a DirectPath device.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | **string** | The ID of the device to configure.  This property was added in __vSphere API 9.1.0.0__. | 
**NewMode** | **string** | The new desired mode of the device.  Possible values:   - &#x60;NONE&#x60;: Device is not available for use by virtual machines.   - &#x60;HOST&#x60;: Device is configured for host use, and is not available to virtual machines.   - &#x60;DIRECTPATH&#x60;: Device is available for virtual machines as a DirectPath device.   - &#x60;ENHANCED_DIRECTPATH&#x60;: Device is available for virtual machines as an Enhanced DirectPath device.   - &#x60;VGPU_SAME_SIZE&#x60;: Device is available for virtual machines in Nvidia vGPU same size mode.   - &#x60;VGPU_MIXED_SIZE&#x60;: Device is available for virtual machines in Nvidia vGPU mixed size mode.   - &#x60;SYSTEM_SELECT&#x60;: System selects the mode. After configuration, the device will be in one of the other valid modes for a DirectPath device.   For more information see: *Vcenter.Host.Hardware.DirectPathDevices.DirectPathDeviceMode*.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then the current device mode remains unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

