# Vcenter.ViJson.OpenApi.Model.HostSystemSwapConfigurationDisabledOption
Indicates that the system swap on the host is currently disabled.  This value is used with the *HostSystem.UpdateSystemSwapConfiguration* managed method to disable system swap. Presence of this value in *HostSystemSwapConfiguration.option* excludes appearance of any other options. Specifying additional options will result in a *InvalidArgument* fault being thrown from the *HostSystem.UpdateSystemSwapConfiguration* method. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Specifies the order the options are preferred among each other.  The lower the value the more important.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

