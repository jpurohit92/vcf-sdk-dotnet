# Vcenter.ViJson.OpenApi.Model.ResourcePoolRuntimeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Memory** | [**ResourcePoolResourceUsage**](ResourcePoolResourceUsage.md) | Runtime resource usage for memory.  Values are in bytes.  | 
**Cpu** | [**ResourcePoolResourceUsage**](ResourcePoolResourceUsage.md) | Runtime resource usage for CPU.  Values are in Mhz.  | 
**OverallStatus** | **ManagedEntityStatusEnum** | Deprecated as of vSphere API 6.5. Use *ManagedEntity.overallStatus*.  Overall health of the tree.  See header for description of various statuses and when they are set.  | 
**SharesScalable** | **string** | The scaling behavior of the shares of a given resource pool.  See *ResourceConfigSpecScaleSharesBehavior_enum* for possible values. The system will automatically compute this property based on the *ResourceConfigSpec.scaleDescendantsShares* setting on every ancestor resource pool. This property does not apply to virtual machines.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

