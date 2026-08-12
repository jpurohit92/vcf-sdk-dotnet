# Vcenter.ViJson.OpenApi.Model.PerformVsanUpgradeExRequestType
The parameters of *VsanUpgradeSystemEx.PerformVsanUpgradeEx*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The cluster to be upgraded  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | 
**PerformObjectUpgrade** | **bool** | After all disk groups have been updated, also upgrade all objects. Once started, rollback of the on disk format is no longer possible. Object upgrade unlocks new vSAN features. The default behavior is upgrading objects is this parameter is not specified.  | [optional] 
**DowngradeFormat** | **bool** | Perform a on-disk format downgrade instead of upgrade. Only possible if no upgraded objects exist.  | [optional] 
**AllowReducedRedundancy** | **bool** | Removes the need for one disk group worth of free space, by allowing reduced redundancy during disk upgrade.  | [optional] 
**ExcludeHosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | Internal debug option meant for functional testing of vSAN upgrades. Skips upgrade on certain hosts and implies performObjectUpgrade being false. Should not be used by customers.  Refers instances of *HostSystem*.  | [optional] 
**Spec** | [**VsanDiskFormatConversionSpec**](VsanDiskFormatConversionSpec.md) | The specification of advanced disk format configuration. The spec cannot be supported in downgrade process, for now we don&#39;t have any advanced features supported by lower disk format.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

