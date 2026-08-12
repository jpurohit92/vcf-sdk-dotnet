# Vcenter.ViJson.OpenApi.Model.MissingObject

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Obj** | [**ManagedObjectReference**](ManagedObjectReference.md) | The object that is being reported missing  | 
**Fault** | [**MethodFault**](MethodFault.md) | Fault describing the failure to lookup this object  The possible faults for missing objects are: - *SystemError* if there was some unknown problem   looking up the object - *ManagedObjectNotFound* if the object is no   longer available  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

