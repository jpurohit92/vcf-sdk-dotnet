# Vcenter.Automation.OpenApi.Model.VcenterComputePoliciesCreateSpec
The Vcenter.Compute.Policies.CreateSpec schema contains common information used to create a new policy.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capability** | **string** | Identifier of the capability this policy is based on.  This property was added in __vSphere API 7.0.3.0__.  if missing or &#x60;null&#x60;, then the name of capability schema will be used to distinguish the policy type.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.policies.Capability&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.policies.Capability&#x60;. | 
**Name** | **string** | Name of the policy. The name needs to be unique within this vCenter server.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | Description of the policy.  This property was added in __vSphere API 7.0.3.0__. | 
**ManagedBy** | [**VcenterComputePoliciesManagedBy**](VcenterComputePoliciesManagedBy.md) | Information about the entity that manages this policy.    This property identifies which entity is responsible for managing the policy and can influence operations such as delete. If missing or &#x60;null&#x60;, the policy is not managed by any specific entity. Any user with ComputePolicy.Manage privilege can manage the policy.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

