# Vcenter.Automation.OpenApi.Model.VcenterNamespacesNetworksNsxSubnetsCondition
Condition defines condition of the *Vcenter.Namespaces.Networks.Nsx.Subnets.Entity*.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the condition. Possible values can be:     - Ready    This property was added in __vSphere API 9.0.0.0__. | 
**ConditionStatus** | **string** | Status of the condition. Possible values are:     - True    - False    - Unknown    This property was added in __vSphere API 9.0.0.0__. | 
**TimeStamp** | **DateTime** | Last time the condition transitioned from one status to another. This should be the time when the underlying condition changed.  This property was added in __vSphere API 9.0.0.0__.  This field could be missing or &#x60;null&#x60; when the time of change of the condition is not known. | [optional] 
**Reason** | **string** | This shows a brief reason of condition.  This property was added in __vSphere API 9.0.0.0__. | 
**Message** | **string** | This shows a human-readable message about condition.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

