# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClustersStats
This schema is deprecated as of __vSphere API 9.1.0.0__.  Use *Vcenter.NamespaceManagement.Supervisors.Summary.Stats* instead.   The Vcenter.NamespaceManagement.Clusters.Stats schema contains the basic Supervisor runtime statistics.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuUsed** | **long** | This property is deprecated as of __vSphere API 9.1.0.0__.  CPU consumed by the Supervisor and its workloads across all hosts in megahertz (MHz).  This property was added in __vSphere API 7.0.0.0__. | 
**CpuCapacity** | **long** | This property is deprecated as of __vSphere API 9.1.0.0__.  Maximum reservable CPU capacity for a Supervisor and its workloads in megahertz (MHz). This value is capped by the maximum physical CPU capacity of all hosts participating in the Supervisor or any limits present on Supervisor resource pools.  This property was added in __vSphere API 7.0.0.0__. | 
**MemoryUsed** | **long** | This property is deprecated as of __vSphere API 9.1.0.0__.  Host memory consumed by a Supervisor and its workloads in mebibytes (MiB).  This property was added in __vSphere API 7.0.0.0__. | 
**MemoryCapacity** | **long** | This property is deprecated as of __vSphere API 9.1.0.0__.  Maximum reservable memory capacity for a Supervisor and its workloads in mebibytes (MiB). This value is capped by the maximum physical memory capacity of all hosts participating in the Supervisor or any limits present on Supervisor resource pools.  This property was added in __vSphere API 7.0.0.0__. | 
**StorageUsed** | **long** | This property is deprecated as of __vSphere API 9.1.0.0__.  Storage committed by all participating Supervisor storage policies in mebibytes (MiB).  This property was added in __vSphere API 7.0.0.0__. | 
**StorageCapacity** | **long** | This property is deprecated as of __vSphere API 9.1.0.0__.  Capacity of all datastores backing all participating Supervisor storage policies in mebibytes (MiB).  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

