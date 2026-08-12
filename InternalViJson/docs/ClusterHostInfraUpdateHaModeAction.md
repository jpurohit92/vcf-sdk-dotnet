# Vcenter.ViJson.OpenApi.Model.ClusterHostInfraUpdateHaModeAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the action.  This is encoded to differentiate between different types of actions aimed at achieving different goals.  | 
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target object on which this action will be applied.  For instance, a migration action will have a virtual machine as its target object, while a host power action will have a host as its target action.  | [optional] 
**OperationType** | **string** | Specify the action type.  Values are of type *OperationType*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

