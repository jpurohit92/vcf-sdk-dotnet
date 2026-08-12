# Vcenter.ViJson.OpenApi.Model.WaitForUpdatesExRequestType
The parameters of *PropertyCollector.WaitForUpdatesEx*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | The data version currently known to the client. The value must be either - the special initial data version (an empty string), - a data version returned from *PropertyCollector.CheckForUpdates* or *PropertyCollector.WaitForUpdates* - a non-truncated data version returned from *PropertyCollector.WaitForUpdatesEx* - a truncated data version returned from the last call to *PropertyCollector.WaitForUpdatesEx* with no intervening calls to *PropertyCollector.WaitForUpdates* or *PropertyCollector.CheckForUpdates*.  | [optional] 
**Options** | [**WaitOptions**](WaitOptions.md) | Additional options controlling the change calculation. If omitted, equivalent to an options argument with no fields set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

