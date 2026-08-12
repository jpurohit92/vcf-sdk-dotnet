# Vcenter.ViJson.OpenApi.Model.HostPlugStoreTopologyPlugin

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The identifier of the plugin.  | 
**Name** | **string** | The name of the plugin.  | 
**Device** | **List&lt;string&gt;** | The set of devices formed by this plugin.  | [optional] 
**ClaimedPath** | **List&lt;string&gt;** | The set of paths claimed by this plugin.  Not every claimed path will necessarily appear as part of a Device. Claimed paths will only appear under Devices if the device identifier of the path matches up with the device identifier exposed by the Device.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

