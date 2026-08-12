# Vcenter.ViJson.OpenApi.Model.FileBackedPortNotSupported
The virtual machine has a port (either a SerialPort or a ParallelPort) which is backed by a file.  This is an error when migrating a virtual machine with the device connected, and can be returned as a subfault of DisallowedMigrationDeviceAttached. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | **string** | The label of the device.  | 
**Reason** | **string** | The specific reason why the device is not supported.  Values should come from *DeviceNotSupportedReason_enum*. This might not be set if we&#39;re not sure of the reason, or if this doesn&#39;t make sense in the context. For example, in the *DisallowedMigrationDeviceAttached* context we already know the problem.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

