# Vcenter.ViJson.OpenApi.Model.VsanHistoricalHealthQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Clusters** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The target cluster list.  Only the query for a single cluster is supported for now.  Refers instances of *ClusterComputeResource*.  | 
**Start** | **DateTime** | The start time querying from the historical result.  | 
**End** | **DateTime** | The end time querying from the historical result.  Default is till now if not specified.  | [optional] 
**TestId** | **string** | The target health test ID.  To get all supported health test IDs and their associated group ID, refer to *VsanVcClusterHealthSystem.VsanQueryAllSupportedHealthChecks*  | [optional] 
**GroupId** | **string** | The group ID which the health test belongs to.  To get all supported health test IDs and their associated group ID, refer to *VsanVcClusterHealthSystem.VsanQueryAllSupportedHealthChecks*  | [optional] 
**IncludeHealthRemediation** | **bool** | True to populate the vSAN health remediation information in the historical health test result.  It&#39;s false by default or when it&#39;s not set.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

