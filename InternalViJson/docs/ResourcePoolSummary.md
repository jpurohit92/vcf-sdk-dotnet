# Vcenter.ViJson.OpenApi.Model.ResourcePoolSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of resource pool.  | 
**Config** | [**ResourceConfigSpec**](ResourceConfigSpec.md) | Current configuration of the resource pool.  | 
**Runtime** | [**ResourcePoolRuntimeInfo**](ResourcePoolRuntimeInfo.md) | Current runtime state of the resource pool.  | 
**QuickStats** | [**ResourcePoolQuickStats**](ResourcePoolQuickStats.md) | A set of statistics that are typically updated with near real-time regularity.  This data object type does not support notification, for scalability reasons. Therefore, changes in QuickStats do not generate property collector updates. To monitor statistics values, use the statistics and alarms modules instead.  | [optional] 
**ConfiguredMemoryMB** | **int** | Total configured memory of all virtual machines in the resource pool, in MB.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

