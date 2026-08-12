# Vcenter.Automation.OpenApi.Model.VcenterComputePoliciesSummary
The Vcenter.Compute.Policies.Summary schema contains commonly used information about a compute policy.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | Identifier of the policy.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.Policy&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.Policy&#x60;. | 
**Name** | **string** | Name of the policy.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | Description of the policy.  This property was added in __vSphere API 7.0.3.0__. | 
**Capability** | **string** | Identifier of the capability this policy is based on.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.policies.Capability&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.policies.Capability&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

