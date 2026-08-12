# Vcenter.ViJson.OpenApi.Model.ClusterUsageSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalCpuCapacityMhz** | **int** | Total CPU capacity of the cluster.  | 
**TotalMemCapacityMB** | **int** | Total memory capacity of the cluster.  | 
**CpuReservationMhz** | **int** | Sum of CPU reservation of all the Resource Pools and powered-on VMs in the cluster.  | 
**MemReservationMB** | **int** | Sum of memory reservation of all the Resource Pools and powered-on VMs in the cluster.  | 
**PoweredOffCpuReservationMhz** | **int** | Sum of CPU reservation of all the powered-off VMs in the cluster.  | [optional] 
**PoweredOffMemReservationMB** | **int** | Sum of memory reservation of all the powered-off VMs in the cluster.  | [optional] 
**CpuDemandMhz** | **int** | Sum of CPU demand of all the powered-on VMs in the cluster.  | 
**MemDemandMB** | **int** | Sum of memory demand of all the powered-on VMs in the cluster.  | 
**StatsGenNumber** | **long** | Generation number of the usage stats.  Updated during every DRS load balancing call.  | 
**CpuEntitledMhz** | **int** | This is the current CPU entitlement across the cluster  | 
**MemEntitledMB** | **int** | This is the current memory entitlement across the cluster  | 
**PoweredOffVmCount** | **int** | The number of powered off VMs in the cluster  | 
**TotalVmCount** | **int** | The number of VMs in the cluster  | 
**Tier0MemCapacityMB** | **int** | Total Tier 0 memory capacity in a cluster.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**ReservedTier0MemMB** | **int** | Total amount of Tier 0 memory used to satisfy virtual machine reservation.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**UnreservedTier0MemMB** | **int** | Total amount of Tier 0 memory available to satisfy reservation.  Available reservation is calculated after accounting for DRS overheads and current reservation.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

