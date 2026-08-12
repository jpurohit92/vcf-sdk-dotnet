# Vcenter.Automation.OpenApi.Model.VcenterNamespacesInstancesStats
The Vcenter.Namespaces.Instances.Stats schema contains the basic runtime statistics about the namespace.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuUsed** | **long** | CPU reservation consumed by the pods in the namespace in megahertz (MHz) across all resource pools backing the namespace. This is the sum of CPU requested by pods in the Kubernetes namespace.  This property was added in __vSphere API 7.0.0.0__. | 
**MemoryUsed** | **long** | Memory reservation consumed by the pods in the namespace in mebibytes (MiB) across all resource pools backing the namespace. This is the sum of memory requested by pods in the Kubernetes namespace.  This property was added in __vSphere API 7.0.0.0__. | 
**StorageUsed** | **long** | Storage reservation consumed by the pods in the namespace in mebibytes (MiB) across all datastores backed by storage policies assigned to the namespace. This is the sum of storage requested by the pods in the Kubernetes namespace.  This property was added in __vSphere API 7.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

