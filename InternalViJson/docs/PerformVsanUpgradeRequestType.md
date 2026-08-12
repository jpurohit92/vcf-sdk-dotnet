# Vcenter.ViJson.OpenApi.Model.PerformVsanUpgradeRequestType
The parameters of *VsanUpgradeSystem.PerformVsanUpgrade_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster to be upgraded  Refers instance of *ClusterComputeResource*.  | 
**PerformObjectUpgrade** | **bool** | After all disk groups have been updated, also upgrade all objects. Once started, rollback of the on disk format is no longer possible. Object upgrade unlocks new VSAN features.  | [optional] 
**DowngradeFormat** | **bool** | Perform a on-disk format downgrade instead of upgrade. Only possible if no upgraded objects exist.  | [optional] 
**AllowReducedRedundancy** | **bool** | Removes the need for one disk group worth of free space, by allowing reduced redundancy during disk upgrade.  | [optional] 
**ExcludeHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Internal debug option meant for functional testing of VSAN upgrades. Skips upgrade on certain hosts and implies performObjectUpgrade being false. Should not be used by customers.  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

