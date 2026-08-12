# Vcenter.ViJson.OpenApi.Model.VirtualPCIPassthroughDynamicBackingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host system.  | 
**UseAutoDetect** | **bool** | Indicates whether the device should be auto detected instead of directly specified.  If this value is set to TRUE, deviceName is ignored.  | [optional] 
**AllowedDevice** | [**List&lt;VirtualPCIPassthroughAllowedDevice&gt;**](VirtualPCIPassthroughAllowedDevice.md) | The list of allowed devices for use with a Dynamic DirectPath device.  | [optional] 
**CustomLabel** | **string** | An optional label.  If set, the device must also have the same customLabel attribute set.  | [optional] 
**AssignedId** | **string** | The id of the device assigned when the VM is powered on.  This value is unset when the VM is powered off.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

