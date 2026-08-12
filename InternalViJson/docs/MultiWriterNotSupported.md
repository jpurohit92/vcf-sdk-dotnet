# Vcenter.ViJson.OpenApi.Model.MultiWriterNotSupported
The multi-writer sharing of the specified virtual disk is not supported.  Typically, this fault is returned as part of a parent fault like *VmConfigIncompatibleForFaultTolerance*, indicating that the virtual disk's multi-writer sharing needs to be changed before fault tolerance can be enabled on the associated virtual machine. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | **string** | The label of the device.  | 
**Reason** | **string** | The specific reason why the device is not supported.  Values should come from *DeviceNotSupportedReason_enum*. This might not be set if we&#39;re not sure of the reason, or if this doesn&#39;t make sense in the context. For example, in the *DisallowedMigrationDeviceAttached* context we already know the problem.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

