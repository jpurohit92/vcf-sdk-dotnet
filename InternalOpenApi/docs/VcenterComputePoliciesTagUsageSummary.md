# Vcenter.Automation.OpenApi.Model.VcenterComputePoliciesTagUsageSummary
The Vcenter.Compute.Policies.TagUsage.Summary schema contains common information about a tag used by a policy.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | Identifier of the policy that uses the tag indicated by *Vcenter.Compute.Policies.TagUsage.Summary.tag*.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.Policy&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.compute.Policy&#x60;. | 
**PolicyName** | **string** | Name of the policy indicated by *Vcenter.Compute.Policies.TagUsage.Summary.policy*.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**PolicyDescription** | **string** | Description of the policy indicated by *Vcenter.Compute.Policies.TagUsage.Summary.policy*.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**Capability** | **string** | Capability of the policy indicated by *Vcenter.Compute.Policies.TagUsage.Summary.policy*.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**TagType** | **string** | Identifier of the tag type used by the policy indicated by *Vcenter.Compute.Policies.TagUsage.Summary.policy*.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.resource&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.resource&#x60;. | 
**Tag** | **string** | Identifier of the tag used by the policy indicated by *Vcenter.Compute.Policies.TagUsage.Summary.policy*.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property tag_type must contain the actual resource type. When operations return a value of this schema as a response, the property tag_type will contain the actual resource type. | 
**TagName** | **string** | Name of the tag used by the policy indicated by *Vcenter.Compute.Policies.TagUsage.Summary.policy*.  This property was added in __vSphere API 7.0.3.0__. | 
**CategoryName** | **string** | Name of the category that has *Vcenter.Compute.Policies.TagUsage.Summary.tag*.  This property was added in __vSphere API 7.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

