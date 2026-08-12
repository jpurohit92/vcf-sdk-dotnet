# Vcenter.Automation.OpenApi.Model.VcenterResourcePoolResourceAllocationInfo
The Vcenter.ResourcePool.ResourceAllocationInfo schema contains resource allocation information of a resource pool.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reservation** | **long** | Amount of resource that is guaranteed available to a resource pool. Reserved resources are not wasted if they are not used. If the utilization is less than the reservation, the resources can be utilized by other running virtual machines. Units are MB for memory, and MHz for CPU.  This property was added in __vSphere API 7.0.0.0__. | 
**ExpandableReservation** | **bool** | In a resource pool with an expandable reservation, the reservation can grow beyond the specified value, if the parent resource pool has unreserved resources. A non-expandable reservation is called a fixed reservation.  This property was added in __vSphere API 7.0.0.0__. | 
**Limit** | **long** | The utilization of a resource pool will not exceed this limit, even if there are available resources. This is typically used to ensure a consistent performance of resource pools independent of available resources. If set to -1, then there is no fixed limit on resource usage (only bounded by available resources and shares). Units are MB for memory, and MHz for CPU.  This property was added in __vSphere API 7.0.0.0__. | 
**Shares** | [**VcenterResourcePoolSharesInfo**](VcenterResourcePoolSharesInfo.md) | Shares are used in case of resource contention.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

