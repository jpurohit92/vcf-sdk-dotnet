# Vcenter.Automation.OpenApi.Model.VcenterComputePoliciesCapabilitiesInfo
The Vcenter.Compute.Policies.Capabilities.Info schema contains information about a compute policy capability.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the capability.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | Description of the capability.  This property was added in __vSphere API 7.0.3.0__. | 
**CreateSpecType** | **string** | Identifier of the schema used to create a policy based on this capability. See *POST /vcenter/compute/policies*.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. | 
**InfoType** | **string** | Identifier of the schema returned when retrieving information about a policy based on this capability. See *GET /vcenter/compute/policies/{policy}*.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

