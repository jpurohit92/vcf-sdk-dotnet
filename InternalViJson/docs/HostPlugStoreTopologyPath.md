# Vcenter.ViJson.OpenApi.Model.HostPlugStoreTopologyPath

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The identifier for the Path.  | 
**Name** | **string** | Name of path.  Use this property to correlate this path object to other path objects.  The state of the Path can be retrieved from the data object (@link vim.host.MultipathStateInfo.Path} on the *HostMultipathStateInfo* data object.  Use this name to configure LogicalUnit multipathing policy using *HostStorageSystem.EnableMultipathPath* and *HostStorageSystem.DisableMultipathPath*.  | 
**ChannelNumber** | **int** | The channel number for a path if applicable.  | [optional] 
**TargetNumber** | **int** | The target number for a path if applicable.  The target number is not guaranteed to be consistent across reboots or rescans of the adapter.  | [optional] 
**LunNumber** | **int** | The LUN number for a path if applicable.  | [optional] 
**Adapter** | **string** | The adapter that provided the Path.  | [optional] 
**Target** | **string** | The target of the Path if any.  | [optional] 
**Device** | **string** | The device that claimed the Path if any.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

