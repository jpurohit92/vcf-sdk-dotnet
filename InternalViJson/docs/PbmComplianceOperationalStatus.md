# Vcenter.ViJson.OpenApi.Model.PbmComplianceOperationalStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Healthy** | **bool** | Whether the object is currently affected by the failure of backend storage resources.  Optional property.  | [optional] 
**OperationETA** | **DateTime** | Estimated completion time of a backend operation affecting the object.  If set, then \&quot;transitional\&quot; will be true. Optional property.  | [optional] 
**OperationProgress** | **long** | Percent progress of a backend operation affecting the object.  If set, then \&quot;transitional\&quot; will be true. Optional property.  | [optional] 
**Transitional** | **bool** | Whether an object is undergoing a backend operation that may affect its performance.  This may be a rebalancing the resources of a healthy object or recovery tasks for an unhealthy object. Optional property.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

