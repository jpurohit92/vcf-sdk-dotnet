# Vcenter.ViJson.OpenApi.Model.ResourceConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the entity with this resource specification: either a VirtualMachine or a ResourcePool.  Refers instance of *ManagedEntity*.  | [optional] 
**ChangeVersion** | **string** | The changeVersion is a unique identifier for a given version of the configuration.  Each change to the configuration will update this value. This is typically implemented as an ever increasing count or a time-stamp. However, a client should always treat this as an opaque string.  If specified when updating the resource config., the changes will only be applied if the current changeVersion matches the specified changeVersion. This field can be used to guard against updates that has happened between the configInfo was read and until it is applied.  | [optional] 
**LastModified** | **DateTime** | Timestamp when the resources were last modified.  This is ignored when the object is used to update a configuration.  | [optional] 
**CpuAllocation** | [**ResourceAllocationInfo**](ResourceAllocationInfo.md) | Resource allocation for CPU.  | 
**MemoryAllocation** | [**ResourceAllocationInfo**](ResourceAllocationInfo.md) | Resource allocation for memory.  | 
**ScaleDescendantsShares** | **string** | Specifies the scaling behavior of the shares of all descendant resource pools under a given resource pool.  See *ResourceConfigSpecScaleSharesBehavior_enum* for possible values. If any scaling behavior other than *disabled* is specified, the system will scale the CPU and memory shares allocated to each descendant resource pool with the total shares of all powered on virtual machines under each respective pool. The system will also use the *SharesInfo* set on each descendant resource pool as a multiplier for the scale. If a resource pool&#39;s shares are already scalable through the *ResourceConfigSpec.scaleDescendantsShares* setting on an ancestor resource pool, the system will not allow *ResourceConfigSpec.scaleDescendantsShares* to be set on the resource pool. The *ResourcePoolRuntimeInfo.sharesScalable* property indicates whether or not a resource pool&#39;s shares are scalable. This property does not apply to virtual machines.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

