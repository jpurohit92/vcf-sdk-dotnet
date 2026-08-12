# Vcenter.ViJson.OpenApi.Model.ResourceAllocationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reservation** | **long** | Amount of resource that is guaranteed available to the virtual machine or resource pool.  Reserved resources are not wasted if they are not used. If the utilization is less than the reservation, the resources can be utilized by other running virtual machines. Units are MB for memory, MHz for CPU.  | [optional] 
**ExpandableReservation** | **bool** | In a resource pool with an expandable reservation, the reservation on a resource pool can grow beyond the specified value, if the parent resource pool has unreserved resources.  A non-expandable reservation is called a fixed reservation. This property is invalid for virtual machines.  | [optional] 
**Limit** | **long** | The utilization of a virtual machine/resource pool will not exceed this limit, even if there are available resources.  This is typically used to ensure a consistent performance of virtual machines / resource pools independent of available resources. If set to -1, then there is no fixed limit on resource usage (only bounded by available resources and shares). Units are MB for memory, MHz for CPU.  | [optional] 
**Shares** | [**SharesInfo**](SharesInfo.md) | Memory shares are used in case of resource contention.  | [optional] 
**OverheadLimit** | **long** | The maximum allowed overhead memory.  For a powered on virtual machine, the overhead memory reservation cannot be larger than its overheadLimit. This property is only applicable to powered on virtual machines and is not persisted across reboots. This property is not applicable for resource pools. If set to -1, then there is no limit on reservation. Units are MB.  Note: For vCenter Server use only. Not available for other clients at this time. The server will throw an exception if you attempt to set this property.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

