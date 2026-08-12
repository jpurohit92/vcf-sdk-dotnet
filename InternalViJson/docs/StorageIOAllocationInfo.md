# Vcenter.ViJson.OpenApi.Model.StorageIOAllocationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Limit** | **long** | The utilization of a virtual machine will not exceed this limit, even if there are available resources.  This is typically used to ensure a consistent performance of virtual machines independent of available resources. If set to -1, then there is no fixed limit on resource usage (only bounded by available resources and shares). The unit is number of I/O per second. While setting the limit for storage I/O resource, if the property is unset, it is treated as no change and the property is not updated. While reading back the limit information of storage I/O resource, if the property is unset, a default value of -1 will be returned, which indicates that there is no limit on resource usage.  | [optional] 
**Shares** | [**SharesInfo**](SharesInfo.md) | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Shares are used in case of resource contention.  The value should be within a range of 200 to 4000. While setting shares for storage I/O resource, if the property is unset, it is treated as no change and the property is not updated. While reading back the shares information of storage I/O resource, if the property is unset, a default value of *SharesInfo.level* &#x3D; normal, *SharesInfo.shares* &#x3D; 1000 will be returned.  | [optional] 
**Reservation** | **int** | Deprecated as of vSphere8.0 U3, and there is no replacement for it.  Reservation control is used to provide guaranteed allocation in terms of IOPS.  Large IO sizes are considered as multiple IOs using a chunk size of 32 KB as default. This control is initially supported only at host level for local datastores. It future, it may get supported on shared storage based on integration with Storage IO Control. Also right now we don&#39;t do any admission control based on IO reservation values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

