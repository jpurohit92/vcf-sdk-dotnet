# Vcenter.ViJson.OpenApi.Model.ChangeAccessModeRequestType
The parameters of *HostAccessManager.ChangeAccessMode*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Principal** | **string** | The affected user or group.  | 
**IsGroup** | **bool** | True if principal refers to a group account, false otherwise.  | 
**AccessMode** | **HostAccessModeEnum** | AccessMode to be granted. *accessOther* is meaningless and will result in InvalidArgument exception.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

