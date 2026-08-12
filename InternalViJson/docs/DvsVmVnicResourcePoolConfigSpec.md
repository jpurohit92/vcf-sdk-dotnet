# Vcenter.ViJson.OpenApi.Model.DvsVmVnicResourcePoolConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** | The type of operation on the virtual NIC network resource pool Possible value can be of *ConfigSpecOperation_enum*  | 
**Key** | **string** | The key of the network resource pool.  The property is ignored for add operations.  | [optional] 
**ConfigVersion** | **string** | The configVersion is a unique identifier for a given version of the configuration.  Each change to the configuration will update this value. This is typically implemented as a non-decreasing count or a time-stamp. However, a client should always treat this as an opaque string.  If specified when updating the resource configuration, the changes will only be applied if the current configVersion matches the specified configVersion. This field can be used to guard against updates that that may have occurred between the time when configVersion was read and when it is applied.  | [optional] 
**AllocationInfo** | [**DvsVmVnicResourceAllocation**](DvsVmVnicResourceAllocation.md) | The resource allocation for the virtual NIC network resource pool.  | [optional] 
**Name** | **string** | The name for the virtual NIC network resource pool.  The property is required for Add operations.  | [optional] 
**Description** | **string** | The description for the virtual NIC network resource pool.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

