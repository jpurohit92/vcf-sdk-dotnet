# Vcenter.Automation.OpenApi.Model.VcenterComputePoliciesUpdateSpec
The Vcenter.Compute.Policies.UpdateSpec schema describes the changes to be applied to a compute policy.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManagedBy** | [**VcenterComputePoliciesManagedBy**](VcenterComputePoliciesManagedBy.md) | Information about the entity that manages this policy. This property identifies which entity is responsible for managing the policy and can influence operations such as delete.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the managedBy property is not modified. | [optional] 
**Description** | **string** | Description for the policy.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the policy description property is not modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

