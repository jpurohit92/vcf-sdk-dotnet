# Vcenter.ViJson.OpenApi.Model.DeviceControllerNotSupported

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | **string** | The label of the device.  | 
**Reason** | **string** | The specific reason why the device is not supported.  Values should come from *DeviceNotSupportedReason_enum*. This might not be set if we&#39;re not sure of the reason, or if this doesn&#39;t make sense in the context. For example, in the *DisallowedMigrationDeviceAttached* context we already know the problem.  | [optional] 
**Controller** | **string** | The type of the controller.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

