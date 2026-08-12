# Vcenter.Automation.OpenApi.Model.VcenterResourcePoolUpdateSpec
The *Vcenter.ResourcePool.UpdateSpec* schema contains specification for updating the configuration of a resource pool.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the resource pool.  This property was added in __vSphere API 7.0.0.0__.  if missing or &#x60;null&#x60; or empty, the name of the resource pool will not be changed. | [optional] 
**CpuAllocation** | [**VcenterResourcePoolResourceAllocationUpdateSpec**](VcenterResourcePoolResourceAllocationUpdateSpec.md) | Resource allocation for CPU.  This property was added in __vSphere API 7.0.0.0__.  if missing or &#x60;null&#x60; or empty, the CPU allocation of the resource pool will not be changed. | [optional] 
**MemoryAllocation** | [**VcenterResourcePoolResourceAllocationUpdateSpec**](VcenterResourcePoolResourceAllocationUpdateSpec.md) | Resource allocation for memory.  This property was added in __vSphere API 7.0.0.0__.  if missing or &#x60;null&#x60; or empty, the memory allocation of the resource pool will not be changed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

