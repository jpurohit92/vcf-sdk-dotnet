# Vcenter.ViJson.OpenApi.Model.PlacementRankResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Reference key for the placement request  | 
**Candidate** | [**ManagedObjectReference**](ManagedObjectReference.md) | Candidate cluster for the placement problem  Refers instance of *ClusterComputeResource*.  | 
**ReservedSpaceMB** | **long** | The reserved storage space for the candidate cluster after placement The unit is in Megabytes  | 
**UsedSpaceMB** | **long** | The expected space usage for the candidate cluster after placement The unit is in Megabytes  | 
**TotalSpaceMB** | **long** | The expected total space for the candidate cluster after placement The unit is in Megabytes  | 
**Utilization** | **double** | The expected aggregate resource utilization for the candidate cluster after placement The unit is a fractional value between 0 and 1.  | 
**Faults** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Information about why a given cluster is not recommended for placement  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

