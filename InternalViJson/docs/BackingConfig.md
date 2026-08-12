# Vcenter.ViJson.OpenApi.Model.BackingConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThinProvisionBackingIdentifier** | **string** | Identifier for the backing pool for thin provisioning  | [optional] 
**DeduplicationBackingIdentifier** | **string** | Identifier for the backing pool for deduplication  | [optional] 
**AutoTieringEnabled** | **bool** | Flag to indicate whether auto-tiering optimizations are active  | [optional] 
**DeduplicationEfficiency** | **long** | Aggregate indication of space savings efficiency in the shared deduplication pool.  The value is between 0 and 100, higher values indicating better efficiency.  | [optional] 
**PerformanceOptimizationInterval** | **long** | Frequency in seconds at which interval auto-tiering optimizations are applied.  A value of 0 indicates continuous optimization.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

