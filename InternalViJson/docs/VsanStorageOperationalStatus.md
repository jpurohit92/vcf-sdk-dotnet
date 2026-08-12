# Vcenter.ViJson.OpenApi.Model.VsanStorageOperationalStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Healthy** | **bool** | Whether the object is currently affected by the failure of backend storage resources.  | [optional] 
**OperationETA** | **DateTime** | Estimated completion time of a backend operation affecting the object.  If set, then \&quot;transitional\&quot; will be true.  | [optional] 
**OperationProgress** | **long** | Percent progress of a backend operation affecting the object.  If set, then \&quot;transitional\&quot; will be true.  | [optional] 
**Transitional** | **bool** | Whether an object is undergoing a backend operation that may affect its performance.  This may be a rebalancing the resources of a healthy object or recovery tasks for an unhealthy object.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

