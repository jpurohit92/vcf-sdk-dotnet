# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceSummary

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
**CurrentFailoverLevel** | **int** | Deprecated as of vSphere API 4.0, use *ClusterFailoverLevelAdmissionControlInfo.currentFailoverLevel*.  Current failover level.  This is the number of physical host failures that can be tolerated without impacting the ability to satisfy the minimums for all running virtual machines. This represents the current value, as opposed to desired value configured by the user.  | 
**AdmissionControlInfo** | [**ClusterDasAdmissionControlInfo**](ClusterDasAdmissionControlInfo.md) | Information about the current amount of resources available for a vSphere HA cluster.  The actual type of admissionControlInfo will depend on what kind of *ClusterDasAdmissionControlPolicy* was used to configure the cluster.  | [optional] 
**NumVmotions** | **int** | Total number of migrations with VMotion that have been done internal to this cluster.  | 
**TargetBalance** | **int** | The target balance, in terms of standard deviation, for a DRS cluster.  Units are thousandths. For example, 12 represents 0.012.  | [optional] 
**CurrentBalance** | **int** | The current balance, in terms of standard deviation, for a DRS cluster.  Units are thousandths. For example, 12 represents 0.012.  | [optional] 
**DrsScore** | **int** | The DRS score of this cluster, in percentage.  | [optional] 
**NumVmsPerDrsScoreBucket** | **List&lt;int&gt;** | The number of VMs in this cluster corresponding to each DRS score bucket.  The buckets are defined as follows: - 0% - 20% - 21% - 40% - 41% - 60% - 61% - 80% - 81% - 100%  | [optional] 
**UsageSummary** | [**ClusterUsageSummary**](ClusterUsageSummary.md) | The current usage summary for a DRS cluster.  | [optional] 
**CurrentEVCModeKey** | **string** | The Enhanced VMotion Compatibility mode that is currently in effect for all hosts in this cluster; unset if no EVC mode is active.  See also *Capability.supportedEVCMode*.  | [optional] 
**CurrentEVCGraphicsModeKey** | **string** | The Enhanced VMotion Compatibility Graphics mode that is currently in effect for all hosts in this cluster; unset if no EVC mode is active.  See also *Capability.supportedEVCGraphicsMode*.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 
**DasData** | [**ClusterDasData**](ClusterDasData.md) | Data pertaining to DAS.  | [optional] 
**ClusterMaintenanceModeStatus** | **string** | Configuration pertinent to state of the cluster maintenance mode.  Valid values are enumerated by the *ClusterMaintenanceModeStatus* type.  ***Since:*** vSphere API Release 7.0.0.2  | [optional] 
**VcsHealthStatus** | **string** | Deprecated as of vSphere 9.0 with no replacement. In a future release of vSphere, the vCLS functionality will be disabled, vCLS system VMs will be deleted, and vCLS APIs will be removed.  The health status of the vSphere Cluster Services in the cluster.  Supported values are enumerated by the *VcsHealthStatus* type.  ***Since:*** vSphere API Release 7.0.1.1  | [optional] 
**VcsSlots** | [**List&lt;ClusterComputeResourceVcsSlots&gt;**](ClusterComputeResourceVcsSlots.md) | Deprecated as of vSphere 9.0 with no replacement. In a future release of vSphere, the vCLS functionality will be disabled, vCLS system VMs will be deleted, and vCLS APIs will be removed.  An array of hosts and number of resource slots on the host for vSphere Cluster Services in the cluster.  The number of resource slots on the host includes both following types: 1\\. Number of vCS VMs running on the host (resource reserved and occupied). 2\\. Number of reserved and unoccupied slots (reserved for new vCS VMs).  ***Since:*** vSphere API Release 7.0.1.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

