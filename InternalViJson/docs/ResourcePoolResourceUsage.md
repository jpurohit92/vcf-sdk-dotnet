# Vcenter.ViJson.OpenApi.Model.ResourcePoolResourceUsage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReservationUsed** | **long** | Total amount of resources that have been used to satisfy the reservation requirements of all descendants of this resource pool (includes both resource pools and virtual machines).  | 
**ReservationUsedForVm** | **long** | Total amount of resources that have been used to satisfy the reservation requirements of running virtual machines in this resource pool or any of its child resource pools.  | 
**UnreservedForPool** | **long** | Total amount of resources available to satisfy a reservation for a child resource pool.  In the undercommitted state, this is limited by the capacity at the root node. In the overcommitted case, this could be higher since we do not perform the dynamic capacity checks.  | 
**UnreservedForVm** | **long** | Total amount of resources available to satisfy a reservation for a child virtual machine.  In general, this should be the same as *ResourcePoolResourceUsage.unreservedForPool*. However, in the overcommitted case, this is limited by the remaining available resources at the root node.  | 
**OverallUsage** | **long** | Deprecated as of vSphere API 6.5. Use *ResourcePoolQuickStats.overallCpuUsage* and *ResourcePoolQuickStats.hostMemoryUsage*.  Close to real-time resource usage of all running child virtual machines, including virtual machines in child resource pools.  | 
**MaxUsage** | **long** | Current upper-bound on usage.  The upper-bound is based on the limit configured on this resource pool, as well as limits configured on any parent resource pool.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

