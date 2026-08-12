# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterStatus** | [**VsanClusterHealthSystemStatusResult**](VsanClusterHealthSystemStatusResult.md) |  | [optional] 
**Timestamp** | **DateTime** | The timestamp for generating the health summary.  The timestamp will remain unchanged if the health summary is cached and fetched in future indicating when the health check was performed  | [optional] 
**ClusterVersions** | [**VsanClusterHealthSystemVersionResult**](VsanClusterHealthSystemVersionResult.md) | Health system version information across the cluster.  Meant for programmatic consumption.  | [optional] 
**ObjectHealth** | [**VsanObjectOverallHealth**](VsanObjectOverallHealth.md) | Object health information across the cluster.  Meant for programmatic consumption.  | [optional] 
**VmHealth** | [**VsanClusterVMsHealthOverallResult**](VsanClusterVMsHealthOverallResult.md) | Ignore this value.  | [optional] 
**NetworkHealth** | [**VsanClusterNetworkHealthResult**](VsanClusterNetworkHealthResult.md) | Network health information across the cluster.  Meant for programmatic consumption.  | [optional] 
**LimitHealth** | [**VsanClusterLimitHealthResult**](VsanClusterLimitHealthResult.md) | Limits health information across the cluster.  Meant for programmatic consumption.  | [optional] 
**AdvCfgSync** | [**List&lt;VsanClusterAdvCfgSyncResult&gt;**](VsanClusterAdvCfgSyncResult.md) | Advanced configuration synchronization information across the cluster.  Meant for programmatic consumption.  | [optional] 
**CreateVmHealth** | [**List&lt;VsanHostCreateVmHealthTestResult&gt;**](VsanHostCreateVmHealthTestResult.md) | VM creation results information across the cluster.  Meant for programmatic consumption. Will only be populated if the respective test was run.  | [optional] 
**PhysicalDisksHealth** | [**List&lt;VsanPhysicalDiskHealthSummary&gt;**](VsanPhysicalDiskHealthSummary.md) | Physical vSAN disk information across the cluster.  Meant for programmatic consumption.  | [optional] 
**EncryptionHealth** | [**VsanClusterEncryptionHealthSummary**](VsanClusterEncryptionHealthSummary.md) | Encryption information across the cluster.  Meant for programmatic consumption.  | [optional] 
**HclInfo** | [**VsanClusterHclInfo**](VsanClusterHclInfo.md) | HCL check information across the cluster.  Meant for programmatic consumption.  | [optional] 
**Groups** | [**List&lt;VsanClusterHealthGroup&gt;**](VsanClusterHealthGroup.md) | Data driven structure to display all health findings for purpose of rendering a UI.  The health findings are grouped into \&quot;groups\&quot; of \&quot;tests\&quot;. Each group and each test has a description, health, and optionally one or more \&quot;details\&quot; tables to display additional information about the test. Programmatic consumption of the health findings should avoid parsing this structure because it is meant for UI consumption and the content will change to improve user experience.  | [optional] 
**OverallHealth** | **string** | Health Enum.  Summarizes all groups and provides a high level status across all categories of health. This Enum defines sets labels for sets of health checks.  | 
**OverallHealthDescription** | **string** | A human readable, short, description of the overallHealth status.  As there may be many issues detected, the most important one is selected to be described. This should be the one getting first customer attention.  | 
**ClomdLiveness** | [**VsanClusterClomdLivenessResult**](VsanClusterClomdLivenessResult.md) | CLOMD liveness on every vSAN host.  Meant for programmatic consumption  | [optional] 
**DiskBalance** | [**VsanClusterBalanceSummary**](VsanClusterBalanceSummary.md) | Balance of disk utilization across the cluster.  | [optional] 
**GenericCluster** | [**VsanGenericClusterBestPracticeHealth**](VsanGenericClusterBestPracticeHealth.md) | Generic cluster configuration best practices checks.  | [optional] 
**NetworkConfig** | [**VsanNetworkConfigBestPracticeHealth**](VsanNetworkConfigBestPracticeHealth.md) | Network configuration best practices checks.  | [optional] 
**VsanConfig** | [**VsanConfigCheckResult**](VsanConfigCheckResult.md) | vSAN configuration checks.  | [optional] 
**BurnInTest** | [**VsanBurnInTestCheckResult**](VsanBurnInTestCheckResult.md) | Deprecated as of vSphere API 6.7.  vSAN burn in test checks.  | [optional] 
**PerfsvcHealth** | [**VsanPerfsvcHealthResult**](VsanPerfsvcHealthResult.md) | vSAN performance service health check result.  | [optional] 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster  Refers instance of *ClusterComputeResource*.  | [optional] 
**FileServiceHealth** | [**VsanClusterFileServiceHealthSummary**](VsanClusterFileServiceHealthSummary.md) | File service health information across the cluster.  Meant for programmatic consumption. If the file service is not enabled, this field would not be set.  | [optional] 
**DitEncryptionHealth** | [**VsanClusterDitEncryptionHealthSummary**](VsanClusterDitEncryptionHealthSummary.md) | Data-in-transit encryption information across the cluster.  Meant for programmatic consumption.  | [optional] 
**HealthScore** | **int** | The overall health score ranging from 0 to 100 based on the vSAN cluster health check result.  | [optional] 
**GlobalDedupHealth** | [**VsanClusterGlobalDedupHealthSummary**](VsanClusterGlobalDedupHealthSummary.md) | The global deduplication health summary across the cluster.  Meant for programmatic consumption.  | [optional] 
**HciMeshDitEncryptionHealth** | [**VsanClusterHciMeshDitEncryptionHealthSummary**](VsanClusterHciMeshDitEncryptionHealthSummary.md) | The HCI Mesh data-in-transit encryption health summary across the cluster.  Meant for programmatic consumption.  | [optional] 
**HealthStatusCounts** | [**VsanHealthStatusCounts**](VsanHealthStatusCounts.md) | The overall count of health checks by status level, including error (red), warning (yellow), and informational (info).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

