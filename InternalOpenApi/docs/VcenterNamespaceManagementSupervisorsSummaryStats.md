# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSummaryStats
The Vcenter.NamespaceManagement.Supervisors.Summary.Stats schema contains the basic Supervisor runtime statistics.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuUsed** | **long** | CPU consumed by the Supervisor and its workloads across all hosts in megahertz (MHz).  This property was added in __vSphere API 8.0.0.1__. | 
**CpuCapacity** | **long** | Maximum reservable CPU capacity for a Supervisor and its workloads in megahertz (MHz). This value is capped by the maximum physical CPU capacity of all hosts participating in the Supervisor or any limits present on Supervisor resource pools.  This property was added in __vSphere API 8.0.0.1__. | 
**MemoryUsed** | **long** | Host memory consumed by a Supervisor and its workloads in mebibytes (MiB).  This property was added in __vSphere API 8.0.0.1__. | 
**MemoryCapacity** | **long** | Maximum reservable memory capacity for a Supervisor and its workloads in mebibytes (MiB). This value is capped by the maximum physical memory capacity of all hosts participating in the Supervisor or any limits present on Supervisor resource pools.  This property was added in __vSphere API 8.0.0.1__. | 
**StorageUsed** | **long** | Storage committed by all participating Supervisor Control Plane VMs in mebibytes (MiB).  This property was added in __vSphere API 8.0.0.1__. | 
**StorageCapacity** | **long** | Capacity of all datastores backing all participating Supervisor Control Plane VMs in mebibytes (MiB).  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

