# Vcenter.ViJson.OpenApi.Model.ClusterFailoverResourcesAdmissionControlPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceReductionToToleratePercent** | **int** | Percentage of resource reduction that a cluster of VMs can tolerate in case of a failover.  | [optional] 
**PMemAdmissionControlEnabled** | **bool** | Deprecated as of vSphere 9.0 APIs with no replacement.  Flag that determines whether strict admission control for persistent memory is enabled.  By default, this value is false. This flag can only be set to true if *ClusterDasConfigInfo.admissionControlEnabled* is set to true. When you use persistent memory admission control, the following operations are prevented, if doing so would violate the *ClusterDasConfigInfo.admissionControlEnabled*. - Creating a virtual machine with persistent memory. - Adding a virtual persistent memory device to a virtual machine. - Increasing the capacity of a virtual persistent memory device.    ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**CpuFailoverResourcesPercent** | **int** | Percentage of CPU resources in the cluster to reserve for failover.  You can specify up to 100% of CPU resources for failover.  | 
**MemoryFailoverResourcesPercent** | **int** | Percentage of memory resources in the cluster to reserve for failover.  You can specify up to 100% of memory resources for failover.  | 
**FailoverLevel** | **int** | Number of host failures that should be tolerated, still guaranteeing sufficient resources to restart virtual machines on available hosts.  If not set, we assume 1.  | [optional] 
**AutoComputePercentages** | **bool** | Flag to enable user input values for *ClusterFailoverResourcesAdmissionControlPolicy.cpuFailoverResourcesPercent* and *ClusterFailoverResourcesAdmissionControlPolicy.memoryFailoverResourcesPercent* By default, this is true and the default calculation is using the *ClusterFailoverResourcesAdmissionControlPolicy.failoverLevel* hosts&#39; resources.  If users want to override the percentage values, they must disable the auto-compute by setting this field to false.  | [optional] 
**PMemFailoverResourcesPercent** | **int** | Deprecated as of vSphere 9.0 APIs with no replacement.  Percentage of persistent memory resources in the cluster to reserve for the failover.  You can specify up to 100% of persistent memory resources for failover.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**AutoComputePMemFailoverResourcesPercent** | **bool** | Deprecated as of vSphere 9.0 APIs with no replacement.  Flag to enable user input values for *ClusterFailoverResourcesAdmissionControlPolicy.pMemFailoverResourcesPercent* By default, this is true and the default calculation is done using the *ClusterFailoverResourcesAdmissionControlPolicy.failoverLevel* hosts&#39; resources.  If a user wants to override the percentage values, they must disable the auto-compute by setting this field to false.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

