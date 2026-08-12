# Vcenter.ViJson.OpenApi.Model.QueryConfigOptionExRequestType
The parameters of *EnvironmentBrowser.QueryConfigOptionEx*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Spec** | [**EnvironmentBrowserConfigOptionQuerySpec**](EnvironmentBrowserConfigOptionQuerySpec.md) | Search criteria and filters to control the result. If a *EnvironmentBrowserConfigOptionQuerySpec.key* or *EnvironmentBrowserConfigOptionQuerySpec.host* (or both) are specified, they will be used to search for a config option. If *EnvironmentBrowserConfigOptionQuerySpec.guestId* is nonempty, the *VirtualMachineConfigOption.guestOSDescriptor* array of the config option is filtered to match against the guest IDs in the spec. If there is no match, the whole list is returned. If the spec argument is omitted, the default *VirtualMachineConfigOption* for this environment browser is returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

