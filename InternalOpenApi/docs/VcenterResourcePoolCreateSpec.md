# Vcenter.Automation.OpenApi.Model.VcenterResourcePoolCreateSpec
The *Vcenter.ResourcePool.CreateSpec* schema contains information used to create a resource pool, see *POST /vcenter/resource-pool*.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the resource pool.  This property was added in __vSphere API 7.0.0.0__. | 
**Parent** | **string** | Parent of the created resource pool.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;ResourcePool&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;ResourcePool&#x60;. | 
**CpuAllocation** | [**VcenterResourcePoolResourceAllocationCreateSpec**](VcenterResourcePoolResourceAllocationCreateSpec.md) | Resource allocation for CPU.  This property was added in __vSphere API 7.0.0.0__.  if missing or &#x60;null&#x60; or empty, use the default CPU allocation specification. | [optional] 
**MemoryAllocation** | [**VcenterResourcePoolResourceAllocationCreateSpec**](VcenterResourcePoolResourceAllocationCreateSpec.md) | Resource allocation for memory.  This property was added in __vSphere API 7.0.0.0__.  if missing or &#x60;null&#x60; or empty, use the default memory allocation specification. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

