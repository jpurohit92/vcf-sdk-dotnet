# Vcenter.ViJson.OpenApi.Model.HostSystemSwapConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Option** | [**List&lt;HostSystemSwapConfigurationSystemSwapOption&gt;**](HostSystemSwapConfigurationSystemSwapOption.md) | The currently enabled options.  When this property contains only one value and this value is *HostSystemSwapConfigurationDisabledOption*, this indicates that the system swap is disabled.   If the *HostSystemSwapConfigurationDisabledOption* option is used together with some other option in call to *HostSystem.UpdateSystemSwapConfiguration*, a *InvalidArgument* is thrown.   It is not allowed to have duplicate values in this array. If so a *InvalidArgument* is thrown.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

