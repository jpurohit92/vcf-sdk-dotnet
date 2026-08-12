# Vcenter.Automation.OpenApi.Model.VcenterHostHardwareDirectPathDevicesDirectPathDeviceMode
The Vcenter.Host.Hardware.DirectPathDevices.DirectPathDeviceMode schema provides information about the valid modes for a DirectPath device.  Possible values:   - `NONE`: Device is not available for use by virtual machines.   - `HOST`: Device is configured for host use, and is not available to virtual machines.   - `DIRECTPATH`: Device is available for virtual machines as a DirectPath device.   - `ENHANCED_DIRECTPATH`: Device is available for virtual machines as an Enhanced DirectPath device.   - `VGPU_SAME_SIZE`: Device is available for virtual machines in Nvidia vGPU same size mode.   - `VGPU_MIXED_SIZE`: Device is available for virtual machines in Nvidia vGPU mixed size mode.   - `SYSTEM_SELECT`: System selects the mode. After configuration, the device will be in one of the other valid modes for a DirectPath device.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

