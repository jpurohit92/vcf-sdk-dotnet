# Vcenter.ViJson.OpenApi.Model.DVSNetworkResourcePoolConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DynamicProperty** | [**List&lt;DynamicProperty&gt;**](DynamicProperty.md) | Set of dynamic properties.  This property is optional because only the properties of an object that are unknown to a client will be part of this set. This property is not readonly just in case we want to send such properties from a client in the future.  | [optional] 
**Key** | **string** | Key of the network resource pool.  The property is ignored for *DistributedVirtualSwitch*.*DistributedVirtualSwitch.AddNetworkResourcePool* operations.  | 
**ConfigVersion** | **string** | Unique identifier for a given version of the configuration.  Each change to the configuration will update this value. This is typically implemented as a non-decreasing count or a time-stamp. However, a client should always treat this as an opaque string.  If you specify the configuration version when you update the resource configuration, the Server will apply the changes only if the specified identifier matches the current *DVSNetworkResourcePool*.*DVSNetworkResourcePool.configVersion* value. You can use this field to guard against updates that may have occurred between the time when the client reads *DVSNetworkResourcePool.configVersion* and when the configuration is applied.  | [optional] 
**AllocationInfo** | [**DVSNetworkResourcePoolAllocationInfo**](DVSNetworkResourcePoolAllocationInfo.md) | Network resource allocation for the network resource pool.  | [optional] 
**Name** | **string** | User defined name for the resource pool.  The property is required for *DistributedVirtualSwitch*.*DistributedVirtualSwitch.AddNetworkResourcePool* operations.  | [optional] 
**Description** | **string** | User-defined description for the resource pool.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

