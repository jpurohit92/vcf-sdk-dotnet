# Vcenter.ViJson.OpenApi.Model.HostSystemSwapConfigurationDatastoreOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Specifies the order the options are preferred among each other.  The lower the value the more important.  | 
**Datastore** | **string** | The datastore to be used with this swap option.  This value should be always set when the encapsulating option is used, otherwise a call to *HostSystem.UpdateSystemSwapConfiguration* will result in a *InvalidArgument* fault.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

