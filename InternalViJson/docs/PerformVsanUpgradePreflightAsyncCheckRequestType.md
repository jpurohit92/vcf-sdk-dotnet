# Vcenter.ViJson.OpenApi.Model.PerformVsanUpgradePreflightAsyncCheckRequestType
The parameters of *VsanUpgradeSystemEx.PerformVsanUpgradePreflightAsyncCheck_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster to process conversion.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | 
**DowngradeFormat** | **bool** | Intend to perform a on-disk format downgrade instead of upgrade. Adds additional checks.  | [optional] 
**Spec** | [**VsanDiskFormatConversionSpec**](VsanDiskFormatConversionSpec.md) | The specification of advanced disk format configuration. Adds additional checks. The specification cannot be supported in downgrade process, for now we don&#39;t have any advanced features supported by lower disk format.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

