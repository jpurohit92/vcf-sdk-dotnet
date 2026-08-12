# Vcenter.ViJson.OpenApi.Model.VirtualDeviceConnectInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MigrateConnect** | **string** | Specifies whether the virtual machine should override the virtual device connection state upon the completion of a migration.  At this time, this property is only applicable to instant clone operations, and will be ignored for other migration types. The property is also only valid with VirtualEthernetCards, and any attempt to set this property on an unsupported device will result in an error. This property will persist only until the virtual machine undergoes a supported migration, at which point it will be consumed and unset on the destination virtual machine, preventing the property from affecting future migrations. The migration&#39;s success is not dependent on whether the device reaches the desired connection state. The set of possible values are described in *VirtualDeviceConnectInfoMigrateConnectOp_enum*.  | [optional] 
**StartConnected** | **bool** | Specifies whether or not to connect the device when the virtual machine starts.  | 
**AllowGuestControl** | **bool** | Enables guest control over whether the connectable device is connected.  | 
**Connected** | **bool** | Indicates whether the device is currently connected.  Valid only while the virtual machine is running.  | 
**Status** | **string** | Indicates the current status of the connectable device.  Valid only while the virtual machine is running. The set of possible values is described in *VirtualDeviceConnectInfoStatus_enum*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

