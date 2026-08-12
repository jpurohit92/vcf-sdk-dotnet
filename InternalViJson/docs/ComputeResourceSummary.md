# Vcenter.ViJson.OpenApi.Model.ComputeResourceSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalCpu** | **int** | Aggregated CPU resources of all hosts, in MHz.  | 
**TotalMemory** | **long** | Aggregated memory resources of all hosts, in bytes.  | 
**NumCpuCores** | **int** | Number of physical CPU cores.  Physical CPU cores are the processors contained by a CPU package.  | 
**NumCpuThreads** | **int** | Aggregated number of CPU threads.  | 
**EffectiveCpu** | **int** | Effective CPU resources (in MHz) available to run virtual machines.  This is the aggregated effective resource level from all running hosts. Hosts that are in maintenance mode or are unresponsive are not counted. Resources used by the VMware Service Console are not included in the aggregate. This value represents the amount of resources available for the root resource pool for running virtual machines.  | 
**EffectiveMemory** | **long** | Effective memory resources (in MB) available to run virtual machines.  This is the aggregated effective resource level from all running hosts. Hosts that are in maintenance mode or are unresponsive are not counted. Resources used by the VMware Service Console are not included in the aggregate. This value represents the amount of resources available for the root resource pool for running virtual machines.  | 
**NumHosts** | **int** | Total number of hosts.  | 
**NumEffectiveHosts** | **int** | Total number of effective hosts.  | 
**OverallStatus** | **ManagedEntityStatusEnum** | Overall alarm status.  In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Since this property is on a DataObject, an update returned by WaitForUpdatesEx may contain values for this property when some other property on the DataObject changes. If this update is a result of a call to WaitForUpdatesEx with a non-empty version parameter, the value for this property may not be current.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

