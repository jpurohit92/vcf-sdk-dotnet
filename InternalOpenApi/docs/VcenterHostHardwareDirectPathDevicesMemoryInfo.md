# Vcenter.Automation.OpenApi.Model.VcenterHostHardwareDirectPathDevicesMemoryInfo
The Vcenter.Host.Hardware.DirectPathDevices.MemoryInfo schema provides information about memory usage on a DirectPath device, in case the device supports it.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsedMemory** | **long** | The memory used on this device in vSphere in MBs, based on virtual machines running on this device.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available. | [optional] 
**TotalMemory** | **long** | The total available memory on the device, in MBs.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available. | [optional] 
**ReservedUsedMemory** | **long** | The amount of reserved memory in use currently on the device, in MBs.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available. | [optional] 
**TotalReservedMemory** | **long** | The total amount of memory reserved on this device, in MBs.  This property was added in __vSphere API 9.1.0.0__.  if missing or &#x60;null&#x60;, then this information is not available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

