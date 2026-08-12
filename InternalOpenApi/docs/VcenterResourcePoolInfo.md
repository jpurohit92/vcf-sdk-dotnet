# Vcenter.Automation.OpenApi.Model.VcenterResourcePoolInfo
The Vcenter.ResourcePool.Info schema contains information about a resource pool.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the vCenter Server resource pool. | 
**ResourcePools** | **List&lt;string&gt;** | Identifiers of the child resource pools contained in this resource pool.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ResourcePool&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ResourcePool&#x60;. | 
**CpuAllocation** | [**VcenterResourcePoolResourceAllocationInfo**](VcenterResourcePoolResourceAllocationInfo.md) | Resource allocation information for CPU.  This property was added in __vSphere API 7.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 
**MemoryAllocation** | [**VcenterResourcePoolResourceAllocationInfo**](VcenterResourcePoolResourceAllocationInfo.md) | Resource allocation information for memory.  This property was added in __vSphere API 7.0.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

