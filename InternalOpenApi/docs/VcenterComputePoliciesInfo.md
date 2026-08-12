# Vcenter.Automation.OpenApi.Model.VcenterComputePoliciesInfo
The Vcenter.Compute.Policies.Info schema contains common information about a compute policy.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the policy.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | Description of the policy.  This property was added in __vSphere API 7.0.3.0__. | 
**Capability** | **string** | Identifier of the capability this policy is based on.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.policies.Capability&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.policies.Capability&#x60;. | 
**ManagedBy** | [**VcenterComputePoliciesManagedBy**](VcenterComputePoliciesManagedBy.md) | Information about the entity that manages this policy.    This property identifies which entity is responsible for managing the policy and can influence operations such as delete. If missing or &#x60;null&#x60;, the policy is not managed by any specific entity. Any user with ComputePolicy.Manage privilege can manage the policy.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

